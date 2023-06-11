using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateq_AP_SIO2.metier
{
    /// <summary>
    /// Représente un livre dans le système.
    /// </summary>
     class Livre : Document
    {
        private string ISBN;
        private string auteur;
        private string laCollection;

        /// <summary>
        /// Initialise une nouvelle instance de la classe Livre avec les paramètres spécifiés.
        /// </summary>
        /// <param name="unId"></param>
        /// <param name="unTitre"></param>
        /// <param name="unISBN"></param>
        /// <param name="unAuteur"></param>
        /// <param name="uneCollection"></param>
        /// <param name="uneImage"></param>
        /// <param name="uneCategorie"></param>
        public Livre(string unId, string unTitre, string unISBN, string unAuteur, string uneCollection, string uneImage, Categorie uneCategorie) : base(unId, unTitre, uneImage, uneCategorie)
        {
            ISBN = unISBN;
            auteur = unAuteur;
            laCollection = uneCollection;
        }

        /// <summary>
        /// Obtient ou définit l'ISBN (International Standard Book Number) du livre.
        /// </summary>
        public string ISBN1 { get => ISBN; set => ISBN = value; }

        /// <summary>
        /// Obtient ou définit l'auteur du livre.
        /// </summary>
        public string Auteur { get => auteur; set => auteur = value; }

        /// <summary>
        /// Obtient ou définit la collection à laquelle le livre appartient.
        /// </summary>
        public string LaCollection { get => laCollection; set => laCollection = value; }
    }
}
