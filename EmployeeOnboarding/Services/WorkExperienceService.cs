using EmployeeOnboarding.Data;
using EmployeeOnboarding.Data.Enum;
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
             if (certificateFile == null)
            {
                return null; // Return null if no certificate file is provided
            }
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


        public void AddExperiences(int empId, WorkExperienceVM experience)
        {          
                var existingExperience = _context.EmployeeExperienceDetails.FirstOrDefault(e => e.EmpGen_Id == empId);

                if (existingExperience != null)
                {
                    // Update existing record

                    existingExperience.Company_name = experience.Company_name;
                    existingExperience.Designation = experience.Designation;
                    existingExperience.Reason = experience.Reason;

                    // Parse and assign DateOnly values
                    DateOnly startDate = DateOnly.Parse(experience.StartDate);
                    DateOnly endDate = DateOnly.Parse(experience.EndDate);
                    existingExperience.StartDate = startDate;
                    existingExperience.EndDate = endDate;
                    existingExperience.Exp_Certificate = SaveCertificateFile(experience.Exp_Certificate, empId.ToString(), "Experience.pdf");
                    existingExperience.Date_Modified = DateTime.UtcNow;
                    existingExperience.Modified_by = empId.ToString();
                    existingExperience.Status = "A";
                }
                else
                {
                    // Add new record

                    var certificateFileName = "Experience.pdf";
                    var _experience = new EmployeeExperienceDetails()
                    {
                        EmpGen_Id = empId,
                        Company_name = experience.Company_name,
                        Designation = experience.Designation,
                        Reason = experience.Reason,

                        // Parse and assign DateOnly values
                        StartDate = DateOnly.Parse(experience.StartDate),
                        EndDate = DateOnly.Parse(experience.EndDate),
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

            //pending status
            var _onboard = new ApprovalStatus()
            {
                EmpGen_Id = empId,
                Current_Status = (int)Status.Pending,
                Comments = "",
                Date_Created = DateTime.UtcNow,
                Date_Modified = DateTime.UtcNow,
                Created_by = empId.ToString(),
                Modified_by = "Admin",
                Status = "A",
            };
            _context.ApprovalStatus.Add(_onboard);
            _context.SaveChanges();
        }


        public getExperienceVM GetExperience(int experienceId)
        {
            var _experience = _context.EmployeeExperienceDetails.Where(n => n.EmpGen_Id == experienceId).Select(experience => new getExperienceVM()
            {
                Company_name = experience.Company_name,
                Designation = experience.Designation,
                Reason = experience.Reason,
                StartDate = experience.StartDate,
                EndDate = experience.EndDate,
            })
                .FirstOrDefault();

            return _experience;
        }

    }
}