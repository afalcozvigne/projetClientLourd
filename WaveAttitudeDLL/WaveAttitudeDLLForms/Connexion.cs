using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WaveAttitudeDLLForms
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
            MessageBox.Show("Bonjour et Bienvenue sur L'application Wave Attitude ");
        }
        public void Connexion_Load(object sender, EventArgs e)
        {
            #region ConnexionALaBDD
            try
            {
                MySqlConnection conn = new MySqlConnection("Server=localhost;Database=WaveAttitude;Uid=root;Pwd=");
                conn.Open();
                MessageBox.Show("Connexion BDD Effectuer");
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("erreur");
            }
            #endregion
            nomCompte.Text = "Nom de Compte";
            motdepasseCompte.Text = "Mot de passe compte";
           
        }
        #region
        // Verification d'un compte existant pour ce connecter a l'application 
        private void m_connexion_Click(object sender, EventArgs e)
        {  
            m_connexion.Text = "Connexion en Cours !";
            MySqlConnection conn = new MySqlConnection("Server=localhost;Database=WaveAttitude;Uid=root;Pwd=");
            conn.Open();
            string cmdtext = "SELECT motdepasse_utilisateur FROM utilisateur WHERE nom_utilisateur=\"" + nomCompte.Text + "\" AND motdepasse_utilisateur =\"" + motdepasseCompte.Text + "\"";
            MySqlCommand cmd = new MySqlCommand(cmdtext,conn);
            object resultat = cmd.ExecuteScalar();
            string res = Convert.ToString(resultat);
            string mdpcomteverif = motdepasseCompte.Text;
            if(res == mdpcomteverif)
            {
                Accueil frm = new Accueil();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Mot de passe faux ou nom de compte inexistant");
                m_connexion.Text = "Connexion";
            }
            conn.Close();
        }
        #endregion
        private void m_compteinexistant_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Veuillez contacter un responsable pour enregistrer un nouveau compte");
        }
    }
}
