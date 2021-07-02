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
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4E03TBFV\MYSQL;Initial Catalog=ProjetHero;Integrated Security=True");

        private void CmdValider_Click(object sender, EventArgs e)
        {
            if(CmbSV.SelectedIndex==0)
            {
                //try
                //{
                //    conn.Open();
                //    string query = "INSERT INTO Incident(Id_incident, Id_Organisation_declarant, Id_super_hero_declarant, Adresse, Commentaire, Date_ajout, Flag_transforme_en_mission)"+
                //        "VALUES('"+ IdDéclarant.Text+"','"+Nom.Text+"','"+Prenom.Text+"','"+
                //}
                //catch(Exception e1)
                //{
                //    MessageBox.Show(e1.Message);
                //}
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Incident ( Nature, Adresse, Date_Ajout)"+
                        "VALUES('"                          + CmbTypeIncident.Text + "','" + AdresseIncident.Text + "','"+Convert.ToDateTime(DateTimeIncident.Text)+ "')";
                    SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
                    SDA.SelectCommand.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("L'incident a bien été créé");
                }
                catch(Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }
                Missions missions = new Missions();
                missions.ShowDialog();
            }
            else
            {
                Autorite_Locale autorite_Locale = new Autorite_Locale();
                autorite_Locale.ShowDialog();
            }

        }

        private void Incident_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSet3IncidentGrdvCivil.Civil'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.civilTableAdapter.Fill(this.projetHeroDataSet3IncidentGrdvCivil.Civil);
            cboColumn.SelectedIndex = 1;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
                    civilBindingSource.Filter = string.Empty;
                else
                    civilBindingSource.Filter = string.Format("{0}='{1}'", cboColumn.Text, txtSearch.Text);
            }
        }

        private void CmdQuitter_Click(object sender, EventArgs e)
        {
            Incident.ActiveForm.Close();
        }
    }
}
