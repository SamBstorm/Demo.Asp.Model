using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Model.Client.Map.Models
{
    public class Film
    {
        public int Identifiant { get; set; }
        public string Titre { get; set; }
        public Person ActeurPrincipal { get; set; }
        public IEnumerable<Person> Acteurs { get; set; }

        public Film(int id, string titre, Person actor, IEnumerable<Person> actors)
        {
            Identifiant = id;
            Titre = titre;
            ActeurPrincipal = actor;
            Acteurs = actors;
        }
    }
}
