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
                Abonne abonne = new Abonne(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), int.Parse(reader[4].ToString()), reader[5].ToString(), DateTime.Parse(reader[6].ToString()), DateTime.Parse(reader[7].ToString()), DateTime.Parse(reader[8].ToString()));
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

        public static List<DVD> getAllDVD()
        {
            List<DVD> lesDvd = new List<DVD>();

            {
                string req = "Select dvd.id, d.titre, dvd.synopsis, dvd.réalisateur, dvd.duree, d.image, d.idCategorie, c.libelle from dvd dvd join document d on dvd.id = d.id join categorie c on d.idCategorie = c.id";

                DAOFactory.connecter();

                MySqlDataReader reader = DAOFactory.execSQLRead(req);

                while (reader.Read())
                {
                    // On ne renseigne pas le genre et la catégorie car on ne peut pas ouvrir 2 dataReader dans la même connexion
                    DVD dvd = new DVD(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(),
                        reader[3].ToString(), int.Parse(reader[4].ToString()), reader[5].ToString(), new Categorie(reader[6].ToString(), reader[7].ToString()));
                    lesDvd.Add(dvd);
                }
                DAOFactory.deconnecter();
            }
            return lesDvd;
        }

        public static List<Users> getAllUsers()
        {
            List<Users> lesUsers = new List<Users>();
            string req = "Select * from users";

            DAOFactory.connecter();

            MySqlDataReader reader = DAOFactory.execSQLRead(req);

            while (reader.Read())
            {
                Users users = new Users(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString());
                lesUsers.Add(users);
            }
            DAOFactory.deconnecter();
            return lesUsers;
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
                string date = unAbonne.Date_naiss.ToString("yyyy-MM-d");
                string date1 = unAbonne.Date_premier_abo.ToString("yyyy-MM-d");
                string date2 = unAbonne.Date_fin_abo.ToString("yyyy-MM-d");
                String query = "INSERT INTO abonnement (id, nom, prenom, adresse, tel, adresse_mail, date_naissance, date_premier_abonnement, date_fin_abo)" + "VALUES('" + int.Parse(unAbonne.Id.ToString()) + "','" + unAbonne.Nom.ToString() + "','" + unAbonne.Prenom.ToString() + "','" + unAbonne.Adresse.ToString() + "','" + int.Parse(unAbonne.Tel.ToString()) + "','" + unAbonne.Adresse_mail.ToString() + "','" + date + "','" + date1 + "','" + date2 + "')";
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
                string date = unAbonne.Date_naiss.ToString("yyyy-MM-d");
                string date1 = unAbonne.Date_premier_abo.ToString("yyyy-MM-d");
                string date2 = unAbonne.Date_fin_abo.ToString("yyyy-MM-d");
                String query = "UPDATE abonnement SET nom= '" + unAbonne.Nom.ToString() + "',prenom='" + unAbonne.Prenom.ToString() + "',adresse='" + unAbonne.Adresse.ToString() + "',tel='" + int.Parse(unAbonne.Tel.ToString()) + "',adresse_mail='" + unAbonne.Adresse_mail.ToString() + "',date_naissance='" + date + "',date_premier_abonnement='" + date1 + "',date_fin_abo='" + date2 + "' where id= '" + int.Parse(unAbonne.Id.ToString()) + "'";
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
                String query = "DELETE FROM abonnement WHERE id ='" + unAbonne.Id + "'";
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
            try
            {
                String req1 = "INSERT INTO document (id, titre, image, idCategorie) VALUES ('" + livre.IdDoc + "', '" + livre.Titre + "', '" + livre.Image + "', '" + livre.LaCategorie.Id + "')";
                String req2 = "INSERT INTO livre (id, ISBN, auteur, collection) VALUES ('" + livre.IdDoc + "', '" + livre.ISBN1 + "', '" + livre.Auteur + "', '" + livre.LaCollection + "')";
                DAOFactory.connecter();
                DAOFactory.execSQLWrite(req1);
                DAOFactory.execSQLWrite(req2);
                DAOFactory.deconnecter();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
        }

        public static void modifLivre(Livre livre)
        {
            try
            {
                string req = "UPDATE document SET id = '" + livre.IdDoc + "', titre = '" + livre.Titre + "', image = '" + livre.Image + "', idCategorie = '" + livre.LaCategorie.Id + "' WHERE id = '" + livre.IdDoc + "'";
                string req2 = "UPDATE livre SET id = '" + livre.IdDoc + "', ISBN = '" + livre.ISBN1 + "', auteur = '" + livre.Auteur + "', collection = '" + livre.LaCollection + "' WHERE id = '" + livre.IdDoc + "'";

                DAOFactory.connecter();
                DAOFactory.execSQLWrite(req);
                DAOFactory.execSQLWrite(req2);
                DAOFactory.deconnecter();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }


        }

        public static void suppLivre(Livre livre)
        {
            string req = "DELETE FROM livre WHERE id = '" + livre.IdDoc + "'";
            string req2 = "DELETE FROM document WHERE id = '" + livre.IdDoc + "'";

            DAOFactory.connecter();
            DAOFactory.execSQLWrite(req);
            DAOFactory.execSQLWrite(req2);
            DAOFactory.deconnecter();
        }

        public static void ajoutDVD(DVD dvd)
        {
            try
            {
                String req1 = "INSERT INTO document (id, titre, image, idCategorie) VALUES ('" + dvd.IdDoc + "', '" + dvd.Titre + "', '" + dvd.Image + "', '" + dvd.LaCategorie.Id + "')";
                String req2 = "INSERT INTO dvd ( id, synopsis, réalisateur,duree) VALUES ('" + dvd.IdDoc + "', '" + dvd.Synopsis + "', '" + dvd.Realisateur + "', '" + int.Parse(dvd.Duree.ToString()) + "')";
                DAOFactory.connecter();
                DAOFactory.execSQLWrite(req1);
                DAOFactory.execSQLWrite(req2);
                DAOFactory.deconnecter();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
        }

        public static void modifDVD(DVD dvd)
        {
            try
            {
                string req = "UPDATE document SET id = '" + dvd.IdDoc + "', titre = '" + dvd.Titre + "', image = '" + dvd.Image + "', idCategorie = '" + dvd.LaCategorie.Id + "' WHERE id = '" + dvd.IdDoc + "'";
                string req2 = "UPDATE dvd SET id = '" + dvd.IdDoc + "', Synopsis = '" + dvd.Synopsis + "', réalisateur = '" + dvd.Realisateur + "', duree = '" + dvd.Duree + "' WHERE id = '" + dvd.IdDoc + "'";

                DAOFactory.connecter();
                DAOFactory.execSQLWrite(req);
                DAOFactory.execSQLWrite(req2);
                DAOFactory.deconnecter();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }


        }

        public static void suppDVD(DVD dvd)
        {
            string req = "DELETE FROM dvd WHERE id = '" + dvd.IdDoc + "'";
            string req2 = "DELETE FROM document WHERE id = '" + dvd.IdDoc + "'";

            DAOFactory.connecter();
            DAOFactory.execSQLWrite(req);
            DAOFactory.execSQLWrite(req2);
            DAOFactory.deconnecter();
        }

        public static Users connex(string unUsername)
        {

            {
                Users user = null;
                string req = "SELECT * FROM users WHERE username = '" + unUsername + "'";

                DAOFactory.connecter();

                MySqlDataReader reader = DAOFactory.execSQLRead(req);

                while (reader.Read())
                {
                    user = new Users(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString());
                }
                DAOFactory.deconnecter();
                return user;
            }
        }

        public static int verifAbonne(Abonne unAbonne)
        {
            try
            {
                string date1 = unAbonne.Date_fin_abo.ToString("yyyy-MM-d");

                int abone = 0;
                string req = "SELECT DateDiff('" + date1 + "', DATE(NOW()))"
;

                DAOFactory.connecter();
                DAOFactory.execSQLWrite(req);
                MySqlDataReader reader = DAOFactory.execSQLRead(req);

                while (reader.Read())
                {



                    abone = int.Parse(reader[0].ToString());


                }

                DAOFactory.deconnecter();
                return abone;
            }
            catch (Exception e)
            {
                DAOFactory.deconnecter();

                throw e;
            }


            DAOFactory.deconnecter();

        }

    }
}
