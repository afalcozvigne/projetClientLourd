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
    public partial class Infocompte : Form
    {
        MySqlDataAdapter sda;
        MySqlCommandBuilder scb;
        DataTable dt;
        public Infocompte()
        {
            InitializeComponent();

        }

        private void Infocompte_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'waveattitudeDataSet.utilisateur'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.utilisateurTableAdapter.Fill(this.waveattitudeDataSet.utilisateur);
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = waveattitude");
            string textreq = "SELECT id_utilisateur, nom_utilisateur, motdepasse_utilisateur FROM utilisateur";
            sda = new MySqlDataAdapter(textreq, conn);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Accueil frm = new Accueil();
            frm.Show();
            this.Close();
        }
    }
}
