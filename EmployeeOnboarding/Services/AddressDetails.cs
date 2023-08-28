using EmployeeOnboarding.Data;
using EmployeeOnboarding.ViewModels;
using EmployeeOnboarding.Models;

namespace EmployeeOnboarding.Services
{
    public class AddressDetails
    {
        private ApplicationDbContext _context;
        public AddressDetails(ApplicationDbContext context)

        {
            _context = context;
        }

        public void AddPermanentAddress(int empId, AddressVM address)
        
        {
            var existingAddress = _context.EmployeeAddressDetails.FirstOrDefault(e => e.EmpGen_Id == empId && e.Address_Type=="Permanent");

            if (existingAddress != null)
            {
                //Update existing record

                existingAddress.Address = address.Address;
                existingAddress.Country_Id = address.Country_Id;
                existingAddress.State_Id = address.State_Id;
                existingAddress.City_Id = address.City_Id;
                existingAddress.Pincode = address.Pincode;
                existingAddress.Date_Modified = DateTime.UtcNow;
                existingAddress.Modified_by = empId.ToString();
                existingAddress.Status = "A";
            }
            else
            {
                //Add new record

                var _contact = new EmployeeColleagueDetails()
                {
                    EmpGen_Id = empId,
                    Address_Type = "Permanent",
                    Address = address.Address,
                    Country_Id = address.Country_Id,
                    State_Id = address.State_Id,
                    City_Id = address.City_Id,
                    Pincode = address.Pincode,
                    Date_Created = DateTime.UtcNow,
                    Date_Modified = DateTime.UtcNow,
                    Created_by = empId.ToString(),
                    Modified_by = empId.ToString(),
                    Status = "A"
                };

                _context.EmployeeAddressDetails.Add(_contact);
            }

            _context.SaveChanges();
        }


        public void AddTemporaryAddress(int empId, AddressVM address)

        {
            var existingAddress = _context.EmployeeAddressDetails.FirstOrDefault(e => e.EmpGen_Id == empId && e.Address_Type == "Temporary");

            if (existingAddress != null)
            {
                //Update existing record

                existingAddress.Address = address.Address;
                existingAddress.Country_Id = address.Country_Id;
                existingAddress.State_Id = address.State_Id;
                existingAddress.City_Id = address.City_Id;
                existingAddress.Pincode = address.Pincode;
                existingAddress.Date_Modified = DateTime.UtcNow;
                existingAddress.Modified_by = empId.ToString();
                existingAddress.Status = "A";
            }
            else
            {
                //Add new record

                var _contact = new EmployeeColleagueDetails()
                {
                    EmpGen_Id = empId,
                    Address_Type = "Temporary",
                    Address = address.Address,
                    Country_Id = address.Country_Id,
                    State_Id = address.State_Id,
                    City_Id = address.City_Id,
                    Pincode = address.Pincode,
                    Date_Created = DateTime.UtcNow,
                    Date_Modified = DateTime.UtcNow,
                    Created_by = empId.ToString(),
                    Modified_by = empId.ToString(),
                    Status = "A"
                };

                _context.EmployeeAddressDetails.Add(_contact);
            }

            _context.SaveChanges();
        }


        //get method

        public AddressVM GetPermanentAddress(int Id)
        {
            var _address = _context.EmployeeAddressDetails.Where(n => n.EmpGen_Id == Id && n.Address_Type == "Permanent").Select(address => new AddressVM()
            {
                Address_Type = address.Address_Type,
                Address = address.Address,
                Country_Id = address.Country_Id,
                State_Id = address.State_Id,
                City_Id = address.City_Id,
                Pincode = address.Pincode,
            }).FirstOrDefault();
            return _address;
        }

        public AddressVM GetTemporaryAddress(int Id)
        {
            var _address = _context.EmployeeAddressDetails.Where(n => n.EmpGen_Id == Id && n.Address_Type == "Temporary").Select(address => new AddressVM()
            {
                Address_Type = address.Address_Type,
                Address = address.Address,
                Country_Id = address.Country_Id,
                State_Id = address.State_Id,
                City_Id = address.City_Id,
                Pincode = address.Pincode,
            }).FirstOrDefault();
            return _address;
        }
    }
}
