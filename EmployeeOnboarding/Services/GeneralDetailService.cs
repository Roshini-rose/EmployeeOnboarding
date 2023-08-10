using DocumentFormat.OpenXml.Wordprocessing;
using EmployeeOnboarding.Data;
using EmployeeOnboarding.Data.Enum;
using EmployeeOnboarding.Models;
using EmployeeOnboarding.ViewModels;
using OnboardingWebsite.Models;
using System.ComponentModel.DataAnnotations;

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
                DateOnly DOB= DateOnly.Parse(general.DOB);
                existingGeneral.FatherName = general.FatherName;
                existingGeneral.Gender = general.Gender;
                existingGeneral.MaritalStatus = general.MaritalStatus;
                DateOnly DateOfMarriage = DateOnly.Parse(general.DateOfMarriage);
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
                    Login_ID = Id,
                    EmployeeName = general.EmployeeName,
                    DOB = DateOnly.Parse(general.DOB),
                    FatherName = general.FatherName,
                    Gender = general.Gender,
                    MaritalStatus= general.MaritalStatus,
                    DateOfMarriage = DateOnly.Parse(general.DateOfMarriage),
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

            var sumbit = _context.Login.FirstOrDefault(e => e.Id == Id);

            sumbit.Invited_Status = "Submitted";

            _context.Login.Update(sumbit);
            _context.SaveChanges();
        }

        //get method
        public GetGeneralVM GetGeneral(int Id)
        {
            var _general = _context.EmployeeGeneralDetails.Where(n => n.Login_ID == Id).Select(general => new GetGeneralVM()
            {
                EmployeeName = general.EmployeeName,
                DOB = general.DOB.ToString(),
                FatherName = general.FatherName,
                Gender = ((Gender)general.Gender).ToString(),
                MaritalStatus = ((MartialStatus)general.Gender).ToString(),
                DateOfMarriage = general.DateOfMarriage.ToString(),
                BloodGrp = EnumExtensionMethods.GetEnumDescription((BloodGroup)general.BloodGrp)
                //BloodGrp = ((BloodGroup)general.BloodGrp).ToString(),
            }).FirstOrDefault();

            return _general;
        }

    }
}

