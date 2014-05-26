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
    public partial class Identification_Page : Form
    {
        public Identification StatusActuel { get; set; }

        public Identification_Page()
        {
            InitializeComponent();
        }
        private void pictureBoxButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void buttonSeConnecter_Click(object sender, EventArgs e)
        {
            StatusActuel = new Identification();

            //Methode de verification des identifiants  -->  EntretienSPPP.DB/IdentificationDB.cs
            StatusActuel.Status = StatusActuel.Verification(textBoxIdentifiant.Text.ToString(), textBoxMotDePasse.Text.ToString());

            //Methode de verification si accès ADMIN ou non  -->  EntretienSPPP.DB/IdentificationDB.cs
            StatusActuel.AdminAcess = StatusActuel.VerificationAdminAcess(textBoxIdentifiant.Text.ToString());

            //Garde en mémoire l'identifiant de la personne
            StatusActuel.Identifiant = textBoxIdentifiant.Text.ToString();


            //Si la methode de verification des identifiants renvois TRUE, Accès est autorisé et la page Acceuil ce lance.
            if (StatusActuel.Status == true)
            {
                this.Hide();
                Acceuil acceuil = new Acceuil(StatusActuel);
                acceuil.ShowDialog();
                this.Close();
            }
            //Sinon l'accès est refuser et un message d'erreur s'affiche.
            else
            {
                MessageBox.Show("Identifiants incorrect !");
            }
        }
    }
}
