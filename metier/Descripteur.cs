using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateq_AP_SIO2.metier
{
    /// <summary>
    /// Représente un descripteur.
    /// </summary>
    class Descripteur
    {
        private string id;
        private string libelle;

        /// <summary>
        /// Initialise une nouvelle instance de la classe Descripteur.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="libelle"></param>
        public Descripteur(string id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        /// <summary>
        /// Obtient ou définit l'identifiant du descripteur.
        /// </summary>
        public string Id { get => id; set => id = value; }

        // Obtient ou définit le libellé du descripteur.
        public string Libelle { get => libelle; set => libelle = value; }
    }
}
