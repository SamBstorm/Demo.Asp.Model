using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Model.Client.Map.Models
{
    public class Person
    {
        public int Identifiant { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime Naissance { get; set; }
        public int Age => DateTime.Now.Year - this.Naissance.Year;

        public Person(int id, string lastname, string firstname, DateTime birthdate )
        {
            Identifiant = id;
            Nom = lastname;
            Prenom = firstname;
            Naissance = birthdate;
        }
    }
}
