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
    public partial class Organisations : Form
    {
        public Organisations()
        {
            InitializeComponent();
        }

        private void Organisations_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'avengersDBDataSetOrga1.Organisations'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.organisationsTableAdapter.Fill(this.avengersDBDataSetOrga1.Organisations);
            // TODO: cette ligne de code charge les données dans la table 'avengersDBDataSetOrga.Organisations'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.organisationsTableAdapter.Fill(this.avengersDBDataSetOrga.Organisations);

        }

        private void CmdQuitter_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=AUDREY;Initial Catalog=AvengersDB;Integrated Security=True");
        private void CmdCréer_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "INSERT INTO Organisations (Id_Organisations, Nom_Organisations, Adresse_Organisations, CodePostale_Organisations, Ville_Organisations, Dirigeant_Organisations, Commentaire_Organisations, DateAjout_Organisations, DateDerniereModification_Organisations) " +
                "VALUES(                            '" + Id.Text + "', '" + Nom.Text + "','" + Adresse.Text + "', '" + CP.Text + "',            '" + Ville.Text + "', '" + Dirigeant.Text + "','" + Commentaire.Text + "', '" + Dateajout.Text + "', '" + Datemodif.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("L'organisation a bien été créée");
        }

        private void CmdRead_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT * FROM Organisations";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void CmdMaj_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "UPDATE Organisations SET Nom_Organisations = '" + Nom.Text + "', Adresse_Organisations = '" + Adresse.Text + "', CodePostale_Organisations = '" + CP.Text + "', Ville_Organisations = '" + Ville.Text + "', Dirigeant_Organisations = '" + Dirigeant.Text + "', Commentaire_Organisations = '" + Commentaire.Text + "', DateAjout_Organisations = '" + Dateajout.Text + "', DateDerniereModification_Organisations = '" + Datemodif.Text + "' WHERE Id_Organisations = '" + Id.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("La modification a bien été prise en compte.");
        }

        private void CmdSupp_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "DELETE FROM Organisations where Id_Organisations = '" + Id.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(" L'identifiant a bien été supprimé");
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Nom.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Adresse.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            CP.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            Ville.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            Dirigeant.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            Commentaire.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            Dateajout.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            Datemodif.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();

        }
    }
}
