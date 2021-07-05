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
                    string query = "INSERT INTO Incident (Id_incident,          Id_civil_declarant, Id_organisation_declarant, Nature,              Flag_transforme_en_mission,                Adresse,                                                     Date_Ajout)" +
                        "VALUES('"                        +        Convert.ToInt32(TxtIncident_Id.Text) + "','" + IdDeclarant.Text+"','"+Convert.ToInt32(txtIdOrga.Text)+ "','"+            CmbTypeIncident.Text + "','" +CmbSV.Text+"','" +           AdresseIncident.Text + "','"+Convert.ToDateTime(DateTimeIncident.Text)+ "')";
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

        private void Extract_Id_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow dgvr in dataGridView1.Rows)
            {
                int id = Convert.ToInt32(dgvr.Cells[0].Value);
                IdDeclarant.Text = id.ToString();
                break;
            }      
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void genIdOrg_Click(object sender, EventArgs e)
        {
            conn.Open();
            //"SELECT Id_organisation FROM Organisation_civil WHERE Id_civil = '" + textBox1.Text + "'";

            SqlCommand cmd = new SqlCommand("SELECT Id_organisation FROM Organisation_civil WHERE Id_civil = '" + IdDeclarant.Text + "'", conn);
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            txtIdOrga.Text=result.ToString();
        }
    }
}
