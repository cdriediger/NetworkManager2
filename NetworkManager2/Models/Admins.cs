using System;
using System.Collections.Generic;

namespace NetworkManager2.Models
{
    public partial class Admins
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public DateTimeOffset Created { get; set; }
    }
}
