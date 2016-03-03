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
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void m_compte_Click(object sender, EventArgs e)
        {
            this.Hide();
            Infocompte frm = new Infocompte();
            frm.Show();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }

        private void m_personnalisation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Personalisation frm = new Personalisation();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Personnel frm = new Personnel();
            frm.Show();
        }
    }
}
