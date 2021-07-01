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
    public partial class Incident : Form
    {
        public Incident()
        {
            InitializeComponent();
        }

        private void Incident_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSetCivilDatagriedIncident.Civil'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.civilTableAdapter.Fill(this.projetHeroDataSetCivilDatagriedIncident.Civil);
            CmbSelecRech.SelectedIndex = 1;
        }

        private void Recherche_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if (string.IsNullOrEmpty(Recherche.Text))
                    civilBindingSource.Filter = string.Empty;
                else
                    civilBindingSource.Filter = string.Format("{0}='{1}'", CmbSelecRech.Text, Recherche.Text);
            }
        }

        private void CmdQuitter_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}
