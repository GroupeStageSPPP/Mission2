using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EntretienSPPP.DB;

namespace EntretienSPPP.WinForm
{
    public partial class ResultatRecherche : Form
    {
        List<int> listeIdentifiants = new List<int>();

        public ResultatRecherche()
        {
            InitializeComponent();
        }
        public ResultatRecherche(List<int> listeARecup)
        {
            InitializeComponent();

            listeIdentifiants = listeARecup;

            foreach (int identifiant in listeIdentifiants)
            {
                Personne pers = new Personne();
                pers = PersonneDB.Get(identifiant);

                listBoxListePersonne.Items.Add(pers);
            }

            listBoxListePersonne.DisplayMember = "Nom";
            listBoxListePersonne.ValueMember = "Identifiant";
        }

        private void listBoxListePersonne_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
