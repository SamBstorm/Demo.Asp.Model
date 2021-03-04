using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Model.Global.Models
{
    public class Film
    {
        public int FilmId { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public int Duration { get; set; }
        public string MainCategory { get; set; }
        public int MainActorId { get; set; }
        public int BoxOffice { get; set; }
        public int Note { get; set; }
    }
}
