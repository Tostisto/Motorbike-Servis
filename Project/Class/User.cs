using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Date_of_birth { get; set; }
        public string Role { get; set; }

        public User() { }

        public User(int Id, string firstname, string lastname, string email, string password, string birth_date, string role)
        {
            this.Id = Id;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Email = email;
            this.Password = password;
            this.Date_of_birth = birth_date;
            this.Role = role;
        }
    }
}
