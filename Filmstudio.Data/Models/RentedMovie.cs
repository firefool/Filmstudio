using System;
using System.Collections.Generic;
using System.Text;

namespace Filmstudio.Data.Models
{
    public class RentedMovie
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid MovieId { get; set; }
        public Guid StudioId { get; set; }
    }
}
