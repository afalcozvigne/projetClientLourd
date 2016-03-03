using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaveAttitudeDLLForms
{
    public partial class Infocompte : Form
    {
        public Infocompte()
        {
            InitializeComponent();

        }

        private void Infocompte_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'waveattitudeDataSet.utilisateur'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.utilisateurTableAdapter.Fill(this.waveattitudeDataSet.utilisateur);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
