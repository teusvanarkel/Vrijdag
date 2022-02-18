using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Models;
using Data;

namespace FillDatabase
{
    public class FillPersons
    {
        public void FillPerson()
        {
            var database = new Database();
            database.Persons.Add(new Person()
            {
                FirstName = "Teus",
                LastName = "van Arkel"
            });
            database.Persons.Add(new Person()
            {
                FirstName = "Joeri",
                LastName = "van Arkel"
            });
            database.Persons.Add(new Person()
            {
                FirstName = "Josien",
                LastName = "ter Maten"
            });
            database.SaveChanges();
        }
    }
}