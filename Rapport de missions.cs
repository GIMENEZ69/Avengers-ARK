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
    public partial class Rapport_de_missions : Form
    {
        public Rapport_de_missions()
        {
            InitializeComponent();
        }

        private void Rapport_de_missions_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSetNomSVRapportMission.Super_vilain'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.super_vilainTableAdapter.Fill(this.projetHeroDataSetNomSVRapportMission.Super_vilain);

        }
    }
}
