using Sample.Core.Entities;

namespace Sample.Core.Contracts
{
  public interface IPersonService
  {
    Task<List<Person>> GetAllPeople();

    Task<Person?> GetPerson(int id);

    Task<Person> AddPerson(Person person);

    Task UpdatePerson(Person person);

    Task DeletePerson(int id);
  }
}