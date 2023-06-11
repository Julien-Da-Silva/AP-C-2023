using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateq_AP_SIO2.metier
{
    /// <summary>
    /// Représente un abonné
    /// </summary>
     class Abonne
    {
        private int id;
        private string nom;
        private string prenom;
        private string adresse;
        private int tel;
        private string adresse_mail;
        private DateTime date_naissance;
        private DateTime date_premier_abonnement;
        private DateTime date_fin_abo;

        /// <summary>
        /// Initialise une nouvelle instance de la classe Abonne avec les valeurs spécifiées.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="adresse"></param>
        /// <param name="tel"></param>
        /// <param name="adresse_mail"></param>
        /// <param name="date_naissance"></param>
        /// <param name="date_premier_abonnement"></param>
        /// <param name="date_fin_abo"></param>
        public Abonne(int id, string nom, string prenom, string adresse, int tel, string adresse_mail, DateTime date_naissance, DateTime date_premier_abonnement, DateTime date_fin_abo)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.tel = tel;
            this.adresse_mail = adresse_mail;
            this.date_naissance = date_naissance;
            this.date_premier_abonnement = date_premier_abonnement;
            this.date_fin_abo = date_fin_abo;
        }

        /// <summary>
        /// Obtient ou définit l'identifiant de l'abonné.
        /// </summary>
        public int Id { get => id; set => id = value; }

        /// <summary>
        /// Obtient ou définit le nom de l'abonné.
        /// </summary>
        public string Nom { get => nom; set => nom = value; }

        /// <summary>
        /// Obtient ou définit le prénom de l'abonné.
        /// </summary>
        public string Prenom { get => prenom; set => prenom = value; }

        /// <summary>
        /// Obtient ou définit l'adresse de l'abonné.
        /// </summary>
        public string Adresse { get => adresse; set => adresse = value; }

        /// <summary>
        /// Obtient ou définit le numéro de téléphone de l'abonné.
        /// </summary>
        public int Tel { get => tel; set => tel = value; }

        /// <summary>
        /// Obtient ou définit l'adresse e-mail de l'abonné.
        /// </summary>
        public string Adresse_mail { get => adresse_mail; set => adresse_mail = value; }

        /// <summary>
        /// Obtient ou définit la date de naissance de l'abonné.
        /// </summary>
        public DateTime Date_naiss { get => date_naissance; set => date_naissance = value; }

        /// <summary>
        /// Obtient ou définit la date du premier abonnement de l'abonné.
        /// </summary>
        public DateTime Date_premier_abo { get => date_premier_abonnement; set => date_premier_abonnement = value; }

        /// <summary>
        /// Obtient ou définit la date de fin de l'abonnement de l'abonné.
        /// </summary>
        public DateTime Date_fin_abo { get => date_fin_abo; set => date_fin_abo = value; }
    }
}
