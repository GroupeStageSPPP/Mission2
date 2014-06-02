using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using EntretienSPPP.DB;
using EntretienSPPP.DB.ALGO;




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

            //ajout flo
            comboBoxAP_1.Items.Add("Rechercher Une(des) personne(s)");
            //comboBoxAP_1.Items.Add("Effectuer une statistique");

            comboBoxAS1_1.Items.Add("Personne");
            comboBoxAS1_1.Items.Add("Poste");
            comboBoxAS1_1.Items.Add("Diplôme");
            comboBoxAS1_1.Items.Add("Langue");
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
                listBoxHobbyAjoutEmploye.Items.Clear();
                listBoxFormationAjoutEmploye.Items.Clear();

                RefreshAjoutEmployeFalse();
            }
            private void RefreshAjoutEmployeTrue()
            {
                if ((TextBoxPrenomAjoutEmploye.Text != "") && (textBoxNomAjoutEmploye.Text != "") && (comboBoxSituationFamillaleAjoutEmploye.Text != "") && (textBoxAdresseAjoutEmploye.Text != "") && (maskedTextBoxCodePostalAjoutEmploye.Text != "") && (textBoxVilleAjoutEmploye.Text != "") && (textBoxMailAjoutEmploye.Text != "") && (maskedTextBoxNumerosTelephoneAjoutEmploye.Text != ""))
                {
                    buttonAjouterAncienEmploi.Enabled = true;
                    buttonAjouterHobby.Enabled = true;
                    buttonAjouterDiplome.Enabled = true;
                    buttonAjouterFormation.Enabled = true;
                    buttonAjouterHabilite.Enabled = true;
                    buttonAJouterInaptitude.Enabled = true;
                    buttonAjouterLangue.Enabled = true;
                    buttonAjouterPoste.Enabled = true;

                    listBoxAcienEmploisAjoutEmploye.Enabled = true;
                    listBoxHobbyAjoutEmploye.Enabled = true;
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
                buttonAjouterHobby.Enabled = false;
                buttonAjouterDiplome.Enabled = false;
                buttonAjouterFormation.Enabled = false;
                buttonAjouterHabilite.Enabled = false;
                buttonAJouterInaptitude.Enabled = false;
                buttonAjouterLangue.Enabled = false;
                buttonAjouterPoste.Enabled = false;

                listBoxAcienEmploisAjoutEmploye.Enabled = false;
                listBoxHobbyAjoutEmploye.Enabled = false;
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
                //Recherche
                if (nonEcran == "RECHERCHE_Recherche")
                {
                    panelRECHERCHE.Visible = true;
                }
                else
                {
                    panelRECHERCHE.Visible = false;
                }
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
            #region Recherche
                private void personnesToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    ouvrirEcran("RECHERCHE_Recherche");
                }
                string tableCible = "";
                string champCible = "";
                string valeurCible = "";
                #region FonctionsDiverses
                    private void ViderEtCacherComboBox(ComboBox comboBox, Label label, bool isVisible)
                    {
                        if (isVisible == false)
                        {
                            comboBox.Visible = false;
                            label.Visible = false;
                        }
                        else
                        {
                            comboBox.Visible = true;
                            label.Visible = true;
                        }
                        comboBox.Items.Clear();
                        comboBox.Text = "";
                    }
                    private void RemplirComboBoxes(ComboBox comboBox, Label label, List<string> listeCB)
                    {
                        ViderEtCacherComboBox(comboBox, label, true);

                        foreach (string chaine in listeCB)
                        {
                            comboBox.Items.Add(chaine);
                        }
                    }
                #endregion
                #region AxePrincipal
                    private void comboBoxAP_1_SelectedIndexChanged(object sender, EventArgs e)
                    {
                        string indexChoisi = (string)comboBoxAP_1.SelectedItem;
                        switch (indexChoisi)
                        {
                            case "Rechercher Une(des) personne(s)":
                                //ordre
                                ViderEtCacherComboBox(comboBoxAP_2, labelAP_2, false);
                                comboBoxAS1_1.Visible = true;
                                labelAS1_1.Visible = true;
                                break;
                            case "Effectuer une statistique":
                                RemplirComboBoxes(comboBoxAP_2, labelAP_2, new List<string>() { "Moyenne", "Minimum", "Maximum", "Compter" });
                                comboBoxAS1_1.Visible = false;
                                labelAS1_1.Visible = false;
                                break;
                            default:
                                break;
                        }

                        ViderEtCacherComboBox(comboBoxAP_3, labelAP_3, false);
                    }
                    private void comboBoxAP_2_SelectedIndexChanged(object sender, EventArgs e)
                    {
                        string indexChoisi = (string)comboBoxAP_2.SelectedItem;

                        switch (indexChoisi)
                        {
                            case "Moyenne":
                                RemplirComboBoxes(comboBoxAP_3, labelAP_3, new List<string>() { "Âge" });
                                break;
                            case "Compter":
                                RemplirComboBoxes(comboBoxAP_3, labelAP_3, new List<string>() { "Personnes" });
                                break;
                            case "Minimum":
                                RemplirComboBoxes(comboBoxAP_3, labelAP_3, new List<string>() { "Âge" });
                                break;
                            case "Maximum":
                                RemplirComboBoxes(comboBoxAP_3, labelAP_3, new List<string>() { "Âge" });
                                break;
                            default:
                                break;
                        }
                    }
                    private void comboBoxAP_3_SelectedIndexChanged(object sender, EventArgs e)
                    {
                        comboBoxAS1_1.Visible = true;
                        labelAS1_1.Visible = true;
                    }
                #endregion
                #region AxeSecondaire
                    private void comboBoxAS1_1_SelectedIndexChanged(object sender, EventArgs e)
                    {
                        string indexChoisi = (string)comboBoxAS1_1.SelectedItem;
                        switch (indexChoisi)
                        {
                            case "Personne":
                                RemplirComboBoxes(comboBoxAS1_2, labelAS1_2, new List<string>() { "Nom", "Prénom", "Ville", "Code postal", "Civilité" });
                                break;
                            case "Poste":
                                RemplirComboBoxes(comboBoxAS1_2, labelAS1_2, new List<string>() { "Libelle", "Fonction" });
                                break;
                            case "Diplôme":
                                RemplirComboBoxes(comboBoxAS1_2, labelAS1_2, new List<string>() { "Libelle"/*, "Niveau"*/ });
                                break;
                            case "Langue":
                                RemplirComboBoxes(comboBoxAS1_2, labelAS1_2, new List<string>() { "Libelle" });
                                break;
                            default:
                                break;
                        }

                        ViderEtCacherComboBox(comboBoxAS1_3, labelAS1_3, false);
                    }
                    private void comboBoxAS1_2_SelectedIndexChanged(object sender, EventArgs e)
                {
                    string indexAS1_1 = (string)comboBoxAS1_1.SelectedItem;
                    string indexChoisi = (string)comboBoxAS1_2.SelectedItem;
                    List<string> liste = new List<string>();

                    switch (indexAS1_1)
                    {
                        case "Personne":
                            switch (indexChoisi)
                            {
                                case "Nom":
                                    ViderEtCacherComboBox(comboBoxAS1_3, labelAS1_3, false);
                                    labelAS1_3.Visible = true;
                                    textBoxAS1_3.Visible = true;
                                    textBoxAS1_3.Text = "";

                                    tableCible = "Personne";
                                    champCible = "Nom";
                                    break;
                                case "Prénom":
                                    ViderEtCacherComboBox(comboBoxAS1_3, labelAS1_3, false);
                                    labelAS1_3.Visible = true;
                                    textBoxAS1_3.Visible = true;
                                    textBoxAS1_3.Text = "";

                                    tableCible = "Personne";
                                    champCible = "Prenom";
                                    break;
                                case "Ville":
                                    labelAS1_3.Visible = true;
                                    textBoxAS1_3.Visible = false;
                                    textBoxAS1_3.Text = "";

                                    ViderEtCacherComboBox(comboBoxAS1_3, labelAS1_3, true);
                                    liste = FonctionFlo.GetListChamp("Ville", "Personne");
                                    RemplirComboBoxes(comboBoxAS1_3, labelAS1_3, liste);

                                    tableCible = "Personne";
                                    champCible = "Ville";
                                    break;
                                case "Code postal":
                                    labelAS1_3.Visible = true;
                                    textBoxAS1_3.Visible = false;
                                    textBoxAS1_3.Text = "";

                                    ViderEtCacherComboBox(comboBoxAS1_3, labelAS1_3, true);
                                    liste = FonctionFlo.GetListChamp("CodePostal", "Personne");
                                    RemplirComboBoxes(comboBoxAS1_3, labelAS1_3, liste);

                                    tableCible = "Personne";
                                    champCible = "CodePostal";
                                    break;
                                case "Civilité":
                                    labelAS1_3.Visible = true;
                                    textBoxAS1_3.Visible = false;
                                    textBoxAS1_3.Text = "";

                                    RemplirComboBoxes(comboBoxAS1_3, labelAS1_3, new List<string>() { "Homme", "Femme" });

                                    tableCible = "Genre";
                                    champCible = "Libelle";
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case "Poste":
                            switch (indexChoisi)
                            {
                                case "Libelle":
                                    labelAS1_3.Visible = true;
                                    textBoxAS1_3.Text = "";

                                    ViderEtCacherComboBox(comboBoxAS1_3, labelAS1_3, true);
                                    liste = FonctionFlo.GetListChamp("Libelle", "Poste");
                                    RemplirComboBoxes(comboBoxAS1_3, labelAS1_3, liste);

                                    tableCible = "Poste";
                                    champCible = "Libelle";
                                    break;
                                case "Fonction":
                                    labelAS1_3.Visible = true;
                                    textBoxAS1_3.Visible = false;
                                    textBoxAS1_3.Text = "";

                                    ViderEtCacherComboBox(comboBoxAS1_3, labelAS1_3, true);
                                    liste = FonctionFlo.GetListChamp("Fonction", "Poste");
                                    RemplirComboBoxes(comboBoxAS1_3, labelAS1_3, liste);

                                    tableCible = "Poste";
                                    champCible = "Fonction";
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case "Diplôme":
                            switch (indexChoisi)
                            {
                                case "Libelle":
                                    labelAS1_3.Visible = true;
                                    textBoxAS1_3.Visible = false;
                                    textBoxAS1_3.Text = "";

                                    ViderEtCacherComboBox(comboBoxAS1_3, labelAS1_3, true);
                                    liste = FonctionFlo.GetListChamp("Libelle", "Diplome");
                                    RemplirComboBoxes(comboBoxAS1_3, labelAS1_3, liste);

                                    tableCible = "Diplome";
                                    champCible = "Libelle";
                                    break;
                                //case "Niveau":
                                //    labelAS1_3_2.Visible = false;
                                //    textBoxAS1_3.Visible = false;
                                //    textBoxAS1_3.Text = "";

                                //    ViderEtCacherComboBox(comboBoxAS1_3, labelAS1_3, true);
                                //    liste = FonctionFlo.GetListChamp("Niveau", "Diplome");
                                //    RemplirComboBoxes(comboBoxAS1_3, labelAS1_3, liste);
                                //    break;
                                default:
                                    break;
                            }
                            break;
                        case "Langue":
                            switch (indexChoisi)
                            {
                                case "Libelle":
                                    labelAS1_3.Visible = true;
                                    textBoxAS1_3.Visible = false;
                                    textBoxAS1_3.Text = "";

                                    ViderEtCacherComboBox(comboBoxAS1_3, labelAS1_3, true);
                                    liste = FonctionFlo.GetListChamp("Libelle", "Langue");
                                    RemplirComboBoxes(comboBoxAS1_3, labelAS1_3, liste);

                                    tableCible = "Langue";
                                    champCible = "Libelle";
                                    break;
                                default:
                                    break;
                            }
                            break;
                        default:
                            break;
                    }

                    buttonLancerRecherche.Visible = true;
                }
                #endregion
                private void buttonLancerRecherche_Click(object sender, EventArgs e)
                {
                    //if (comboBoxAS1_3.Text == "" && comboBoxAS1_3.Visible == false)
                    //{
                    //    MessageBox.Show("Requête incomplète.");
                    //}
                    //else if (textBoxAS1_3.Text == "" && textBoxAS1_3.Visible == false)
                    //{
                    //    MessageBox.Show("Requête incomplète.");
                    //}

                    if (comboBoxAS1_3.Text != "" && comboBoxAS1_3.Visible == true)
                    {
                        valeurCible = comboBoxAS1_3.Text;
                    }
                    else if (textBoxAS1_3.Text != "" && textBoxAS1_3.Visible == true)
                    {
                        valeurCible = textBoxAS1_3.Text;
                    }

                    //poste / diplome / langue / civ
                    List<string> requete = new List<string>();
                    requete.Add("select Personne.Identifiant from Personne");
                    requete.Add("inner join POSTE_PERSONNE");
                    requete.Add("on Personne.Identifiant = POSTE_PERSONNE.IdentifiantPersonne");
                    requete.Add("inner join Poste");
                    requete.Add("on Poste.Identifiant = POSTE_PERSONNE.IdentifiantPoste");
                    requete.Add("inner join DIPLOME_PERSONNE");
                    requete.Add("on Personne.Identifiant = DIPLOME_PERSONNE.IdentifiantPersonne");
                    requete.Add("inner join DIPLOME");
                    requete.Add("on DIPLOME.Identifiant = DIPLOME_PERSONNE.IdentifiantDiplome");
                    requete.Add("inner join LANGUE_PERSONNE");
                    requete.Add("on PERSONNE.Identifiant = LANGUE_PERSONNE.IdentifiantPersonne");
                    requete.Add("inner join LANGUE");
                    requete.Add("on Langue.Identifiant = LANGUE_PERSONNE.IdentifiantLangue");
                    requete.Add("inner join GENRE");
                    requete.Add("on Personne.IdentifiantGenre = Genre.Identifiant");
                    requete.Add("where " + tableCible + "." + champCible + " = " + "\'" + valeurCible + "\'");
                    string requeteFinale = "";

                    foreach (string row in requete)
                    {
                        requeteFinale += row + " ";
                    }

                    LancerRequete(requeteFinale);
                }
                private void LancerRequete(string request)
                {
                    //ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["EntretienSPPP"];
                    //SqlConnection connection = new SqlConnection(connectionStringSettings.ToString());
                    SqlConnection connection = DataBase.connection;
                    connection.Open();
                    SqlCommand commande = new SqlCommand(request, connection);

                    SqlDataReader dataReader = commande.ExecuteReader();

                    List<int> listARecup = new List<int>();
                    List<int> listQQCH = new List<int>();

                    while (dataReader.Read())
                    {
                        listARecup.Add(dataReader.GetInt32(0));
                    }
                    dataReader.Close();
                    connection.Close();

                    if (listARecup.Count == 0)
                    {
                        MessageBox.Show("Aucun résultat pour cette recherche.");
                    }
                    else
                    {
                        //winform
                        ResultatRecherche res = new ResultatRecherche(listARecup);

                        res.ShowDialog();
                    }

                }
            #endregion
            #region Statistiques
            #endregion
        #endregion
        #region Fonction de l'onglet : ADMINISTRATION
                #region Employé

                private void buttonADMINISTRATIONAjoutEmployeSuivant_Click(object sender,                EventArgs e)
            {
                Personne personne = new Personne();
                personne.Nom = this.textBoxNomAjoutEmploye.Text;
                personne.Prenom = this.TextBoxPrenomAjoutEmploye.Text;
                personne.DateNaissance = this.dateTimePickerDateNaissanceAjoutEmploye.Value;
                personne.Rue = this.textBoxAdresseAjoutEmploye.Text;
                personne.CodePostal = this.maskedTextBoxCodePostalAjoutEmploye.Text;
                personne.Ville = this.textBoxVilleAjoutEmploye.Text;
                personne.Mail = this.textBoxMailAjoutEmploye.Text;
                personne.Telephone = this.maskedTextBoxNumerosTelephoneAjoutEmploye.Text;

                bool isChecked = this.BoutonRadioMonsieurAjoutEmploye.Checked;
                      if (isChecked)
                         {
                personne.genre = 1;
                         }
                      else
                         {
                personne.genre = 2;
                         }

                 

                 personne.famille = Convert.ToInt32(this.comboBoxSituationFamillaleAjoutEmploye.SelectedValue);
                
                 PersonneDB.Insert(personne);



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
                        this.RefreshListeBoxHabilite();
                        this.RefreshListBoxAncienEmploi();
                        this.RefreshListeDiplomePersonne();
                        this.RefreshLanguePersonne();
                        this.RefreshInaptitudePersonne();
                        this.RefreshPosteActuel();
                        this.refreshCompetencePersonne();



                        this.comboBoxSituationFamillaleAjoutEmploye.DataSource = FamilleDB.List();
                        this.comboBoxSituationFamillaleAjoutEmploye.ValueMember = "Identifiant";
                        this.comboBoxSituationFamillaleAjoutEmploye.DisplayMember = "Libelle";

                    }
                #endregion
                #region RafraichissementListBox
                    private void RefreshListeBoxHabilite()
                    {
                        List<Habilite_Personne> listHabilitePersonne =Habilite_PersonneDB.List();

                        this.listBoxHabilitationAjoutEmploye.DataSource =listHabilitePersonne;
                        this.listBoxHabilitationAjoutEmploye.DisplayMember = "habilite";
                        this.listBoxHabilitationAjoutEmploye.DisplayMember = "organisme";
                        this.listBoxHabilitationAjoutEmploye.ValueMember = "Identifiant";

                    }
                    private void RefreshListBoxAncienEmploi()
                    {
                        List<CV> listAncienEmploi = CVDB.List();
                        this.listBoxAcienEmploisAjoutEmploye.DataSource =listAncienEmploi;
                        this.listBoxAcienEmploisAjoutEmploye.DisplayMember ="Entreprise";
                        this.listBoxAcienEmploisAjoutEmploye.DisplayMember = "Poste";
                        this.listBoxAcienEmploisAjoutEmploye.ValueMember = "Identifiant";
                    }
                    private void RefreshListeDiplomePersonne()
                    {
                        List<Diplome_Personne> ListDIplomePersonne =Diplome_PersonneDB.List();
                        this.listBoxDiplomesAjoutEmploye.DataSource =ListDIplomePersonne;
                        this.listBoxDiplomesAjoutEmploye.DisplayMember = "diplome";
                        this.listBoxDiplomesAjoutEmploye.DisplayMember = "DateObtention";
                        this.listBoxDiplomesAjoutEmploye.ValueMember = "Identifiant";
                    }
                    private void RefreshLanguePersonne()
                    {
                        List<Langue_Personne> listLanguePersonne = Langue_PersonneDB.List                                      ();
                        this.listBoxLangueAjoutEmploye.DataSource = listLanguePersonne;
                        this.listBoxLangueAjoutEmploye.DisplayMember = "langue";
                        this.listBoxLangueAjoutEmploye.DisplayMember = "niveau";
                        this.listBoxLangueAjoutEmploye.ValueMember = "Identifiant";
                    }
                    private void RefreshInaptitudePersonne()
                    {
                        List<Inaptitude_Personne> listInaptitudePersonne =                                                                      Inaptitude_PersonneDB.List();
                        this.listBoxInaptitudeAjoutEmploye.DataSource =                                                                         listInaptitudePersonne;
                        this.listBoxInaptitudeAjoutEmploye.DisplayMember = "inaptitude";
                        this.listBoxInaptitudeAjoutEmploye.DisplayMember = "Definitif";
                        this.listBoxInaptitudeAjoutEmploye.DisplayMember = "DateFin";
                        this.listBoxInaptitudeAjoutEmploye.ValueMember = "Identifiant";
                    }
                    private void RefreshPosteActuel()
                    {
                        List<Poste_Personne> ListPostePersonne = Poste_PersonneDB.List();
                        this.listBoxPosteActuelAjoutEmploye.DataSource =                                                                        ListPostePersonne;
                        this.listBoxPosteActuelAjoutEmploye.DisplayMember = "Contrat";
                        this.listBoxPosteActuelAjoutEmploye.DisplayMember = "poste";
                        this.listBoxPosteActuelAjoutEmploye.DisplayMember ="Coefficient";
                        this.listBoxPosteActuelAjoutEmploye.DisplayMember = "site";
                        this.listBoxPosteActuelAjoutEmploye.ValueMember = "Identifiant";
                    }
                    private void refreshCompetencePersonne()
                {
                    List<Competence> competencePersonne = CompetenceDB.List();
                    this.listBoxHobbyAjoutEmploye.DataSource = competencePersonne;
                    this.listBoxHobbyAjoutEmploye.DisplayMember = "Libelle";
                    this.listBoxHobbyAjoutEmploye.ValueMember = "Identifiant";
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