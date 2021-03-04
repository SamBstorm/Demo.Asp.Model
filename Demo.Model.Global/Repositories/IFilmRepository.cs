using Demo.Model.Global.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Model.Global.Repositories
{
    public interface IFilmRepository<TFilm> : IRepository<TFilm, int>
    {
        IEnumerable<TFilm> GetByMainActor(int actorId);
    }
}
