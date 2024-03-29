﻿
namespace Mediateq_AP_SIO2
{
    partial class FrmMediateq
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.CRUD_DVD = new System.Windows.Forms.TabPage();
            this.label72 = new System.Windows.Forms.Label();
            this.grpBoxRechercherDvd = new System.Windows.Forms.GroupBox();
            this.dgvRechercherTitreDvd = new System.Windows.Forms.DataGridView();
            this.rech_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rech_titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rech_synopsis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rech_realisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rech_duree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rech_image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rech_categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label22 = new System.Windows.Forms.Label();
            this.txtBoxRechercherTitreDvd = new System.Windows.Forms.TextBox();
            this.btnRefreshDvd = new System.Windows.Forms.Button();
            this.dgvDvd = new System.Windows.Forms.DataGridView();
            this.id_dvd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titre_dvd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image_dvd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.synopsis_dvd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realisateur_dvd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duree_dvd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorie_dvd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpxCRUD_DVD2 = new System.Windows.Forms.GroupBox();
            this.btnSuppDvd = new System.Windows.Forms.Button();
            this.btnModifDvd = new System.Windows.Forms.Button();
            this.label68 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.txtBoxModifDvdImage = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.txtBoxModifDvdDuree = new System.Windows.Forms.TextBox();
            this.txtBoxModifDvdRealisateur = new System.Windows.Forms.TextBox();
            this.txtBoxModifDvdSynopsis = new System.Windows.Forms.TextBox();
            this.txtBoxModifDvdTitre = new System.Windows.Forms.TextBox();
            this.txtBoxModifDvdId = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.cbx_ModifCategDvd = new System.Windows.Forms.ComboBox();
            this.cbx_ModifDvd = new System.Windows.Forms.ComboBox();
            this.gpxCRUD_DVD = new System.Windows.Forms.GroupBox();
            this.btnAjout_DVD = new System.Windows.Forms.Button();
            this.label60 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.txtDvd_Duree = new System.Windows.Forms.TextBox();
            this.txtDvd_Realisateur = new System.Windows.Forms.TextBox();
            this.txtDvd_Synopsis = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.txtDvd_Image = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.txtDvd_Titre = new System.Windows.Forms.TextBox();
            this.txtDvd_id = new System.Windows.Forms.TextBox();
            this.cbx_categDVD = new System.Windows.Forms.ComboBox();
            this.CRUDLivreDvd = new System.Windows.Forms.TabPage();
            this.label71 = new System.Windows.Forms.Label();
            this.grpBoxRechercherLivre = new System.Windows.Forms.GroupBox();
            this.dgvRechercherLivreTitre = new System.Windows.Forms.DataGridView();
            this.rech_id_livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rech_titre_livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rech_isbn_livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rech_auteur_livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rech_collection_livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rech_image_livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rech_categorie_livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxRechercherLivreTitre = new System.Windows.Forms.TextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.btnRefreshLivre = new System.Windows.Forms.Button();
            this.dgvLivre = new System.Windows.Forms.DataGridView();
            this.ID_Livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auteur_Livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titre_Livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN_Livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Collection_Livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image_Livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categorie_Livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxLivre2 = new System.Windows.Forms.GroupBox();
            this.txtBoxModifLivreCollection = new System.Windows.Forms.TextBox();
            this.txtBoxModifLivreImage = new System.Windows.Forms.TextBox();
            this.txtBoxModifLivreISBN = new System.Windows.Forms.TextBox();
            this.txtBoxModifLivreTitre = new System.Windows.Forms.TextBox();
            this.txtBoxModifLivreAuteur = new System.Windows.Forms.TextBox();
            this.txtBoxModifLivreId = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.btnModifLivre = new System.Windows.Forms.Button();
            this.cbxModifCateg = new System.Windows.Forms.ComboBox();
            this.btnSuppLivre = new System.Windows.Forms.Button();
            this.cbModifLivre = new System.Windows.Forms.ComboBox();
            this.groupBoxLivre = new System.Windows.Forms.GroupBox();
            this.btnAjouter_livre = new System.Windows.Forms.Button();
            this.label45 = new System.Windows.Forms.Label();
            this.txtLivre_collection = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.cbx_livre = new System.Windows.Forms.ComboBox();
            this.label43 = new System.Windows.Forms.Label();
            this.txtLivre_auteur = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.txtLivre_ISBN = new System.Windows.Forms.TextBox();
            this.txtLivre_image = new System.Windows.Forms.TextBox();
            this.txtLivre_titre = new System.Windows.Forms.TextBox();
            this.txtLivre_id = new System.Windows.Forms.TextBox();
            this.exemplaire = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ajouter_exemplaire = new System.Windows.Forms.Button();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.cb_rayon = new System.Windows.Forms.ComboBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.txtBox_numero = new System.Windows.Forms.TextBox();
            this.cb_document = new System.Windows.Forms.ComboBox();
            this.dgvAbo = new System.Windows.Forms.TabPage();
            this.dataGridViewAbonne = new System.Windows.Forms.DataGridView();
            this.idAbo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRUD_abo = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvRechercherAbo = new System.Windows.Forms.DataGridView();
            this.rech_abo_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rech_abo_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rech_abo_prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rech_abo_adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rech_abo_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rech_abo_adresse_mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rech_abo_date_naissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rech_abo_date_premier_abo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rech_abo_date_fin_abo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxRechercherAbo = new System.Windows.Forms.TextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.dtp_annee = new System.Windows.Forms.DateTimePicker();
            this.Refresh = new System.Windows.Forms.Button();
            this.dataGridAbo = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomAbo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomAbo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseAbo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telAbo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseMailAbo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateNaissanceAbo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePremierAbo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFinAbo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_modif_tel = new System.Windows.Forms.TextBox();
            this.verifDate = new System.Windows.Forms.Button();
            this.dtp_date_fin_abo = new System.Windows.Forms.DateTimePicker();
            this.dtp_modif_date_premier_abo = new System.Windows.Forms.DateTimePicker();
            this.dtp_modif_annee = new System.Windows.Forms.DateTimePicker();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.Modifier = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.modif_adresse_mail = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.modif_adresse = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.modif_prenom = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.modif_nom = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.cb_modif = new System.Windows.Forms.ComboBox();
            this.modif_id = new System.Windows.Forms.TextBox();
            this.cbSupp = new System.Windows.Forms.ComboBox();
            this.supprimer = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Aj_adresse_mail = new System.Windows.Forms.TextBox();
            this.Aj_adresse = new System.Windows.Forms.TextBox();
            this.Aj_tel = new System.Windows.Forms.TextBox();
            this.Aj_prenom = new System.Windows.Forms.TextBox();
            this.Aj_nom = new System.Windows.Forms.TextBox();
            this.Ajouter = new System.Windows.Forms.Button();
            this.tabLivres = new System.Windows.Forms.TabPage();
            this.grpRechercheTitre = new System.Windows.Forms.GroupBox();
            this.dgvLivres = new System.Windows.Forms.DataGridView();
            this.idDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lacollection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txbTitre = new System.Windows.Forms.TextBox();
            this.grpRechercheCode = new System.Windows.Forms.GroupBox();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txbNumDoc = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblAuteur = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCollection = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabTitres = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvTitres = new System.Windows.Forms.DataGridView();
            this.idTitre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empruntable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodicite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxDomaines = new System.Windows.Forms.ComboBox();
            this.tabParutions = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvParutions = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateParution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTitres = new System.Windows.Forms.ComboBox();
            this.Connexion = new System.Windows.Forms.TabControl();
            this.dtp_premier_abo = new System.Windows.Forms.DateTimePicker();
            this.CRUD_DVD.SuspendLayout();
            this.grpBoxRechercherDvd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRechercherTitreDvd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDvd)).BeginInit();
            this.gpxCRUD_DVD2.SuspendLayout();
            this.gpxCRUD_DVD.SuspendLayout();
            this.CRUDLivreDvd.SuspendLayout();
            this.grpBoxRechercherLivre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRechercherLivreTitre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivre)).BeginInit();
            this.groupBoxLivre2.SuspendLayout();
            this.groupBoxLivre.SuspendLayout();
            this.exemplaire.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.dgvAbo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbonne)).BeginInit();
            this.CRUD_abo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRechercherAbo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAbo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabLivres.SuspendLayout();
            this.grpRechercheTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivres)).BeginInit();
            this.grpRechercheCode.SuspendLayout();
            this.tabTitres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitres)).BeginInit();
            this.tabParutions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParutions)).BeginInit();
            this.Connexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // CRUD_DVD
            // 
            this.CRUD_DVD.Controls.Add(this.label72);
            this.CRUD_DVD.Controls.Add(this.grpBoxRechercherDvd);
            this.CRUD_DVD.Controls.Add(this.btnRefreshDvd);
            this.CRUD_DVD.Controls.Add(this.dgvDvd);
            this.CRUD_DVD.Controls.Add(this.gpxCRUD_DVD2);
            this.CRUD_DVD.Controls.Add(this.gpxCRUD_DVD);
            this.CRUD_DVD.Location = new System.Drawing.Point(4, 22);
            this.CRUD_DVD.Name = "CRUD_DVD";
            this.CRUD_DVD.Size = new System.Drawing.Size(1362, 723);
            this.CRUD_DVD.TabIndex = 8;
            this.CRUD_DVD.Text = "CRUD DVD";
            this.CRUD_DVD.UseVisualStyleBackColor = true;
            this.CRUD_DVD.Enter += new System.EventHandler(this.CRUD_DVD_Enter);
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("Magneto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label72.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label72.Location = new System.Drawing.Point(386, 30);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(176, 32);
            this.label72.TabIndex = 49;
            this.label72.Text = "CRUD DVD";
            // 
            // grpBoxRechercherDvd
            // 
            this.grpBoxRechercherDvd.Controls.Add(this.dgvRechercherTitreDvd);
            this.grpBoxRechercherDvd.Controls.Add(this.label22);
            this.grpBoxRechercherDvd.Controls.Add(this.txtBoxRechercherTitreDvd);
            this.grpBoxRechercherDvd.Location = new System.Drawing.Point(591, 86);
            this.grpBoxRechercherDvd.Name = "grpBoxRechercherDvd";
            this.grpBoxRechercherDvd.Size = new System.Drawing.Size(753, 229);
            this.grpBoxRechercherDvd.TabIndex = 4;
            this.grpBoxRechercherDvd.TabStop = false;
            this.grpBoxRechercherDvd.Text = "Rechercher par titre";
            // 
            // dgvRechercherTitreDvd
            // 
            this.dgvRechercherTitreDvd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRechercherTitreDvd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rech_id,
            this.rech_titre,
            this.rech_synopsis,
            this.rech_realisateur,
            this.rech_duree,
            this.rech_image,
            this.rech_categorie});
            this.dgvRechercherTitreDvd.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvRechercherTitreDvd.Location = new System.Drawing.Point(6, 73);
            this.dgvRechercherTitreDvd.Name = "dgvRechercherTitreDvd";
            this.dgvRechercherTitreDvd.Size = new System.Drawing.Size(741, 150);
            this.dgvRechercherTitreDvd.TabIndex = 2;
            this.dgvRechercherTitreDvd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRechercherTitreDvd_CellClick);
            // 
            // rech_id
            // 
            this.rech_id.HeaderText = "ID";
            this.rech_id.Name = "rech_id";
            // 
            // rech_titre
            // 
            this.rech_titre.HeaderText = "Titre";
            this.rech_titre.Name = "rech_titre";
            // 
            // rech_synopsis
            // 
            this.rech_synopsis.HeaderText = "Synopsis";
            this.rech_synopsis.Name = "rech_synopsis";
            // 
            // rech_realisateur
            // 
            this.rech_realisateur.HeaderText = "Réalisateur";
            this.rech_realisateur.Name = "rech_realisateur";
            // 
            // rech_duree
            // 
            this.rech_duree.HeaderText = "Durée";
            this.rech_duree.Name = "rech_duree";
            // 
            // rech_image
            // 
            this.rech_image.HeaderText = "Image";
            this.rech_image.Name = "rech_image";
            // 
            // rech_categorie
            // 
            this.rech_categorie.HeaderText = "Categorie";
            this.rech_categorie.Name = "rech_categorie";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(26, 35);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(107, 13);
            this.label22.TabIndex = 1;
            this.label22.Text = "Rechercher par titre :";
            // 
            // txtBoxRechercherTitreDvd
            // 
            this.txtBoxRechercherTitreDvd.Location = new System.Drawing.Point(157, 31);
            this.txtBoxRechercherTitreDvd.Name = "txtBoxRechercherTitreDvd";
            this.txtBoxRechercherTitreDvd.Size = new System.Drawing.Size(220, 20);
            this.txtBoxRechercherTitreDvd.TabIndex = 0;
            this.txtBoxRechercherTitreDvd.TextChanged += new System.EventHandler(this.txtBoxRechercherTitreDvd_TextChanged);
            // 
            // btnRefreshDvd
            // 
            this.btnRefreshDvd.Location = new System.Drawing.Point(771, 427);
            this.btnRefreshDvd.Name = "btnRefreshDvd";
            this.btnRefreshDvd.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshDvd.TabIndex = 3;
            this.btnRefreshDvd.Text = "Refresh";
            this.btnRefreshDvd.UseVisualStyleBackColor = true;
            this.btnRefreshDvd.Click += new System.EventHandler(this.btnRefreshDvd_Click);
            // 
            // dgvDvd
            // 
            this.dgvDvd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDvd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_dvd,
            this.titre_dvd,
            this.image_dvd,
            this.synopsis_dvd,
            this.realisateur_dvd,
            this.duree_dvd,
            this.categorie_dvd});
            this.dgvDvd.GridColor = System.Drawing.Color.DarkKhaki;
            this.dgvDvd.Location = new System.Drawing.Point(9, 384);
            this.dgvDvd.Name = "dgvDvd";
            this.dgvDvd.Size = new System.Drawing.Size(756, 97);
            this.dgvDvd.TabIndex = 2;
            // 
            // id_dvd
            // 
            this.id_dvd.HeaderText = "ID";
            this.id_dvd.Name = "id_dvd";
            // 
            // titre_dvd
            // 
            this.titre_dvd.HeaderText = "Titre";
            this.titre_dvd.Name = "titre_dvd";
            // 
            // image_dvd
            // 
            this.image_dvd.HeaderText = "Image";
            this.image_dvd.Name = "image_dvd";
            // 
            // synopsis_dvd
            // 
            this.synopsis_dvd.HeaderText = "Synopsis";
            this.synopsis_dvd.Name = "synopsis_dvd";
            // 
            // realisateur_dvd
            // 
            this.realisateur_dvd.HeaderText = "Réalisateur";
            this.realisateur_dvd.Name = "realisateur_dvd";
            // 
            // duree_dvd
            // 
            this.duree_dvd.HeaderText = "Durée";
            this.duree_dvd.Name = "duree_dvd";
            // 
            // categorie_dvd
            // 
            this.categorie_dvd.HeaderText = "Catégorie";
            this.categorie_dvd.Name = "categorie_dvd";
            // 
            // gpxCRUD_DVD2
            // 
            this.gpxCRUD_DVD2.Controls.Add(this.btnSuppDvd);
            this.gpxCRUD_DVD2.Controls.Add(this.btnModifDvd);
            this.gpxCRUD_DVD2.Controls.Add(this.label68);
            this.gpxCRUD_DVD2.Controls.Add(this.label67);
            this.gpxCRUD_DVD2.Controls.Add(this.label65);
            this.gpxCRUD_DVD2.Controls.Add(this.label66);
            this.gpxCRUD_DVD2.Controls.Add(this.txtBoxModifDvdImage);
            this.gpxCRUD_DVD2.Controls.Add(this.label64);
            this.gpxCRUD_DVD2.Controls.Add(this.label63);
            this.gpxCRUD_DVD2.Controls.Add(this.txtBoxModifDvdDuree);
            this.gpxCRUD_DVD2.Controls.Add(this.txtBoxModifDvdRealisateur);
            this.gpxCRUD_DVD2.Controls.Add(this.txtBoxModifDvdSynopsis);
            this.gpxCRUD_DVD2.Controls.Add(this.txtBoxModifDvdTitre);
            this.gpxCRUD_DVD2.Controls.Add(this.txtBoxModifDvdId);
            this.gpxCRUD_DVD2.Controls.Add(this.label62);
            this.gpxCRUD_DVD2.Controls.Add(this.label61);
            this.gpxCRUD_DVD2.Controls.Add(this.cbx_ModifCategDvd);
            this.gpxCRUD_DVD2.Controls.Add(this.cbx_ModifDvd);
            this.gpxCRUD_DVD2.Location = new System.Drawing.Point(272, 76);
            this.gpxCRUD_DVD2.Name = "gpxCRUD_DVD2";
            this.gpxCRUD_DVD2.Size = new System.Drawing.Size(290, 302);
            this.gpxCRUD_DVD2.TabIndex = 1;
            this.gpxCRUD_DVD2.TabStop = false;
            this.gpxCRUD_DVD2.Text = "modif DVD";
            // 
            // btnSuppDvd
            // 
            this.btnSuppDvd.BackColor = System.Drawing.Color.Red;
            this.btnSuppDvd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSuppDvd.Location = new System.Drawing.Point(147, 270);
            this.btnSuppDvd.Name = "btnSuppDvd";
            this.btnSuppDvd.Size = new System.Drawing.Size(121, 32);
            this.btnSuppDvd.TabIndex = 17;
            this.btnSuppDvd.Text = "Supprimer";
            this.btnSuppDvd.UseVisualStyleBackColor = false;
            this.btnSuppDvd.Enter += new System.EventHandler(this.btnSuppDvd_Enter);
            // 
            // btnModifDvd
            // 
            this.btnModifDvd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnModifDvd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifDvd.Location = new System.Drawing.Point(147, 235);
            this.btnModifDvd.Name = "btnModifDvd";
            this.btnModifDvd.Size = new System.Drawing.Size(121, 29);
            this.btnModifDvd.TabIndex = 16;
            this.btnModifDvd.Text = "Modifier";
            this.btnModifDvd.UseVisualStyleBackColor = false;
            this.btnModifDvd.Enter += new System.EventHandler(this.btnModifDvd_Enter);
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(71, 190);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(34, 13);
            this.label68.TabIndex = 15;
            this.label68.Text = "durée";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(71, 157);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(55, 13);
            this.label67.TabIndex = 14;
            this.label67.Text = "réalisateur";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(71, 209);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(35, 13);
            this.label65.TabIndex = 12;
            this.label65.Text = "image";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(71, 134);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(47, 13);
            this.label66.TabIndex = 13;
            this.label66.Text = "synopsis";
            // 
            // txtBoxModifDvdImage
            // 
            this.txtBoxModifDvdImage.Location = new System.Drawing.Point(147, 209);
            this.txtBoxModifDvdImage.Name = "txtBoxModifDvdImage";
            this.txtBoxModifDvdImage.Size = new System.Drawing.Size(121, 20);
            this.txtBoxModifDvdImage.TabIndex = 6;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(71, 112);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(24, 13);
            this.label64.TabIndex = 11;
            this.label64.Text = "titre";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(71, 86);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(15, 13);
            this.label63.TabIndex = 10;
            this.label63.Text = "id";
            // 
            // txtBoxModifDvdDuree
            // 
            this.txtBoxModifDvdDuree.Location = new System.Drawing.Point(147, 183);
            this.txtBoxModifDvdDuree.Name = "txtBoxModifDvdDuree";
            this.txtBoxModifDvdDuree.Size = new System.Drawing.Size(121, 20);
            this.txtBoxModifDvdDuree.TabIndex = 9;
            // 
            // txtBoxModifDvdRealisateur
            // 
            this.txtBoxModifDvdRealisateur.Location = new System.Drawing.Point(147, 157);
            this.txtBoxModifDvdRealisateur.Name = "txtBoxModifDvdRealisateur";
            this.txtBoxModifDvdRealisateur.Size = new System.Drawing.Size(121, 20);
            this.txtBoxModifDvdRealisateur.TabIndex = 8;
            // 
            // txtBoxModifDvdSynopsis
            // 
            this.txtBoxModifDvdSynopsis.Location = new System.Drawing.Point(147, 131);
            this.txtBoxModifDvdSynopsis.Name = "txtBoxModifDvdSynopsis";
            this.txtBoxModifDvdSynopsis.Size = new System.Drawing.Size(121, 20);
            this.txtBoxModifDvdSynopsis.TabIndex = 7;
            // 
            // txtBoxModifDvdTitre
            // 
            this.txtBoxModifDvdTitre.Location = new System.Drawing.Point(147, 105);
            this.txtBoxModifDvdTitre.Name = "txtBoxModifDvdTitre";
            this.txtBoxModifDvdTitre.Size = new System.Drawing.Size(121, 20);
            this.txtBoxModifDvdTitre.TabIndex = 5;
            // 
            // txtBoxModifDvdId
            // 
            this.txtBoxModifDvdId.Location = new System.Drawing.Point(147, 79);
            this.txtBoxModifDvdId.Name = "txtBoxModifDvdId";
            this.txtBoxModifDvdId.ReadOnly = true;
            this.txtBoxModifDvdId.Size = new System.Drawing.Size(121, 20);
            this.txtBoxModifDvdId.TabIndex = 4;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(69, 53);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(52, 13);
            this.label62.TabIndex = 3;
            this.label62.Text = "Catégorie";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(69, 27);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(54, 13);
            this.label61.TabIndex = 2;
            this.label61.Text = "Titre DVD";
            // 
            // cbx_ModifCategDvd
            // 
            this.cbx_ModifCategDvd.FormattingEnabled = true;
            this.cbx_ModifCategDvd.Location = new System.Drawing.Point(147, 49);
            this.cbx_ModifCategDvd.Name = "cbx_ModifCategDvd";
            this.cbx_ModifCategDvd.Size = new System.Drawing.Size(121, 21);
            this.cbx_ModifCategDvd.TabIndex = 1;
            // 
            // cbx_ModifDvd
            // 
            this.cbx_ModifDvd.FormattingEnabled = true;
            this.cbx_ModifDvd.Location = new System.Drawing.Point(147, 19);
            this.cbx_ModifDvd.Name = "cbx_ModifDvd";
            this.cbx_ModifDvd.Size = new System.Drawing.Size(121, 21);
            this.cbx_ModifDvd.TabIndex = 0;
            this.cbx_ModifDvd.SelectedIndexChanged += new System.EventHandler(this.cbx_ModifDvd_SelectedIndexChanged);
            // 
            // gpxCRUD_DVD
            // 
            this.gpxCRUD_DVD.Controls.Add(this.btnAjout_DVD);
            this.gpxCRUD_DVD.Controls.Add(this.label60);
            this.gpxCRUD_DVD.Controls.Add(this.label59);
            this.gpxCRUD_DVD.Controls.Add(this.label58);
            this.gpxCRUD_DVD.Controls.Add(this.txtDvd_Duree);
            this.gpxCRUD_DVD.Controls.Add(this.txtDvd_Realisateur);
            this.gpxCRUD_DVD.Controls.Add(this.txtDvd_Synopsis);
            this.gpxCRUD_DVD.Controls.Add(this.label57);
            this.gpxCRUD_DVD.Controls.Add(this.label56);
            this.gpxCRUD_DVD.Controls.Add(this.label55);
            this.gpxCRUD_DVD.Controls.Add(this.txtDvd_Image);
            this.gpxCRUD_DVD.Controls.Add(this.label54);
            this.gpxCRUD_DVD.Controls.Add(this.txtDvd_Titre);
            this.gpxCRUD_DVD.Controls.Add(this.txtDvd_id);
            this.gpxCRUD_DVD.Controls.Add(this.cbx_categDVD);
            this.gpxCRUD_DVD.Location = new System.Drawing.Point(32, 67);
            this.gpxCRUD_DVD.Name = "gpxCRUD_DVD";
            this.gpxCRUD_DVD.Size = new System.Drawing.Size(213, 265);
            this.gpxCRUD_DVD.TabIndex = 0;
            this.gpxCRUD_DVD.TabStop = false;
            this.gpxCRUD_DVD.Text = "CRUD DVD";
            // 
            // btnAjout_DVD
            // 
            this.btnAjout_DVD.BackColor = System.Drawing.Color.Green;
            this.btnAjout_DVD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAjout_DVD.Location = new System.Drawing.Point(89, 215);
            this.btnAjout_DVD.Name = "btnAjout_DVD";
            this.btnAjout_DVD.Size = new System.Drawing.Size(109, 33);
            this.btnAjout_DVD.TabIndex = 1;
            this.btnAjout_DVD.Text = "Ajouter";
            this.btnAjout_DVD.UseVisualStyleBackColor = false;
            this.btnAjout_DVD.Enter += new System.EventHandler(this.btnAjout_DVD_Enter);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(20, 183);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(34, 13);
            this.label60.TabIndex = 10;
            this.label60.Text = "durée";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(20, 157);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(55, 13);
            this.label59.TabIndex = 9;
            this.label59.Text = "réalisateur";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(20, 131);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(47, 13);
            this.label58.TabIndex = 8;
            this.label58.Text = "synopsis";
            // 
            // txtDvd_Duree
            // 
            this.txtDvd_Duree.Location = new System.Drawing.Point(89, 176);
            this.txtDvd_Duree.Name = "txtDvd_Duree";
            this.txtDvd_Duree.Size = new System.Drawing.Size(100, 20);
            this.txtDvd_Duree.TabIndex = 7;
            // 
            // txtDvd_Realisateur
            // 
            this.txtDvd_Realisateur.Location = new System.Drawing.Point(89, 150);
            this.txtDvd_Realisateur.Name = "txtDvd_Realisateur";
            this.txtDvd_Realisateur.Size = new System.Drawing.Size(100, 20);
            this.txtDvd_Realisateur.TabIndex = 6;
            // 
            // txtDvd_Synopsis
            // 
            this.txtDvd_Synopsis.Location = new System.Drawing.Point(89, 124);
            this.txtDvd_Synopsis.Name = "txtDvd_Synopsis";
            this.txtDvd_Synopsis.Size = new System.Drawing.Size(100, 20);
            this.txtDvd_Synopsis.TabIndex = 5;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(20, 105);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(35, 13);
            this.label57.TabIndex = 4;
            this.label57.Text = "image";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(20, 79);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(24, 13);
            this.label56.TabIndex = 3;
            this.label56.Text = "titre";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(20, 49);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(15, 13);
            this.label55.TabIndex = 2;
            this.label55.Text = "id";
            // 
            // txtDvd_Image
            // 
            this.txtDvd_Image.Location = new System.Drawing.Point(89, 98);
            this.txtDvd_Image.Name = "txtDvd_Image";
            this.txtDvd_Image.Size = new System.Drawing.Size(100, 20);
            this.txtDvd_Image.TabIndex = 2;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(20, 22);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(51, 13);
            this.label54.TabIndex = 1;
            this.label54.Text = "categorie";
            // 
            // txtDvd_Titre
            // 
            this.txtDvd_Titre.Location = new System.Drawing.Point(89, 72);
            this.txtDvd_Titre.Name = "txtDvd_Titre";
            this.txtDvd_Titre.Size = new System.Drawing.Size(100, 20);
            this.txtDvd_Titre.TabIndex = 1;
            // 
            // txtDvd_id
            // 
            this.txtDvd_id.Location = new System.Drawing.Point(89, 46);
            this.txtDvd_id.Name = "txtDvd_id";
            this.txtDvd_id.Size = new System.Drawing.Size(100, 20);
            this.txtDvd_id.TabIndex = 1;
            // 
            // cbx_categDVD
            // 
            this.cbx_categDVD.FormattingEnabled = true;
            this.cbx_categDVD.Location = new System.Drawing.Point(89, 19);
            this.cbx_categDVD.Name = "cbx_categDVD";
            this.cbx_categDVD.Size = new System.Drawing.Size(121, 21);
            this.cbx_categDVD.TabIndex = 1;
            // 
            // CRUDLivreDvd
            // 
            this.CRUDLivreDvd.Controls.Add(this.label71);
            this.CRUDLivreDvd.Controls.Add(this.grpBoxRechercherLivre);
            this.CRUDLivreDvd.Controls.Add(this.btnRefreshLivre);
            this.CRUDLivreDvd.Controls.Add(this.dgvLivre);
            this.CRUDLivreDvd.Controls.Add(this.groupBoxLivre2);
            this.CRUDLivreDvd.Controls.Add(this.groupBoxLivre);
            this.CRUDLivreDvd.Location = new System.Drawing.Point(4, 22);
            this.CRUDLivreDvd.Name = "CRUDLivreDvd";
            this.CRUDLivreDvd.Size = new System.Drawing.Size(1362, 723);
            this.CRUDLivreDvd.TabIndex = 7;
            this.CRUDLivreDvd.Text = "CRUD livre";
            this.CRUDLivreDvd.UseVisualStyleBackColor = true;
            this.CRUDLivreDvd.Enter += new System.EventHandler(this.CRUDLivreDvd_Enter);
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Magneto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label71.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label71.Location = new System.Drawing.Point(398, 34);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(196, 32);
            this.label71.TabIndex = 49;
            this.label71.Text = "CRUD Livre";
            // 
            // grpBoxRechercherLivre
            // 
            this.grpBoxRechercherLivre.Controls.Add(this.dgvRechercherLivreTitre);
            this.grpBoxRechercherLivre.Controls.Add(this.txtBoxRechercherLivreTitre);
            this.grpBoxRechercherLivre.Controls.Add(this.label69);
            this.grpBoxRechercherLivre.Location = new System.Drawing.Point(697, 95);
            this.grpBoxRechercherLivre.Name = "grpBoxRechercherLivre";
            this.grpBoxRechercherLivre.Size = new System.Drawing.Size(669, 303);
            this.grpBoxRechercherLivre.TabIndex = 14;
            this.grpBoxRechercherLivre.TabStop = false;
            this.grpBoxRechercherLivre.Text = "Rechercher un livre";
            // 
            // dgvRechercherLivreTitre
            // 
            this.dgvRechercherLivreTitre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRechercherLivreTitre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rech_id_livre,
            this.rech_titre_livre,
            this.rech_isbn_livre,
            this.rech_auteur_livre,
            this.rech_collection_livre,
            this.rech_image_livre,
            this.rech_categorie_livre});
            this.dgvRechercherLivreTitre.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvRechercherLivreTitre.Location = new System.Drawing.Point(6, 110);
            this.dgvRechercherLivreTitre.Name = "dgvRechercherLivreTitre";
            this.dgvRechercherLivreTitre.Size = new System.Drawing.Size(663, 170);
            this.dgvRechercherLivreTitre.TabIndex = 2;
            this.dgvRechercherLivreTitre.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRechercherLivreTitre_CellClick);
            // 
            // rech_id_livre
            // 
            this.rech_id_livre.HeaderText = "ID";
            this.rech_id_livre.Name = "rech_id_livre";
            // 
            // rech_titre_livre
            // 
            this.rech_titre_livre.HeaderText = "Titre";
            this.rech_titre_livre.Name = "rech_titre_livre";
            // 
            // rech_isbn_livre
            // 
            this.rech_isbn_livre.HeaderText = "ISBN";
            this.rech_isbn_livre.Name = "rech_isbn_livre";
            // 
            // rech_auteur_livre
            // 
            this.rech_auteur_livre.HeaderText = "Auteur";
            this.rech_auteur_livre.Name = "rech_auteur_livre";
            // 
            // rech_collection_livre
            // 
            this.rech_collection_livre.HeaderText = "Collection";
            this.rech_collection_livre.Name = "rech_collection_livre";
            // 
            // rech_image_livre
            // 
            this.rech_image_livre.HeaderText = "Image";
            this.rech_image_livre.Name = "rech_image_livre";
            // 
            // rech_categorie_livre
            // 
            this.rech_categorie_livre.HeaderText = "Categorie";
            this.rech_categorie_livre.Name = "rech_categorie_livre";
            // 
            // txtBoxRechercherLivreTitre
            // 
            this.txtBoxRechercherLivreTitre.Location = new System.Drawing.Point(143, 34);
            this.txtBoxRechercherLivreTitre.Name = "txtBoxRechercherLivreTitre";
            this.txtBoxRechercherLivreTitre.Size = new System.Drawing.Size(164, 20);
            this.txtBoxRechercherLivreTitre.TabIndex = 1;
            this.txtBoxRechercherLivreTitre.TextChanged += new System.EventHandler(this.txtBoxRechercherLivreTitre_TextChanged);
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(18, 41);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(101, 13);
            this.label69.TabIndex = 0;
            this.label69.Text = "Rechercher par titre";
            // 
            // btnRefreshLivre
            // 
            this.btnRefreshLivre.Location = new System.Drawing.Point(788, 540);
            this.btnRefreshLivre.Name = "btnRefreshLivre";
            this.btnRefreshLivre.Size = new System.Drawing.Size(89, 32);
            this.btnRefreshLivre.TabIndex = 13;
            this.btnRefreshLivre.Text = "Refresh";
            this.btnRefreshLivre.UseVisualStyleBackColor = true;
            this.btnRefreshLivre.Click += new System.EventHandler(this.btnRefreshLivre_Click);
            // 
            // dgvLivre
            // 
            this.dgvLivre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Livre,
            this.Auteur_Livre,
            this.Titre_Livre,
            this.ISBN_Livre,
            this.Collection_Livre,
            this.Image_Livre,
            this.Categorie_Livre});
            this.dgvLivre.GridColor = System.Drawing.Color.DarkKhaki;
            this.dgvLivre.Location = new System.Drawing.Point(8, 423);
            this.dgvLivre.Name = "dgvLivre";
            this.dgvLivre.Size = new System.Drawing.Size(764, 251);
            this.dgvLivre.TabIndex = 12;
            // 
            // ID_Livre
            // 
            this.ID_Livre.HeaderText = "ID";
            this.ID_Livre.Name = "ID_Livre";
            // 
            // Auteur_Livre
            // 
            this.Auteur_Livre.HeaderText = "Auteur";
            this.Auteur_Livre.Name = "Auteur_Livre";
            // 
            // Titre_Livre
            // 
            this.Titre_Livre.HeaderText = "Titre";
            this.Titre_Livre.Name = "Titre_Livre";
            // 
            // ISBN_Livre
            // 
            this.ISBN_Livre.HeaderText = "ISBN";
            this.ISBN_Livre.Name = "ISBN_Livre";
            // 
            // Collection_Livre
            // 
            this.Collection_Livre.HeaderText = "Collection";
            this.Collection_Livre.Name = "Collection_Livre";
            // 
            // Image_Livre
            // 
            this.Image_Livre.HeaderText = "Image";
            this.Image_Livre.Name = "Image_Livre";
            // 
            // Categorie_Livre
            // 
            this.Categorie_Livre.HeaderText = "Categorie";
            this.Categorie_Livre.Name = "Categorie_Livre";
            // 
            // groupBoxLivre2
            // 
            this.groupBoxLivre2.Controls.Add(this.txtBoxModifLivreCollection);
            this.groupBoxLivre2.Controls.Add(this.txtBoxModifLivreImage);
            this.groupBoxLivre2.Controls.Add(this.txtBoxModifLivreISBN);
            this.groupBoxLivre2.Controls.Add(this.txtBoxModifLivreTitre);
            this.groupBoxLivre2.Controls.Add(this.txtBoxModifLivreAuteur);
            this.groupBoxLivre2.Controls.Add(this.txtBoxModifLivreId);
            this.groupBoxLivre2.Controls.Add(this.label53);
            this.groupBoxLivre2.Controls.Add(this.label52);
            this.groupBoxLivre2.Controls.Add(this.label51);
            this.groupBoxLivre2.Controls.Add(this.label50);
            this.groupBoxLivre2.Controls.Add(this.label49);
            this.groupBoxLivre2.Controls.Add(this.label48);
            this.groupBoxLivre2.Controls.Add(this.label47);
            this.groupBoxLivre2.Controls.Add(this.label46);
            this.groupBoxLivre2.Controls.Add(this.btnModifLivre);
            this.groupBoxLivre2.Controls.Add(this.cbxModifCateg);
            this.groupBoxLivre2.Controls.Add(this.btnSuppLivre);
            this.groupBoxLivre2.Controls.Add(this.cbModifLivre);
            this.groupBoxLivre2.Location = new System.Drawing.Point(345, 84);
            this.groupBoxLivre2.Name = "groupBoxLivre2";
            this.groupBoxLivre2.Size = new System.Drawing.Size(346, 333);
            this.groupBoxLivre2.TabIndex = 11;
            this.groupBoxLivre2.TabStop = false;
            this.groupBoxLivre2.Text = "Livres modif";
            // 
            // txtBoxModifLivreCollection
            // 
            this.txtBoxModifLivreCollection.Location = new System.Drawing.Point(169, 193);
            this.txtBoxModifLivreCollection.Name = "txtBoxModifLivreCollection";
            this.txtBoxModifLivreCollection.Size = new System.Drawing.Size(100, 20);
            this.txtBoxModifLivreCollection.TabIndex = 14;
            // 
            // txtBoxModifLivreImage
            // 
            this.txtBoxModifLivreImage.Location = new System.Drawing.Point(169, 219);
            this.txtBoxModifLivreImage.Name = "txtBoxModifLivreImage";
            this.txtBoxModifLivreImage.Size = new System.Drawing.Size(100, 20);
            this.txtBoxModifLivreImage.TabIndex = 14;
            // 
            // txtBoxModifLivreISBN
            // 
            this.txtBoxModifLivreISBN.Location = new System.Drawing.Point(169, 135);
            this.txtBoxModifLivreISBN.Name = "txtBoxModifLivreISBN";
            this.txtBoxModifLivreISBN.Size = new System.Drawing.Size(100, 20);
            this.txtBoxModifLivreISBN.TabIndex = 14;
            // 
            // txtBoxModifLivreTitre
            // 
            this.txtBoxModifLivreTitre.Location = new System.Drawing.Point(169, 110);
            this.txtBoxModifLivreTitre.Name = "txtBoxModifLivreTitre";
            this.txtBoxModifLivreTitre.Size = new System.Drawing.Size(100, 20);
            this.txtBoxModifLivreTitre.TabIndex = 14;
            // 
            // txtBoxModifLivreAuteur
            // 
            this.txtBoxModifLivreAuteur.Location = new System.Drawing.Point(169, 162);
            this.txtBoxModifLivreAuteur.Name = "txtBoxModifLivreAuteur";
            this.txtBoxModifLivreAuteur.Size = new System.Drawing.Size(100, 20);
            this.txtBoxModifLivreAuteur.TabIndex = 20;
            // 
            // txtBoxModifLivreId
            // 
            this.txtBoxModifLivreId.Location = new System.Drawing.Point(169, 81);
            this.txtBoxModifLivreId.Name = "txtBoxModifLivreId";
            this.txtBoxModifLivreId.ReadOnly = true;
            this.txtBoxModifLivreId.Size = new System.Drawing.Size(100, 20);
            this.txtBoxModifLivreId.TabIndex = 13;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(111, 22);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(54, 13);
            this.label53.TabIndex = 19;
            this.label53.Text = "Titre Livre";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(111, 54);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(52, 13);
            this.label52.TabIndex = 12;
            this.label52.Text = "Categorie";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(106, 196);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(52, 13);
            this.label51.TabIndex = 12;
            this.label51.Text = "collection";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(123, 222);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(35, 13);
            this.label50.TabIndex = 12;
            this.label50.Text = "image";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(134, 110);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(24, 13);
            this.label49.TabIndex = 12;
            this.label49.Text = "titre";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(121, 168);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(37, 13);
            this.label48.TabIndex = 12;
            this.label48.Text = "auteur";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(126, 138);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(32, 13);
            this.label47.TabIndex = 12;
            this.label47.Text = "ISBN";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(134, 86);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(15, 13);
            this.label46.TabIndex = 12;
            this.label46.Text = "id";
            // 
            // btnModifLivre
            // 
            this.btnModifLivre.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnModifLivre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifLivre.Location = new System.Drawing.Point(169, 245);
            this.btnModifLivre.Name = "btnModifLivre";
            this.btnModifLivre.Size = new System.Drawing.Size(121, 40);
            this.btnModifLivre.TabIndex = 18;
            this.btnModifLivre.Text = "Modifier";
            this.btnModifLivre.UseVisualStyleBackColor = false;
            this.btnModifLivre.Enter += new System.EventHandler(this.btnModifLivre_Enter);
            // 
            // cbxModifCateg
            // 
            this.cbxModifCateg.FormattingEnabled = true;
            this.cbxModifCateg.Location = new System.Drawing.Point(169, 54);
            this.cbxModifCateg.Name = "cbxModifCateg";
            this.cbxModifCateg.Size = new System.Drawing.Size(121, 21);
            this.cbxModifCateg.TabIndex = 13;
            // 
            // btnSuppLivre
            // 
            this.btnSuppLivre.BackColor = System.Drawing.Color.Red;
            this.btnSuppLivre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSuppLivre.Location = new System.Drawing.Point(169, 291);
            this.btnSuppLivre.Name = "btnSuppLivre";
            this.btnSuppLivre.Size = new System.Drawing.Size(121, 36);
            this.btnSuppLivre.TabIndex = 12;
            this.btnSuppLivre.Text = "Supprimer";
            this.btnSuppLivre.UseVisualStyleBackColor = false;
            this.btnSuppLivre.Enter += new System.EventHandler(this.btnSuppLivre_Enter);
            // 
            // cbModifLivre
            // 
            this.cbModifLivre.FormattingEnabled = true;
            this.cbModifLivre.Location = new System.Drawing.Point(169, 19);
            this.cbModifLivre.Name = "cbModifLivre";
            this.cbModifLivre.Size = new System.Drawing.Size(121, 21);
            this.cbModifLivre.TabIndex = 12;
            this.cbModifLivre.SelectedIndexChanged += new System.EventHandler(this.cbModifLivre_SelectedIndexChanged);
            // 
            // groupBoxLivre
            // 
            this.groupBoxLivre.Controls.Add(this.btnAjouter_livre);
            this.groupBoxLivre.Controls.Add(this.label45);
            this.groupBoxLivre.Controls.Add(this.txtLivre_collection);
            this.groupBoxLivre.Controls.Add(this.label44);
            this.groupBoxLivre.Controls.Add(this.cbx_livre);
            this.groupBoxLivre.Controls.Add(this.label43);
            this.groupBoxLivre.Controls.Add(this.txtLivre_auteur);
            this.groupBoxLivre.Controls.Add(this.label42);
            this.groupBoxLivre.Controls.Add(this.label41);
            this.groupBoxLivre.Controls.Add(this.label40);
            this.groupBoxLivre.Controls.Add(this.label39);
            this.groupBoxLivre.Controls.Add(this.txtLivre_ISBN);
            this.groupBoxLivre.Controls.Add(this.txtLivre_image);
            this.groupBoxLivre.Controls.Add(this.txtLivre_titre);
            this.groupBoxLivre.Controls.Add(this.txtLivre_id);
            this.groupBoxLivre.Location = new System.Drawing.Point(20, 73);
            this.groupBoxLivre.Name = "groupBoxLivre";
            this.groupBoxLivre.Size = new System.Drawing.Size(295, 280);
            this.groupBoxLivre.TabIndex = 0;
            this.groupBoxLivre.TabStop = false;
            this.groupBoxLivre.Text = "Livre";
            // 
            // btnAjouter_livre
            // 
            this.btnAjouter_livre.BackColor = System.Drawing.Color.Green;
            this.btnAjouter_livre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAjouter_livre.Location = new System.Drawing.Point(123, 222);
            this.btnAjouter_livre.Name = "btnAjouter_livre";
            this.btnAjouter_livre.Size = new System.Drawing.Size(112, 41);
            this.btnAjouter_livre.TabIndex = 1;
            this.btnAjouter_livre.Text = "Ajouter";
            this.btnAjouter_livre.UseVisualStyleBackColor = false;
            this.btnAjouter_livre.Enter += new System.EventHandler(this.btnAjouter_livre_Enter);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(59, 165);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(52, 13);
            this.label45.TabIndex = 9;
            this.label45.Text = "collection";
            // 
            // txtLivre_collection
            // 
            this.txtLivre_collection.Location = new System.Drawing.Point(123, 165);
            this.txtLivre_collection.Name = "txtLivre_collection";
            this.txtLivre_collection.Size = new System.Drawing.Size(100, 20);
            this.txtLivre_collection.TabIndex = 6;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(6, 22);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(111, 13);
            this.label44.TabIndex = 8;
            this.label44.Text = "chosissez la categorie";
            // 
            // cbx_livre
            // 
            this.cbx_livre.FormattingEnabled = true;
            this.cbx_livre.Location = new System.Drawing.Point(123, 23);
            this.cbx_livre.Name = "cbx_livre";
            this.cbx_livre.Size = new System.Drawing.Size(121, 21);
            this.cbx_livre.TabIndex = 1;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(71, 110);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(37, 13);
            this.label43.TabIndex = 8;
            this.label43.Text = "auteur";
            // 
            // txtLivre_auteur
            // 
            this.txtLivre_auteur.Location = new System.Drawing.Point(123, 110);
            this.txtLivre_auteur.Name = "txtLivre_auteur";
            this.txtLivre_auteur.Size = new System.Drawing.Size(100, 20);
            this.txtLivre_auteur.TabIndex = 5;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(74, 87);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(32, 13);
            this.label42.TabIndex = 7;
            this.label42.Text = "ISBN";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(71, 193);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(35, 13);
            this.label41.TabIndex = 6;
            this.label41.Text = "image";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(74, 142);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(24, 13);
            this.label40.TabIndex = 5;
            this.label40.Text = "titre";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(83, 61);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(15, 13);
            this.label39.TabIndex = 1;
            this.label39.Text = "id";
            // 
            // txtLivre_ISBN
            // 
            this.txtLivre_ISBN.Location = new System.Drawing.Point(123, 83);
            this.txtLivre_ISBN.Name = "txtLivre_ISBN";
            this.txtLivre_ISBN.Size = new System.Drawing.Size(100, 20);
            this.txtLivre_ISBN.TabIndex = 4;
            // 
            // txtLivre_image
            // 
            this.txtLivre_image.Location = new System.Drawing.Point(123, 193);
            this.txtLivre_image.Name = "txtLivre_image";
            this.txtLivre_image.Size = new System.Drawing.Size(100, 20);
            this.txtLivre_image.TabIndex = 3;
            // 
            // txtLivre_titre
            // 
            this.txtLivre_titre.Location = new System.Drawing.Point(123, 142);
            this.txtLivre_titre.Name = "txtLivre_titre";
            this.txtLivre_titre.Size = new System.Drawing.Size(100, 20);
            this.txtLivre_titre.TabIndex = 2;
            // 
            // txtLivre_id
            // 
            this.txtLivre_id.Location = new System.Drawing.Point(123, 58);
            this.txtLivre_id.Name = "txtLivre_id";
            this.txtLivre_id.Size = new System.Drawing.Size(100, 20);
            this.txtLivre_id.TabIndex = 1;
            // 
            // exemplaire
            // 
            this.exemplaire.Controls.Add(this.groupBox2);
            this.exemplaire.Location = new System.Drawing.Point(4, 22);
            this.exemplaire.Name = "exemplaire";
            this.exemplaire.Size = new System.Drawing.Size(1362, 723);
            this.exemplaire.TabIndex = 6;
            this.exemplaire.Text = "exemplaire";
            this.exemplaire.UseVisualStyleBackColor = true;
            this.exemplaire.Enter += new System.EventHandler(this.exemplaire_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ajouter_exemplaire);
            this.groupBox2.Controls.Add(this.dtp_date);
            this.groupBox2.Controls.Add(this.cb_rayon);
            this.groupBox2.Controls.Add(this.label38);
            this.groupBox2.Controls.Add(this.label37);
            this.groupBox2.Controls.Add(this.label36);
            this.groupBox2.Controls.Add(this.label35);
            this.groupBox2.Controls.Add(this.label34);
            this.groupBox2.Controls.Add(this.txtBox_numero);
            this.groupBox2.Controls.Add(this.cb_document);
            this.groupBox2.Location = new System.Drawing.Point(31, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 297);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "grpBox_documents";
            // 
            // ajouter_exemplaire
            // 
            this.ajouter_exemplaire.Location = new System.Drawing.Point(106, 233);
            this.ajouter_exemplaire.Name = "ajouter_exemplaire";
            this.ajouter_exemplaire.Size = new System.Drawing.Size(75, 23);
            this.ajouter_exemplaire.TabIndex = 1;
            this.ajouter_exemplaire.Text = "Ajouter";
            this.ajouter_exemplaire.UseVisualStyleBackColor = true;
            this.ajouter_exemplaire.Enter += new System.EventHandler(this.ajouter_exemplaire_Enter);
            // 
            // dtp_date
            // 
            this.dtp_date.Enabled = false;
            this.dtp_date.Location = new System.Drawing.Point(106, 130);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(200, 20);
            this.dtp_date.TabIndex = 1;
            // 
            // cb_rayon
            // 
            this.cb_rayon.FormattingEnabled = true;
            this.cb_rayon.Location = new System.Drawing.Point(106, 175);
            this.cb_rayon.Name = "cb_rayon";
            this.cb_rayon.Size = new System.Drawing.Size(121, 21);
            this.cb_rayon.TabIndex = 1;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(27, 175);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(33, 13);
            this.label38.TabIndex = 1;
            this.label38.Text = "rayon";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(27, 93);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(42, 13);
            this.label37.TabIndex = 1;
            this.label37.Text = "numero";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(24, 36);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(56, 13);
            this.label36.TabIndex = 1;
            this.label36.Text = "Document";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(21, 130);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(66, 13);
            this.label35.TabIndex = 2;
            this.label35.Text = "date d\'achat";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(21, 86);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(0, 13);
            this.label34.TabIndex = 1;
            // 
            // txtBox_numero
            // 
            this.txtBox_numero.Location = new System.Drawing.Point(106, 86);
            this.txtBox_numero.Name = "txtBox_numero";
            this.txtBox_numero.Size = new System.Drawing.Size(121, 20);
            this.txtBox_numero.TabIndex = 1;
            // 
            // cb_document
            // 
            this.cb_document.FormattingEnabled = true;
            this.cb_document.Location = new System.Drawing.Point(106, 36);
            this.cb_document.Name = "cb_document";
            this.cb_document.Size = new System.Drawing.Size(121, 21);
            this.cb_document.TabIndex = 1;
            // 
            // dgvAbo
            // 
            this.dgvAbo.Controls.Add(this.dataGridViewAbonne);
            this.dgvAbo.Location = new System.Drawing.Point(4, 22);
            this.dgvAbo.Name = "dgvAbo";
            this.dgvAbo.Size = new System.Drawing.Size(1362, 723);
            this.dgvAbo.TabIndex = 5;
            this.dgvAbo.Text = "dataGridAbo";
            this.dgvAbo.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAbonne
            // 
            this.dataGridViewAbonne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAbonne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAbo,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridViewAbonne.Location = new System.Drawing.Point(32, 27);
            this.dataGridViewAbonne.Name = "dataGridViewAbonne";
            this.dataGridViewAbonne.Size = new System.Drawing.Size(948, 389);
            this.dataGridViewAbonne.TabIndex = 0;
            // 
            // idAbo
            // 
            this.idAbo.HeaderText = "Id";
            this.idAbo.Name = "idAbo";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "nomAbo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "prenomAbo";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Adresse";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tel";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Adresse Mail";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Date Naissance";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Date Premier Abo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Date Fin Abo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // CRUD_abo
            // 
            this.CRUD_abo.Controls.Add(this.label14);
            this.CRUD_abo.Controls.Add(this.groupBox3);
            this.CRUD_abo.Controls.Add(this.dtp_premier_abo);
            this.CRUD_abo.Controls.Add(this.dtp_annee);
            this.CRUD_abo.Controls.Add(this.Refresh);
            this.CRUD_abo.Controls.Add(this.dataGridAbo);
            this.CRUD_abo.Controls.Add(this.groupBox1);
            this.CRUD_abo.Controls.Add(this.cbSupp);
            this.CRUD_abo.Controls.Add(this.supprimer);
            this.CRUD_abo.Controls.Add(this.label23);
            this.CRUD_abo.Controls.Add(this.label21);
            this.CRUD_abo.Controls.Add(this.label20);
            this.CRUD_abo.Controls.Add(this.label19);
            this.CRUD_abo.Controls.Add(this.label18);
            this.CRUD_abo.Controls.Add(this.label17);
            this.CRUD_abo.Controls.Add(this.label16);
            this.CRUD_abo.Controls.Add(this.label15);
            this.CRUD_abo.Controls.Add(this.Aj_adresse_mail);
            this.CRUD_abo.Controls.Add(this.Aj_adresse);
            this.CRUD_abo.Controls.Add(this.Aj_tel);
            this.CRUD_abo.Controls.Add(this.Aj_prenom);
            this.CRUD_abo.Controls.Add(this.Aj_nom);
            this.CRUD_abo.Controls.Add(this.Ajouter);
            this.CRUD_abo.Location = new System.Drawing.Point(4, 22);
            this.CRUD_abo.Name = "CRUD_abo";
            this.CRUD_abo.Size = new System.Drawing.Size(1362, 723);
            this.CRUD_abo.TabIndex = 4;
            this.CRUD_abo.Text = "CRUD_abo";
            this.CRUD_abo.UseVisualStyleBackColor = true;
            this.CRUD_abo.Enter += new System.EventHandler(this.CRUD_abo_Enter);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Magneto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label14.Location = new System.Drawing.Point(374, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(234, 38);
            this.label14.TabIndex = 0;
            this.label14.Text = "CRUD Abonné";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvRechercherAbo);
            this.groupBox3.Controls.Add(this.txtBoxRechercherAbo);
            this.groupBox3.Controls.Add(this.label70);
            this.groupBox3.Location = new System.Drawing.Point(647, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(722, 231);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rechercher par nom";
            // 
            // dgvRechercherAbo
            // 
            this.dgvRechercherAbo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRechercherAbo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rech_abo_id,
            this.rech_abo_nom,
            this.rech_abo_prenom,
            this.rech_abo_adresse,
            this.rech_abo_tel,
            this.rech_abo_adresse_mail,
            this.rech_abo_date_naissance,
            this.rech_abo_date_premier_abo,
            this.rech_abo_date_fin_abo});
            this.dgvRechercherAbo.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvRechercherAbo.Location = new System.Drawing.Point(6, 75);
            this.dgvRechercherAbo.Name = "dgvRechercherAbo";
            this.dgvRechercherAbo.Size = new System.Drawing.Size(746, 150);
            this.dgvRechercherAbo.TabIndex = 2;
            this.dgvRechercherAbo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRechercherAbo_CellClick_1);
            // 
            // rech_abo_id
            // 
            this.rech_abo_id.HeaderText = "ID";
            this.rech_abo_id.Name = "rech_abo_id";
            // 
            // rech_abo_nom
            // 
            this.rech_abo_nom.HeaderText = "Nom";
            this.rech_abo_nom.Name = "rech_abo_nom";
            // 
            // rech_abo_prenom
            // 
            this.rech_abo_prenom.HeaderText = "Prénom";
            this.rech_abo_prenom.Name = "rech_abo_prenom";
            // 
            // rech_abo_adresse
            // 
            this.rech_abo_adresse.HeaderText = "Adresse";
            this.rech_abo_adresse.Name = "rech_abo_adresse";
            // 
            // rech_abo_tel
            // 
            this.rech_abo_tel.HeaderText = "Tél";
            this.rech_abo_tel.Name = "rech_abo_tel";
            // 
            // rech_abo_adresse_mail
            // 
            this.rech_abo_adresse_mail.HeaderText = "Adresse Mail";
            this.rech_abo_adresse_mail.Name = "rech_abo_adresse_mail";
            // 
            // rech_abo_date_naissance
            // 
            this.rech_abo_date_naissance.HeaderText = "DateNaissance";
            this.rech_abo_date_naissance.Name = "rech_abo_date_naissance";
            // 
            // rech_abo_date_premier_abo
            // 
            this.rech_abo_date_premier_abo.HeaderText = "Premier Abo";
            this.rech_abo_date_premier_abo.Name = "rech_abo_date_premier_abo";
            // 
            // rech_abo_date_fin_abo
            // 
            this.rech_abo_date_fin_abo.HeaderText = "FinAbo";
            this.rech_abo_date_fin_abo.Name = "rech_abo_date_fin_abo";
            // 
            // txtBoxRechercherAbo
            // 
            this.txtBoxRechercherAbo.Location = new System.Drawing.Point(104, 36);
            this.txtBoxRechercherAbo.Name = "txtBoxRechercherAbo";
            this.txtBoxRechercherAbo.Size = new System.Drawing.Size(154, 20);
            this.txtBoxRechercherAbo.TabIndex = 1;
            this.txtBoxRechercherAbo.TextChanged += new System.EventHandler(this.txtBoxRechercherAbo_TextChanged);
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(43, 36);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(29, 13);
            this.label70.TabIndex = 0;
            this.label70.Text = "Nom";
            // 
            // dtp_annee
            // 
            this.dtp_annee.Location = new System.Drawing.Point(167, 247);
            this.dtp_annee.Name = "dtp_annee";
            this.dtp_annee.Size = new System.Drawing.Size(125, 20);
            this.dtp_annee.TabIndex = 45;
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(930, 542);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 44;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Enter += new System.EventHandler(this.Refresh_Enter);
            // 
            // dataGridAbo
            // 
            this.dataGridAbo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAbo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nomAbo,
            this.prenomAbo,
            this.adresseAbo,
            this.telAbo,
            this.adresseMailAbo,
            this.dateNaissanceAbo,
            this.datePremierAbo,
            this.dateFinAbo});
            this.dataGridAbo.GridColor = System.Drawing.Color.DarkKhaki;
            this.dataGridAbo.Location = new System.Drawing.Point(3, 468);
            this.dataGridAbo.Name = "dataGridAbo";
            this.dataGridAbo.Size = new System.Drawing.Size(921, 206);
            this.dataGridAbo.TabIndex = 43;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // nomAbo
            // 
            this.nomAbo.HeaderText = "Nom";
            this.nomAbo.Name = "nomAbo";
            // 
            // prenomAbo
            // 
            this.prenomAbo.HeaderText = "Prenom";
            this.prenomAbo.Name = "prenomAbo";
            // 
            // adresseAbo
            // 
            this.adresseAbo.HeaderText = "Adresse";
            this.adresseAbo.Name = "adresseAbo";
            // 
            // telAbo
            // 
            this.telAbo.HeaderText = "Tel";
            this.telAbo.Name = "telAbo";
            // 
            // adresseMailAbo
            // 
            this.adresseMailAbo.HeaderText = "adresse Mail";
            this.adresseMailAbo.Name = "adresseMailAbo";
            // 
            // dateNaissanceAbo
            // 
            this.dateNaissanceAbo.HeaderText = "Date Naissance";
            this.dateNaissanceAbo.Name = "dateNaissanceAbo";
            // 
            // datePremierAbo
            // 
            this.datePremierAbo.HeaderText = "Date Premier Abonnement";
            this.datePremierAbo.Name = "datePremierAbo";
            // 
            // dateFinAbo
            // 
            this.dateFinAbo.HeaderText = "Date Fin Abo";
            this.dateFinAbo.Name = "dateFinAbo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_modif_tel);
            this.groupBox1.Controls.Add(this.verifDate);
            this.groupBox1.Controls.Add(this.dtp_date_fin_abo);
            this.groupBox1.Controls.Add(this.dtp_modif_date_premier_abo);
            this.groupBox1.Controls.Add(this.dtp_modif_annee);
            this.groupBox1.Controls.Add(this.label33);
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.Modifier);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.modif_adresse_mail);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.modif_adresse);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.modif_prenom);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.modif_nom);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.cb_modif);
            this.groupBox1.Controls.Add(this.modif_id);
            this.groupBox1.Location = new System.Drawing.Point(290, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 388);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "modif Abo";
            // 
            // txt_modif_tel
            // 
            this.txt_modif_tel.Location = new System.Drawing.Point(189, 176);
            this.txt_modif_tel.Name = "txt_modif_tel";
            this.txt_modif_tel.Size = new System.Drawing.Size(100, 20);
            this.txt_modif_tel.TabIndex = 47;
            // 
            // verifDate
            // 
            this.verifDate.BackColor = System.Drawing.Color.ForestGreen;
            this.verifDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.verifDate.Location = new System.Drawing.Point(133, 339);
            this.verifDate.Name = "verifDate";
            this.verifDate.Size = new System.Drawing.Size(83, 36);
            this.verifDate.TabIndex = 47;
            this.verifDate.Text = "Verif abo";
            this.verifDate.UseVisualStyleBackColor = false;
            this.verifDate.Click += new System.EventHandler(this.verifDate_Click);
            // 
            // dtp_date_fin_abo
            // 
            this.dtp_date_fin_abo.Location = new System.Drawing.Point(189, 311);
            this.dtp_date_fin_abo.Name = "dtp_date_fin_abo";
            this.dtp_date_fin_abo.Size = new System.Drawing.Size(121, 20);
            this.dtp_date_fin_abo.TabIndex = 53;
            // 
            // dtp_modif_date_premier_abo
            // 
            this.dtp_modif_date_premier_abo.Location = new System.Drawing.Point(188, 275);
            this.dtp_modif_date_premier_abo.Name = "dtp_modif_date_premier_abo";
            this.dtp_modif_date_premier_abo.Size = new System.Drawing.Size(121, 20);
            this.dtp_modif_date_premier_abo.TabIndex = 52;
            // 
            // dtp_modif_annee
            // 
            this.dtp_modif_annee.Location = new System.Drawing.Point(189, 240);
            this.dtp_modif_annee.Name = "dtp_modif_annee";
            this.dtp_modif_annee.Size = new System.Drawing.Size(121, 20);
            this.dtp_modif_annee.TabIndex = 46;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(50, 27);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(129, 13);
            this.label33.TabIndex = 51;
            this.label33.Text = "veuillez choisir un abonné";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(155, 46);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(15, 13);
            this.label32.TabIndex = 50;
            this.label32.Text = "id";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(103, 311);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(69, 13);
            this.label31.TabIndex = 38;
            this.label31.Text = "date_fin_abo";
            // 
            // Modifier
            // 
            this.Modifier.BackColor = System.Drawing.Color.DodgerBlue;
            this.Modifier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Modifier.Location = new System.Drawing.Point(241, 341);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(104, 33);
            this.Modifier.TabIndex = 30;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = false;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(50, 282);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(133, 13);
            this.label30.TabIndex = 37;
            this.label30.Text = "date_premier_abonnement";
            // 
            // modif_adresse_mail
            // 
            this.modif_adresse_mail.Location = new System.Drawing.Point(189, 207);
            this.modif_adresse_mail.Name = "modif_adresse_mail";
            this.modif_adresse_mail.Size = new System.Drawing.Size(100, 20);
            this.modif_adresse_mail.TabIndex = 46;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(101, 240);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(82, 13);
            this.label29.TabIndex = 36;
            this.label29.Text = "date_naissance";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(115, 210);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(68, 13);
            this.label28.TabIndex = 35;
            this.label28.Text = "adresse_mail";
            // 
            // modif_adresse
            // 
            this.modif_adresse.Location = new System.Drawing.Point(189, 142);
            this.modif_adresse.Name = "modif_adresse";
            this.modif_adresse.Size = new System.Drawing.Size(100, 20);
            this.modif_adresse.TabIndex = 44;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(145, 175);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(18, 13);
            this.label27.TabIndex = 34;
            this.label27.Text = "tel";
            // 
            // modif_prenom
            // 
            this.modif_prenom.Location = new System.Drawing.Point(189, 110);
            this.modif_prenom.Name = "modif_prenom";
            this.modif_prenom.Size = new System.Drawing.Size(100, 20);
            this.modif_prenom.TabIndex = 43;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(128, 146);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(44, 13);
            this.label26.TabIndex = 33;
            this.label26.Text = "adresse";
            // 
            // modif_nom
            // 
            this.modif_nom.Location = new System.Drawing.Point(189, 81);
            this.modif_nom.Name = "modif_nom";
            this.modif_nom.Size = new System.Drawing.Size(100, 20);
            this.modif_nom.TabIndex = 42;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(130, 110);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(42, 13);
            this.label25.TabIndex = 32;
            this.label25.Text = "prenom";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(145, 84);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(27, 13);
            this.label24.TabIndex = 31;
            this.label24.Text = "nom";
            // 
            // cb_modif
            // 
            this.cb_modif.FormattingEnabled = true;
            this.cb_modif.Location = new System.Drawing.Point(189, 19);
            this.cb_modif.Name = "cb_modif";
            this.cb_modif.Size = new System.Drawing.Size(121, 21);
            this.cb_modif.TabIndex = 40;
            this.cb_modif.SelectedIndexChanged += new System.EventHandler(this.cb_modif_SelectedIndexChanged);
            // 
            // modif_id
            // 
            this.modif_id.Location = new System.Drawing.Point(189, 46);
            this.modif_id.Name = "modif_id";
            this.modif_id.ReadOnly = true;
            this.modif_id.Size = new System.Drawing.Size(100, 20);
            this.modif_id.TabIndex = 41;
            // 
            // cbSupp
            // 
            this.cbSupp.FormattingEnabled = true;
            this.cbSupp.Location = new System.Drawing.Point(744, 73);
            this.cbSupp.Name = "cbSupp";
            this.cbSupp.Size = new System.Drawing.Size(121, 21);
            this.cbSupp.TabIndex = 39;
            // 
            // supprimer
            // 
            this.supprimer.BackColor = System.Drawing.Color.Red;
            this.supprimer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.supprimer.Location = new System.Drawing.Point(744, 108);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(121, 32);
            this.supprimer.TabIndex = 21;
            this.supprimer.Text = "supprimer";
            this.supprimer.UseVisualStyleBackColor = false;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(660, 81);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(67, 13);
            this.label23.TabIndex = 20;
            this.label23.Text = "nom Abonné";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(28, 280);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(133, 13);
            this.label21.TabIndex = 17;
            this.label21.Text = "date_premier_abonnement";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(79, 247);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 13);
            this.label20.TabIndex = 16;
            this.label20.Text = "date_naissance";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(96, 214);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 13);
            this.label19.TabIndex = 15;
            this.label19.Text = "adresse_mail";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(122, 179);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(18, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "tel";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(120, 141);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "adresse";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(122, 106);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "prenom";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(134, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "nom";
            // 
            // Aj_adresse_mail
            // 
            this.Aj_adresse_mail.Location = new System.Drawing.Point(175, 207);
            this.Aj_adresse_mail.Name = "Aj_adresse_mail";
            this.Aj_adresse_mail.Size = new System.Drawing.Size(100, 20);
            this.Aj_adresse_mail.TabIndex = 5;
            // 
            // Aj_adresse
            // 
            this.Aj_adresse.Location = new System.Drawing.Point(175, 138);
            this.Aj_adresse.Name = "Aj_adresse";
            this.Aj_adresse.Size = new System.Drawing.Size(100, 20);
            this.Aj_adresse.TabIndex = 4;
            // 
            // Aj_tel
            // 
            this.Aj_tel.Location = new System.Drawing.Point(175, 172);
            this.Aj_tel.Name = "Aj_tel";
            this.Aj_tel.Size = new System.Drawing.Size(100, 20);
            this.Aj_tel.TabIndex = 2;
            // 
            // Aj_prenom
            // 
            this.Aj_prenom.Location = new System.Drawing.Point(175, 99);
            this.Aj_prenom.Name = "Aj_prenom";
            this.Aj_prenom.Size = new System.Drawing.Size(100, 20);
            this.Aj_prenom.TabIndex = 1;
            // 
            // Aj_nom
            // 
            this.Aj_nom.Location = new System.Drawing.Point(175, 62);
            this.Aj_nom.Name = "Aj_nom";
            this.Aj_nom.Size = new System.Drawing.Size(100, 20);
            this.Aj_nom.TabIndex = 0;
            // 
            // Ajouter
            // 
            this.Ajouter.BackColor = System.Drawing.Color.DodgerBlue;
            this.Ajouter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ajouter.Location = new System.Drawing.Point(167, 315);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(117, 38);
            this.Ajouter.TabIndex = 8;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = false;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click_1);
            // 
            // tabLivres
            // 
            this.tabLivres.Controls.Add(this.grpRechercheTitre);
            this.tabLivres.Controls.Add(this.grpRechercheCode);
            this.tabLivres.Location = new System.Drawing.Point(4, 22);
            this.tabLivres.Name = "tabLivres";
            this.tabLivres.Size = new System.Drawing.Size(1362, 723);
            this.tabLivres.TabIndex = 2;
            this.tabLivres.Text = "Livres";
            this.tabLivres.UseVisualStyleBackColor = true;
            this.tabLivres.Enter += new System.EventHandler(this.tabLivres_Enter);
            // 
            // grpRechercheTitre
            // 
            this.grpRechercheTitre.Controls.Add(this.dgvLivres);
            this.grpRechercheTitre.Controls.Add(this.label6);
            this.grpRechercheTitre.Controls.Add(this.txbTitre);
            this.grpRechercheTitre.Location = new System.Drawing.Point(30, 251);
            this.grpRechercheTitre.Name = "grpRechercheTitre";
            this.grpRechercheTitre.Size = new System.Drawing.Size(723, 264);
            this.grpRechercheTitre.TabIndex = 18;
            this.grpRechercheTitre.TabStop = false;
            this.grpRechercheTitre.Text = "RECHERCHE PAR TITRE";
            // 
            // dgvLivres
            // 
            this.dgvLivres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDoc,
            this.titre,
            this.auteur,
            this.isbn,
            this.lacollection});
            this.dgvLivres.Location = new System.Drawing.Point(18, 62);
            this.dgvLivres.Name = "dgvLivres";
            this.dgvLivres.Size = new System.Drawing.Size(689, 180);
            this.dgvLivres.TabIndex = 4;
            // 
            // idDoc
            // 
            this.idDoc.HeaderText = "NUMERO";
            this.idDoc.Name = "idDoc";
            this.idDoc.Width = 60;
            // 
            // titre
            // 
            this.titre.HeaderText = "TITRE DU LIVRE";
            this.titre.Name = "titre";
            this.titre.Width = 200;
            // 
            // auteur
            // 
            this.auteur.HeaderText = "AUTEUR(E)";
            this.auteur.Name = "auteur";
            // 
            // isbn
            // 
            this.isbn.HeaderText = "Code ISBN";
            this.isbn.Name = "isbn";
            this.isbn.Width = 90;
            // 
            // lacollection
            // 
            this.lacollection.HeaderText = "COLLECTION";
            this.lacollection.Name = "lacollection";
            this.lacollection.Width = 200;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Saisir le titre ou la partie d\'un titre :";
            // 
            // txbTitre
            // 
            this.txbTitre.Location = new System.Drawing.Point(236, 18);
            this.txbTitre.Name = "txbTitre";
            this.txbTitre.Size = new System.Drawing.Size(174, 20);
            this.txbTitre.TabIndex = 3;
            this.txbTitre.TextChanged += new System.EventHandler(this.txbTitre_TextChanged);
            // 
            // grpRechercheCode
            // 
            this.grpRechercheCode.Controls.Add(this.lblCategorie);
            this.grpRechercheCode.Controls.Add(this.label13);
            this.grpRechercheCode.Controls.Add(this.btnRechercher);
            this.grpRechercheCode.Controls.Add(this.lblTitre);
            this.grpRechercheCode.Controls.Add(this.lblImage);
            this.grpRechercheCode.Controls.Add(this.label5);
            this.grpRechercheCode.Controls.Add(this.label10);
            this.grpRechercheCode.Controls.Add(this.txbNumDoc);
            this.grpRechercheCode.Controls.Add(this.lblNumero);
            this.grpRechercheCode.Controls.Add(this.lblAuteur);
            this.grpRechercheCode.Controls.Add(this.lblISBN);
            this.grpRechercheCode.Controls.Add(this.label7);
            this.grpRechercheCode.Controls.Add(this.label11);
            this.grpRechercheCode.Controls.Add(this.lblCollection);
            this.grpRechercheCode.Controls.Add(this.label8);
            this.grpRechercheCode.Controls.Add(this.label12);
            this.grpRechercheCode.Controls.Add(this.label9);
            this.grpRechercheCode.Location = new System.Drawing.Point(30, 19);
            this.grpRechercheCode.Name = "grpRechercheCode";
            this.grpRechercheCode.Size = new System.Drawing.Size(723, 206);
            this.grpRechercheCode.TabIndex = 17;
            this.grpRechercheCode.TabStop = false;
            this.grpRechercheCode.Text = "RECHERCHE PAR CODE DOCUMENT";
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(490, 179);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(57, 13);
            this.lblCategorie.TabIndex = 18;
            this.lblCategorie.Text = "(catégorie)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(359, 179);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Catégorie de public :";
            // 
            // btnRechercher
            // 
            this.btnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercher.Location = new System.Drawing.Point(298, 21);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(96, 20);
            this.btnRechercher.TabIndex = 4;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(280, 80);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(30, 13);
            this.lblTitre.TabIndex = 12;
            this.lblTitre.Text = "(titre)";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(172, 115);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(41, 13);
            this.lblImage.TabIndex = 16;
            this.lblImage.Text = "(image)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Saisir un numéro de document :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(233, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Titre :";
            // 
            // txbNumDoc
            // 
            this.txbNumDoc.Location = new System.Drawing.Point(207, 22);
            this.txbNumDoc.Name = "txbNumDoc";
            this.txbNumDoc.Size = new System.Drawing.Size(67, 20);
            this.txbNumDoc.TabIndex = 0;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(156, 80);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(48, 13);
            this.lblNumero.TabIndex = 11;
            this.lblNumero.Text = "(numéro)";
            // 
            // lblAuteur
            // 
            this.lblAuteur.AutoSize = true;
            this.lblAuteur.Location = new System.Drawing.Point(295, 146);
            this.lblAuteur.Name = "lblAuteur";
            this.lblAuteur.Size = new System.Drawing.Size(43, 13);
            this.lblAuteur.TabIndex = 14;
            this.lblAuteur.Text = "(auteur)";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(98, 146);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(32, 13);
            this.lblISBN.TabIndex = 15;
            this.lblISBN.Text = "(isbn)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Numéro de document :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(233, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Auteur(e) :";
            // 
            // lblCollection
            // 
            this.lblCollection.AutoSize = true;
            this.lblCollection.Location = new System.Drawing.Point(92, 179);
            this.lblCollection.Name = "lblCollection";
            this.lblCollection.Size = new System.Drawing.Size(58, 13);
            this.lblCollection.TabIndex = 13;
            this.lblCollection.Text = "(collection)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Emplacement de l\'image :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Collection :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Code ISBN :";
            // 
            // tabTitres
            // 
            this.tabTitres.Controls.Add(this.label4);
            this.tabTitres.Controls.Add(this.dgvTitres);
            this.tabTitres.Controls.Add(this.label2);
            this.tabTitres.Controls.Add(this.cbxDomaines);
            this.tabTitres.Location = new System.Drawing.Point(4, 22);
            this.tabTitres.Name = "tabTitres";
            this.tabTitres.Padding = new System.Windows.Forms.Padding(3);
            this.tabTitres.Size = new System.Drawing.Size(1362, 723);
            this.tabTitres.TabIndex = 1;
            this.tabTitres.Text = "Titres";
            this.tabTitres.UseVisualStyleBackColor = true;
            this.tabTitres.Enter += new System.EventHandler(this.tabTitres_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(183, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Visualisation des titres abonnés";
            // 
            // dgvTitres
            // 
            this.dgvTitres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTitres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTitre,
            this.nom,
            this.empruntable,
            this.dateFin,
            this.periodicite});
            this.dgvTitres.Location = new System.Drawing.Point(72, 139);
            this.dgvTitres.Name = "dgvTitres";
            this.dgvTitres.Size = new System.Drawing.Size(623, 111);
            this.dgvTitres.TabIndex = 2;
            // 
            // idTitre
            // 
            this.idTitre.HeaderText = "NUMERO";
            this.idTitre.Name = "idTitre";
            this.idTitre.Width = 60;
            // 
            // nom
            // 
            this.nom.HeaderText = "TITRE";
            this.nom.Name = "nom";
            this.nom.Width = 200;
            // 
            // empruntable
            // 
            this.empruntable.HeaderText = "EMPRUNTABLE";
            this.empruntable.Name = "empruntable";
            // 
            // dateFin
            // 
            this.dateFin.HeaderText = "FIN D\'ABONNEMENT";
            this.dateFin.Name = "dateFin";
            this.dateFin.Width = 140;
            // 
            // periodicite
            // 
            this.periodicite.HeaderText = "PERIODICITE";
            this.periodicite.Name = "periodicite";
            this.periodicite.Width = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choisir un domaine :";
            // 
            // cbxDomaines
            // 
            this.cbxDomaines.FormattingEnabled = true;
            this.cbxDomaines.Location = new System.Drawing.Point(208, 77);
            this.cbxDomaines.Name = "cbxDomaines";
            this.cbxDomaines.Size = new System.Drawing.Size(226, 21);
            this.cbxDomaines.TabIndex = 0;
            this.cbxDomaines.SelectedIndexChanged += new System.EventHandler(this.cbxDomaines_SelectedIndexChanged);
            // 
            // tabParutions
            // 
            this.tabParutions.Controls.Add(this.label3);
            this.tabParutions.Controls.Add(this.dgvParutions);
            this.tabParutions.Controls.Add(this.label1);
            this.tabParutions.Controls.Add(this.cbxTitres);
            this.tabParutions.Location = new System.Drawing.Point(4, 22);
            this.tabParutions.Name = "tabParutions";
            this.tabParutions.Padding = new System.Windows.Forms.Padding(3);
            this.tabParutions.Size = new System.Drawing.Size(1362, 723);
            this.tabParutions.TabIndex = 0;
            this.tabParutions.Text = "Parutions";
            this.tabParutions.UseVisualStyleBackColor = true;
            this.tabParutions.Enter += new System.EventHandler(this.tabParutions_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Visualisation des numéros reçus par titre";
            // 
            // dgvParutions
            // 
            this.dgvParutions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParutions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.dateParution,
            this.photo});
            this.dgvParutions.Location = new System.Drawing.Point(88, 135);
            this.dgvParutions.Name = "dgvParutions";
            this.dgvParutions.Size = new System.Drawing.Size(543, 235);
            this.dgvParutions.TabIndex = 2;
            // 
            // numero
            // 
            this.numero.HeaderText = "NUMERO";
            this.numero.Name = "numero";
            this.numero.Width = 60;
            // 
            // dateParution
            // 
            this.dateParution.HeaderText = "DATE DE PARUTION";
            this.dateParution.Name = "dateParution";
            this.dateParution.Width = 140;
            // 
            // photo
            // 
            this.photo.HeaderText = "EMPLACEMENT PHOTO";
            this.photo.Name = "photo";
            this.photo.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choisir un titre :";
            // 
            // cbxTitres
            // 
            this.cbxTitres.FormattingEnabled = true;
            this.cbxTitres.Location = new System.Drawing.Point(188, 74);
            this.cbxTitres.Name = "cbxTitres";
            this.cbxTitres.Size = new System.Drawing.Size(146, 21);
            this.cbxTitres.TabIndex = 0;
            this.cbxTitres.SelectedIndexChanged += new System.EventHandler(this.cbxTitres_SelectedIndexChanged);
            // 
            // Connexion
            // 
            this.Connexion.Controls.Add(this.tabParutions);
            this.Connexion.Controls.Add(this.tabTitres);
            this.Connexion.Controls.Add(this.tabLivres);
            this.Connexion.Controls.Add(this.CRUD_abo);
            this.Connexion.Controls.Add(this.dgvAbo);
            this.Connexion.Controls.Add(this.exemplaire);
            this.Connexion.Controls.Add(this.CRUDLivreDvd);
            this.Connexion.Controls.Add(this.CRUD_DVD);
            this.Connexion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Connexion.Location = new System.Drawing.Point(0, 0);
            this.Connexion.Name = "Connexion";
            this.Connexion.SelectedIndex = 0;
            this.Connexion.Size = new System.Drawing.Size(1370, 749);
            this.Connexion.TabIndex = 0;
            this.Connexion.Enter += new System.EventHandler(this.tabOngletsApplication_Enter);
            // 
            // dtp_premier_abo
            // 
            this.dtp_premier_abo.Enabled = false;
            this.dtp_premier_abo.Location = new System.Drawing.Point(167, 280);
            this.dtp_premier_abo.MaxDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dtp_premier_abo.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dtp_premier_abo.Name = "dtp_premier_abo";
            this.dtp_premier_abo.Size = new System.Drawing.Size(117, 20);
            this.dtp_premier_abo.TabIndex = 46;
            this.dtp_premier_abo.Value = new System.DateTime(2023, 6, 11, 0, 0, 0, 0);
            // 
            // FrmMediateq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.Connexion);
            this.Name = "FrmMediateq";
            this.Text = "Gestion Médiathèque";
            this.Load += new System.EventHandler(this.FrmMediateq_Load);
            this.CRUD_DVD.ResumeLayout(false);
            this.CRUD_DVD.PerformLayout();
            this.grpBoxRechercherDvd.ResumeLayout(false);
            this.grpBoxRechercherDvd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRechercherTitreDvd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDvd)).EndInit();
            this.gpxCRUD_DVD2.ResumeLayout(false);
            this.gpxCRUD_DVD2.PerformLayout();
            this.gpxCRUD_DVD.ResumeLayout(false);
            this.gpxCRUD_DVD.PerformLayout();
            this.CRUDLivreDvd.ResumeLayout(false);
            this.CRUDLivreDvd.PerformLayout();
            this.grpBoxRechercherLivre.ResumeLayout(false);
            this.grpBoxRechercherLivre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRechercherLivreTitre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivre)).EndInit();
            this.groupBoxLivre2.ResumeLayout(false);
            this.groupBoxLivre2.PerformLayout();
            this.groupBoxLivre.ResumeLayout(false);
            this.groupBoxLivre.PerformLayout();
            this.exemplaire.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.dgvAbo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbonne)).EndInit();
            this.CRUD_abo.ResumeLayout(false);
            this.CRUD_abo.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRechercherAbo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAbo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabLivres.ResumeLayout(false);
            this.grpRechercheTitre.ResumeLayout(false);
            this.grpRechercheTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivres)).EndInit();
            this.grpRechercheCode.ResumeLayout(false);
            this.grpRechercheCode.PerformLayout();
            this.tabTitres.ResumeLayout(false);
            this.tabTitres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitres)).EndInit();
            this.tabParutions.ResumeLayout(false);
            this.tabParutions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParutions)).EndInit();
            this.Connexion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.TabPage CRUD_DVD;
        private System.Windows.Forms.GroupBox grpBoxRechercherDvd;
        private System.Windows.Forms.DataGridView dgvRechercherTitreDvd;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtBoxRechercherTitreDvd;
        private System.Windows.Forms.Button btnRefreshDvd;
        private System.Windows.Forms.DataGridView dgvDvd;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_dvd;
        private System.Windows.Forms.DataGridViewTextBoxColumn titre_dvd;
        private System.Windows.Forms.DataGridViewTextBoxColumn image_dvd;
        private System.Windows.Forms.DataGridViewTextBoxColumn synopsis_dvd;
        private System.Windows.Forms.DataGridViewTextBoxColumn realisateur_dvd;
        private System.Windows.Forms.DataGridViewTextBoxColumn duree_dvd;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorie_dvd;
        private System.Windows.Forms.GroupBox gpxCRUD_DVD2;
        private System.Windows.Forms.Button btnSuppDvd;
        private System.Windows.Forms.Button btnModifDvd;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.TextBox txtBoxModifDvdImage;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.TextBox txtBoxModifDvdDuree;
        private System.Windows.Forms.TextBox txtBoxModifDvdRealisateur;
        private System.Windows.Forms.TextBox txtBoxModifDvdSynopsis;
        private System.Windows.Forms.TextBox txtBoxModifDvdTitre;
        private System.Windows.Forms.TextBox txtBoxModifDvdId;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.ComboBox cbx_ModifCategDvd;
        private System.Windows.Forms.ComboBox cbx_ModifDvd;
        private System.Windows.Forms.GroupBox gpxCRUD_DVD;
        private System.Windows.Forms.Button btnAjout_DVD;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.TextBox txtDvd_Duree;
        private System.Windows.Forms.TextBox txtDvd_Realisateur;
        private System.Windows.Forms.TextBox txtDvd_Synopsis;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox txtDvd_Image;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox txtDvd_Titre;
        private System.Windows.Forms.TextBox txtDvd_id;
        private System.Windows.Forms.ComboBox cbx_categDVD;
        private System.Windows.Forms.TabPage CRUDLivreDvd;
        private System.Windows.Forms.GroupBox grpBoxRechercherLivre;
        private System.Windows.Forms.DataGridView dgvRechercherLivreTitre;
        private System.Windows.Forms.TextBox txtBoxRechercherLivreTitre;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Button btnRefreshLivre;
        private System.Windows.Forms.DataGridView dgvLivre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auteur_Livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titre_Livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN_Livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Collection_Livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Image_Livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categorie_Livre;
        private System.Windows.Forms.GroupBox groupBoxLivre2;
        private System.Windows.Forms.TextBox txtBoxModifLivreCollection;
        private System.Windows.Forms.TextBox txtBoxModifLivreImage;
        private System.Windows.Forms.TextBox txtBoxModifLivreISBN;
        private System.Windows.Forms.TextBox txtBoxModifLivreTitre;
        private System.Windows.Forms.TextBox txtBoxModifLivreAuteur;
        private System.Windows.Forms.TextBox txtBoxModifLivreId;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Button btnModifLivre;
        private System.Windows.Forms.ComboBox cbxModifCateg;
        private System.Windows.Forms.Button btnSuppLivre;
        private System.Windows.Forms.ComboBox cbModifLivre;
        private System.Windows.Forms.GroupBox groupBoxLivre;
        private System.Windows.Forms.Button btnAjouter_livre;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox txtLivre_collection;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.ComboBox cbx_livre;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox txtLivre_auteur;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txtLivre_ISBN;
        private System.Windows.Forms.TextBox txtLivre_image;
        private System.Windows.Forms.TextBox txtLivre_titre;
        private System.Windows.Forms.TextBox txtLivre_id;
        private System.Windows.Forms.TabPage exemplaire;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ajouter_exemplaire;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.ComboBox cb_rayon;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtBox_numero;
        private System.Windows.Forms.ComboBox cb_document;
        private System.Windows.Forms.TabPage dgvAbo;
        private System.Windows.Forms.DataGridView dataGridViewAbonne;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAbo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TabPage CRUD_abo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvRechercherAbo;
        private System.Windows.Forms.TextBox txtBoxRechercherAbo;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.DateTimePicker dtp_annee;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.DataGridView dataGridAbo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomAbo;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomAbo;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseAbo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telAbo;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseMailAbo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateNaissanceAbo;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePremierAbo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFinAbo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_modif_tel;
        private System.Windows.Forms.Button verifDate;
        private System.Windows.Forms.DateTimePicker dtp_date_fin_abo;
        private System.Windows.Forms.DateTimePicker dtp_modif_date_premier_abo;
        private System.Windows.Forms.DateTimePicker dtp_modif_annee;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox modif_adresse_mail;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox modif_adresse;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox modif_prenom;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox modif_nom;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cb_modif;
        private System.Windows.Forms.TextBox modif_id;
        private System.Windows.Forms.ComboBox cbSupp;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Aj_adresse_mail;
        private System.Windows.Forms.TextBox Aj_adresse;
        private System.Windows.Forms.TextBox Aj_tel;
        private System.Windows.Forms.TextBox Aj_prenom;
        private System.Windows.Forms.TextBox Aj_nom;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.TabPage tabLivres;
        private System.Windows.Forms.GroupBox grpRechercheTitre;
        private System.Windows.Forms.DataGridView dgvLivres;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn auteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lacollection;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbTitre;
        private System.Windows.Forms.GroupBox grpRechercheCode;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbNumDoc;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblAuteur;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCollection;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabTitres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvTitres;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTitre;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn empruntable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodicite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxDomaines;
        private System.Windows.Forms.TabPage tabParutions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvParutions;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateParution;
        private System.Windows.Forms.DataGridViewTextBoxColumn photo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTitres;
        private System.Windows.Forms.TabControl Connexion;
        private System.Windows.Forms.DataGridViewTextBoxColumn rech_abo_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn rech_abo_nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn rech_abo_prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn rech_abo_adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn rech_abo_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn rech_abo_adresse_mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn rech_abo_date_naissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn rech_abo_date_premier_abo;
        private System.Windows.Forms.DataGridViewTextBoxColumn rech_abo_date_fin_abo;
        private System.Windows.Forms.DataGridViewTextBoxColumn rech_id_livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn rech_titre_livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn rech_isbn_livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn rech_auteur_livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn rech_collection_livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn rech_image_livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn rech_categorie_livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn rech_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn rech_titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn rech_synopsis;
        private System.Windows.Forms.DataGridViewTextBoxColumn rech_realisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn rech_duree;
        private System.Windows.Forms.DataGridViewTextBoxColumn rech_image;
        private System.Windows.Forms.DataGridViewTextBoxColumn rech_categorie;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtp_premier_abo;
    }
}

