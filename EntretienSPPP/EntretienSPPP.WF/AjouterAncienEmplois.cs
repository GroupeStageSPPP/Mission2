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
    public partial class AjouterAncienEmplois : Form
    {
        public AjouterAncienEmplois()
        {
            InitializeComponent();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmerAjoutEmploi_Click(object sender, EventArgs e)
        {
            //fonction creer Ancien emplois
            this.Close();
        }
    }
}
