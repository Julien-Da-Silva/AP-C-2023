using Mediateq_AP_SIO2.metier;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateq_AP_SIO2
{
    class DAODocuments
    {
        public static List<Categorie> getAllCategories()
        {
            List<Categorie> lesCategories = new List<Categorie>();
            string req = "Select * from categorie";

            DAOFactory.connecter();

            MySqlDataReader reader = DAOFactory.execSQLRead(req);

            while (reader.Read())
            {
                Categorie categorie = new Categorie(reader[0].ToString(), reader[1].ToString());
                lesCategories.Add(categorie);
            }
            DAOFactory.deconnecter();
            return lesCategories;
        }

        //public static List<DVD> getAllDVD()
        //{
            //List<DVD> lesDVD = new List<DVD>();
           // string req = "Select dvd.id, dvd.synopsis, dvd.duree , dvd.réalisateur, d.titre, d.image ,d.idPublic, c.libelle from dvd inner join document d on dvd.id=d.id inner join categorie c on d.idPublic = c.id ";

            //DAOFactory.connecter();

            //MySqlDataReader reader = DAOFactory.execSQLRead(req);

            //while (reader.Read())
            //{
               // DVD Dvd = new DVD(reader[0].ToString(), reader[1].ToString(), int.Parse(reader[2].ToString()), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), new Categorie(reader[6].ToString(), reader[7].ToString()));
               // lesDVD.Add(Dvd);
           // }
           // DAOFactory.deconnecter();
            //return lesDVD;
        //}

        public static List<Descripteur> getAllDescripteurs()
        {
            List<Descripteur> lesDescripteurs = new List<Descripteur>();
            string req = "Select * from descripteur";

            DAOFactory.connecter();

            MySqlDataReader reader = DAOFactory.execSQLRead(req);

            while (reader.Read())
            {
                Descripteur genre = new Descripteur(reader[0].ToString(), reader[1].ToString());
                lesDescripteurs.Add(genre);
            }
            DAOFactory.deconnecter();
            return lesDescripteurs;
        }


        public static List<Abonne> getAllAbonnes()
        {
            List<Abonne> lesAbonnes = new List<Abonne>();
            string req = "Select * from abonnement";

            DAOFactory.connecter();

            MySqlDataReader reader = DAOFactory.execSQLRead(req);

            while (reader.Read())
            {
                Abonne abonne = new Abonne(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), int.Parse(reader[4].ToString()), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString());
                lesAbonnes.Add(abonne);
            }
            DAOFactory.deconnecter();
            return lesAbonnes;
        }

        public static List<Document> getAllDocuments()
        {
            List<Document> lesDocuments = new List<Document>();
            string req = "Select * from document  ";

            DAOFactory.connecter();

            MySqlDataReader reader = DAOFactory.execSQLRead(req);

            while (reader.Read())
            {
                Document doc = new Document(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), new Categorie(reader[3].ToString(), reader[4].ToString()));
                lesDocuments.Add(doc);
            }
            DAOFactory.deconnecter();
            return lesDocuments;
        }

        public static List<Rayon> getAllRayons()
        {
            List<Rayon> lesRayons = new List<Rayon>();
            string req = "Select * from rayon";

            DAOFactory.connecter();

            MySqlDataReader reader = DAOFactory.execSQLRead(req);

            while (reader.Read())
            {
                Rayon rayon = new Rayon(reader[0].ToString(), reader[1].ToString());
                lesRayons.Add(rayon);
            }
            DAOFactory.deconnecter();
            return lesRayons;
        }



        public static List<Livre> getAllLivres()
        {
            List<Livre> lesLivres = new List<Livre>();

            {
                string req = "Select l.id, l.ISBN, l.auteur, d.titre, d.image, l.collection, d.idCategorie, c.libelle from livre l join document d on l.id = d.id join categorie c on d.idCategorie = c.id";

                DAOFactory.connecter();

                MySqlDataReader reader = DAOFactory.execSQLRead(req);

                while (reader.Read())
                {
                    // On ne renseigne pas le genre et la catégorie car on ne peut pas ouvrir 2 dataReader dans la même connexion
                    Livre livre = new Livre(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(),
                        reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), new Categorie(reader[6].ToString(), reader[7].ToString()));
                    lesLivres.Add(livre);
                }
                DAOFactory.deconnecter();
            }
            return lesLivres;
        }
        // public static void setDescripteurs(List<Livre> lesLivres)
        //{
        // DAOFactory.connecter();

        //foreach (Livre livre in lesLivres)
        //{
        // List<Descripteur> lesDescripteursDuLivre = new List<Descripteur>(); ;
        // string req = "Select de.id, de.libelle from descripteur de ";
        // req += " join est_decrit_par e on de.id = e.idDesc";
        //req += " join document do on do.id = '" + livre.IdDoc + "'";

        // MySqlDataReader reader = DAOFactory.execSQLRead(req);
        //while (reader.Read())
        // {
        //  lesDescripteursDuLivre.Add(new Descripteur(reader[0].ToString(), reader[1].ToString()));
        // }
        // livre.LesDescripteurs = lesDescripteursDuLivre;
        //}
        //DAOFactory.deconnecter();
        //}

        public static Categorie getCategorieByLivre(Livre pLivre)
        {
            Categorie categorie;
            string req = "Select c.id,c.libelle from categorie c,document d where c.id = d.idPublic and d.id='";
            req += pLivre.IdDoc + "'";

            DAOFactory.connecter();

            MySqlDataReader reader = DAOFactory.execSQLRead(req);

            if (reader.Read())
            {
                categorie = new Categorie(reader[0].ToString(), reader[1].ToString());
            }
            else
            {
                categorie = null;
            }
            DAOFactory.deconnecter();
            return categorie;
        }

        //Méthode permettant d'ajouter un abonné
       public static void ajouterAbo(Abonne unAbonne)
        {
            try
            {
                String query = "INSERT INTO abonnement (id, nom, prenom, adresse, tel, adresse_mail, date_naissance, date_premier_abonnement, date_fin_abo)" + "VALUES('" + int.Parse(unAbonne.Id.ToString()) + "','" + unAbonne.Nom.ToString() + "','" + unAbonne.Prenom.ToString() + "','" + unAbonne.Adresse.ToString() + "','" + int.Parse(unAbonne.Tel.ToString()) + "','" + unAbonne.Adresse_mail.ToString() + "','" + unAbonne.Date_naiss.ToString() + "','" + unAbonne.Date_premier_abo.ToString() + "','" + unAbonne.Date_fin_abo.ToString() + "')";
                DAOFactory.connecter();
                DAOFactory.execSQLWrite(query);
                DAOFactory.deconnecter();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
        }

        //Méthode permettant de mofifier un abonné
        public static void modifierAbo(Abonne unAbonne)
        {
            try
            {
                String query = "UPDATE abonnement SET nom= '" + unAbonne.Nom.ToString() + "',prenom='" + unAbonne.Prenom.ToString() + "',adresse='" + unAbonne.Adresse.ToString() + "',tel='" + int.Parse(unAbonne.Tel.ToString()) + "',adresse_mail='" + unAbonne.Adresse_mail.ToString() + "',date_naissance='" + unAbonne.Date_naiss.ToString() + "',date_premier_abonnement='" + unAbonne.Date_premier_abo.ToString() + "',date_fin_abo='" + unAbonne.Date_fin_abo.ToString() + "' where id= '" + int.Parse(unAbonne.Id.ToString()) + "'";
                DAOFactory.connecter();
                DAOFactory.execSQLWrite(query); 
                DAOFactory.deconnecter();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
        }


        //Méthode permettant de supprimer un abonné
        public static void supAbo(Abonne unAbonne)
    {
        try
        {
            String query = "DELETE FROM abonnement WHERE id ='"+unAbonne.Id+"'";
            DAOFactory.connecter();
            DAOFactory.execSQLWrite(query);
            DAOFactory.deconnecter();
        }
        catch (Exception e)
        {
            Console.WriteLine("{0} Exception caught.", e);
        }
    }

        public static void ajouterExemplaire(Exemplaire unExemplaire)
        {
            try
            {
                String query = "INSERT INTO exemplaire (idDoc, numero, dateAchat, idRayon)" + "VALUES('" + unExemplaire.IdDoc.ToString() + "','" + unExemplaire.Numero.ToString() + "','" + unExemplaire.DateAchat.ToString() + "','" + unExemplaire.IdRayon.ToString() + "')";
                DAOFactory.connecter();
                DAOFactory.execSQLWrite(query);
                DAOFactory.deconnecter();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
        }

        public static void ajoutLivre(Livre livre)
        { 
            {   
                String req1 = "INSERT INTO document (id, titre, image, idCategorie) VALUES ('" + livre.IdDoc + "', '" + livre.Titre + "', '" + livre.Image + "', '" + livre.LaCategorie.Id + "')";
                String req2 = "INSERT INTO livre (id, ISBN, auteur, collection,) VALUES ('" + livre.IdDoc + "', '" + livre.ISBN1 + "', '" + livre.Auteur + "', '" + livre.LaCollection + "')";
                DAOFactory.connecter();
                DAOFactory.execSQLWrite(req1);
                DAOFactory.execSQLWrite(req2);
            }
            DAOFactory.deconnecter();
        }

       
        public static void suppLivre (Livre livre)
        {
            string req = "DELETE FROM livre WHERE id = '" + livre.IdDoc + "'";
            string req2 = "DELETE FROM document WHERE id = '" + livre.IdDoc + "'";

            DAOFactory.connecter();
            DAOFactory.execSQLWrite(req);
            DAOFactory.execSQLWrite(req2);
            DAOFactory.deconnecter();
        }

    }


}


