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
    public partial class AjouterCompetence : Form
    {
        public AjouterCompetence()
        {
            InitializeComponent();
        }

        private void comboBoxCompétences_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCompétences.Text == "Autre")
            {
                textBoxNomNewCompetence.Enabled = true;
            }
            else
            {
                textBoxNomNewCompetence.Enabled = false;
            }
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAjouterCompétence_Click(object sender, EventArgs e)
        {
            //Fonction créer une compétence
            this.Close();
        }
    }
}
