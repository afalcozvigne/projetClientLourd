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
    public partial class Personnel : Form
    {
        public Personnel()
        {
            InitializeComponent();
        }

        private void Personnel_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'waveattitudeDataSet1.personnel'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.personnelTableAdapter.Fill(this.waveattitudeDataSet1.personnel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Accueil frm = new Accueil();
            frm.Show();
        }
    }
}
