using Demo.Model.Client.Map.Mapper;
using Demo.Model.Client.Map.Models;
using Demo.Model.Global.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.Model.Client.Map.Services
{
    public class PersonService : IPersonRepository<Client.Map.Models.Person>
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
            return _repo.Get(id).ToClient();
        }

        public IEnumerable<Person> Get()
        {
            return _repo.Get().Select(p => p.ToClient());
        }

        public IEnumerable<Person> GetByFilm(int filmId)
        {
            return _repo.GetByFilm(filmId).Select(p => p.ToClient());
        }

        public bool Update(int id, Person entity)
        {
            throw new NotImplementedException();
        }
    }
}
