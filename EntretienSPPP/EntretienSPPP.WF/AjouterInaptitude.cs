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
    public partial class AjouterInaptitude : Form
    {
        public AjouterInaptitude()
        {
            InitializeComponent();
        }

        private void comboBoxTypeInaptitude_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTypeInaptitude.Text == "Autre")
            {
                TextBoxNomInaptitude.Enabled = true;
            }
            else
            {
                TextBoxNomInaptitude.Enabled = false;
            }
        }

        private void radioButtonTemporaire_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonTemporaire.Checked == true)
            {
                label4.Enabled = true;
                dateTimePickerDateFinInaptitude.Enabled = true;
            }
            else
            {
                label4.Enabled = false;
                dateTimePickerDateFinInaptitude.Enabled = false;
            }
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            //fonction ajouter une inaptuitude.
            Close();
        }
    }
}
