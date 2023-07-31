﻿using EmployeeOnboarding.Data;
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

        public void AddExperience(string empId, WorkExperienceVM experience)
        {
            var certificateFileName = "Experience.pdf"; // Change this to the desired name for UG certificate
            var _experience = new EmployeeExperienceDetails()
            {
                Empid = empId,
                Company_name = experience.Company_name,
                Designation = experience.Designation,
                Totalmonths = experience.Totalmonths,
                Reason = experience.Reason,
                StartDate = experience.StartDate,
                EndDate = experience.EndDate,
                Exp_Certificate = SaveCertificateFile(experience.Exp_Certificate, empId, certificateFileName),
                Date_Created = DateTime.UtcNow,
                Date_Modified = DateTime.UtcNow,
                Created_by = empId,
                Modified_by = empId,
                Status = "A"
            };

            _context.EmployeeExperienceDetails.Add(_experience);
            _context.SaveChanges();
        }

        public WorkExperienceVM GetExperience(string experienceId)
        {
            var _education = _context.EmployeeExperienceDetails.Where(n => n.Empid == experienceId).Select(experience => new WorkExperienceVM()
            {
                Company_name = experience.Company_name,
                Designation = experience.Designation,
                Totalmonths = experience.Totalmonths,
                Reason = experience.Reason,
                StartDate = experience.StartDate,
                EndDate = experience.EndDate,
            }).FirstOrDefault();

            return _education;
        }
    }
}