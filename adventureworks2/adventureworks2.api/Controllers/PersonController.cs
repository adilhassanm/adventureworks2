using adventureworks2.api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace adventureworks2.api.Controllers
{
    [ApiController]

    [Route("Person")]
    public class PersonController : Controller
    {
        private readonly IPersonrepository personrepository;

        public PersonController(IPersonrepository personrepository)
        {
            this.personrepository = personrepository;
        }
        [HttpGet]
        public IActionResult GetAllPerson()
        {
            var person = personrepository.GetAll();
            return Ok(person);

        }

    }
}
