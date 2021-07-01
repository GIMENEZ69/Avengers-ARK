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
    public partial class Incident : Form
    {
        public Incident()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4E03TBFV\MYSQL;Initial Catalog=ProjetHero;Integrated Security=True");

        private void CmdValider_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                //string query = "INSERT INTO Incident(Id_incident, Id_Organisation_declarant, Id_super_hero_declarant, Adresse, Commentaire, Date_ajout, Flag_transforme_en_mission)"+
                //    "VALUES('"+
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
    }
}
