using EmployeeOnboarding.Data;
using EmployeeOnboarding.Data.Enum;
using EmployeeOnboarding.ViewModels;

namespace EmployeeOnboarding.Services
{
    public class ContactDetails
    {
        private ApplicationDbContext _context;
        public ContactDetails(ApplicationDbContext context)
        {
            _context = context;
        }
        //contact details 

        //post method 


        public void AddContact(int Id, ContactVM contact)
        {
            var existingContact = _context.EmployeeContactDetails.FirstOrDefault(e => e.EmpGen_Id == Id);

            if (existingContact != null)
            {
                //Update existing record

                existingContact.Personal_Emailid = contact.Personal_Emailid;
                existingContact.Contact_no = contact.Contact_no;
                existingContact.Emgy_Contactperson = contact.Emgy_Contactperson;
                existingContact.Emgy_Contactrelation = contact.Emgy_Contactrelation;
                existingContact.Emgy_Contactno = contact.Emgy_Contactno;
                existingContact.Date_Modified = DateTime.UtcNow;
                existingContact.Modified_by = Id.ToString();
                existingContact.Status = "A";
            }
            else
            {
                //Add new record

                var _contact = new EmployeeContactDetails()
                {
                    EmpGen_Id = Id,
                    Personal_Emailid = contact.Personal_Emailid,
                    Contact_no = contact.Contact_no,
                    Emgy_Contactperson = contact.Emgy_Contactperson,
                    Emgy_Contactrelation = contact.Emgy_Contactrelation,
                    Emgy_Contactno = contact.Emgy_Contactno,
                    Date_Created = DateTime.UtcNow,
                    Date_Modified = DateTime.UtcNow,
                    Created_by = Id.ToString(),
                    Modified_by = Id.ToString(),
                    Status = "A"
                };

                _context.EmployeeContactDetails.Add(_contact);
            }

            _context.SaveChanges();
        }


        //get method

        public GetContactVM GetContact(int Id)
        {
            var _contact = _context.EmployeeContactDetails.Where(n => n.EmpGen_Id == Id).Select(contact => new GetContactVM()
            {
                Personal_Emailid = contact.Personal_Emailid,
                Contact_no = contact.Contact_no,
                Emgy_Contactperson = contact.Emgy_Contactperson,
                Emgy_Contactrelation = ((EmergencyContactRelation)contact.Emgy_Contactrelation).ToString(),
                Emgy_Contactno = contact.Emgy_Contactno,      

            }).FirstOrDefault();
            return _contact;

        }
    }
}
