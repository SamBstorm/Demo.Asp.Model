using Demo.Model.Global.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Model.Global.Repositories
{
    public interface IMediaRepository: IRepository<Media,int>
    {
        IEnumerable<Media> GetByFilm(int filmId);
    }
}
