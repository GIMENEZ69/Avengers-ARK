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
    public partial class Civils : Form
    {
        public Civils()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'avengersDBDataSet.Civils'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.civilsTableAdapter.Fill(this.avengersDBDataSet.Civils);

        }

        private void CmdQuitter_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TKJHI8I;Initial Catalog=AvengersDB;Integrated Security=True");
        private void CmdCréer_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "INSERT INTO Civils (Id_Civils, Nom_Civils,                  Prenom_Civils,         Civilite_Civils,         Adresse_Civils, CodePostale_Civils, Ville_Civils,           Email_Civils,       NumTel_Civils,      DateDeNaissance_Civils, Nationalite_Civils,         DateDeDeces_Civils,         AppartenanceOrganisation_Civils, Commentaire_Civils,        DateAjout_Civils,       DateDeDerniereModification_Civils) " +
                "VALUES(                      '" + Id.Text + "', '" + Nom.Text + "','" + Prenom.Text + "','" + Civilite.Text + "', '" + Adresse.Text + "','" + CP.Text + "','" + Ville.Text + "','" + Email.Text + "', '" + Tel.Text + "', '" + Ddn.Text + "', '" + Nationalite.Text + "',     '" + DateDeces.Text + "', '" + Appartenanceorg.Text + "', '" + Commentaire.Text + "', '" + Dateajout.Text + "', '" + Datemodif.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Le civil a bien été créé");
        }

        private void CmdRead_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT * FROM Civils";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void CmdMaj_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "UPDATE Civils SET Nom_Civils = '" + Nom.Text + "', Prenom_Civils = '" + Prenom.Text + "', Civilite_Civils = '" + Civilite.Text + "', Adresse_Civils = '" + Adresse.Text + "', CodePostale_Civils = '" + CP.Text + "', Ville_Civils = '" + Ville.Text + "', Email_Civils = '" + Email.Text + "', NumTel_Civils = '" + Tel.Text + "', DateDeNaissance_Civils = '" + Ddn.Text + "', Nationalite_Civils = '" + Nationalite.Text + "', DateDeDeces_Civils = '" + DateDeces.Text + "', AppartenanceOrganisation_Civils = '" + Appartenanceorg.Text + "', Commentaire_Civils = '" + Commentaire.Text + "', DateAjout_Civils = '" + Dateajout.Text + "', DateDeDerniereModification_Civils = '" + Datemodif.Text + "' WHERE Id_Civils = '" + Id.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("La modification a bien été prise en compte.");
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Nom.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Prenom.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Civilite.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            Adresse.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            CP.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            Ville.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            Email.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            Tel.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            Ddn.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            Nationalite.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            DateDeces.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            Appartenanceorg.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
            Commentaire.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
            Dateajout.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();
            Datemodif.Text = dataGridView1.SelectedRows[0].Cells[15].Value.ToString();
        }

        private void CmdSupp_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "DELETE FROM Civils where Id_Civils = '" + Id.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("L'identifiant a bien été supprimé");
        }
    }
}
