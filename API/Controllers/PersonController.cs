using Business;
using Common.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet(Name = "GetPersons")]
        public IEnumerable<Person> GetPersons()
        {
            return _personService.GetPersons();
        }
    }
}