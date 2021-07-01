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
            Incident incident = new Incident();
            incident.ShowDialog();
        }
    }
}
