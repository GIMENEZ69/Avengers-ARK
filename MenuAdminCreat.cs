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
            SuperHeros superheros = new SuperHeros();
            superheros.ShowDialog();
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
