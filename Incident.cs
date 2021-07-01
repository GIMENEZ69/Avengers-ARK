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
            //try
            //{
            //    conn.Open();
            //    string query = "INSERT INTO Incident(Id_incident, Id_Organisation_declarant, Id_super_hero_declarant, Adresse, Commentaire, Date_ajout, Flag_transforme_en_mission)"+
            //        "VALUES('"+ IdDéclarant.Text+"','"+Nom.Text+"','"+Prenom.Text+"','"+
            //}
            //catch(Exception e1)
            //{
            //    MessageBox.Show(e1.Message);
            //}
        }

        private void Incident_Load(object sender, EventArgs e)
        {
            
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboSearchBy.Text == "Id")
                {
                    conn.Open();
                    string query = "SELECT Id_civil, Nom, Prenom, Adresse, Date_Naissance FROM Civil WHERE Prenom = '"+input+"'";
                    SqlDataAdapter SDA = new SqlDataAdapter(query, conn);

                }
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
    }
}
