using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateq_AP_SIO2.metier
{
    /// <summary>
    /// Représente un exemplaire
    /// </summary>
     class Exemplaire
    {
        private string idDoc;
        private string numero;
        private DateTime dateAchat;
        private string idRayon;
        private string idEtat;

        /// <summary>
        /// Initialise une nouvelle instance de la classe Exemplaire avec les paramètres spécifiés.
        /// </summary>
        /// <param name="idDoc"></param>
        /// <param name="numero"></param>
        /// <param name="dateAchat"></param>
        /// <param name="idRayon"></param>
        public Exemplaire(string idDoc, string numero, DateTime dateAchat, string idRayon)
        {
            this.idDoc = idDoc;
            this.numero = numero;
            this.dateAchat = dateAchat;
            this.idRayon = idRayon;
        }

        /// <summary>
        /// Obtient ou définit l'identifiant du document associé à l'exemplaire.
        /// </summary>
        public string IdDoc { get => idDoc; set => idDoc = value; }

        /// <summary>
        /// Obtient ou définit le numéro de l'exemplaire.
        /// </summary>
        public string Numero { get => numero; set => numero = value; }

        /// <summary>
        /// Obtient ou définit la date d'achat de l'exemplaire.
        /// </summary>
        public DateTime DateAchat { get => dateAchat; set => dateAchat = value; }

        /// <summary>
        /// Obtient ou définit l'identifiant du rayon où l'exemplaire est situé.
        /// </summary>
        public string IdRayon { get => idRayon; set => idRayon = value; }

        /// <summary>
        /// Obtient ou définit l'identifiant de l'état de l'exemplaire.
        /// </summary>
        public string IdEtat { get => idEtat; set => idEtat = value; }
    }
}
