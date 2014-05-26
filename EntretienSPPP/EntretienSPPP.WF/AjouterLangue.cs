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
    public partial class AjouterLangue : Form
    {
        public AjouterLangue()
        {
            InitializeComponent();
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            //Fonction creer une langue.
            Close();
        }

        private void comboBoxLangue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLangue.Text == "Autre")
            {
                textBoxAjoutLangue.Enabled = true;
            }
            else 
            {
                textBoxAjoutLangue.Enabled = false;
            }
        }
    }
}
