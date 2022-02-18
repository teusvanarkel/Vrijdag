using Common.Models;

namespace Business;

public interface IPersonService
{
    IEnumerable<Person> GetPersons();
}
