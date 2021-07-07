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
    public partial class Crise_Civil : Form
    {
        public Crise_Civil()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=AUDREY;Initial Catalog=ProjetHero;Integrated Security=True");

        private void Crise_Civil_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSetCivil.Civil'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.civilTableAdapter.Fill(this.projetHeroDataSetCivil.Civil);
            CmbSelecRech.SelectedIndex = 0;
        }

        private void CmdSelect_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgrv in dataGridView1.Rows)
            {
                IdCivil.Text = dgrv.Cells[0].Value.ToString();
                NomCivilMort.Text = dgrv.Cells[1].Value.ToString();
                DateDeces.Text = dgrv.Cells[5].Value.ToString();
                break;
            }
        }

        private void Recherche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(Recherche.Text))
                    civilBindingSource.Filter = string.Empty;
                else
                    civilBindingSource.Filter = string.Format("{0}='{1}'", CmbSelecRech.Text, Recherche.Text);
            }
        }

        private void CmdValider_Click(object sender, EventArgs e)
        {
            if (CmbProces.SelectedIndex == 0)
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Crise (Id_crise, Id_mission, Id_litige, Dommages_collateraux)" +
                        "VALUES('" + IdCrise.Text + "', '" + IdMission.Text + "','" + IdLitige.Text + "', '" + CoutDommage.Text + "')";
                    SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
                    SDA.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("La crise a bien ete créée");
                    conn.Close();

                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);

                }
                Litige litige = new Litige();
                litige.ShowDialog();
            }
            else
            {
                MessageBox.Show("Crise créée");
                PageChoixAdmin pagechoixadmin = new PageChoixAdmin();
                pagechoixadmin.ShowDialog();
            }
        }

        private void CmdIdMission_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Id_mission FROM mission WHERE Id_civil = '" + IdCivil.Text + "'", conn);
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            IdMission.Text = result.ToString();
        }
    }
}
