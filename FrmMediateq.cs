using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mediateq_AP_SIO2.metier;


namespace Mediateq_AP_SIO2
{
    public partial class FrmMediateq : Form
    {
        #region Variables globales

        static List<Categorie> lesCategories;
        static List<Descripteur> lesDescripteurs;
        static List<Revue> lesTitres;
        static List<Livre> lesLivres;
        static List<Abonne> lesAbonnes;
        static List<Document> lesDocuments;
        static List<Rayon> lesRayons;

        //static List<DVD> lesDVD;

        #endregion


        #region Procédures évènementielles

        public FrmMediateq()
        {
            InitializeComponent();
        }

        private void FrmMediateq_Load(object sender, EventArgs e)
        {
            // Création de la connexion avec la base de données
            DAOFactory.creerConnection();

            // Chargement des objets en mémoire
            lesDescripteurs = DAODocuments.getAllDescripteurs();
            lesTitres = DAOPresse.getAllTitre();
            lesAbonnes = DAODocuments.getAllAbonnes();
            lesDocuments = DAODocuments.getAllDocuments();
            lesRayons = DAODocuments.getAllRayons();
            lesCategories = DAODocuments.getAllCategories();
            //    lesDVD = DAODocuments.getAllDVD();

        }

        #endregion


        #region Parutions
        //-----------------------------------------------------------
        // ONGLET "PARUTIONS"
        //------------------------------------------------------------
        private void tabParutions_Enter(object sender, EventArgs e)
        {
            cbxTitres.DataSource = lesTitres;
            cbxTitres.DisplayMember = "titre";
        }

        private void cbxTitres_SelectedIndexChanged(object sender, EventArgs e)
        {
                List<Parution> lesParutions;

                Revue titreSelectionne = (Revue)cbxTitres.SelectedItem;
                lesParutions = DAOPresse.getParutionByTitre(titreSelectionne);

                // ré-initialisation du dataGridView
                dgvParutions.Rows.Clear();

                // Parcours de la collection des titres et alimentation du datagridview
                foreach (Parution parution in lesParutions)
                {
                    dgvParutions.Rows.Add(parution.Numero, parution.DateParution, parution.Photo);
                }
            
        }
        #endregion


        #region Revues
        //-----------------------------------------------------------
        // ONGLET "TITRES"
        //------------------------------------------------------------
        private void tabTitres_Enter(object sender, EventArgs e)
        {
            cbxDomaines.DataSource = lesDescripteurs;
            cbxDomaines.DisplayMember = "libelle";
        }

        private void cbxDomaines_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Objet Domaine sélectionné dans la comboBox
            Descripteur domaineSelectionne = (Descripteur)cbxDomaines.SelectedItem;

            // ré-initialisation du dataGridView
            dgvTitres.Rows.Clear();

            // Parcours de la collection des titres et alimentation du datagridview
            foreach (Revue revue in lesTitres)
            {
                if (revue.IdDescripteur==domaineSelectionne.Id)
                {
                    dgvTitres.Rows.Add(revue.Id, revue.Titre, revue.Empruntable, revue.DateFinAbonnement, revue.DelaiMiseADispo);
                }
            }
        }
        #endregion


        #region Livres
        //-----------------------------------------------------------
        // ONGLET "LIVRES"
        //-----------------------------------------------------------

        private void tabLivres_Enter(object sender, EventArgs e)
        {
            // Chargement des objets en mémoire
            lesCategories = DAODocuments.getAllCategories();
            lesDescripteurs = DAODocuments.getAllDescripteurs();
            lesLivres = DAODocuments.getAllLivres();
            //DAODocuments.setDescripteurs(lesLivres);
        }
   
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            // On réinitialise les labels
            lblNumero.Text = "";
            lblTitre.Text = "";
            lblAuteur.Text = "";
            lblCollection.Text = "";
            lblISBN.Text = "";
            lblImage.Text = "";

