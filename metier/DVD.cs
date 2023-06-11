using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateq_AP_SIO2.metier
{
    /// <summary>
    /// représente un DVD
    /// </summary>
     class DVD : Document
    {
        private string synopsis;
        private string realisateur;
        private int duree;

        /// <summary>
        /// Initialise une nouvelle instance de la classe DVD.
        /// </summary>
        /// <param name="unId"></param>
        /// <param name="unTitre"></param>
        /// <param name="unSynopsis"></param>
        /// <param name="unRealisateur"></param>
        /// <param name="uneDuree"></param>
        /// <param name="uneImage"></param>
        /// <param name="uneCategorie"></param>
        public DVD(string unId, string unTitre, string unSynopsis, string unRealisateur, int uneDuree, string uneImage, Categorie uneCategorie) : base(unId, unTitre, uneImage, uneCategorie)
        {
            Synopsis = unSynopsis;
            Realisateur = unRealisateur;
            Duree = uneDuree;
        }

        /// <summary>
        /// Obtient ou définit le synopsis du DVD.
        /// </summary>
        public string Synopsis { get => synopsis; set => synopsis = value; }

        /// <summary>
        /// Obtient ou définit le réalisateur du DVD.
        /// </summary>
        public string Realisateur { get => realisateur; set => realisateur = value; }

        /// <summary>
        /// Obtient ou définit la durée du DVD en minutes.
        /// </summary>
        public int Duree { get => duree; set => duree = value; }
    }
}
