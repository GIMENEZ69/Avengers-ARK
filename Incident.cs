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

        SqlConnection conn = new SqlConnection(@"Data Source=AUDREY;Initial Catalog=ProjetHero;Integrated Security=True");

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

        private void CmdValider_Click(object sender, EventArgs e)
        {
            if (CmbSV.SelectedIndex==1)
            {
                MessageBox.Show("Nous vous remercions pour votre déclaration. Votre demande a été transmises aux autorités locales.");
                
            } else
            {
                conn.Open();
                string query = "INSERT INTO Incident (Id_civil_declarant, Nature, Adresse, Date_ajout)" +
                    "VALUES(  '" + IdCivilRattache.Text + "', '" + CmbNatureIncident.Text + "', '" + AdresseIncident.Text + "', '" + Convert.ToDateTime(DateTimeIncident.Text) + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
                SDA.SelectCommand.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Votre incident a bien été déclaré.");
            }
        }

        private void CmdValidDeclarant_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dataGridView1.Rows)
            {
                int id = Convert.ToInt32(dgvr.Cells[0].Value);
                IdCivilRattache.Text = id.ToString();
                break;
            }
        }
    }
}
