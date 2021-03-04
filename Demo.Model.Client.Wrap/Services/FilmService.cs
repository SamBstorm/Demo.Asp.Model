using Demo.Model.Client.Wrap.Models;
using Demo.Model.Global.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Model.Client.Wrap.Services
{
    public class FilmService : IFilmRepository<Film>
    {
        private IFilmRepository<Global.Models.Film> _repo;

        public FilmService()
        {
            _repo = new FilmRepository();
        }

        public int Create(Film entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Film Get(int id)
        {
            return new Film(_repo.Get(id));
        }

        public IEnumerable<Film> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Film> GetByMainActor(int actorId)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, Film entity)
        {
            throw new NotImplementedException();
        }
    }
}
