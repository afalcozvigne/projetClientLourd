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
    public partial class Personnel : Form
    {
        MySqlDataAdapter sda;
        MySqlCommandBuilder scb;
        DataTable dt;
        public Personnel()
        {
            InitializeComponent();
        }

        private void Personnel_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = waveattitude");
            string textreq = "SELECT id_personnel, nom_personnel, prenom_personnel, age_personnel FROM personnel";
            sda = new MySqlDataAdapter(textreq,conn );
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Accueil frm = new Accueil();
            frm.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            scb = new MySqlCommandBuilder(sda);
            sda.Update(dt);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "id_personnel")
            { 
                MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = waveattitude");
                string textreq = "SELECT id_personnel, nom_personnel, prenom_personnel, age_personnel FROM personnel WHERE id_personnel like'"+ textBox1.Text +"%'";
                sda = new MySqlDataAdapter(textreq, conn);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox2.Text == "nom_personnel")
            {
                MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = waveattitude");
                string textreq = "SELECT id_personnel, nom_personnel, prenom_personnel, age_personnel FROM personnel WHERE nom_personnel like'" + textBox1.Text + "%'";
                sda = new MySqlDataAdapter(textreq, conn);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox2.Text == "prenom_personnel")
            {
                MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = waveattitude");
                string textreq = "SELECT id_personnel, nom_personnel, prenom_personnel, age_personnel FROM personnel WHERE prenom_personnel like'" + textBox1.Text + "%'";
                sda = new MySqlDataAdapter(textreq, conn);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox2.Text == "age_personnel")
            {
                MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = waveattitude");
                string textreq = "SELECT id_personnel, nom_personnel, prenom_personnel, age_personnel FROM personnel WHERE age_personnel like'" + textBox1.Text + "%'";
                sda = new MySqlDataAdapter(textreq, conn);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
