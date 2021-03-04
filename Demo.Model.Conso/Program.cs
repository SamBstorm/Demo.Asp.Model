//using Demo.Model.Client.Map.Services;
//using Demo.Model.Global.Repositories;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Demo.Model.Conso
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            IPersonRepository<Client.Map.Models.Person> ps = new PersonService();
//            IEnumerable<Client.Map.Models.Person> people = ps.Get();
//            foreach (Client.Map.Models.Person person in people)
//            {
//                Console.WriteLine(person.Nom + " " + person.Prenom);
//            }
//            Console.ReadLine();
//            IFilmRepository<Client.Map.Models.Film> fs = new FilmService();
//            Client.Map.Models.Film film = fs.Get(1);
//            Console.WriteLine(film.Titre);
//            Console.WriteLine(film.ActeurPrincipal.Nom);
//            foreach (Client.Map.Models.Person person in film.Acteurs)
//            {
//                Console.WriteLine(person.Nom + " " + person.Prenom + " " + person.Age);
//            }
//            Console.ReadLine();
//        }
//    }
//}

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
            IPersonRepository<Client.Map.Models.Person> ps = new PersonService();
            IEnumerable<Client.Map.Models.Person> people = ps.Get();
            foreach (Client.Map.Models.Person person in people)
            {
                Console.WriteLine(person.Nom + " " + person.Prenom);
            }
            Console.ReadLine();
            //IFilmRepository<Client.Map.Models.Film> fs = new FilmService();
            //Client.Map.Models.Film film = fs.Get(1);
            //Console.WriteLine(film.Titre);
            //Console.WriteLine(film.ActeurPrincipal.Nom);
            //foreach (Client.Map.Models.Person person in film.Acteurs)
            //{
            //    Console.WriteLine(person.Nom + " " + person.Prenom + " " + person.Age);
            //}
            //Console.ReadLine();
        }
    }
}
