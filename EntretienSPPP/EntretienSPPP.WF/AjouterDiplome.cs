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

            diplome_personne.diplome = Convert.ToInt32(this.comboBoxIntituléDiplôme.SelectedValue);
            diplome_personne.DateObtention = this.dateTimePicker1.Value;
            diplome_personne.diplome = Convert.ToInt32(this.comboBoxNiveauDiplôme.SelectedValue);


            if (this.comboBoxNiveauDiplôme.SelectedValue == "Autre")
            {
                Niveau niveau = new Niveau();
                niveau.Libelle = this.textBoxNiveauAjout.Text;
                NiveauDB.Insert(niveau);
            }

            if (this.comboBoxIntituléDiplôme.SelectedValue == "Autre")
            {
                Diplome NewDiplome = new Diplome();
                NewDiplome.Libelle = this.textBoxIntituléAjout.Text;
                NewDiplome.niveau = NiveauDB.LastID();
                DiplomeDB.Insert(NewDiplome);
            }

            Diplome_PersonneDB.Insert(diplome_personne);

            Close();
        }
    }
}
