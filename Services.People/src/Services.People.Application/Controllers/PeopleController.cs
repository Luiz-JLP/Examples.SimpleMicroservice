using Microsoft.AspNetCore.Mvc;
using Services.People.Domains.Interfaces;
using Services.People.Models;

namespace Services.People.Application.Controllers
{
    [Controller]
    [Route("people")]
    public class PeopleController : Controller
    {
        private readonly IPeopleDomain _domain;

        public PeopleController(IPeopleDomain domain)
        {
            _domain = domain;
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            try
            {
                var personCreated = _domain.Create(person);
                return Ok(personCreated);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult Get(string id)
        {
            try
            {
                var person = _domain.Read(id);
                return Ok(person);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("all")]
        public IActionResult Get()
        {
            try
            {
                var people = _domain.Read();
                return Ok(people);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Update(Person person)
        {
            try
            {
                var personUpdated = _domain.Update(person);
                return Ok(personUpdated);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult Delete(Person person)
        {
            try
            {
                var processCompleted = _domain.Delete(person);
                return Ok(processCompleted);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
