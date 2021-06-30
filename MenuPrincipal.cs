using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Form.ActiveForm.Close();
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
