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
            Poste_Personne PostePersonne = new Poste_Personne();

            PostePersonne.personne = PersonneDB.LastID();
            PostePersonne.poste = Convert.ToInt32(this.comboBoxIntituléPoste.SelectedValue);
            PostePersonne.Contrat = this.comboBoxTypeContrat.SelectedText;
            PostePersonne.DateDebut = this.dateTimePickerDateDebutPoste.Value;
            PostePersonne.DateFin = this.dateTimePickerDateFinPoste.Value;
            PostePersonne.site = Convert.ToInt32(this.comboBoxSite.SelectedValue);
            PostePersonne.Statut = this.comboBoxStatus.SelectedText;
            PostePersonne.Coefficient = Convert.ToInt32(this.textBoxCoefficient.Text);

            Poste_PersonneDB.Insert(PostePersonne);
            
            this.Close();
        }
    }
}
