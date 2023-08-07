using EmployeeOnboarding.Data;
using EmployeeOnboarding.Models;
using EmployeeOnboarding.ViewModels;

namespace EmployeeOnboarding.Services
{

    public class WorkExperienceService
    {

        private ApplicationDbContext _context;
        public WorkExperienceService(ApplicationDbContext context)
        {
            _context = context;
        }


        private string SaveCertificateFile(IFormFile certificateFile, string empId, string fileName)
        {
            var empFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "Certificates", empId);
            if (!Directory.Exists(empFolderPath))
            {
                Directory.CreateDirectory(empFolderPath);
            }

            var filePath = Path.Combine(empFolderPath, fileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                certificateFile.CopyTo(fileStream);
            }

            return filePath; // Return the file path
        }

        public void AddExperience(int empId, WorkExperienceVM experience)
        {
            var existingExperience = _context.EmployeeExperienceDetails.FirstOrDefault(e => e.EmpGen_Id == empId);

            if (existingExperience != null)
            {
                //Update existing record

                existingExperience.Company_name = experience.Company_name;
                existingExperience.Designation = experience.Designation;
                existingExperience.Reason = experience.Reason;
                existingExperience.StartDate = experience.StartDate;
                existingExperience.EndDate = experience.EndDate;
                existingExperience.Exp_Certificate = SaveCertificateFile(experience.Exp_Certificate, empId.ToString(), "Experience.pdf");
                existingExperience.Date_Modified = DateTime.UtcNow;
                existingExperience.Modified_by = empId.ToString();
                existingExperience.Status = "A";
            }
            else
            {
                //Add new record

                var certificateFileName = "Experience.pdf";
                var _experience = new EmployeeExperienceDetails()
                {
                    EmpGen_Id = empId,
                    Company_name = experience.Company_name,
                    Designation = experience.Designation,
                    Reason = experience.Reason,
                    StartDate = experience.StartDate,
                    EndDate = experience.EndDate,
                    Exp_Certificate = SaveCertificateFile(experience.Exp_Certificate, empId.ToString(), certificateFileName),
                    Date_Created = DateTime.UtcNow,
                    Date_Modified = DateTime.UtcNow,
                    Created_by = empId.ToString(),
                    Modified_by = empId.ToString(),
                    Status = "A"
                };

                _context.EmployeeExperienceDetails.Add(_experience);
            }

            _context.SaveChanges();
        }


        public WorkExperienceVM GetExperience(int experienceId)
        {
            var _education = _context.EmployeeExperienceDetails
                .Where(n => n.EmpGen_Id == experienceId)
                .Select(experience => new WorkExperienceVM()
                {
                    Company_name = experience.Company_name,
                    Designation = experience.Designation,
                    Reason = experience.Reason,
                    StartDate = experience.StartDate,
                    EndDate = experience.EndDate,
                    Exp_Certificate = experience.Exp_Certificate != null ? new UploadedCertificate() : null
                })
                .FirstOrDefault();

            return _education;
        }

        public class UploadedCertificate : IFormFile
        {
            public string ContentType => "text/plain";
            public string ContentDisposition => null;
            public IHeaderDictionary Headers => new HeaderDictionary();
            public long Length => 0;
            public string Name => null;
            public string FileName => "Uploaded";

            public void CopyTo(Stream target) => throw new NotImplementedException();
            public Task CopyToAsync(Stream target, CancellationToken cancellationToken = default) => throw new NotImplementedException();
            public Stream OpenReadStream() => Stream.Null;

            public override string ToString() => "Uploaded";  // Change this line to return "Uploaded"
        }


    }
}