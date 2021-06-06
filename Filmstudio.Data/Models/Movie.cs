using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmstudio.Data.Models
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string OriginCountry { get; set; }
        public int ReleaseYear { get; set; }


    }
}
