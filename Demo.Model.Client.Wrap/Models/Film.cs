using Demo.Model.Client.Wrap.Services;
using Demo.Model.Global.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.Model.Client.Wrap.Models
{
    public class Film
    {
        public int Identifiant => _film.FilmId;
        public string Titre => _film.Title;

        public Person ActeurPrincipal => new PersonService().Get(_film.MainActorId);
        public IEnumerable<Person> Acteurs => new PersonService().GetByFilm(_film.FilmId);

        private Global.Models.Film _film;

        public Film(Global.Models.Film film)
        {
            _film = film;
        }
    }
}
