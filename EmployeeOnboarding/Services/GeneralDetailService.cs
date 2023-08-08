﻿using EmployeeOnboarding.Data;
using EmployeeOnboarding.Data.Enum;
using EmployeeOnboarding.ViewModels;
using OnboardingWebsite.Models;

namespace EmployeeOnboarding.Services
{
    public class GeneralDetailService
    {

        private ApplicationDbContext _context;
        public GeneralDetailService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddGeneral(int Id, GeneralVM general)
        {
            var existingGeneral = _context.EmployeeGeneralDetails.FirstOrDefault(e => e.Login_ID == Id );

            if (existingGeneral != null)
            {
                //Update existing record

                existingGeneral.EmployeeName = general.EmployeeName;
                existingGeneral.DOB = general.DOB;
                existingGeneral.FatherName = general.FatherName;
                existingGeneral.Gender = general.Gender;
                existingGeneral.MaritalStatus = general.MaritalStatus;
                existingGeneral.DateOfMarriage = general.DateOfMarriage;
                existingGeneral.BloodGrp = general.BloodGrp;
                existingGeneral.Date_Modified = DateTime.UtcNow;
                existingGeneral.Modified_by = Id.ToString();
                existingGeneral.Status = "A";
            }
            else
            {
                //Add new record

                var _general= new EmployeeGeneralDetails()
                {
                   
                    EmployeeName = general.EmployeeName,
                    DOB = general.DOB,
                    FatherName = general.FatherName,
                    Gender = general.Gender,
                    MaritalStatus= general.MaritalStatus,
                    DateOfMarriage = general.DateOfMarriage,
                    BloodGrp = general.BloodGrp,
                    Date_Created = DateTime.UtcNow,
                    Date_Modified = DateTime.UtcNow,
                    Created_by = Id.ToString(),
                    Modified_by = Id.ToString(),
                    Status = "A"
                };

                _context.EmployeeGeneralDetails.Add(_general);
            }

            _context.SaveChanges();
        }
        //get method
        public GeneralVM GetGeneral(int Id)
        {
            var _general = _context.EmployeeGeneralDetails.Where(n => n.Login_ID == Id).Select(general => new GeneralVM()
            {
                EmployeeName = general.EmployeeName,
                DOB = general.DOB,
                FatherName = general.FatherName,
                Gender = general.Gender,
                MaritalStatus = general.MaritalStatus,
                DateOfMarriage = general.DateOfMarriage,
                BloodGrp = general.BloodGrp,
            }).FirstOrDefault();



            return _general;
        }

    }
}
