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
           
            InitializeComponent();
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAjouterCompétence_Click(object sender, EventArgs e)
        {
            Competence_Personne competencePersonne = new Competence_Personne();
            competencePersonne.personne = PersonneDB.LastID();
            Competence_PersonneDB.Insert(competencePersonne);
            this.Close();
        }
    }
}
