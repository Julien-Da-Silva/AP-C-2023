using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateq_AP_SIO2.metier
{
    /// <summary>
    /// Représente un user
    /// </summary>
     class Users
    {
        private int id;
        private string username;
        private string password;
        private string role;

        /// <summary>
        /// Initialise une nouvelle instance de la classe Users avec les valeurs spécifiées.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="role"></param>
        public Users(int id, string username, string password, string role)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.role = role;
        }

        /// <summary>
        /// Obtient ou définit l'identifiant de l'utilisateur.
        /// </summary>
        public int Id { get => id; set => id = value; }

        // Obtient ou définit le nom d'utilisateur.
        public string Username { get => username; set => username = value; }

        /// <summary>
        /// Obtient ou définit le mot de passe de l'utilisateur.
        /// </summary>
        public string Password { get => password; set => password = value; }

        /// <summary>
        /// Obtient ou définit le rôle de l'utilisateur.
        /// </summary>
        public string Role { get => role; set => role = value; }
    }

}
