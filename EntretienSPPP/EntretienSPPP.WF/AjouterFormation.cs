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
    public partial class AjouterFormation : Form
    {
        public AjouterFormation()
        {
            InitializeComponent();
        }

        private void comboBoxListeNomOrganisme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxListeNomOrganisme.Text == "Autre")
            {
                textBoxNomOrganisme.Visible = true;
            }
            else
            {
                textBoxNomOrganisme.Visible = false;
            }
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            //Fonction creer une formation
            Close();
        }

    }
}
