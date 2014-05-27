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
    public partial class AjouterFormation : Form
    {
        public AjouterFormation()
        {
            InitializeComponent();
        }

        private void comboBoxListeNomOrganisme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxListeNomOrganisme.Text == "Autre")
            {
                textBoxNomOrganisme.Visible = true;
            }
            else
            {
                textBoxNomOrganisme.Visible = false;
            }
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            Formation_Personne formation = new Formation_Personne();

            formation.personne.Identifiant = PersonneDB.LastID();
            formation.formation.Titre =   textBoxTitreFormation.Text;
            formation.organisme.Identifiant = Convert.ToInt32                                                      (this.comboBoxListeNomOrganisme.SelectedValue);

            if (this.comboBoxListeNomOrganisme.SelectedValue == "Autre")
            {
                Organisme organisme = new Organisme();
                organisme.Libelle = textBoxNomOrganisme.Text;
                OrganismeDB.Insert(organisme);

            }
            //formation.Annee = this.textBoxAnnée.Text;
            formation.formation.Objectif = this.textBoxObjectifFOrmation.Text;
            formation.Contenu = this.comboBoxNoteContenu.SelectedText;
            formation.Formateur = this.comboBoxNoteFOrmateur.SelectedText;

            bool isChecked = this.radioButtonUtile.Checked;
            if (isChecked)
            {
                //formation..Identifiant = 1;
            }
            else
            {
                //formation..Identifiant = 2;
            }
            formation.Documentation = this.comboBoxNoteDocumentation.SelectedText;
            
            
            Close();
        }

    }
}
