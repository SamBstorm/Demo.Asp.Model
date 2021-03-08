using Demo.Model.Client.Map.Mapper;
using Demo.Model.Client.Map.Models;
using Demo.Model.Global.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Model.Client.Map.Services
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
            return _repo.Create(entity.ToGlobal());
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Film Get(int id)
        {
            return _repo.Get(id).ToClient();
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
