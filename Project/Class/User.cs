using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class User
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateOnly Birth_Date { get; set; }
        public string Role { get; set; }

        public User(string Id, string firstname, string lastname, string email, string password, DateOnly birth_date, string role)
        {
            this.Id = Id;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Email = email;
            this.Password = password;
            this.Birth_Date = birth_date;
            this.Role = Role;
        }

    }
}
