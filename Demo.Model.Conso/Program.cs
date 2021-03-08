//using Demo.Model.Client.Wrap.Models;
//using Demo.Model.Client.Wrap.Services;
using Demo.Model.Client.Map.Models;
using Demo.Model.Client.Map.Services;
using Demo.Model.Global.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Model.Conso
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonRepository<Person> ps = new PersonService();
            IEnumerable<Person> people = ps.Get();
            foreach (Person person in people)
            {
                Console.WriteLine(person.Nom + " " + person.Prenom);
            }
            Console.ReadLine();
            IFilmRepository<Film> fs = new FilmService();
            Film film = fs.Get(1);
            Console.WriteLine(film.Titre);
            Console.WriteLine(film.ActeurPrincipal.Nom);
            foreach (Person person in film.Acteurs)
            {
                Console.WriteLine(person.Nom + " " + person.Prenom + " " + person.Age);
            }
            Console.ReadLine();

            ///////Mapping
            Film filmTest = new Film(0,"Die Hard",null,null);
            ///////Wrapping
            //Film filmTest = new Film();
            //filmTest.Titre = "Die Hard";
            int id = fs.Create(filmTest);
            Console.WriteLine(fs.Get(id).Titre);
            Console.ReadLine();
        }
    }
}
