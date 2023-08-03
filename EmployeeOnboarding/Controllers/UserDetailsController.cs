using EmployeeOnboarding.Data.Services;
using EmployeeOnboarding.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeOnboarding.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class UserDetailsController : ControllerBase
    {

        public GeneralServices _generalservices;
        public UserDetailsController(GeneralServices generalservices)
        {
            _generalservices = generalservices;
        }



        //General details
        //post method
        [HttpPost("add-general-details")]
        public IActionResult AddGeneral(string empId, [FromBody] GeneralVM general)
        {
            _generalservices.AddGeneral(empId, general);
            return Ok();
        }


        //get method

        [HttpGet("get-general-details/{id}")]
        public IActionResult GetGeneral(string id)
        {
            var generaldetails = _generalservices.GetGeneral(id);
            return Ok(generaldetails);
        }

        //Contact details
        //Post method
        [HttpPost("add-contact-details")]
        public IActionResult AddContact(string empId, [FromBody] ContactVM contact)
        {
            _generalservices.AddContact(empId, contact);
            return Ok();
        }

        //get method

        [HttpGet("get-contact-details/{id}")]
        public IActionResult GetContact(string id)
        {
            var Contactdetails = _generalservices.GetContact(id);
            return Ok(Contactdetails);
        }

        //get method

        [HttpGet("get-address-details/{id}")]
        public IActionResult GetAddress(string id)
        {
            var Addressdetails = _generalservices.GetAddress(id);
            return Ok(Addressdetails);
        }


        //Additional details
        //Post method
        [HttpPost("add-additional-details")]
        public IActionResult AddAdditional(string empId, [FromBody] AdditionalVM additional)
        {
            _generalservices.AddAdditional(empId, additional);
            return Ok();
        }

        //get method

        [HttpGet("get-additional-details/{id}")]
        public IActionResult GetAdditional(string id)
        {
            var Additionaldetails = _generalservices.GetAdditional(id);
            return Ok(Additionaldetails);
        }



    }
    
}
