using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ASPProject.Data
{
    public class User : IdentityUser
    {

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
         public Roles Roles { get; set; }
        public int PhoneNumbert { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
