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
    public partial class AjouterPoste : Form
    {
        public AjouterPoste()
        {
            InitializeComponent();
        }

        private void ButtonRetourAjout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEnregistrerPoste_Click(object sender, EventArgs e)
        {
            //fonction créer poste
            this.Close();
        }
    }
}
