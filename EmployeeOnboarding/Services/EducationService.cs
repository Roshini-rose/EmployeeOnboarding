using EmployeeOnboarding.Data;
using EmployeeOnboarding.Models;
using OnboardingWebsite.Models;

namespace EmployeeOnboarding.Data.Services
{
    public class EducationService
    {
        private ApplicationDbContext _context;
        public EducationService(ApplicationDbContext context)
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

        public void AddEducationUG(int empId, EducationVM education)
        {
            var existingEducation = _context.EmployeeEducationDetails.FirstOrDefault(e => e.EmpGen_Id == empId && e.programme == "UG");

            if (existingEducation != null)
            {
                //Update existing record

                existingEducation.CollegeName = education.CollegeName;
                existingEducation.Degree = education.Degree;
                existingEducation.specialization = education.specialization;
                existingEducation.Passoutyear = education.Passoutyear;
                existingEducation.Certificate = SaveCertificateFile(education.Certificate, empId.ToString(), "UG_certificate.pdf");
                existingEducation.Date_Modified = DateTime.UtcNow;
                existingEducation.Modified_by = empId.ToString();
                existingEducation.Status = "A";
            }
            else
            {
                //Add new record

                var certificateFileName = "UG_certificate.pdf";
                var _education = new EmployeeEducationDetails()
                {
                    EmpGen_Id = empId,
                    programme = "UG",
                    CollegeName = education.CollegeName,
                    Degree = education.Degree,
                    specialization = education.specialization,
                    Passoutyear = education.Passoutyear,
                    Certificate = SaveCertificateFile(education.Certificate, empId.ToString(), certificateFileName),
                    Date_Created = DateTime.UtcNow,
                    Date_Modified = DateTime.UtcNow,
                    Created_by = empId.ToString(),
                    Modified_by = empId.ToString(),
                    Status = "A"
                };

                _context.EmployeeEducationDetails.Add(_education);
            }

            _context.SaveChanges();
        }

        public void AddEducationPG(int empId, EducationVM education)
        {
            var existingEducation = _context.EmployeeEducationDetails.FirstOrDefault(e => e.EmpGen_Id == empId && e.programme == "PG");

            if (existingEducation != null)
            {
                //Update existing record

                existingEducation.CollegeName = education.CollegeName;
                existingEducation.Degree = education.Degree;
                existingEducation.specialization = education.specialization;
                existingEducation.Passoutyear = education.Passoutyear;
                existingEducation.Certificate = SaveCertificateFile(education.Certificate, empId.ToString(), "PG_certificate.pdf");
                existingEducation.Date_Modified = DateTime.UtcNow;
                existingEducation.Modified_by = empId.ToString();
                existingEducation.Status = "A";
            }
            else
            {
                //Add new record

                var certificateFileName = "PG_certificate.pdf";
                var _education = new EmployeeEducationDetails()
                {
                    EmpGen_Id = empId,
                    programme = "PG",
                    CollegeName = education.CollegeName,
                    Degree = education.Degree,
                    specialization = education.specialization,
                    Passoutyear = education.Passoutyear,
                    Certificate = SaveCertificateFile(education.Certificate, empId.ToString(), certificateFileName),
                    Date_Created = DateTime.UtcNow,
                    Date_Modified = DateTime.UtcNow,
                    Created_by = empId.ToString(),
                    Modified_by = empId.ToString(),
                    Status = "A"
                };

                _context.EmployeeEducationDetails.Add(_education);
            }

            _context.SaveChanges();
        }


/*
        public EducationVM GetEducationUG(string educationId)
        {
            var _education = _context.EmployeeEducationDetails.Where(n => n.Empid == educationId && n.programme == "UG").Select(education => new EducationVM()
            {
                programme = "UG",
                CollegeName = education.CollegeName,
                Degree = education.Degree,
                specialization = education.specialization,
                Passoutyear = education.Passoutyear,
            }).FirstOrDefault();//

            return _education;
        }

        public EducationVM GetEducationPG(string educationId)
        {
            var _education = _context.EmployeeEducationDetails.Where(n => n.Empid == educationId && n.programme == "PG").Select(education => new EducationVM()
            {
                programme = "PG",
                CollegeName = education.CollegeName,
                Degree = education.Degree,
                specialization = education.specialization,
                Passoutyear = education.Passoutyear,
            }).FirstOrDefault();

            return _education;
        }
*/


    }
}
