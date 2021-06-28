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
    public partial class SuperHeros : Form
    {
        public SuperHeros()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'avengersDBDataSetFKIdCivils.Civils'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.civilsTableAdapter.Fill(this.avengersDBDataSetFKIdCivils.Civils);
            // TODO: cette ligne de code charge les données dans la table 'avengersDBDataSetSuperHeros.SuperHeros'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.superHerosTableAdapter.Fill(this.avengersDBDataSetSuperHeros.SuperHeros);
            // TODO: cette ligne de code charge les données dans la table 'avengersDBDataSet.Civils'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4E03TBFV\MYSQL;Initial Catalog=AvengersDB;Integrated Security=True");


        private void CmdCréer_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "INSERT INTO SuperHeros (Id_SuperHeros, Nom_SuperHeros, Pouvoir_SuperHeros,          PointFaible_SuperHeros,     Commentaire_SuperHeros, Id_Civils) " +
                "VALUES(                      '" + Id.Text + "', '" + Nom.Text + "','" + Pouvoir.Text + "', '" + PointFaible.Text + "', '" + Commentaire.Text + "', '" + CmbIdCivils.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Le Super-Héros a bien été créé");
        }

        private void CmbIdCivils_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmdRead_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT * FROM SuperHeros";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void CmdMaj_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "UPDATE SuperHeros SET Id_SuperHeros = '" + Id.Text + "', Nom_SuperHeros = '" + Nom.Text + "', Pouvoir_SuperHeros = '" + Pouvoir.Text + "', PointFaible_SuperHeros = '" + PointFaible.Text + "', Commentaire_SuperHeros = '" + Commentaire.Text + "', Id_Civils = '" + CmbIdCivils.Text + "' WHERE Id_SuperHeros = '" + Id.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("La modification a bien été prise en compte.");
        }

        private void CmdSupp_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "DELETE FROM SuperHeros where Id_SuperHeros = '" + Id.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("L'identifiant a bien été supprimé");
        }

        private void CmdQuitter_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Nom.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Pouvoir.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            PointFaible.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            Commentaire.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            CmbIdCivils.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
