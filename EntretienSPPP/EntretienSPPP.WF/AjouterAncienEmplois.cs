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
    public partial class AjouterAncienEmplois : Form
    {
        public AjouterAncienEmplois()
        {
           
            InitializeComponent();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmerAjoutEmploi_Click(object sender, EventArgs e)
        {
            CV ancienEmploi = new CV();
            ancienEmploi.personne = PersonneDB.LastID();
            ancienEmploi.Entreprise = this.textBoxEntreprise.Text;
            ancienEmploi.Poste = this.textBoxIntituleDuPoste.Text;
            ancienEmploi.DateDeb = this.dateTimePickerDateDebutAncienEmploi.Value;
            ancienEmploi.DateFin = this.dateTimePickerDateFinAncienEmploi.Value;
            //ancienEmploi.Secteur = this.dateTimePickerDateFinAncienEmploi;

            CVDB.Insert(ancienEmploi);



            this.Close();
        }
    }
}
