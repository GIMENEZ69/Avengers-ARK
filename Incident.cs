/**
 * Titre : Avengers
 * Créer par : RG / AS / DC / KT
 * Date : 06/07/2021
 **/
using System;
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

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TKJHI8I;Initial Catalog=ProjetHero;Integrated Security=True");
        
        private void CmdValider_Click(object sender, EventArgs e)
        {
            if (CmbSV.SelectedIndex == 0)
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Incident ( Id_civil_declarant, Id_organisation_declarant, Nature, Adresse, Date_Ajout)" +
                        "VALUES('" + comboBox1.Text + "','" + txtIdOrga.Text + "','" + CmbTypeIncident.Text + "','" + AdresseIncident.Text + "','" + Convert.ToDateTime(DateTimeIncident.Text) + "')";
                    SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
                    SDA.SelectCommand.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("L'incident a bien été créé");
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }
                Missions missions = new Missions();
                missions.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nous vous remercions pour votre declaration. Votre demande a été transmise aux autorités locales");
            }
        }

        private void Incident_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSet13.mefaits'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.mefaitsTableAdapter.Fill(this.projetHeroDataSet13.mefaits);
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSet3IncidentGrdvCivil.Civil'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.civilTableAdapter1.Fill(this.projetHeroDataSet_incident.Civil);
            
            cboColonne.SelectedIndex = 1;
            cboColonne.Text = "";
            comboBox1.Text = "";
            textSearch.Text = "";
            CmbTypeIncident.Text = "";
        }

        private void textSearch_KeyDownn(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(textSearch.Text))
                    civilBindingSource.Filter = string.Empty;
                else
                    civilBindingSource1.Filter = string.Format("{0}='{1}'", cboColonne.Text, textSearch.Text);
            }
        }

        private void CmdQuitter_Click(object sender, EventArgs e)
        {
            Incident.ActiveForm.Close();
        }
        

        //private void Extract_Id_Click_1(object sender, EventArgs e)
        //{
            
        //    foreach (DataGridViewRow dataGridView in dataGridView.Rows)
        //    {
        //        int id = Convert.ToInt32(dataGridView.Cells[0].Value);
        //        txt_idDeclarant.Text = id.ToString();
        //        break;
        //    }
        //}

        private void genIdOrg_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Id_organisation FROM Organisation_civil WHERE Id_civil = '" + comboBox1.Text + "'", conn);
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            txtIdOrga.Text = result.ToString();
        }

        private void dataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textSearch.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}



