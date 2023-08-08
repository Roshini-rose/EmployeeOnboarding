using EmployeeOnboarding.Services;
using EmployeeOnboarding.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeOnboarding.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
   public class UserDetailsController : ControllerBase
    {

        public GeneralDetailService _generalservices;
        public ContactDetails _contactdetails;
        public AddressDetails _addressdetails;
        public AdditionalDetails _additionaldetails;
        public UserDetailsController(GeneralDetailService generalservices,ContactDetails contactDetails,AddressDetails addressdetails,AdditionalDetails additionalDetails)
        {
            _generalservices = generalservices;
            _contactdetails= contactDetails;
            _addressdetails= addressdetails;
            _additionaldetails= additionalDetails;  

        }
       
        



        //General details
        //post method
        [HttpPost("add-general-details/{Id}")]
        public IActionResult AddGeneral(int Id, [FromForm] GeneralVM general)
        {
           _generalservices.AddGeneral(Id, general);
            return Ok();
        }


        //get method

       [HttpGet("get-general-details/{Id}")]
        public IActionResult GetGeneral(int Id)
        {
         var generaldetails = _generalservices.GetGeneral(Id);
           return Ok(generaldetails);
        }

        //Contact details
       //Post method
       [HttpPost("add-contact-details/{Id}")]
       public IActionResult AddContact(int Id, [FromForm] ContactVM contact)
       {
           _contactdetails.AddContact(Id, contact);
            return Ok();
        }


        //get method
        [HttpGet("get-contact-details/{id}")]
        public IActionResult GetContact(int id)
       {
            var Contactdetails = _contactdetails.GetContact(id);
            return Ok(Contactdetails);
        }

        //Post method
        [HttpPost("add-address-details/{Id}")]
        public IActionResult AddAddress(int Id, AddressVM address)
        {
           _addressdetails.AddAddress(Id,address);
            return Ok();
        }

        //get method

        [HttpGet("get-address-details/{id}")]
        public IActionResult GetAddress(int id)
        {
            var Addressdetails = _addressdetails.GetAddress(id);
            return Ok(Addressdetails);
        }

        
        //Additional details
        //Post method
        [HttpPost("add-additional-details/{Id}")]
        public IActionResult AddAdditional(int Id, [FromForm] AdditionalVM additional)
        {
          _additionaldetails.AddAdditional(Id, additional);
            return Ok();
        }

        //get method

        [HttpGet("get-additional-details/{id}")]
       public IActionResult GetAdditional(int id)
       {
          var Additionaldetails = _additionaldetails.GetAdditional(id);
          return Ok(Additionaldetails);
       }

   }
    
}
