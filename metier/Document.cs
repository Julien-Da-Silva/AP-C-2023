using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateq_AP_SIO2.metier
{
    /// <summary>
    /// Représente un document
    /// </summary>
     class Document
    {
        private string idDoc;
        private string titre;
        private string image;
        private Categorie laCategorie;

        /// <summary>
        /// Initialise une nouvelle instance de la classe Document.
        /// </summary>
        /// <param name="unId"></param>
        /// <param name="unTitre"></param>
        /// <param name="uneImage"></param>
        /// <param name="uneCategorie"></param>
        public Document(string unId, string unTitre, string uneImage, Categorie uneCategorie)
        {
            idDoc = unId;
            titre = unTitre;
            image = uneImage;
            laCategorie = uneCategorie;
        }

        /// <summary>
        /// Obtient ou définit l'identifiant du document.
        /// </summary>
        public string IdDoc { get => idDoc; set => idDoc = value; }

        /// <summary>
        /// Obtient ou définit le titre du document.
        /// </summary>
        public string Titre { get => titre; set => titre = value; }

        /// <summary>
        /// Obtient ou définit le chemin de l'image du document.
        /// </summary>
        public string Image { get => image; set => image = value; }

        /// <summary>
        /// Obtient ou définit la catégorie du document.
        /// </summary>
        internal Categorie LaCategorie { get => laCategorie; set => laCategorie = value; }
    }
}
