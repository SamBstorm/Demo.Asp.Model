using Demo.Model.Global.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.Model.Global.Repositories
{
    public class FilmRepository : IFilmRepository<Film>
    {
        public int Create(Film entity)
        {
            int maxId = DBContext.DB.Films.Max(f => f.FilmId);
            maxId += 1;
            entity.FilmId = maxId;
            DBContext.DB.Films.Add(entity);
            return entity.FilmId;
        }

        public bool Delete(int id)
        {
            if (DBContext.DB.Films.Select(f => f.FilmId).Contains(id))
            {
                Film oldFilm = DBContext.DB.Films.Where(f => f.FilmId == id).SingleOrDefault();
                DBContext.DB.Films.Remove(oldFilm);
                return true;
            }
            else return false;
        }

        public Film Get(int id)
        {
            return DBContext.DB.Films.Where(f => f.FilmId == id).SingleOrDefault();
        }

        public IEnumerable<Film> Get()
        {
            return DBContext.DB.Films;
        }

        public IEnumerable<Film> GetByMainActor(int actorId)
        {
            return DBContext.DB.Films.Where(f => f.MainActorId == actorId);
        }

        public bool Update(int id, Film entity)
        {
            if (DBContext.DB.Films.Select(f => f.FilmId).Contains(id))
            {
                Film oldFilm = DBContext.DB.Films.Where(f => f.FilmId == id).SingleOrDefault();
                int index = DBContext.DB.Films.IndexOf(oldFilm);
                entity.FilmId = id;
                DBContext.DB.Films[index] = entity;
                return true;
            }
            else return false;
        }
    }
}
