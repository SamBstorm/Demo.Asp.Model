using Demo.Model.Client.Map.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.Model.Client.Map.Mapper
{
    public static class Mapper
    {
        public static Client.Map.Models.Person ToClient(this Global.Models.Person entity)
        {
            if (entity == null) return null;
            return new Models.Person(
                entity.PersonId,
                entity.LastName,
                entity.Firstname,
                entity.BirthDate
                );
        }
        public static Global.Models.Person ToGlobal(this Client.Map.Models.Person entity)
        {
            if (entity == null) return null;
            return new Global.Models.Person()
            {
                PersonId = entity.Identifiant,
                LastName = entity.Nom,
                Firstname = entity.Prenom,
                BirthDate = entity.Naissance
            };
        }

        public static Client.Map.Models.Film ToClient(this Global.Models.Film entity)
        {
            if (entity == null) return null;
            PersonService ps = new PersonService();
            return new Models.Film(
                entity.FilmId,
                entity.Title,
                ps.Get(entity.MainActorId),
                ps.GetByFilm(entity.FilmId)
                );
        }
        public static Global.Models.Film ToGlobal(this Client.Map.Models.Film entity)
        {
            if (entity == null) return null;
            return new Global.Models.Film()
            {
                FilmId = entity.Identifiant,
                Title = entity.Titre,
                MainActorId = entity.ActeurPrincipal.Identifiant,
            };
        }

    }
}
