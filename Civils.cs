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
            // TODO: This line of code loads data into the 'projetHeroDataSet3.Civil' table. You can move, or remove it, as needed.
            this.civilTableAdapter1.Fill(this.projetHeroDataSet3.Civil);
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSetCivil.Civil'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.civilTableAdapter.Fill(this.projetHeroDataSetCivil.Civil);


        }

        private void CmdQuitter_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=MSI-UBI\MSSQLSERVER01;Initial Catalog=ProjetHero;Integrated Security=True");
        private void CmdCréer_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO Civil (Id_civil,            Nom,                    Prenom,              Adresse,        Date_naissance,          Date_ajout,                Date_modification) " +
                    "VALUES(                      '" + Id.Text + "', '" + Nom.Text + "','" + Prenom.Text + "', '" + Adresse.Text + "', '" + DateTimeNaissance.Text + "', '" + DateTimeAjout.Text + "', '" + DateTimeModif.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
                SDA.SelectCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Le civil a bien été créé");
            }
            catch(Exception i)
            {
                MessageBox.Show(i.Message); 
            }
           
        }

        private void CmdRead_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT * FROM Civil";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void CmdMaj_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "UPDATE Civil SET Nom = '" + Nom.Text + "', Prenom = '" + Prenom.Text + "', Adresse = '" + Adresse.Text + "', Date_naissance = '" + DateTimeNaissance.Text + "', Date_ajout = '" + DateTimeAjout.Text + "', Date_modification = '" + DateTimeModif.Text + "' WHERE Id_civil = '" + Id.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("La modification a bien été prise en compte.");
        }

        private void CmdSupp_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "DELETE FROM Civil where Id_civil = '" + Id.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("L'identifiant a bien été supprimé");
        }

        private void dataGridView1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            Id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Nom.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Prenom.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Adresse.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            DateTimeNaissance.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            //DateTimeDeces.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            DateTimeAjout.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            DateTimeModif.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void DateTimeModif_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
