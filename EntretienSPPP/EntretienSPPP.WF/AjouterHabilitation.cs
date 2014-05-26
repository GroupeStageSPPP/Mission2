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
    public partial class AjouterHabilitation : Form
    {
        public AjouterHabilitation()
        {
            InitializeComponent();
        }

        #region fonctionsButtons
            private void buttonRetour_Click(object sender, EventArgs e)
            {
                this.Close();
            }
            private void buttonValiderHabilité_Click(object sender, EventArgs e)
        {
            //fonction creer habiliter
            this.Close();
        }
        #endregion

        #region fonctionTextBoxApparition
            private void comboBoxNomOrganisme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNomOrganisme.Text == "Autre")
            {
                textBoxNouveauNom.Enabled = true;
            }
            else
            {
                textBoxNouveauNom.Enabled = false;
            }
        }
        #endregion
    }
}
