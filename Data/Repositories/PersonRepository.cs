using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Models;

namespace Data.Repositories
{

    public class PersonRepository : IPersonRepository
    {
        private Database _database;
        public PersonRepository(Database database)
        {
            _database = database;
        }
        public IEnumerable<Person> GetPersons()
        {
            return _database.Persons;
        }
    }
}