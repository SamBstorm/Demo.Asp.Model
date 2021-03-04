using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Model.Client.Wrap.Models
{
    public class Person
    {
        public int Identifiant => _person.PersonId;
        public string Prenom => _person.Firstname;
        public string Nom => _person.LastName;

        public DateTime Naissance => _person.BirthDate;
        public int Age => DateTime.Now.Year - Naissance.Year;

        private Global.Models.Person _person;

        public Person(Global.Models.Person person)
        {
            _person = person;
        }
    }
}
