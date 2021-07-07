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
    public partial class Crise_Heros : Form
    {
        public Crise_Heros()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=AUDREY;Initial Catalog=ProjetHero;Integrated Security=True");

        private void Crise_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSetCriseSH.Mission_superhero'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.mission_superheroTableAdapter.Fill(this.projetHeroDataSetCriseSH.Mission_superhero);
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSetherosmission.Super_hero'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.super_heroTableAdapter.Fill(this.projetHeroDataSetherosmission.Super_hero);
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSetCriseHeros.Civil'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.civilTableAdapter.Fill(this.projetHeroDataSetCriseHeros.Civil);
            CmbSelecRech.SelectedIndex = 0;
        }

       private void Recherche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(Recherche.Text))
                    missionsuperheroBindingSource.Filter = string.Empty;
                else
                    missionsuperheroBindingSource.Filter = string.Format("{0}='{1}'", CmbSelecRech.Text, Recherche.Text);
            }
        }

        private void CmdSelect_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgrv in dataGridView2.Rows)
            {
                int id = Convert.ToInt32(dgrv.Cells[0].Value);
                IdMission.Text = id.ToString(); 
                NomSH.Text = dgrv.Cells[1].Value.ToString();
                break;
            }
        }

        private void CmdValider_Click(object sender, EventArgs e)
        {
            MessageBox.Show("L'identité d'un héros a été démasquée");
            //Crise_Heros.ActiveForm.Close();
            //MenuPrincipal menuPrincipal = new MenuPrincipal();
            //menuPrincipal.ShowDialog();
        }

        private void CmdIdSH_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Id_super_hero FROM Super_hero WHERE Nom_hero = '" + NomSH.Text + "'", conn);
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            IdSH.Text = result.ToString();
        }
    }
}
