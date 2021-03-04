using Demo.Model.Client.Wrap.Models;
using Demo.Model.Global.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.Model.Client.Wrap.Services
{
    public class PersonService : IPersonRepository<Person>
    {
        private IPersonRepository<Global.Models.Person> _repo;

        public PersonService()
        {
            _repo = new PersonRepository();
        }

        public int Create(Person entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Person Get(int id)
        {
            return new Person(_repo.Get(id));
        }

        public IEnumerable<Person> Get()
        {
            return _repo.Get().Select(p=>new Person(p));
        }

        public IEnumerable<Person> GetByFilm(int filmId)
        {
            return _repo.GetByFilm(filmId).Select(p => new Person(p));
        }

        public bool Update(int id, Person entity)
        {
            throw new NotImplementedException();
        }
    }
}
