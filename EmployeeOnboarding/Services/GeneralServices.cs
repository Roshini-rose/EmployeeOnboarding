using EmployeeOnboarding.Data;
using EmployeeOnboarding.Data.ViewModels;

namespace EmployeeOnboarding.Data.Services
{
    public class GeneralServices
    {


        private ApplicationDbContext _context;
        public GeneralServices(ApplicationDbContext context)
        {
            _context = context;
        }


        //post method
        public void AddGeneral(string empId, GeneralVM general)
        {
            var _general = new EmployeeGeneralDetails()
            {
                Empid = empId,
                EmployeeName = general.EmployeeName,
                DOB = general.DOB,
                FatherName = general.FatherName,
                Gender = general.Gender,
                MaritalName = general.MaritalName,
                DateOfMarriage = general.DateOfMarriage,
                BloodGrp = general.BloodGrp,
                Date_Created = DateTime.UtcNow,
                Date_Modified = DateTime.UtcNow,
                Created_by = empId,
                Modified_by = empId,
                Status = "created"


            };
            _context.EmployeeGeneralDetails.Add(_general);
            _context.SaveChanges();
        }

        //get method
        public GeneralVM GetGeneral(String Id)
        {
            var _general = _context.EmployeeGeneralDetails.Where(n => n.Empid == Id).Select(general => new GeneralVM()
            {
                EmployeeName = general.EmployeeName,
                DOB = general.DOB,
                FatherName = general.FatherName,
                Gender = general.Gender,
                MaritalName = general.MaritalName,
                DateOfMarriage = general.DateOfMarriage,
                BloodGrp = general.BloodGrp,
            }).FirstOrDefault();

            return _general;
        }
        //contact details 
        //post method 
        public void AddContact(string empId, ContactVM contact)
        {
            var _contact = new EmployeeContactDetails()
            {
                Empid = empId,
                Personal_Emailid = contact.Personal_Emailid,
                Contact_no = contact.Contact_no,
                Emgy_Contactperson = contact.Emgy_Contactperson,
                Emgy_Contactrelation = contact.Emgy_Contactrelation,
                Emgy_Contactno = contact.Emgy_Contactno,
                Date_Created = DateTime.UtcNow,
                Date_Modified = DateTime.UtcNow,
                Created_by = empId,
                Modified_by = empId,
                Status = "created"


            };
            _context.EmployeeContactDetails.Add(_contact);
            _context.SaveChanges();
        }

        //get method
        public ContactVM GetContact(String Id)
        {
            var _contact = _context.EmployeeContactDetails.Where(n => n.Empid == Id).Select(contact => new ContactVM()
            {
                Personal_Emailid = contact.Personal_Emailid,
                Contact_no = contact.Contact_no,
                Emgy_Contactperson = contact.Emgy_Contactperson,
                Emgy_Contactrelation = contact.Emgy_Contactrelation,
                Emgy_Contactno = contact.Emgy_Contactno,
            }).FirstOrDefault();

            return _contact;
        }

        public void AddAddress(string empId,AddressVM address)
        {
            var _address = new EmployeeAddressDetails()
            {
                Empid = empId,
                Address = address.Address,
                Country = address.Country,
                State = address.State,
                City = address.City,
                Pincode = address.Pincode,
                Date_Created = DateTime.UtcNow,
                Date_Modified = DateTime.UtcNow,
                Created_by = empId,
                Modified_by = empId,
                Status = "created"


            };
            _context.EmployeeAddressDetails.Add(_address);
            _context.SaveChanges();
        }

        //get method
        public AddressVM GetAddress(string Id)
        {
            var _address = _context.EmployeeAddressDetails.Where(n => n.Empid == Id).Select(address => new AddressVM()
            {
                Address = address.Address,
                Country = address.Country,
                State = address.State,
                City = address.City,
                Pincode = address.Pincode,
            }).FirstOrDefault();

            return _address;
        }



        //Additional 
        //post
        public void AddAdditional(string empId,AdditionalVM additional)
        {
            var _additional = new EmployeeAdditionalInfo()
            {
                Empid = empId,
                Disability = additional.Disability,
                Disablility_type = additional.Disablility_type,
                Covid_VaccSts = additional.Covid_VaccSts,
                Vacc_Certificate = additional.Vacc_Certificate,
                Date_Created = DateTime.UtcNow,
                Date_Modified = DateTime.UtcNow,
                Created_by = empId,
                Modified_by = empId,
                Status = "created"



            };
            _context.EmployeeAdditionalInfo.Add(_additional);
            _context.SaveChanges();
        }



        //get method
        public AdditionalVM GetAdditional(string Id)
        {
            var _additional = _context.EmployeeAdditionalInfo.Where(n => n.Empid == Id).Select(additional => new AdditionalVM()
            {
                Disability = additional.Disability,
                Disablility_type = additional.Disablility_type,
                Covid_VaccSts = additional.Covid_VaccSts,
                Vacc_Certificate = additional.Vacc_Certificate,

            }).FirstOrDefault();

            return _additional;

        }
    }
}
