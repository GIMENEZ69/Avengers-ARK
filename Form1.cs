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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'avengersDBDataSet10.Civils'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.civilsTableAdapter.Fill(this.avengersDBDataSet10.Civils);
            // TODO: cette ligne de code charge les données dans la table 'avengersDBDataSet9.SuperHeros'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.superHerosTableAdapter.Fill(this.avengersDBDataSet9.SuperHeros);

        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TKJHI8I;Initial Catalog=AvengersDB;Integrated Security=True");

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
    }
}
