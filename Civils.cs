﻿using System;
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
    public partial class Civils : Form
    {
        public Civils()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSetCivil.Civil'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.civilTableAdapter.Fill(this.projetHeroDataSetCivil.Civil);


        }

        private void CmdQuitter_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=AUDREY;Initial Catalog=ProjetHero;Integrated Security=True");
        private void CmdCréer_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "INSERT INTO Civil (Id_civil,            Nom,                    Prenom,              Adresse,        Date_naissance,            Date_deces,          Date_ajout,                Date_modification) " +
                "VALUES(                      '" + Id.Text + "', '" + Nom.Text + "','" + Prenom.Text + "', '" + Adresse.Text + "', '" + Convert.ToDateTime(DateTimeNaissance.Value) + "', '" + Convert.ToDateTime(DateTimeDeces.Value) + "', '" + Convert.ToDateTime(DateTimeAjout.Value) + "', '" + Convert.ToDateTime(DateTimeModif.Value) + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Le civil a bien été créé");
        }

        private void CmdRead_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT * FROM Civil";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void CmdMaj_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "UPDATE Civil SET Nom = '" + Nom.Text + "', Prenom = '" + Prenom.Text + "', Adresse = '" + Adresse.Text + "', Date_naissance = '" + Convert.ToDateTime(DateTimeNaissance.Value) + "', Date_deces = '" + Convert.ToDateTime(DateTimeDeces.Value) + "', Date_ajout = '" + Convert.ToDateTime(DateTimeAjout.Value) + "', Date_modification = '" + Convert.ToDateTime(DateTimeModif.Value) + "' WHERE Id_civil = '" + Id.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("La modification a bien été prise en compte.");
        }

        private void CmdSupp_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "DELETE FROM Civil where Id_civil = '" + Id.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("L'identifiant a bien été supprimé");
        }

        private void dataGridView1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            Id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Nom.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Prenom.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Adresse.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            DateTimeNaissance.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            DateTimeDeces.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            DateTimeAjout.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            DateTimeModif.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
        }
    }
}
