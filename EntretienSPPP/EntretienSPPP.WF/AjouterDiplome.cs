using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntretienSPPP.WinForm
{
    public partial class AjouterDiplome : Form
    {
        public AjouterDiplome()
        {
            InitializeComponent();
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonEnregistrerDiplôme_Click(object sender, EventArgs e)
        {
            //Fonction création diplôme
            Close();
        }
    }
}
