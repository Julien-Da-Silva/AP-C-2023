﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mediateq_AP_SIO2.metier;
using System.Text.RegularExpressions;


namespace Mediateq_AP_SIO2
{
    /// <summary>
    /// Formulaire Mediateq ou sont réalisé les traitements
    /// </summary>
     partial class FrmMediateq : Form
    {
        #region Variables globales

        static List<Categorie> lesCategories;
        static List<Descripteur> lesDescripteurs;
        static List<Revue> lesTitres;
        static List<Livre> lesLivres;
        static List<Abonne> lesAbonnes;
        static List<Document> lesDocuments;
        static List<Rayon> lesRayons;
        static List<DVD> lesDVD;
        static List<Users> lesUsers;

        public Users u { get; set; }


        //static List<DVD> lesDVD;

        #endregion


        #region Procédures évènementielles

        public FrmMediateq(Users utilisateur)
        {
            InitializeComponent();
            u = utilisateur;
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
            lesDVD = DAODocuments.getAllDVD();

            if (u.Role == "pret")
            {
                Connexion.TabPages.Remove(CRUD_abo);
                Connexion.TabPages.Remove(dgvAbo);
                Connexion.TabPages.Remove(exemplaire);
            }

            if (u.Role == "culture")
            {
                Connexion.TabPages.Remove(CRUD_abo);
                Connexion.TabPages.Remove(CRUDLivreDvd);
                Connexion.TabPages.Remove(CRUD_DVD);
            }

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
        /* private void Ajouter_Click(object sender, EventArgs e)
         {
                 DateTime dtpannee = dtp_annee.Value;
                 Abonne abo = new Abonne(int.Parse(Aj_id.Text), Aj_nom.Text, Aj_prenom.Text, Aj_adresse.Text, int.Parse(Aj_tel.Text), Aj_adresse_mail.Text, dtpannee, Aj_date_premier_abo.Text, Aj_date_fin_abo.Text);
                 DAODocuments.ajouterAbo(abo);
                 MessageBox.Show("Abonné ajouté");
         }*/

        private void Ajouter_Click_1(object sender, EventArgs e)
        {

            // Validation du format du prénom et du nom
            Regex regexNomPrenom = new Regex(@"^[A-Za-z\s]+$");
            if (!regexNomPrenom.IsMatch(Aj_nom.Text) || !regexNomPrenom.IsMatch(Aj_prenom.Text))
            {
                MessageBox.Show("Le prénom et le nom doivent contenir uniquement des lettres.");
                return;
            }

            // Validation de l'adresse
            Regex regexAdresse = new Regex(@"^[A-Za-z0-9\s]+$");
            if (!regexAdresse.IsMatch(Aj_adresse.Text))
            {
                MessageBox.Show("Adresse invalide. Utilisez uniquement des lettres, des chiffres et des espaces.");
                return;
            }

            Regex regexTelephone = new Regex(@"^\d{10}$");
            if (!regexTelephone.IsMatch(Aj_tel.Text))
            {
                MessageBox.Show("numéro de téléphone invalide. Utilisez le format XXXXXXXXXX.");
                return;

            }

            // Validation de l'adresse e-mail
            Regex regexEmail = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (!regexEmail.IsMatch(Aj_adresse_mail.Text))
            {
                MessageBox.Show("Adresse e-mail invalide.");
                return;
            }


            if (string.IsNullOrEmpty(Aj_nom.Text) || string.IsNullOrEmpty(Aj_prenom.Text) || string.IsNullOrEmpty(Aj_adresse.Text) || string.IsNullOrEmpty(Aj_tel.Text) || string.IsNullOrEmpty(Aj_adresse_mail.Text))
            {
                Ajouter.Enabled = false;
                return;
            }

            Ajouter.Enabled = true;

            DateTime dtpannee = dtp_annee.Value;
            DateTime dtpPremierAbo = dtp_premier_abo.Value;
            DateTime dtpFinAbo = dtpPremierAbo.AddMonths(2);
            DAODocuments.ajouterAbo(Aj_nom.Text, Aj_prenom.Text, Aj_adresse.Text, int.Parse(Aj_tel.Text), Aj_adresse_mail.Text, dtpannee, dtpPremierAbo, dtpFinAbo);
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

            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet abonné ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DAODocuments.supAbo(abonne);
                MessageBox.Show("Abonné supprimé");
            }
        }


