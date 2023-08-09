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
        /*
        public void AddPermanentAddress(int Id, AddressVM address)
            
        {
            var existingAddress = _context.EmployeeAddressDetails.FirstOrDefault(e => e.EmpGen_Id == Id && e.Address_Type == "Permanent");

            if (existingAddress != null)
            {
                //Update existing record

                existingAddress.Address = address.Address;
                existingAddress.Country_Id = address.Country_Id;
                existingAddress.State_Id = address.State_Id;
                existingAddress.City_Id = address.City_Id;
                existingAddress.Pincode = address.Pincode;
                existingAddress.Date_Modified = DateTime.UtcNow;
                existingAddress.Modified_by = Id.ToString();
                existingAddress.Status = "A";
            }
            else
            {
                //Add new record

                var _contact = new EmployeeAddressDetails()
                {
                    EmpGen_Id = Id,
                    Address_Type = "Permanent",
                    Address = address.Address,
                    Country_Id = address.Country_Id,
                    State_Id = address.State_Id,
                    City_Id = address.City_Id,
                    Pincode = address.Pincode,
                    Date_Created = DateTime.UtcNow,
                    Date_Modified = DateTime.UtcNow,
                    Created_by = Id.ToString(),
                    Modified_by = Id.ToString(),
                    Status = "A"
                };

                _context.EmployeeAddressDetails.Add(_contact);
            }

            _context.SaveChanges();
        }



        public void AddTemporaryAddress(int Id, AddressVM address)

        {
            var existingAddress = _context.EmployeeAddressDetails.FirstOrDefault(e => e.EmpGen_Id == Id && e.Address_Type == "Temporary");

            if (existingAddress != null)
            {
                //Update existing record

                existingAddress.Address = address.Address;
                existingAddress.Country_Id = address.Country_Id;
                existingAddress.State_Id = address.State_Id;
                existingAddress.City_Id = address.City_Id;
                existingAddress.Pincode = address.Pincode;
                existingAddress.Date_Modified = DateTime.UtcNow;
                existingAddress.Modified_by = Id.ToString();
                existingAddress.Status = "A";
            }
            else
            {
                //Add new record

                var _contact = new EmployeeAddressDetails()
                {
                    EmpGen_Id = Id,
                    Address_Type = "Temporary",
                    Address = address.Address,
                    Country_Id = address.Country_Id,
                    State_Id = address.State_Id,
                    City_Id = address.City_Id,
                    Pincode = address.Pincode,
                    Date_Created = DateTime.UtcNow,
                    Date_Modified = DateTime.UtcNow,
                    Created_by = Id.ToString(),
                    Modified_by = Id.ToString(),
                    Status = "A"
                };

                _context.EmployeeAddressDetails.Add(_contact);
            }

            _context.SaveChanges();
        }



        //get method

        public AddressVM GetAddress(int Id)
        {
            var _address = _context.EmployeeAddressDetails.Where(n => n.EmpGen_Id == Id).Select(address => new AddressVM()
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
        */
    }
}
  