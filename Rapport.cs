using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avergers
{
    public partial class Rapport : Form
    {
        public Rapport()
        {
            InitializeComponent();
        }

        private void CmdAnnuler_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Rapport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projetHeroDataSetCivilMort.Civil' table. You can move, or remove it, as needed.
            this.civilTableAdapter.Fill(this.projetHeroDataSetCivilMort.Civil);

        }
    }
}
