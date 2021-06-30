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
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSet3SuperVilainDGV.Super_vilain'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.super_vilainTableAdapter1.Fill(this.projetHeroDataSet3SuperVilainDGV.Super_vilain);
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSet3ComboIdCivilSuperVilain.Civil'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.civilTableAdapter1.Fill(this.projetHeroDataSet3ComboIdCivilSuperVilain.Civil);
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSetFKIdCivil.Civil'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.civilTableAdapter.Fill(this.projetHeroDataSetFKIdCivil.Civil);
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSetVilain.Super_vilain'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.super_vilainTableAdapter.Fill(this.projetHeroDataSetVilain.Super_vilain);

        }

        private void CmdQuitter_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4E03TBFV\MYSQL;Initial Catalog=ProjetHero;Integrated Security=True");
        private void CmdCréer_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "INSERT INTO Super_vilain (Id_super_vilain, Id_civil,                Nom_vilain,         Pouvoir,                Commentaire) " +
                "VALUES(                      '" + Id.Text + "', '" + CmbIdCivil.Text + "', '" + Nom.Text + "','" + Pouvoir.Text + "', '" + Commentaire.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Le Super-Vilain a bien été créé");
        }

        private void CmdRead_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT * FROM Super_vilain";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void CmdMaj_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "UPDATE Super_vilain SET Id_civil = '" + CmbIdCivil.Text + "', Nom_vilain = '" + Nom.Text+"', Pouvoir = '"+Pouvoir.Text+"', Commentaire = '"+Commentaire.Text+"' WHERE Id_super_vilain = '" + Id.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("La modification a bien été prise en compte.");
        }

        private void CmdSupp_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "DELETE FROM Super_vilain where Id_super_vilain = '" + Id.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(" L'identifiant a bien été supprimé");
        }

        private void dataGridView1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            Id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            CmbIdCivil.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Nom.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Pouvoir.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            Commentaire.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
