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
    public partial class AjouterCompetence : Form
    {
        public AjouterCompetence()
        {
            //this.comboBoxCompétences.DataSource = CompetenceDB.List();
            //this.comboBoxCompétences.DisplayMember = "Identifiant";
            //this.comboBoxCompétences.ValueMember = "Libelle";
            InitializeComponent();
        }

        private void comboBoxCompétences_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCompétences.Text == "Autre")
            {
                textBoxNomNewCompetence.Enabled = true;
            }
            else
            {
                textBoxNomNewCompetence.Enabled = false;
            }
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAjouterCompétence_Click(object sender, EventArgs e)
        {
            Competence_Personne competencePersonne = new Competence_Personne();

            competencePersonne.personne.Identifiant = PersonneDB.LastID();
            competencePersonne.competence.Identifiant = Convert.ToInt32                                            (this.comboBoxCompétences.SelectedValue);

            if (this.comboBoxCompétences.SelectedValue == "Autre")
            {
                Competence competence = new Competence();
                competence.Libelle = this.textBoxNomNewCompetence.SelectedText;
                competencePersonne.competence.Identifiant = CompetenceDB.LastID();
            }

            Competence_PersonneDB.Insert(competencePersonne);
            this.Close();
        }
    }
}
