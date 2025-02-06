using Microsoft.AspNetCore.Mvc;
using Sample.Core.Contracts;
using Sample.Core.Entities;

namespace Sample.Web.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class PersonController : ControllerBase
  {
    private readonly IPersonService  _personService;

    public PersonController(IPersonService personService)
    {
      _personService = personService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Person>>> GetAllPeople() {
      var people = await _personService.GetAllPeople(); 
      return Ok(people);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Person?>> GetPerson(int id)
    {
      var person = await _personService.GetPerson(id);

      if (person is null)
        return NotFound();

      return Ok(person);
    }

    [HttpPost]
    public async Task<ActionResult> AddPerson(Person newPerson)
    {
      var person = await _personService.AddPerson(newPerson);
      return CreatedAtAction(nameof(GetPerson), new { id = person!.Id }, person);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> UpdatePerson(int id, Person person)
    {
      if (id != person.Id)
        return BadRequest();

      var personToUpdate = _personService.GetPerson(id);

      if (personToUpdate is null)
        return NotFound();

      await _personService.UpdatePerson(person);
      return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeletePerson(int id)
    {
      var person = _personService.GetPerson(id);

      if (person is null)
        return NotFound();

      await _personService.DeletePerson(id);
      return NoContent();
    }
  }
}