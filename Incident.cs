using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avergers
{
    public partial class Incident : Form
    {
        public Incident()
        {
            InitializeComponent();
        }

        private void AdresseIncident_TextChanged(object sender, EventArgs e)
        {

        }

        private void Incident_Load(object sender, EventArgs e)
        {
            

        }

        


        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtsearch.Text))
                    civilBindingSource4.Filter = string.Empty;
                else
                    civilBindingSource4.Filter = string.Format("{0}='{1}'", comboBox1.Text, txtsearch.Text);

            }
        }

        private void Incident_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projetHeroDataSet17.Civil' table. You can move, or remove it, as needed.
            this.civilTableAdapter4.Fill(this.projetHeroDataSet17.Civil);

        }
    }

}