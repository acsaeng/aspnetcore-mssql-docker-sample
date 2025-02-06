using Microsoft.EntityFrameworkCore;
using Sample.Core.Contracts;
using Sample.Core.Entities;
using Sample.Infrastructure.Data;

namespace Sample.Services
{
  public class PersonService : IPersonService
  {
    private readonly DataContext  _context;

    public PersonService(DataContext context)
    {
      _context = context;
    }

    public async Task<List<Person>> GetAllPeople()
    {
      var people = await _context.People.AsNoTracking().ToListAsync();
      return people;
    }

    public async Task<Person?> GetPerson(int id)
    {
      var person = await _context.People.FindAsync(id);
      return person;
    }

    public async Task<Person> AddPerson(Person person)
    {
      _context.People.Add(person);
      await _context.SaveChangesAsync();
      return person;
    }

    public async Task UpdatePerson(Person updatedPerson)
    {
      var person = await _context.People.FindAsync(updatedPerson.Id);

      if (person is not null)
      {
        person.FirstName = updatedPerson.FirstName;
        person.LastName = updatedPerson.LastName;
        await _context.SaveChangesAsync();
      }
    }

    public async Task DeletePerson(int id)
    {
      var person = await _context.People.FindAsync(id);

      if (person is not null)
      {
        _context.People.Remove(person);
        await _context.SaveChangesAsync();
      }
    }
  }
}