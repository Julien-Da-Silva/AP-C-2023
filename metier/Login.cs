using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateq_AP_SIO2.metier
{
     class Login
    {
        private int id_login;
        private string user;
        private string password;

        public Login(int id_login, string user, string password)
        {
            this.id_login = id_login;
            this.user = user;
            this.password = password;
        }

        public int Id_login { get => id_login; set => id_login = value; }
        public string User { get => user; set => user = value; }

        public string Password { get => password; set => password = value; }
    }
}
