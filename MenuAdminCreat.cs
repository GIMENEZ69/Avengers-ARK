/**
 * Titre : Avengers
 * Créer par : RG / AS / DC / KT
 * Date : 06/07/2021
 **/
using System;
using System.Windows.Forms;

namespace Avergers
{
    public partial class MenuAdminCreat : Form
    {
        public MenuAdminCreat()
        {
            InitializeComponent();
        }

        private void CmdCivils_Click(object sender, EventArgs e)
        {
            Civils civil = new Civils();
            civil.ShowDialog();
        }

        private void CmdQuitter_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void CmdSH_Click(object sender, EventArgs e)
        {
            SuperHeros superHeros = new SuperHeros();
            superHeros.ShowDialog();
        }

        private void CmdSV_Click(object sender, EventArgs e)
        {
            SuperVilains supervilains = new SuperVilains();
            supervilains.ShowDialog();
        }

        private void CmdOrg_Click(object sender, EventArgs e)
        {
            Organisations org = new Organisations();
            org.ShowDialog();
        }
    }
}
