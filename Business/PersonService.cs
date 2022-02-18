using System.Collections.ObjectModel;
using Common.Models;
using Data.Repositories;

namespace Business;

public class PersonService : IPersonService
{
    private IPersonRepository _personRepository;

    public PersonService(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public IEnumerable<Person> GetPersons()
    {
        return _personRepository.GetPersons();
    }
}
