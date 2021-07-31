/**
 * Titre : Avengers
 * Créer par : RG / AS / DC / KT
 * Date : 06/07/2021
 **/
using System;
using System.Windows.Forms;

namespace Avergers
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void CmdQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CmdUtilisateur_Click(object sender, EventArgs e)
        {
            Utilisateur utilisateur = new Utilisateur();
            utilisateur.ShowDialog();
        }

        private void CmdAdmin_Click(object sender, EventArgs e)
        {
            PageChoixAdmin choixadmin = new PageChoixAdmin();
            choixadmin.ShowDialog();
        }
    }
}
