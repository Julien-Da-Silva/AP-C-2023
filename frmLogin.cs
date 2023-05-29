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
            if (u.Password==passwordHash)
            {
                new FrmMediateq(u).Show();
            } else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe invalide" , "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
