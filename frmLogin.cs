using Mediateq_AP_SIO2.metier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Mediateq_AP_SIO2
{
    /// <summary>
    /// Formulaire login ou sont réalisé les traitements pour la connexion
    /// </summary>
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Users u = DAODocuments.connex(txtUsername.Text);
            string passwordHash = txtPassword.Text;
            if (u != null && u.Password == passwordHash)
            {
                new FrmMediateq(u).Show();
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe invalide", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /*BitConverter.ToString(new SHA256Managed().ComputeHash(Encoding.UTF8.GetBytes(txtPassword.Text))).Replace("-", "");*/

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                // Création de la connexion avec la base de données
                DAOFactory.creerConnection();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            // Vérifier l'état de la case à cocher
            if (CheckbxShowPas.Checked)
            {
                // Afficher le mot de passe
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                // Masquer le mot de passe
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
