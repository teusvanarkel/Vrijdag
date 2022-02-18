using Common.Models;

namespace Data.Repositories
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetPersons();
    }
}