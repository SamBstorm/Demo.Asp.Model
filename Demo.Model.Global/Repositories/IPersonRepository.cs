using Demo.Model.Global.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Model.Global.Repositories
{
    public interface IPersonRepository<TPerson> : IRepository<TPerson,int>
    {
        IEnumerable<TPerson> GetByFilm(int filmId);
    }
}