            // On recherche le livre correspondant au numéro de document saisi.
            // S'il n'existe pas: on affiche un popup message d'erreur
            bool trouve = false;
            foreach (Livre livre in lesLivres)
            {
                if (livre.IdDoc == txbNumDoc.Text)
                {
                    lblNumero.Text = livre.IdDoc;
                    lblTitre.Text = livre.Titre;
                    lblAuteur.Text = livre.Auteur;
                    lblCollection.Text = livre.LaCollection;
                    lblISBN.Text = livre.ISBN1;
                    lblImage.Text = livre.Image;
                    trouve = true;
                }
            }
            if (!trouve)
                MessageBox.Show("Document non trouvé dans les livres");
        }

        private void txbTitre_TextChanged(object sender, EventArgs e)
        {
            dgvLivres.Rows.Clear();

            // On parcourt tous les livres. Si le titre matche avec la saisie, on l'affiche dans le datagrid.
            foreach (Livre livre in lesLivres)
            {
                // on passe le champ de saisie et le titre en minuscules car la méthode Contains
                // tient compte de la casse.
                string saisieMinuscules;
                saisieMinuscules = txbTitre.Text.ToLower();
                string titreMinuscules;
                titreMinuscules = livre.Titre.ToLower();

                //on teste si le titre du livre contient ce qui a été saisi
                if (titreMinuscules.Contains(saisieMinuscules))
                {
                    dgvLivres.Rows.Add(livre.IdDoc,livre.Titre,livre.Auteur,livre.ISBN1,livre.LaCollection);
                }
            }
        }

        #endregion

        

       //Bouton permettant d'ajouter un abonné
        private void Ajouter_Click(object sender, EventArgs e)
        {
                Abonne abo = new Abonne(int.Parse(Aj_id.Text), Aj_nom.Text, Aj_prenom.Text, Aj_adresse.Text, int.Parse(Aj_tel.Text), Aj_adresse_mail.Text, Aj_date_naiss.Text, Aj_date_premier_abo.Text, Aj_date_fin_abo.Text);
                DAODocuments.ajouterAbo(abo);
                MessageBox.Show("Abonné ajouté");
        }

        //Alimentation des ComboBox
        private void CRUD_abo_Enter(object sender, EventArgs e)
        {
            //ComboBox supprimé
            cbSupp.DataSource = lesAbonnes;
            cbSupp.DisplayMember = "nom";
            //ComboBox ajouté
            cb_modif.DataSource = lesAbonnes;
            cb_modif.DisplayMember = "prenom";
            foreach (Abonne abonne in lesAbonnes)
            {
                dataGridAbo.Rows.Add(abonne.Id, abonne.Nom, abonne.Prenom, abonne.Adresse, abonne.Tel, abonne.Adresse_mail, abonne.Date_naiss, abonne.Date_premier_abo, abonne.Date_fin_abo);
            }

        }

        //Bouton confirmant la suppression
        private void supprimer_Click(object sender, EventArgs e)
        {
                Abonne abonne = (Abonne)cbSupp.SelectedItem;
                DAODocuments.supAbo(abonne);
                MessageBox.Show("Abonné supprimé");
 
        }

        // Bouton appelant la méthode modifierAbo permettant d'effectuer la modification de l'abonné
       private void Modifier_Click(object sender, EventArgs e)
        {
                int idModif = Int32.Parse(modif_id.Text);
                string nomModif = modif_nom.Text;
                string prenomModif = modif_prenom.Text;
                string adresseModif = modif_adresse.Text;
                int telModif = Int32.Parse(numericUpDown1.Text);
                string adresseMailModif = modif_adresse_mail.Text;
                string dateNaissanceModif = modif_date_naissance.Text;
                string datePremierAboModif = modif_date_premier_abonnement.Text;
                string dateFinAboModif = modif_fin_abo.Text;

                Abonne abonneModif = new Abonne(idModif, nomModif, prenomModif, adresseModif, telModif, adresseMailModif, dateNaissanceModif, datePremierAboModif, dateFinAboModif);
                MessageBox.Show("Abonné modifé");

               DAODocuments.modifierAbo(abonneModif);     
        }


        private void cb_modif_SelectedIndexChanged(object sender, EventArgs e)
        {
            Abonne abonne = (Abonne)cb_modif.SelectedItem;

            modif_id.Text = abonne.Id.ToString();
            modif_nom.Text = abonne.Nom;
            modif_prenom.Text = abonne.Prenom;
            modif_adresse.Text = abonne.Adresse;
            numericUpDown1.Text = abonne.Tel.ToString();
            modif_adresse_mail.Text = abonne.Adresse_mail;
            modif_date_naissance.Text = abonne.Date_naiss;
            modif_date_premier_abonnement.Text = abonne.Date_premier_abo;
            modif_fin_abo.Text = abonne.Date_fin_abo;  
        }


        //Alimentation du dataGridView
        private void tabOngletsApplication_Enter(object sender, EventArgs e)
        {
            foreach (Abonne abonne in lesAbonnes)
            {
                dataGridViewAbonne.Rows.Add(abonne.Id, abonne.Nom, abonne.Prenom, abonne.Adresse, abonne.Tel, abonne.Adresse_mail, abonne.Date_naiss, abonne.Date_premier_abo, abonne.Date_fin_abo);
            }
        }


        // Bouton rafraîchissement du DataGrid
        private void Refresh_Enter(object sender, EventArgs e)
        {
            //DataGrid vidé
            dataGridAbo.Rows.Clear();

            //Rafraîchissement de la collection
            lesAbonnes = DAODocuments.getAllAbonnes();
            foreach (Abonne abonne in lesAbonnes)
            {
                dataGridAbo.Rows.Add(abonne.Id, abonne.Nom, abonne.Prenom, abonne.Adresse, abonne.Tel, abonne.Adresse_mail, abonne.Date_naiss, abonne.Date_premier_abo, abonne.Date_fin_abo);
            }
            dataGridAbo.Refresh();
        }

       /* private void groupBox2_Enter(object sender, EventArgs e)
        {

        }*/

        private void exemplaire_Enter(object sender, EventArgs e)
        {
            cb_document.DataSource = lesDocuments;
            cb_document.DisplayMember = "titre";
            cb_rayon.DataSource = lesRayons;
            cb_rayon.DisplayMember = "libelle";
            Document d = (Document)cb_document.SelectedItem;
            Rayon r = (Rayon)cb_rayon.SelectedItem;

        }

        private void ajouter_exemplaire_Enter(object sender, EventArgs e)
        {
            Exemplaire ex = new Exemplaire(cb_document.Text, txtBox_numero.Text, dtp_date.Value, cb_rayon.Text);
            DAODocuments.ajouterExemplaire(ex);
            MessageBox.Show("Exemplaire ajouté");
        }

        private void btnAjouter_livre_Enter(object sender, EventArgs e)
        {
            lesLivres = DAODocuments.getAllLivres();
            string IDLivre = txtLivre_id.Text;
            string ISBNLivre = txtLivre_ISBN.Text;
            string AuteurLivre = txtLivre_auteur.Text;
            string TitreLivre = txtLivre_titre.Text;
            string ImageLivre = txtLivre_image.Text;
            string uneCollection = txtLivre_collection.Text;
            Categorie uneCategorie = (Categorie)cbx_livre.SelectedItem;

            Livre livre1 = new Livre(IDLivre, ISBNLivre, AuteurLivre, TitreLivre, ImageLivre, uneCollection, uneCategorie);
            DAODocuments.ajoutLivre(livre1);
            MessageBox.Show("livre ajouté");
        }

        private void CRUDLivreDvd_Enter(object sender, EventArgs e)
        {
            lesLivres = DAODocuments.getAllLivres();
            cbx_livre.DataSource = lesCategories;
            cbx_livre.DisplayMember = "libelle";
            cbxModifCateg.DataSource = lesCategories;
            cbxModifCateg.DisplayMember = "libelle";
            cbModifLivre.DataSource = lesLivres;
            cbModifLivre.DisplayMember = "auteur";

        }

        private void cbModifLivre_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxModifCateg.DataSource = lesCategories;
            cbxModifCateg.DisplayMember = "libelle";

            Livre livreSelec = (Livre)cbModifLivre.SelectedItem;

            foreach (Livre unLivre in lesLivres)
            {
                if (unLivre.IdDoc == livreSelec.IdDoc)
                {
                    txtBoxModifLivreId.Text = livreSelec.IdDoc;
                    txtBoxModifLivreTitre.Text = livreSelec.Titre;
                    txtBoxModifLivreISBN.Text = livreSelec.ISBN1;
                    txtBoxModifLivreAuteur.Text = livreSelec.Auteur;
                    txtBoxModifLivreCollection.Text = livreSelec.LaCollection;
                    txtBoxModifLivreImage.Text = livreSelec.Image;
                    cbxModifCateg.Text = livreSelec.LaCategorie.Libelle;
                }
            }
        }

        private void btnSuppLivre_Enter(object sender, EventArgs e)
        {
            string IdLivreModif = txtBoxModifLivreId.Text;
            string TitreLivreModif = txtBoxModifLivreTitre.Text;
            string ISBNLivreModif = txtBoxModifLivreISBN.Text;
            string AuteurLivreModif = txtBoxModifLivreAuteur.Text;
            string CollectionLivreModif = txtBoxModifLivreCollection.Text;
            string ImageLivreModif = txtBoxModifLivreImage.Text;
            Categorie CategLivreModif = (Categorie)cbxModifCateg.SelectedItem;

            Livre livre = new Livre(IdLivreModif, TitreLivreModif, ISBNLivreModif, AuteurLivreModif, CollectionLivreModif, ImageLivreModif, CategLivreModif);
            DAODocuments.suppLivre(livre);
            MessageBox.Show("livre supprimé");
        }

        //private void cbModifLivre_Enter(object sender, EventArgs e)
        // {

        // }

        //private void exemplaire_Click(object sender, EventArgs e)
        //{

        //}
    }
}