        // Bouton appelant la méthode modifierAbo permettant d'effectuer la modification de l'abonné

        private void Modifier_Click(object sender, EventArgs e)
        {
            int idModif = Int32.Parse(modif_id.Text);
            string nomModif = modif_nom.Text;
            string prenomModif = modif_prenom.Text;
            string adresseModif = modif_adresse.Text;
            int telModif = Int32.Parse(txt_modif_tel.Text);
            string adresseMailModif = modif_adresse_mail.Text;
            DateTime dateNaissanceModif = dtp_modif_annee.Value;
            DateTime datePremierAboModif = dtp_modif_date_premier_abo.Value;
            DateTime dateFinAboModif = dtp_date_fin_abo.Value;

            // Utilisation des regex pour la validation

            // Validation de l'adresse e-mail
            Regex regexEmail = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (!regexEmail.IsMatch(adresseMailModif))
            {
                MessageBox.Show("Adresse e-mail invalide.");
                return;
            }

            // Validation du format du prénom et du nom
            Regex regexNomPrenom = new Regex(@"^[A-Za-z\s]+$");
            if (!regexNomPrenom.IsMatch(nomModif) || !regexNomPrenom.IsMatch(prenomModif))
            {
                MessageBox.Show("Le prénom et le nom doivent contenir uniquement des lettres.");
                return;
            }

            Regex regexTelephone = new Regex(@"^[0-9]{10}$");
            if (!regexTelephone.IsMatch(txt_modif_tel.Text))
            {
                MessageBox.Show("Numéro de téléphone invalide. Utilisez le format XXXXXXXXXX.");
                return;
            }

            Abonne abonneModif = new Abonne(idModif, nomModif, prenomModif, adresseModif, telModif, adresseMailModif, dateNaissanceModif, datePremierAboModif, dateFinAboModif);
            MessageBox.Show("Abonné modifié");

            DAODocuments.modifierAbo(abonneModif);
        }



