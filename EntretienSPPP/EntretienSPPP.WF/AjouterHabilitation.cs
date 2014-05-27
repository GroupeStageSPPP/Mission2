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
    public partial class AjouterHabilitation : Form
    {
        public AjouterHabilitation()
        {
            InitializeComponent();
        }

        #region fonctionsButtons
            private void buttonRetour_Click(object sender, EventArgs e)
            {
                this.Close();
            }
            private void buttonValiderHabilité_Click(object sender, EventArgs e)
        {
            
                Habilite_Personne habilité = new Habilite_Personne();
            
            habilité.Identifiant = PersonneDB.LastID();
            habilité.habilite.Identifiant = Convert.ToInt32(this.comboBoxTypeHabilité.SelectedValue);
            habilité.organisme.Identifiant = Convert.ToInt32(this.comboBoxNomOrganisme.SelectedValue);
            habilité.DateFin = this.dateTimePickerDateFinValidité.Value;

            if (this.comboBoxNomOrganisme.Text == "Autre")
            {
                Organisme organisme = new Organisme();
                organisme.Libelle = textBoxNouveauNom.Text;
                OrganismeDB.Insert(organisme);
                habilité.organisme.Identifiant = OrganismeDB.LastID();

            }

            

            Habilite_PersonneDB.Insert(habilité);


            this.Close();
        }
        #endregion

        #region fonctionTextBoxApparition
            private void comboBoxNomOrganisme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNomOrganisme.Text == "Autre")
            {
                textBoxNouveauNom.Enabled = true;
            }
            else
            {
                textBoxNouveauNom.Enabled = false;
            }
        }
        #endregion
    }
}
