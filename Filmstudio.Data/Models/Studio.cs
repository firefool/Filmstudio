using System;
using System.Collections.Generic;
using System.Text;

namespace Filmstudio.Data.Models
{
    public class Studio : User
    {
        public string Location { get; set; }
        public string OwnerName { get; set; }
        public string Email { get; set; }
    }
}