        private void cb_modif_SelectedIndexChanged(object sender, EventArgs e)
        {
            Abonne abonne = (Abonne)cb_modif.SelectedItem;

            modif_id.Text = abonne.Id.ToString();
            modif_nom.Text = abonne.Nom;
            modif_prenom.Text = abonne.Prenom;
            modif_adresse.Text = abonne.Adresse;
            txt_modif_tel.Text = abonne.Tel.ToString();
            modif_adresse_mail.Text = abonne.Adresse_mail;
            dtp_modif_annee.Value = abonne.Date_naiss;
            dtp_premier_abo.Value = abonne.Date_premier_abo;
            dtp_date_fin_abo.Value = abonne.Date_fin_abo;  
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

            // Validation de l'ID du livre (uniquement des chiffres)
            Regex regexIDLivre = new Regex(@"^\d+$");
            if (!regexIDLivre.IsMatch(IDLivre))
            {
                MessageBox.Show("ID du livre invalide. Utilisez uniquement des chiffres.");
                return;
            }

            // Validation de l'ISBN du livre (chiffres et tirets)
            Regex regexISBNLivre = new Regex(@"^\d{13}$");
            if (!regexISBNLivre.IsMatch(ISBNLivre))
            {
                MessageBox.Show("ISBN du livre invalide. Utilisez un format valide (10 chiffres ou 9 chiffres et la lettre 'X' en dernière position).");
                return;
            }

            // Validation de l'auteur du livre (lettres, espaces et éventuellement d'autres caractères spéciaux)
            Regex regexAuteurLivre = new Regex(@"^[A-Za-z\s-]+$");
            if (!regexAuteurLivre.IsMatch(AuteurLivre))
            {
                MessageBox.Show("Auteur du livre invalide. Utilisez uniquement des lettres et des espaces.");
                return;
            }

            // Validation du titre du livre (lettres, chiffres, espaces et éventuellement d'autres caractères spéciaux)
            Regex regexTitreLivre = new Regex(@"^[A-Za-z0-9\s\p{P}-]+$");
            if (!regexTitreLivre.IsMatch(TitreLivre))
            {
                MessageBox.Show("Titre du livre invalide. Utilisez uniquement des lettres, des chiffres et des espaces.");
                return;
            }

            // Validation de la collection du livre (lettres, chiffres, espaces et éventuellement d'autres caractères spéciaux)
            Regex regexCollection = new Regex(@"^[A-Za-z0-9\s\p{P}-]+$");
            if (!regexCollection.IsMatch(uneCollection))
            {
                MessageBox.Show("Collection du livre invalide. Utilisez uniquement des lettres, des chiffres et des espaces.");
                return;
            }

            Livre livre1 = new Livre(IDLivre, TitreLivre, ISBNLivre, AuteurLivre, uneCollection, ImageLivre, uneCategorie);
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
            cbModifLivre.DisplayMember = "titre";

            lesLivres = DAODocuments.getAllLivres();

            //Affichage des nouvelles données dans le DataGrid

            foreach (Livre livreModifcation in lesLivres)
            {
                dgvLivre.Rows.Add(livreModifcation.IdDoc, livreModifcation.ISBN1, livreModifcation.Auteur, livreModifcation.Titre, livreModifcation.Image, livreModifcation.LaCollection, livreModifcation.LaCategorie.Libelle);
            }

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
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce livre ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DAODocuments.suppLivre(livre);
                MessageBox.Show("livre supprimé");
            }
        }

        private void btnModifLivre_Enter(object sender, EventArgs e)
        {
            string idLivreModif = txtBoxModifLivreId.Text;
            string titreLivreModif = txtBoxModifLivreTitre.Text;
            string ISBNLivreModif = txtBoxModifLivreISBN.Text;
            string auteurLivreModif = txtBoxModifLivreAuteur.Text;
            string collectionLivreModif = txtBoxModifLivreCollection.Text;
            string imageLivreModif = txtBoxModifLivreImage.Text;
            Categorie categorieModifLivre = (Categorie)cbxModifCateg.SelectedItem;

            // Validation de l'ID du livre (uniquement des chiffres)
            Regex regexIDLivreModif = new Regex(@"^\d+$");
            if (!regexIDLivreModif.IsMatch(idLivreModif))
            {
                MessageBox.Show("ID du livre invalide. Utilisez uniquement des chiffres.");
                return;
            }

            // Validation de l'ISBN du livre (chiffres et tirets)
            Regex regexISBNLivreModif = new Regex(@"^\d{13}$");
            if (!regexISBNLivreModif.IsMatch(ISBNLivreModif))
            {
                MessageBox.Show("ISBN du livre invalide. Le format de 'ISBN doit être composé de 13 chiffres.");
                return;
            }

            // Validation de l'auteur du livre (lettres, espaces et tirets)
            Regex regexAuteurLivreModif = new Regex(@"^[A-Za-z\s-]+$");
            if (!regexAuteurLivreModif.IsMatch(auteurLivreModif))
            {
                MessageBox.Show("Auteur du livre invalide. Utilisez uniquement des lettres, des espaces et des tirets.");
                return;
            }

            // Validation du titre du livre (lettres, chiffres, espaces et tirets)
            Regex regexTitreLivreModif = new Regex(@"^[A-Za-z0-9\s-]+$");
            if (!regexTitreLivreModif.IsMatch(titreLivreModif))
            {
                MessageBox.Show("Titre du livre invalide. Utilisez uniquement des lettres, des chiffres, des espaces et des tirets.");
                return;
            }

            // Le reste du code pour la modification du livre...


            Livre livre = new Livre(idLivreModif, titreLivreModif, ISBNLivreModif, auteurLivreModif, collectionLivreModif, imageLivreModif, categorieModifLivre);

            DAODocuments.modifLivre(livre);
            MessageBox.Show("livre modifié");

            lesLivres = DAODocuments.getAllLivres();

            dgvLivre.Rows.Clear();

            //Affichage des nouvelles données dans le DataGrid

            foreach (Livre livreModifcation in lesLivres)
            {
                dgvLivre.Rows.Add(livreModifcation.IdDoc, livreModifcation.ISBN1, livreModifcation.Auteur, livreModifcation.Titre, livreModifcation.Image, livreModifcation.LaCollection, livreModifcation.LaCategorie.Libelle);
            }
        }

