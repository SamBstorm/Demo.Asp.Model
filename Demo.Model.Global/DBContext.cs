using Demo.Model.Global.Models;
using System;
using System.Collections.Generic;

namespace Demo.Model.Global
{
    public static class DBContext
    
    {
        public static Database DB = new Database();
    }

    public class Database{
        public List<Film> Films { get; set; }
        public List<Person> Persons { get; set; }
        public List<Media> Medias { get; set; }
        public List<Film_Media> Film_Medias { get; set; }
        public List<Film_Person> Film_Persons { get; set; }

        public Database()
        {
            Films = new List<Film>();
            Persons = new List<Person>();
            Medias = new List<Media>();
            Film_Medias = new List<Film_Media>();
            Film_Persons = new List<Film_Person>();
            Films.Add(new Film() { FilmId = 1, Title = "Jurassic Park", ReleaseYear = 1992, MainCategory = "Horror", Duration = 100, Note = 10, MainActorId = 1, BoxOffice = 200000 });
            Films.Add(new Film() { FilmId = 2, Title = "Jurassic World", ReleaseYear = 2016, MainCategory = "Horror", Duration = 120, Note = 5, MainActorId = 2, BoxOffice = 300000 });
            Films.Add(new Film() { FilmId = 3, Title = "Matrix", ReleaseYear = 1999, MainCategory = "Science-fiction", Duration = 120, Note = 8, MainActorId = 3, BoxOffice = 200000 });
            Films.Add(new Film() { FilmId = 4, Title = "Star Wars", ReleaseYear = 1979, MainCategory = "Science-fiction", Duration = 100, Note = 7, MainActorId = 4, BoxOffice = 200000 });
            Films.Add(new Film() { FilmId = 5, Title = "Star Trek", ReleaseYear = 1983, MainCategory = "Science-fiction", Duration = 120, Note = 7, MainActorId = 5, BoxOffice = 180000 });

            Persons.Add(new Person() { PersonId = 1, LastName = "Neil", Firstname = "Sam", BirthDate = new DateTime(1965,8,21) });
            Persons.Add(new Person() { PersonId = 2, LastName = "Pratt", Firstname = "Chris", BirthDate = new DateTime() });
            Persons.Add(new Person() { PersonId = 3, LastName = "Reeves", Firstname = "Keanu", BirthDate = new DateTime() });
            Persons.Add(new Person() { PersonId = 4, LastName = "Hammil", Firstname = "Mark", BirthDate = new DateTime() });
            Persons.Add(new Person() { PersonId = 5, LastName = "Steward", Firstname = "Patrick", BirthDate = new DateTime() });
            Persons.Add(new Person() { PersonId = 6, LastName = "Speilberg", Firstname = "Steven", BirthDate = new DateTime() });
            Persons.Add(new Person() { PersonId = 7, LastName = "Lucas", Firstname = "Georges", BirthDate = new DateTime() });
            Persons.Add(new Person() { PersonId = 8, LastName = "Ravoski", Firstname = "Toto", BirthDate = new DateTime() });

            Medias.Add(new Media() { MediaId = 1, MediaType = "Affiche", MediaUrl = "" });
            Medias.Add(new Media() { MediaId = 2, MediaType = "Affiche", MediaUrl = "" });
            Medias.Add(new Media() { MediaId = 3, MediaType = "Interview", MediaUrl = "" });
            Medias.Add(new Media() { MediaId = 4, MediaType = "Bande-annonce", MediaUrl = "" });

            Film_Medias.Add(new Film_Media() { FilmId = 1, MediaId = 1 });
            Film_Medias.Add(new Film_Media() { FilmId = 2, MediaId = 2 });
            Film_Medias.Add(new Film_Media() { FilmId = 1, MediaId = 4 });
            Film_Medias.Add(new Film_Media() { FilmId = 3, MediaId = 3 });

            Film_Persons.Add(new Film_Person() { FilmId = 1, PersonId = 6, PersonAttribution = "Realisator" });
            Film_Persons.Add(new Film_Person() { FilmId = 4, PersonId = 7, PersonAttribution = "Realisator" });
            Film_Persons.Add(new Film_Person() { FilmId = 3, PersonId = 8, PersonAttribution = "Realisator" });
            Film_Persons.Add(new Film_Person() { FilmId = 1, PersonId = 1, PersonAttribution = "Actor" });
            Film_Persons.Add(new Film_Person() { FilmId = 2, PersonId = 2, PersonAttribution = "Actor" });
            Film_Persons.Add(new Film_Person() { FilmId = 3, PersonId = 3, PersonAttribution = "Actor" });
            Film_Persons.Add(new Film_Person() { FilmId = 4, PersonId = 4, PersonAttribution = "Actor" });
            Film_Persons.Add(new Film_Person() { FilmId = 5, PersonId = 5, PersonAttribution = "Actor" });
        }
    }
}
