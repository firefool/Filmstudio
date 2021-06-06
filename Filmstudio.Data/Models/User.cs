using System;
using System.Collections.Generic;
using System.Text;

namespace Filmstudio.Data.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        private string Password { get; set; }
    }
}
