using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSetIdIncident.Incident'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.incidentTableAdapter.Fill(this.projetHeroDataSetIdIncident.Incident);
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSet_incident.Civil'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.civilTableAdapter1.Fill(this.projetHeroDataSet_incident.Civil);
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSet5.Civil'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.civilTableAdapter.Fill(this.projetHeroDataSet.Civil);
            
            cboColonne.SelectedIndex = 1;

        }

        private void textSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(textSearch.Text))
                    civilBindingSource1.Filter = string.Empty;
                else
                    civilBindingSource1.Filter = string.Format("{0}='{1}'", cboColonne.Text, textSearch.Text);
            }
        }

        private void CmdQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TKJHI8I;Initial Catalog=ProjetHero;Integrated Security=True");

        private void CmdValider_Click(object sender, EventArgs e)
        {
            if(CmbSV.SelectedIndex==1)
            {
                MessageBox.Show("Nous vous remercions pour votre declaration. Votre demande a été transmise aux autorités locales");
            }
            else
            {
                conn.Open();
                string query = "INSERT INTO Incident ( Nature, Adresse, Date_ajout)"+
                      "VALUES(                      '" + CmbNatureIncident.Text + "','" + AdresseIncident.Text + "','" + Convert.ToDateTime(DateTimeIncident.Text) + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
                SDA.SelectCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("L'incident a bien été declaré.");

                
            }
        }

       
    }
}
