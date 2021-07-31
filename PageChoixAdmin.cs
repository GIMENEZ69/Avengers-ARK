/**
 * Titre : Avengers
 * Créer par : RG / AS / DC / KT
 * Date : 06/07/2021
 **/
using System;
using System.Windows.Forms;

namespace Avergers
{
    public partial class PageChoixAdmin : Form
    {
        public PageChoixAdmin()
        {
            InitializeComponent();
        }

        private void CmdCreation_Click(object sender, EventArgs e)
        {
            MenuAdminCreat creation = new MenuAdminCreat();
            creation.ShowDialog();
        }

        private void CmdQuitter_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void CmdGestion_Click(object sender, EventArgs e)
        {
            Missions mission = new Missions();
            mission.ShowDialog();
        }
    }
}
