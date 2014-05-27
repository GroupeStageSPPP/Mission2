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
    public partial class Acceuil : Form
    {
        public Identification Status { get; set; }

        public Acceuil(Identification entreUtilisateur)
        {
            InitializeComponent();

            Status = new Identification();

            Status.AdminAcess = entreUtilisateur.AdminAcess;
            Status.Identifiant = entreUtilisateur.Identifiant;
            Status.Status = entreUtilisateur.Status;

            if (Status.AdminAcess == true)
            {
                administrationToolStripMenuItem.Enabled = true;
            }
            else
            {
                administrationToolStripMenuItem.Enabled = false;
            }
        }
        private void Acceuil_Load(object sender, EventArgs e)
        {
            ouvrirEcran("Acceuil");
        }

        #region Fonctions
            private void viderAjoutEmploye() 
            {
                textBoxNomAjoutEmploye.Text = "";
                TextBoxPrenomAjoutEmploye.Text = "";
                BoutonRadioMonsieurAjoutEmploye.Checked = true;
                BoutonRadioMadameAjoutEmploye.Checked = false;
                DateTimePicker dateTimePickerToday = new DateTimePicker();
                dateTimePickerDateNaissanceAjoutEmploye.Value = dateTimePickerToday.Value;
                comboBoxSituationFamillaleAjoutEmploye.Text = "";

                textBoxAdresseAjoutEmploye.Text = "";
                maskedTextBoxCodePostalAjoutEmploye.Text = "";
                textBoxVilleAjoutEmploye.Text = "";
                textBoxMailAjoutEmploye.Text = "";
                maskedTextBoxNumerosTelephoneAjoutEmploye.Text = "";

                listBoxHabilitationAjoutEmploye.Items.Clear();
                listBoxAcienEmploisAjoutEmploye.Items.Clear();
                listBoxDiplomesAjoutEmploye.Items.Clear();
                listBoxLangueAjoutEmploye.Items.Clear();
                listBoxInaptitudeAjoutEmploye.Items.Clear();
                listBoxPosteActuelAjoutEmploye.Items.Clear();
                listBoxCompetenceAjoutEmploye.Items.Clear();
                listBoxFormationAjoutEmploye.Items.Clear();

                RefreshAjoutEmployeFalse();
            }
            private void RefreshAjoutEmployeTrue()
            {
                if ((TextBoxPrenomAjoutEmploye.Text != "") && (textBoxNomAjoutEmploye.Text != "") && (comboBoxSituationFamillaleAjoutEmploye.Text != "") && (textBoxAdresseAjoutEmploye.Text != "") && (maskedTextBoxCodePostalAjoutEmploye.Text != "") && (textBoxVilleAjoutEmploye.Text != "") && (textBoxMailAjoutEmploye.Text != "") && (maskedTextBoxNumerosTelephoneAjoutEmploye.Text != ""))
                {
                    buttonAjouterAncienEmploi.Enabled = true;
                    buttonAjouterCompétence.Enabled = true;
                    buttonAjouterDiplome.Enabled = true;
                    buttonAjouterFormation.Enabled = true;
                    buttonAjouterHabilite.Enabled = true;
                    buttonAJouterInaptitude.Enabled = true;
                    buttonAjouterLangue.Enabled = true;
                    buttonAjouterPoste.Enabled = true;

                    listBoxAcienEmploisAjoutEmploye.Enabled = true;
                    listBoxCompetenceAjoutEmploye.Enabled = true;
                    listBoxDiplomesAjoutEmploye.Enabled = true;
                    listBoxFormationAjoutEmploye.Enabled = true;
                    listBoxHabilitationAjoutEmploye.Enabled = true;
                    listBoxInaptitudeAjoutEmploye.Enabled = true;
                    listBoxLangueAjoutEmploye.Enabled = true;
                    listBoxPosteActuelAjoutEmploye.Enabled = true;

                    label19.Enabled = true;
                    label17.Enabled = true;
                    label21.Enabled = true;
                    label15.Enabled = true;
                    label20.Enabled = true;
                    label18.Enabled = true;
                    label14.Enabled = true;
                    label16.Enabled = true;

                    buttonConfirmer.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Veuillez remplir tous les champs");
                }
            }
            private void RefreshAjoutEmployeFalse()
            {
                buttonAjouterAncienEmploi.Enabled = false;
                buttonAjouterCompétence.Enabled = false;
                buttonAjouterDiplome.Enabled = false;
                buttonAjouterFormation.Enabled = false;
                buttonAjouterHabilite.Enabled = false;
                buttonAJouterInaptitude.Enabled = false;
                buttonAjouterLangue.Enabled = false;
                buttonAjouterPoste.Enabled = false;

                listBoxAcienEmploisAjoutEmploye.Enabled = false;
                listBoxCompetenceAjoutEmploye.Enabled = false;
                listBoxDiplomesAjoutEmploye.Enabled = false;
                listBoxFormationAjoutEmploye.Enabled = false;
                listBoxHabilitationAjoutEmploye.Enabled = false;
                listBoxInaptitudeAjoutEmploye.Enabled = false;
                listBoxLangueAjoutEmploye.Enabled = false;
                listBoxPosteActuelAjoutEmploye.Enabled = false;

                label19.Enabled = false;
                label17.Enabled = false;
                label21.Enabled = false;
                label15.Enabled = false;
                label20.Enabled = false;
                label18.Enabled = false;
                label14.Enabled = false;
                label16.Enabled = false;

                buttonConfirmer.Enabled = false;
            }
            private void ouvrirEcran(string nonEcran)
            {
                //Ajouter un employe
                if (nonEcran == "Ajouter_un_employe")
                {
                    panelAjoutemploye.Visible = true;
                }
                else
                {
                    panelAjoutemploye.Visible = false;
                }
                //Ajouter un poste
                if (nonEcran == "Ajouter_un_poste")
                {
                    panelAjoutPoste.Visible = true;
                }
                else
                {
                    panelAjoutPoste.Visible = false;
                }
                //Ajouter une formation
                if (nonEcran == "Ajouter_une_formation")
                {
                    panelAjoutFormation.Visible = true;
                }
                else
                {
                    panelAjoutFormation.Visible = false;
                }
                //Acceuil
                if (nonEcran == "Acceuil")
                {
                    panelAcceuil.Visible = true;
                }
                else
                {
                    panelAcceuil.Visible = false;
                }
                //Nouvel entretien
                if (nonEcran == "Nouvel_Entretien")
                {
                    panelNouvelEntretien.Visible = true;
                }
                else
                {
                    panelNouvelEntretien.Visible = false;
                }
            }
        #endregion
        #region ToolStripMenu
        //Couleur ToolStripMenuItem
            private void optionToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
            {
                optionToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            }
            private void optionToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
            {
                optionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            }
            private void administrationToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
            {
                administrationToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            }
            private void administrationToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
            {
                administrationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            }
            private void toolStripMenuItem1_DropDownOpened(object sender, EventArgs e)
            {
                toolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            }
            private void toolStripMenuItem1_DropDownClosed(object sender, EventArgs e)
            {
                toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            }
            private void entretienToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
            {
                entretienToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            }
            private void entretienToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
            {
                entretienToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            }

        //Fonction de navigation : ToolStripMenuItem
            private void employésToolStripMenuItem_Click(object sender, EventArgs e)
            {
                //  --> ADMINISTRATION/Ajouter_un_employe
                ouvrirEcran("Ajouter_un_employe");
            }
            private void formationToolStripMenuItem_Click(object sender, EventArgs e)
            {
                //  --> ADMINISTRATION/Ajouter_une_formation
                ouvrirEcran("Ajouter_une_formation");
            }
            private void posteToolStripMenuItem_Click(object sender, EventArgs e)
            {
                //  --> ADMINISTRATION/Ajouter_un_poste
                ouvrirEcran("Ajouter_un_poste");
            }
            private void toolStripMenuItem2_Click(object sender, EventArgs e)
            {
                //  --> OPTION/Acceuil
                ouvrirEcran("Acceuil");
            }
            private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
            {
                //  --> ENTRETIEN/Nouveau
                ouvrirEcran("Nouvel_Entretien");
            }
        #endregion

        #region Fonction de l'onglet : ENTRETIEN

        #endregion
        #region Fonction de l'onglet : RECHERCHE

        #endregion
        #region Fonction de l'onglet : ADMINISTRATION
            #region Employé

            private void buttonADMINISTRATIONAjoutEmployeSuivant_Click(object sender,                EventArgs e)
            {
                RefreshAjoutEmployeTrue();
            }
                private void panelAjoutemploye_VisibleChanged(object sender, EventArgs e)
                {
                    if (panelAjoutemploye.Visible == false)
                    {
                        viderAjoutEmploye();
                    }
                    else
                    {
                        viderAjoutEmploye();
                    }
                }
                #region ChargementPAge
                    private void ChargementTermine(object sender, EventArgs e)
                    {
                    //    this.RefreshListeBoxHabilite();
                    //    this.RefreshListBoxAncienEmploi();
                    //    this.RefreshListeDiplomePersonne();
                    //    this.RefreshLanguePersonne();
                    //    this.RefreshInaptitudePersonne();
                    //    this.RefreshPosteActuel();
                    //    this.refreshCompetencePersonne();
                    }
                #endregion
                #region RafraichissementListBox
                    private void RefreshListeBoxHabilite()
                    {
                        List<Habilite_Personne> listHabilitePersonne =                                           Habilite_PersonneDB.List();

                        this.listBoxHabilitationAjoutEmploye.DataSource =                                        listHabilitePersonne;
                        this.listBoxHabilitationAjoutEmploye.DisplayMember = "habilite";
                        this.listBoxHabilitationAjoutEmploye.DisplayMember = "organisme";
                        this.listBoxHabilitationAjoutEmploye.ValueMember = "Identifiant";

                    }
                    private void RefreshListBoxAncienEmploi()
                    {
                        List<CV> listAncienEmploi = CVDB.List();
                        this.listBoxAcienEmploisAjoutEmploye.DataSource =                                        listAncienEmploi;
                        this.listBoxAcienEmploisAjoutEmploye.DisplayMember =                                     "Entreprise";
                        this.listBoxAcienEmploisAjoutEmploye.DisplayMember = "Poste";
                        this.listBoxAcienEmploisAjoutEmploye.ValueMember = "Identifiant";
                    }
                    private void RefreshListeDiplomePersonne()
                    {
                        List<Diplome_Personne> ListDIplomePersonne =                                             Diplome_PersonneDB.List();
                        this.listBoxDiplomesAjoutEmploye.DataSource =                                            ListDIplomePersonne;
                        this.listBoxDiplomesAjoutEmploye.DisplayMember = "diplome";
                        this.listBoxDiplomesAjoutEmploye.DisplayMember = "DateObtention";
                        this.listBoxDiplomesAjoutEmploye.ValueMember = "Identifiant";
                    }
                    private void RefreshLanguePersonne()
                    {
                        List<Langue_Personne> listLanguePersonne = Langue_PersonneDB.List                        ();
                        this.listBoxLangueAjoutEmploye.DataSource = listLanguePersonne;
                        this.listBoxLangueAjoutEmploye.DisplayMember = "langue";
                        this.listBoxLangueAjoutEmploye.DisplayMember = "niveau";
                        this.listBoxLangueAjoutEmploye.ValueMember = "Identifiant";
                    }
                    private void RefreshInaptitudePersonne()
                    {
                        List<Inaptitude_Personne> listInaptitudePersonne =                                       Inaptitude_PersonneDB.List();
                        this.listBoxInaptitudeAjoutEmploye.DataSource =                                          listInaptitudePersonne;
                        this.listBoxInaptitudeAjoutEmploye.DisplayMember = "inaptitude";
                        this.listBoxInaptitudeAjoutEmploye.DisplayMember = "Definitif";
                        this.listBoxInaptitudeAjoutEmploye.DisplayMember = "DateFin";
                        this.listBoxInaptitudeAjoutEmploye.ValueMember = "Identifiant";
                    }
                    private void RefreshPosteActuel()
                    {
                        List<Poste_Personne> ListPostePersonne = Poste_PersonneDB.List();
                        this.listBoxPosteActuelAjoutEmploye.DataSource =                                         ListPostePersonne;
                        this.listBoxPosteActuelAjoutEmploye.DisplayMember = "Contrat";
                        this.listBoxPosteActuelAjoutEmploye.DisplayMember = "poste";
                        this.listBoxPosteActuelAjoutEmploye.DisplayMember =                                      "Coefficient";
                        this.listBoxPosteActuelAjoutEmploye.DisplayMember = "site";
                        this.listBoxPosteActuelAjoutEmploye.ValueMember = "Identifiant";
                    }
                    private void refreshCompetencePersonne()
                {
                    List<Competence> competencePersonne = CompetenceDB.List();
                    this.listBoxCompetenceAjoutEmploye.DataSource = competencePersonne;
                    this.listBoxCompetenceAjoutEmploye.DisplayMember = "Libelle";
                    this.listBoxCompetenceAjoutEmploye.ValueMember = "Identifiant";
                }
                #endregion
                #region fonctionsButtonAjouter
                    private void buttonAjouterAncienEmploi_Click(object sender, EventArgs e)
                    {
                        AjouterAncienEmplois ancienEmplois = new AjouterAncienEmplois();
                        ancienEmplois.ShowDialog();
                    }
                    private void buttonAjouterHabilite_Click(object sender, EventArgs e)
                    {
                        AjouterHabilitation habilite = new AjouterHabilitation();
                        habilite.ShowDialog();
                    }
                    private void buttonAjouterDiplome_Click(object sender, EventArgs e)
                    {
                        AjouterDiplome diplome = new AjouterDiplome();
                        diplome.ShowDialog();
                    }
                    private void buttonAjouterLangue_Click(object sender, EventArgs e)
                    {
                        AjouterLangue langue = new AjouterLangue();
                        langue.ShowDialog();
                    }
                    private void buttonAjouterFormation_Click(object sender, EventArgs e)
                    {
                        AjouterFormation formation = new AjouterFormation();
                        formation.ShowDialog();
                    }
                    private void buttonAjouterCompétence_Click(object sender, EventArgs e)
                    {
                        AjouterCompetence competence = new AjouterCompetence();
                        competence.ShowDialog();
                    }
                    private void buttonAjouterPoste_Click(object sender, EventArgs e)
                    {
                        AjouterPoste poste = new AjouterPoste();
                        poste.ShowDialog();
                    }
                    private void buttonAJouterInaptitude_Click(object sender, EventArgs e)
                    {
                        AjouterInaptitude inaptitude = new AjouterInaptitude();
                        inaptitude.ShowDialog();
                    }
                #endregion
            #endregion
            #region Formation

            #endregion
            #region Postes

            #endregion
        #endregion
        #region Fonction de l'onglet : OPTION
            private void pleinÉcranToolStripMenuItem_Click(object sender, EventArgs e)
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                pleinÉcranToolStripMenuItem.Checked = true;
                fenêtréToolStripMenuItem.Checked = false;
            }
            private void fenêtréToolStripMenuItem_Click(object sender, EventArgs e)
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Maximized;
                pleinÉcranToolStripMenuItem.Checked = false;
                fenêtréToolStripMenuItem.Checked = true;
            }
            #region Accueil
                private void panel11_MouseEnter(object sender, EventArgs e)
                {
                    panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                }
                private void panel11_MouseLeave(object sender, EventArgs e)
                {
                    panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                }

                private void panel12_MouseEnter(object sender, EventArgs e)
                {
                    panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                }
                private void panel12_MouseLeave(object sender, EventArgs e)
                {
                    panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                }

                private void panel13_MouseEnter(object sender, EventArgs e)
                {
                    panel13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                }
                private void panel13_MouseLeave(object sender, EventArgs e)
                {
                    panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                }
            #endregion
        #endregion
        #region Fonction de l'onglet : QUITTER
            private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
            {
                QuitterComfirmation quitter = new QuitterComfirmation();
                quitter.ShowDialog();
            }
        #endregion

        private void statistiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraphiqueMOI graphMoi = new GraphiqueMOI();
            graphMoi.ShowDialog();

            GraphiqueMOD graphMOd = new GraphiqueMOD();
            graphMOd.ShowDialog();

            GraphiqueHierarchie graphHi = new GraphiqueHierarchie();
            graphHi.ShowDialog();

            GraphiqueSatisfaction graphSatisf = new GraphiqueSatisfaction();
            graphSatisf.ShowDialog();
        }

   
    }
}