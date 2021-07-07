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
    public partial class Litige : Form
    {
        public Litige()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=AUDREY;Initial Catalog=ProjetHero;Integrated Security=True");
        private void Litige_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSetlitige.Crise'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.criseTableAdapter.Fill(this.projetHeroDataSetlitige.Crise);
            CmbSelecRech.SelectedIndex = 0;
        }

        private void CmdProceder_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO Litige (Id_crise, Id_litige, Description, Type, Cout_litige)" +
                    "VALUES('" + IdCrise.Text + "', '" + IdLitige.Text + "','" + Description.Text + "', '" + CmbTypeLitige.Text + "','" + CoutDommage.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
                SDA.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Le litige a bien ete créée");
                conn.Close();
                PageChoixAdmin pagechoixadmin = new PageChoixAdmin();
                pagechoixadmin.ShowDialog();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);

            }
        }


        private void Recherche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(Recherche.Text))
                    criseBindingSource.Filter = string.Empty;
                else
                    criseBindingSource.Filter = string.Format("{0}='{1}'", CmbSelecRech.Text, Recherche.Text);
            }
        }

        private void CmdSelect_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgrv in dataGridView1.Rows)
            {
                IdCrise.Text = dgrv.Cells[0].Value.ToString();
                IdLitige.Text = dgrv.Cells[2].Value.ToString();
                CoutDommage.Text = dgrv.Cells[3].Value.ToString();
                break;
            }
        }
    }
}
