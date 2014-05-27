using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntretienSPPP.DB;

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
            Langue_Personne languePersonne = new Langue_Personne();

            languePersonne.personne = PersonneDB.LastID();

            languePersonne.langue = Convert.ToInt32(this.comboBoxLangue.SelectedValue);

            languePersonne.Niveau = this.comboBoxNiveauLangue.SelectedText;

            //languePersonne.Utilite = ;

            if (this.comboBoxLangue.SelectedValue == "Autre")
            {
                Langue NewLangue = new Langue();
                NewLangue.Libelle = this.textBoxAjoutLangue.Text;
                LangueDB.CreateLangue(NewLangue);
                languePersonne.langue = LangueDB.LastID(); 

            }

            Langue_PersonneDB.Insert(languePersonne);

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
