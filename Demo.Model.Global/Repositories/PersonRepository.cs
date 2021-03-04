using Demo.Model.Global.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.Model.Global.Repositories
{
    public class PersonRepository : IPersonRepository<Person>
    {
        public int Create(Person entity)
        {
            int maxId = DBContext.DB.Persons.Max(f => f.PersonId);
            maxId += 1;
            entity.PersonId = maxId;
            DBContext.DB.Persons.Add(entity);
            return entity.PersonId;
        }

        public bool Delete(int id)
        {
            if (DBContext.DB.Persons.Select(f => f.PersonId).Contains(id))
            {
                Person oldPerson = DBContext.DB.Persons.Where(f => f.PersonId == id).SingleOrDefault();
                DBContext.DB.Persons.Remove(oldPerson);
                return true;
            }
            else return false;
        }

        public Person Get(int id)
        {
            return DBContext.DB.Persons.Where(f => f.PersonId == id).SingleOrDefault();
        }

        public IEnumerable<Person> Get()
        {
            return DBContext.DB.Persons;
        }

        public IEnumerable<Person> GetByFilm(int filmId)
        {
            return DBContext.DB.Film_Persons
                .Where(fm => fm.FilmId == filmId)
                .Join(DBContext.DB.Persons, fm => fm.PersonId, m => m.PersonId, (fm, m) => m);
        }

        public bool Update(int id, Person entity)
        {
            if (DBContext.DB.Persons.Select(f => f.PersonId).Contains(id))
            {
                Person oldPerson = DBContext.DB.Persons.Where(f => f.PersonId == id).SingleOrDefault();
                int index = DBContext.DB.Persons.IndexOf(oldPerson);
                entity.PersonId = id;
                DBContext.DB.Persons[index] = entity;
                return true;
            }
            else return false;
        }
    }
}
