using EmployeeOnboarding.Data;
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
        public StateService _stateservice;
        public CityService _cityservice;
        public UserDetailsController(GeneralDetailService generalservices,
            ContactDetails contactDetails,
            AddressDetails addressdetails,
            AdditionalDetails additionalDetails,
            StateService stateService,
            CityService cityService)
        {
            _generalservices = generalservices;
            _contactdetails= contactDetails;
            _addressdetails= addressdetails;
            _additionaldetails= additionalDetails;  
            _stateservice= stateService;
            _cityservice= cityService;

        }
       

        //General details
        //post method
        [HttpPost("add-general-details/{Id}")]
        public IActionResult  AddGeneral(int Id, [FromBody] GeneralVM general)
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
       public IActionResult AddContact(int Id, [FromBody] ContactVM contact)    
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
        [HttpPost("add-permanent-address-details/{Id}")]
        public IActionResult AddPermanentAddress(int Id, AddressVM address)
        {
            _addressdetails.AddPermanentAddress(Id, address);
            return Ok();
        }



        [HttpPost("add-temporary-address-details/{Id}")]
        public IActionResult AddTemporaryAddress(int Id, AddressVM address)
        {
            _addressdetails.AddTemporaryAddress(Id, address);
            return Ok();
        }

        //get method

        [HttpGet("get-permanent-address-details/{id}")]
        public IActionResult GetPermanentAddress(int id)
        {
            var Addressdetails = _addressdetails.GetPermanentAddress(id);
            return Ok(Addressdetails);
        }

        [HttpGet("get-temporary-address-details/{id}")]
        public IActionResult GetTemporaryAddress(int id)
        {
            var Addressdetails = _addressdetails.GetTemporaryAddress(id);
            return Ok(Addressdetails);
        }


      

        [HttpGet("get-State/{id}")]
        public IActionResult GetState(int id)
        {
            var State = _stateservice.GetState(id);
            return Ok(State);
        }



     

        [HttpGet("get-City/{id}")]
        public IActionResult GetCity(int id)
        {
            var city = _cityservice.GetCity(id);
            return Ok(city);
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

