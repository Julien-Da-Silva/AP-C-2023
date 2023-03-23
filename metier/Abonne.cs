using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateq_AP_SIO2.metier
{
     class Abonne
    {
        private int id;
        private string nom;
        private string prenom;
        private string adresse;
        private int tel;
        private string adresse_mail;
        private string date_naissance;
        private string date_premier_abonnement;
        private string date_fin_abo;

        public Abonne(int id, string nom, string prenom, string adresse, int tel, string adresse_mail, string date_naissance, string date_premier_abonnement, string date_fin_abo)
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

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }

        public string Prenom { get => prenom; set => prenom = value; }

        public string Adresse { get => adresse; set => adresse = value; }

        public int Tel { get => tel; set => tel = value; }

        public string Adresse_mail { get => adresse_mail; set => adresse_mail = value; }

        public string Date_naiss { get => date_naissance; set => date_naissance = value; }

        public string Date_premier_abo { get => date_premier_abonnement; set => date_premier_abonnement = value; }

        public string Date_fin_abo { get => date_fin_abo; set => date_fin_abo = value; }
    }
}
