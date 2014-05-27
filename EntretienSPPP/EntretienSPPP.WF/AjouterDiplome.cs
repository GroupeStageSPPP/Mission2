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
            Diplome_Personne diplome_personne = new Diplome_Personne();

            //diplome.diplome.Identifiant = Convert.ToInt32(this.comboxDiplome.SelectedValue);
            //diplome.DateObtention = this.DateTime.selectValue;
            diplome_personne.diplome = Convert.ToInt32(this.comboBoxNiveauDiplôme.SelectedValue);


            if (this.comboBoxNiveauDiplôme.SelectedValue == "Autre")
            {
                Niveau niveau = new Niveau();
                //niveau.Libelle = this..Text;
                NiveauDB.Insert(niveau);
            }

            //if (this.comboBoxDiplôme.SelectedValue == "Autre")
            //{
            //    Diplome NewDiplome = new Diplome();
            //    NewDiplome.Libelle = textBoxIntituléDiplôme.Text;
            //    diplome.diplome.niveau = NiveauDB.LastID();      
            //    DiplomeDB.Insert(NewDiplome);
            //}

            Diplome_PersonneDB.Insert(diplome_personne);

            Close();
        }
    }
}