        private void CRUD_DVD_Enter(object sender, EventArgs e)
        {
            lesDVD = DAODocuments.getAllDVD();
            cbx_categDVD.DataSource = lesCategories;
            cbx_categDVD.DisplayMember = "libelle";
            cbx_ModifDvd.DataSource = lesDVD;
            cbx_ModifDvd.DisplayMember = "titre";
            cbx_ModifCategDvd.DataSource= lesCategories;
            cbx_ModifCategDvd.DisplayMember = "libelle";

            foreach (DVD dvd in lesDVD)
            {
                dgvDvd.Rows.Add(dvd.IdDoc, dvd.Titre, dvd.Image, dvd.Synopsis, dvd.Realisateur, dvd.Duree, dvd.LaCategorie.Libelle);
            }
        }

        private void btnAjout_DVD_Enter(object sender, EventArgs e)
    {
        lesDVD = DAODocuments.getAllDVD();
        string IDDVD = txtDvd_id.Text;
        string TitreDVD = txtDvd_Titre.Text;
        string ImageDVD = txtDvd_Image.Text;
        string SynopsisDVD = txtDvd_Synopsis.Text;
        string RealisateurDVD = txtDvd_Realisateur.Text;
        int DureeDVD = 0;
        if (!int.TryParse(txtDvd_Duree.Text, out DureeDVD))
        {
            MessageBox.Show("Durée du DVD invalide. Veuillez entrer une durée valide (nombre entier).");
            return;
        }
        Categorie uneCategorie = (Categorie)cbx_categDVD.SelectedItem;

        Regex regexIDDVD = new Regex(@"^[a-zA-Z0-9]+$");
        if (!regexIDDVD.IsMatch(IDDVD))
        {
            MessageBox.Show("ID du DVD invalide. L'ID doit être composé de caractères alphanumériques.");
            return;
        }

        Regex regexTitreDVD = new Regex(@"^.+$");
        if (!regexTitreDVD.IsMatch(TitreDVD))
        {
            MessageBox.Show("Titre du DVD invalide. Veuillez entrer un titre valide.");
            return;
        }

        Regex regexSynopsisDVD = new Regex(@"^.+$");
        if (!regexSynopsisDVD.IsMatch(SynopsisDVD))
        {
            MessageBox.Show("Synopsis du DVD invalide. Veuillez entrer un synopsis valide.");
            return;
        }
        Regex regexRealisateurDVD = new Regex(@"^[a-zA-Z\s]+$");
        if (!regexRealisateurDVD.IsMatch(RealisateurDVD))
        {
            MessageBox.Show("Réalisateur du DVD invalide. Veuillez entrer un réalisateur valide sans caractères spéciaux.");
            return;
        } 

            if (string.IsNullOrEmpty(IDDVD) || string.IsNullOrEmpty(TitreDVD) || string.IsNullOrEmpty(SynopsisDVD) || string.IsNullOrEmpty(RealisateurDVD) || string.IsNullOrEmpty(txtDvd_Duree.Text))
        {
            btnAjout_DVD.Enabled = false;
            return;
        }

        btnAjout_DVD.Enabled = true;

        DVD dvd1 = new DVD(IDDVD, TitreDVD, SynopsisDVD, RealisateurDVD, DureeDVD, ImageDVD, uneCategorie);
        DAODocuments.ajoutDVD(dvd1);
        MessageBox.Show("DVD ajouté");
    }


