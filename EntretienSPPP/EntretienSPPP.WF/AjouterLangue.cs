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

            this.comboBoxLangue.DataSource = LangueDB.List();
            this.comboBoxLangue.ValueMember = "identifiant";
            this.comboBoxLangue.DisplayMember = "libelle";

            //this.comboBoxNiveauLangue.Items.Add("Survie");
            //this.comboBoxNiveauLangue.Items.Add("Basique");
            //this.comboBoxNiveauLangue.Items.Add("Courant");
            //this.comboBoxNiveauLangue.Items.Add("Bilingue");

            

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

            if (this.checkBoxUtilite.Checked)
            {
                languePersonne.Utilite = 'U';
            }

            else { languePersonne.Utilite = 'I'; }

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
