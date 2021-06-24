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

        private void SuperHeros_Load(object sender, EventArgs e)
        {
            

        }

        private void CmdQuitter_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TKJHI8I;Initial Catalog=AvengersDB;Integrated Security=True");
        private void CmdCréer_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "INSERT INTO SuperHeros (Id_SuperHeros, Nom_SuperHeros, Pouvoir_SuperHeros,          PointFaible_SuperHeros,     Commentaire_SuperHeros, Id_Civils) " +
                "VALUES(                      '" + Id.Text + "', '" + Nom.Text + "','" + Pouvoir.Text + "', '" + PointFaible.Text + "', '" + Commentaire.Text + "', '"+CmbIdCivils.Text+"')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Le Super-Héros a bien été créé");
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
            string query = "UPDATE SuperHeros SET Nom_SuperHeros = '" + Nom.Text + "', Pouvoir_SuperHeros = '" + Pouvoir.Text + "', PointFaible_SuperHeros = '" + PointFaible.Text+ "', Commentaire_SuperHeros = '" + Commentaire.Text + "', Id_Civils = '"+int.Parse(CmbIdCivils.Text)+"' WHERE Id_SuperHeros = '" + Id.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("La modification a bien été prise en compte.");
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Nom.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Pouvoir.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            PointFaible.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            Commentaire.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            CmbIdCivils.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
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

        private void CmbIdCivils_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT Id_Civils FROM Civils";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            CmbIdCivils.DataSource = dt;
            conn.Close();
        }

        private void civilsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
