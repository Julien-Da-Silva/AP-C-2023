using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateq_AP_SIO2.metier
{
    /// <summary>
    /// Représente un rayon dans une médiathèque.
    /// </summary>
     class Rayon
    {

        public Rayon(string id, string libelle)
        {
            Id = id;
            Libelle = libelle;
        }

        /// <summary>
        /// Obtient ou définit l'identifiant du rayon.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Obtient ou définit le libellé du rayon.
        /// </summary>
        public string Libelle { get; set; }

        /// Initialise une nouvelle instance de la classe Rayon.
    }
}
