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
    public partial class Crise_Vilain : Form
    {
        public Crise_Vilain()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=AUDREY;Initial Catalog=ProjetHero;Integrated Security=True");

        private void Crise_Vilain_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSetCriseSuperVilain.Mission_supervilain'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.mission_supervilainTableAdapter.Fill(this.projetHeroDataSetCriseSuperVilain.Mission_supervilain);

        }

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

    }
}
