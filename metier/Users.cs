using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateq_AP_SIO2.metier
{
        public class Users
    {
        private int id;
        private string username;
        private string password;
        private string role;

        public Users(int id , string username, string password, string role)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.role = role;
        }

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
    }
}
