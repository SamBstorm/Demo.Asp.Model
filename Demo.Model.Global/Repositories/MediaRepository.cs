using Demo.Model.Global.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.Model.Global.Repositories
{
    public class MediaRepository : IMediaRepository
    {
        public int Create(Media entity)
        {
            int maxId = DBContext.DB.Medias.Max(f => f.MediaId);
            maxId += 1;
            entity.MediaId = maxId;
            DBContext.DB.Medias.Add(entity);
            return entity.MediaId;
        }

        public bool Delete(int id)
        {
            if (DBContext.DB.Medias.Select(f => f.MediaId).Contains(id))
            {
                Media oldMedia = DBContext.DB.Medias.Where(f => f.MediaId == id).SingleOrDefault();
                DBContext.DB.Medias.Remove(oldMedia);
                return true;
            }
            else return false;
        }

        public Media Get(int id)
        {
            return DBContext.DB.Medias.Where(f => f.MediaId == id).SingleOrDefault();
        }

        public IEnumerable<Media> Get()
        {
            return DBContext.DB.Medias;
        }

        public IEnumerable<Media> GetByFilm(int filmId)
        {
            return DBContext.DB.Film_Medias
                .Where(fm=>fm.FilmId == filmId)
                .Join(DBContext.DB.Medias, fm => fm.MediaId, m => m.MediaId, (fm, m) => m);
            //Comparaison avec le SQL
            //SELECT m.*
            //FROM Film_Medias AS fm JOIN Medias AS m
            //ON fm.MediaId = m.MediaId
        }

        public bool Update(int id, Media entity)
        {
            if (DBContext.DB.Medias.Select(f => f.MediaId).Contains(id))
            {
                Media oldMedia = DBContext.DB.Medias.Where(f => f.MediaId == id).SingleOrDefault();
                int index = DBContext.DB.Medias.IndexOf(oldMedia);
                entity.MediaId = id;
                DBContext.DB.Medias[index] = entity;
                return true;
            }
            else return false;
        }
    }
}