        private void cbx_ModifDvd_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx_ModifCategDvd.DataSource = lesCategories;
            cbx_ModifCategDvd.DisplayMember = "libelle";

            DVD DvdSelec = (DVD)cbx_ModifDvd.SelectedItem;

            foreach (DVD unDVD in lesDVD)
            {
                if (unDVD.IdDoc == DvdSelec.IdDoc)
                {
                    txtBoxModifDvdId.Text = DvdSelec.IdDoc;
                    txtBoxModifDvdTitre.Text = DvdSelec.Titre;
                    txtBoxModifDvdImage.Text = DvdSelec.Image;
                    txtBoxModifDvdSynopsis.Text = DvdSelec.Synopsis;
                    txtBoxModifDvdRealisateur.Text = DvdSelec.Realisateur;
                    txtBoxModifDvdDuree.Text = DvdSelec.Duree.ToString();
                    cbx_ModifCategDvd.Text = DvdSelec.LaCategorie.Libelle;
                }
            }
        }

        private void btnModifDvd_Enter(object sender, EventArgs e)
        {
            string idDvdModif = txtBoxModifDvdId.Text;
            string TitreDvdModif = txtBoxModifDvdTitre.Text;
            string ImageDvdeModif = txtBoxModifDvdImage.Text;
            string SynopsisDvdModif = txtBoxModifDvdSynopsis.Text;
            string RealisateurDvdModif = txtBoxModifDvdRealisateur.Text;
            int DureeDvdModif = Int32.Parse(txtBoxModifDvdDuree.Text);
            Categorie CategorieModifDvd = (Categorie)cbx_ModifCategDvd.SelectedItem;


            Regex regexSynopsisDVD = new Regex(@"^.+$");
            if (!regexSynopsisDVD.IsMatch(SynopsisDvdModif))
            {
                MessageBox.Show("Synopsis du DVD invalide. Veuillez entrer un synopsis valide.");
                return;
            }

            Regex regexTitreDVD = new Regex(@"^[A-Za-z\s]+$");
            if (!regexTitreDVD.IsMatch(TitreDvdModif))
            {
                MessageBox.Show("Titre du DVD invalide. Veuillez entrer un titre valide contenant uniquement des lettres et des espaces.");
                return;
            }

            Regex regexRealisateurDVD = new Regex(@"^[A-Za-z\s]+$");
            if (!regexRealisateurDVD.IsMatch(RealisateurDvdModif))
            {
                MessageBox.Show("Réalisateur du DVD invalide. Veuillez entrer un réalisateur valide contenant uniquement des lettres et des espaces.");
                return;
            }

            DVD dvd = new DVD(idDvdModif, TitreDvdModif, SynopsisDvdModif, RealisateurDvdModif, DureeDvdModif, ImageDvdeModif, CategorieModifDvd);

            DAODocuments.modifDVD(dvd);
            MessageBox.Show("dvd modifié");
        }

        private void btnSuppDvd_Enter(object sender, EventArgs e)
        {
            string idDvdModif = txtBoxModifDvdId.Text;
            string TitreDvdModif = txtBoxModifDvdTitre.Text;
            string ImageDvdeModif = txtBoxModifDvdImage.Text;
            string SynopsisDvdModif = txtBoxModifDvdSynopsis.Text;
            string RealisateurDvdModif = txtBoxModifDvdRealisateur.Text;
            int DureeDvdModif = Int32.Parse(txtBoxModifDvdDuree.Text);
            Categorie CategorieModifDvd = (Categorie)cbx_ModifCategDvd.SelectedItem;

            DVD dvd = new DVD(idDvdModif, TitreDvdModif, ImageDvdeModif, SynopsisDvdModif, DureeDvdModif, RealisateurDvdModif, CategorieModifDvd);
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce DVD ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DAODocuments.suppDVD(dvd);
                MessageBox.Show("DVD supprimé");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        /*private void verifDate_Enter(object sender, EventArgs e)
        {
            dtp_date_fin_abo
        }*/

        private void verifDate_Click(object sender, EventArgs e)
        {

            Abonne abonne = (Abonne)cb_modif.SelectedItem;
            DateTime dateFinAbo = abonne.Date_fin_abo;

            // Calcul du nombre de jours restants avant la fin de l'abonnement
            TimeSpan difference = dateFinAbo - DateTime.Today;
            int verif = difference.Days;

            if (verif <= 0)
            {
                MessageBox.Show("L'abonnement de cet abonné a expiré.");
            }
            else if (verif < 30)
            {
                MessageBox.Show("Il reste " + verif.ToString() + " jour(s) avant la fin de son abonnement. Il faudra le renouveler.");
            }
            else
            {
                MessageBox.Show("Il reste " + verif.ToString() + " jour(s) avant la fin de son abonnement.");
            }
        }

        private void btnRefreshLivre_Click(object sender, EventArgs e)
        {
            //DataGrid vidé
            dgvLivre.Rows.Clear();

            //Rafraîchissement de la collection
            lesLivres = DAODocuments.getAllLivres();
            foreach (Livre livre in lesLivres )
            {
                dgvLivre.Rows.Add(livre.IdDoc, livre.Auteur, livre.Titre, livre.ISBN1, livre.LaCollection, livre.Image, livre.LaCategorie);
            }
            dgvLivre.Refresh();
        }

        private void btnRefreshDvd_Click(object sender, EventArgs e)
        {
            dgvDvd.Rows.Clear();

            //Rafraîchissement de la collection
            lesDVD = DAODocuments.getAllDVD();
            foreach (DVD dvd in lesDVD)
            {
                dgvDvd.Rows.Add(dvd.IdDoc, dvd.Titre, dvd.Image, dvd.Synopsis, dvd.Realisateur, dvd.Duree, dvd.LaCategorie.Libelle);
            }
            dgvDvd.Refresh();
        }

        private void txtBoxRechercherTitreDvd_TextChanged(object sender, EventArgs e)
        {
            dgvRechercherTitreDvd.Rows.Clear();

            // On parcourt tous les livres. Si le titre matche avec la saisie, on l'affiche dans le datagrid.
            foreach (DVD dvd in lesDVD)
            {
                // on passe le champ de saisie et le titre en minuscules car la méthode Contains
                // tient compte de la casse.
                string saisieMinuscules;
                saisieMinuscules = txtBoxRechercherTitreDvd.Text.ToLower();
                string titreMinuscules;
                titreMinuscules = dvd.Titre.ToLower();

                //on teste si le titre du livre contient ce qui a été saisi
                if (titreMinuscules.Contains(saisieMinuscules))
                {
                    dgvRechercherTitreDvd.Rows.Add(dvd.IdDoc, dvd.Titre, dvd.Synopsis, dvd.Realisateur, dvd.Duree, dvd.Image, dvd.LaCategorie.Libelle);
                }
            }
        }

        private void txtBoxRechercherLivreTitre_TextChanged(object sender, EventArgs e)
        {
            dgvRechercherLivreTitre.Rows.Clear();

            // On parcourt tous les livres. Si le titre matche avec la saisie, on l'affiche dans le datagrid.
            foreach (Livre livre in lesLivres)
            {
                // on passe le champ de saisie et le titre en minuscules car la méthode Contains
                // tient compte de la casse.
                string saisieMinuscules;
                saisieMinuscules = txtBoxRechercherLivreTitre.Text.ToLower();
                string titreMinuscules;
                titreMinuscules = livre.Titre.ToLower();

                //on teste si le titre du livre contient ce qui a été saisi
                if (titreMinuscules.Contains(saisieMinuscules))
                {
                    dgvRechercherLivreTitre.Rows.Add(livre.IdDoc,livre.Titre, livre.ISBN1, livre.Auteur, livre.LaCollection, livre.Image,livre.LaCategorie.Libelle);
                }
            }
        }

        private void txtBoxRechercherAbo_TextChanged(object sender, EventArgs e)
        {
            dgvRechercherAbo.Rows.Clear();

            // On parcourt tous les livres. Si le titre matche avec la saisie, on l'affiche dans le datagrid.
            foreach (Abonne Abo in lesAbonnes)
            {
                // on passe le champ de saisie et le titre en minuscules car la méthode Contains
                // tient compte de la casse.
                string saisieMinuscules;
                saisieMinuscules = txtBoxRechercherAbo.Text.ToLower();
                string titreMinuscules;
                titreMinuscules = Abo.Nom.ToLower();

                //on teste si le titre du livre contient ce qui a été saisi
                if (titreMinuscules.Contains(saisieMinuscules))
                {
                    dgvRechercherAbo.Rows.Add(Abo.Id, Abo.Nom, Abo.Prenom, Abo.Adresse, Abo.Tel, Abo.Adresse_mail, Abo.Date_naiss, Abo.Date_premier_abo, Abo.Date_fin_abo);
                }
            }
        }

        private void dgvRechercherAbo_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Vérifie si la cellule cliquée est valide
            {
                DataGridViewCell cell = dgvRechercherAbo.Rows[e.RowIndex].Cells[e.ColumnIndex]; // Récupère la cellule cliquée

                if (cell.Value != null && cell.Value != DBNull.Value && !string.IsNullOrEmpty(cell.Value.ToString()))
                {
                    // Remplir les TextBox avec les valeurs de la cellule cliquée
                    modif_id.Text = dgvRechercherAbo.Rows[e.RowIndex].Cells["rech_abo_id"].Value.ToString();
                    modif_nom.Text = dgvRechercherAbo.Rows[e.RowIndex].Cells["rech_abo_nom"].Value.ToString();
                    modif_prenom.Text = dgvRechercherAbo.Rows[e.RowIndex].Cells["rech_abo_prenom"].Value.ToString();
                    modif_adresse.Text = dgvRechercherAbo.Rows[e.RowIndex].Cells["rech_abo_adresse"].Value.ToString();
                    txt_modif_tel.Text = dgvRechercherAbo.Rows[e.RowIndex].Cells["rech_abo_tel"].Value.ToString();
                    modif_adresse_mail.Text = dgvRechercherAbo.Rows[e.RowIndex].Cells["rech_abo_adresse_mail"].Value.ToString();
                    dtp_modif_annee.Value = Convert.ToDateTime(dgvRechercherAbo.Rows[e.RowIndex].Cells["rech_abo_date_naissance"].Value);
                    dtp_premier_abo.Value = Convert.ToDateTime(dgvRechercherAbo.Rows[e.RowIndex].Cells["rech_abo_date_premier_abo"].Value);
                    dtp_date_fin_abo.Value = Convert.ToDateTime(dgvRechercherAbo.Rows[e.RowIndex].Cells["rech_abo_date_fin_abo"].Value);
                }
            }
        }

        private void dgvRechercherLivreTitre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Vérifie si la cellule cliquée est valide
            {
                DataGridViewCell cell = dgvRechercherLivreTitre.Rows[e.RowIndex].Cells[e.ColumnIndex]; // Récupère la cellule cliquée

                if (cell.Value != null && cell.Value != DBNull.Value && !string.IsNullOrEmpty(cell.Value.ToString()))
                {
                    txtBoxModifLivreId.Text = dgvRechercherLivreTitre.Rows[e.RowIndex].Cells["rech_id_livre"].Value.ToString();
                    txtBoxModifLivreTitre.Text = dgvRechercherLivreTitre.Rows[e.RowIndex].Cells["rech_titre_livre"].Value.ToString();
                    txtBoxModifLivreISBN.Text = dgvRechercherLivreTitre.Rows[e.RowIndex].Cells["rech_isbn_livre"].Value.ToString();
                    txtBoxModifLivreAuteur.Text = dgvRechercherLivreTitre.Rows[e.RowIndex].Cells["rech_auteur_livre"].Value.ToString();
                    txtBoxModifLivreCollection.Text = dgvRechercherLivreTitre.Rows[e.RowIndex].Cells["rech_collection_livre"].Value.ToString();
                    txtBoxModifLivreImage.Text = dgvRechercherLivreTitre.Rows[e.RowIndex].Cells["rech_image_livre"].Value.ToString();

                    string categorieLibelle = dgvRechercherLivreTitre.Rows[e.RowIndex].Cells["rech_categorie_livre"].Value.ToString();
                    Categorie categorie = lesCategories.Find(c => c.Libelle == categorieLibelle);
                    if (categorie != null)
                    {
                        cbxModifCateg.SelectedItem = categorie;
                    }

                    //récupération du titre en parcourant la combo box, on recupére la valeur lorsqu'elle est égale à la ligne du datagridview

                    string titreLivre = dgvRechercherLivreTitre.Rows[e.RowIndex].Cells["rech_titre_livre"].Value.ToString();
                    foreach (Livre livre in cbModifLivre.Items)
                    {
                        if (livre.Titre == titreLivre)
                        {
                            cbModifLivre.SelectedItem = livre;
                            break;
                        }
                    }
                }
            }
        }

        private void dgvRechercherTitreDvd_CellClick(object sender, DataGridViewCellEventArgs e)
        {

                 if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Vérifie si la cellule cliquée est valide
            {
                DataGridViewCell cell = dgvRechercherTitreDvd.Rows[e.RowIndex].Cells[e.ColumnIndex]; // Récupère la cellule cliquée

                if (cell.Value != null && cell.Value != DBNull.Value && !string.IsNullOrEmpty(cell.Value.ToString()))
                {
                    txtBoxModifDvdId.Text = dgvRechercherTitreDvd.Rows[e.RowIndex].Cells["rech_id"].Value.ToString();
                    txtBoxModifDvdTitre.Text = dgvRechercherTitreDvd.Rows[e.RowIndex].Cells["rech_titre"].Value.ToString();
                    txtBoxModifDvdSynopsis.Text = dgvRechercherTitreDvd.Rows[e.RowIndex].Cells["rech_synopsis"].Value.ToString();
                    txtBoxModifDvdRealisateur.Text = dgvRechercherTitreDvd.Rows[e.RowIndex].Cells["rech_realisateur"].Value.ToString();
                    txtBoxModifDvdDuree.Text = dgvRechercherTitreDvd.Rows[e.RowIndex].Cells["rech_duree"].Value.ToString();
                    txtBoxModifDvdImage.Text = dgvRechercherTitreDvd.Rows[e.RowIndex].Cells["rech_image"].Value.ToString();

                    string categorieLibelle = dgvRechercherTitreDvd.Rows[e.RowIndex].Cells["rech_categorie"].Value.ToString();
                    Categorie categorie = lesCategories.Find(c => c.Libelle == categorieLibelle);
                    if (categorie != null)
                    {
                        cbx_ModifCategDvd.SelectedItem = categorie;
                    }

                    string titreDVD = dgvRechercherTitreDvd.Rows[e.RowIndex].Cells["rech_titre"].Value.ToString();
                    foreach (DVD dvd in cbx_ModifDvd.Items)
                    {
                        if (dvd.Titre == titreDVD)
                        {
                            cbx_ModifDvd.SelectedItem = dvd;
                            break;
                        }
                    }
                }
            }
                }
    }
}
