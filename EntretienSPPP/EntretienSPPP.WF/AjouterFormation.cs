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
            Formation_Personne formation_personne = new Formation_Personne();
            Formation formation = new Formation();

            formation_personne.personne = PersonneDB.LastID();
            formation.Titre = textBoxTitreFormation.Text;
            formation_personne.organisme = Convert.ToInt32(this.comboBoxListeNomOrganisme.SelectedValue);

            if (this.comboBoxListeNomOrganisme.SelectedValue == "Autre")
            {
                Organisme organisme = new Organisme();
                organisme.Libelle = textBoxNomOrganisme.Text;
                OrganismeDB.Insert(organisme);

            }
            //formation.Annee = this.textBoxAnnée.Text;
            formation.Objectif = this.textBoxObjectifFOrmation.Text;
            formation_personne.Contenu = this.comboBoxNoteContenu.SelectedText;
            formation_personne.Formateur = this.comboBoxNoteFOrmateur.SelectedText;

            bool isChecked = this.radioButtonUtile.Checked;
            if (isChecked)
            {
                //formation..Identifiant = 1;
            }
            else
            {
                //formation..Identifiant = 2;
            }
            formation_personne.Documentation = this.comboBoxNoteDocumentation.SelectedText;
            
            
            Close();
        }

    }
}
