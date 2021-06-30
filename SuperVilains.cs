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
    public partial class SuperVilains : Form
    {
        public SuperVilains()
        {
            InitializeComponent();
        }

        private void SuperVilains_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'avengersDBDataSetVilains.SuperVilains'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.superVilainsTableAdapter.Fill(this.avengersDBDataSetVilains.SuperVilains);
            // GRIDVIEW : TODO: cette ligne de code charge les données dans la table 'avengersDBDataSetSuperVilains.SuperVilains'. Vous pouvez la déplacer ou la supprimer selon les besoins.

        }

        private void CmdQuitter_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=MSI-UBI\MSSQLSERVER01;Initial Catalog=ProjetHero;Integrated Security=True");
        private void CmdCréer_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "INSERT INTO SuperVilains (Id_super_vilain, Nom_vilain, Degats_SuperVilain, Commentaire_SuperVilains) " +
                "VALUES(                      '" + Id.Text + "', '" + Nom.Text + "','" + Degats.Text + "', '" + Commentaire.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Le Super-Vilain a bien été créé");
        }

        private void CmdRead_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT * FROM SuperVilains";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void CmdMaj_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "UPDATE SuperVilains SET Nom_SuperVilains = '"+ Nom.Text+"', Degats_SuperVilains = '"+Degats.Text+"', Commentaire_SuperVilains = '"+Commentaire.Text+"' WHERE Id_SuperVilains = '" + Id.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("La modification a bien été prise en compte.");
        }

        private void CmdSupp_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "DELETE FROM SuperVilains where Id_SuperVilains = '" + Id.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(" L'identifiant a bien été supprimé");
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Nom.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Degats.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Commentaire.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
           
        }
    }
}
