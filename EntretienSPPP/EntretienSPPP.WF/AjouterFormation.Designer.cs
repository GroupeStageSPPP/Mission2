namespace EntretienSPPP.WinForm
{
    partial class AjouterFormation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterFormation));
            this.label11 = new System.Windows.Forms.Label();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.comboBoxInterneExterne = new System.Windows.Forms.ComboBox();
            this.comboBoxProgressionFormation = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButtonInutile = new System.Windows.Forms.RadioButton();
            this.radioButtonUtile = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxNoteFOrmateur = new System.Windows.Forms.ComboBox();
            this.comboBoxNoteDocumentation = new System.Windows.Forms.ComboBox();
            this.comboBoxNoteContenu = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTitreFormation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNomOrganisme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxListeNomOrganisme = new System.Windows.Forms.ComboBox();
            this.textBoxObjectifFOrmation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InformationPerso = new System.Windows.Forms.Label();
            this.dateTimePickerDateFormation = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label11.Location = new System.Drawing.Point(12, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 53;
            this.label11.Text = "Date";
            // 
            // buttonRetour
            // 
            this.buttonRetour.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.buttonRetour.Location = new System.Drawing.Point(12, 379);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(78, 23);
            this.buttonRetour.TabIndex = 52;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = true;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAjouter.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.buttonAjouter.Location = new System.Drawing.Point(321, 379);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(78, 23);
            this.buttonAjouter.TabIndex = 51;
            this.buttonAjouter.Text = "Enregistrer";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // comboBoxInterneExterne
            // 
            this.comboBoxInterneExterne.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.comboBoxInterneExterne.FormattingEnabled = true;
            this.comboBoxInterneExterne.Location = new System.Drawing.Point(147, 352);
            this.comboBoxInterneExterne.Name = "comboBoxInterneExterne";
            this.comboBoxInterneExterne.Size = new System.Drawing.Size(121, 21);
            this.comboBoxInterneExterne.TabIndex = 50;
            // 
            // comboBoxProgressionFormation
            // 
            this.comboBoxProgressionFormation.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.comboBoxProgressionFormation.FormattingEnabled = true;
            this.comboBoxProgressionFormation.Location = new System.Drawing.Point(12, 352);
            this.comboBoxProgressionFormation.Name = "comboBoxProgressionFormation";
            this.comboBoxProgressionFormation.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProgressionFormation.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label10.Location = new System.Drawing.Point(144, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Rapport a l\'entreprise";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label9.Location = new System.Drawing.Point(12, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Progression";
            // 
            // radioButtonInutile
            // 
            this.radioButtonInutile.AutoSize = true;
            this.radioButtonInutile.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.radioButtonInutile.Location = new System.Drawing.Point(199, 266);
            this.radioButtonInutile.Name = "radioButtonInutile";
            this.radioButtonInutile.Size = new System.Drawing.Size(61, 17);
            this.radioButtonInutile.TabIndex = 46;
            this.radioButtonInutile.TabStop = true;
            this.radioButtonInutile.Text = "Inutile";
            this.radioButtonInutile.UseVisualStyleBackColor = true;
            // 
            // radioButtonUtile
            // 
            this.radioButtonUtile.AutoSize = true;
            this.radioButtonUtile.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.radioButtonUtile.Location = new System.Drawing.Point(147, 266);
            this.radioButtonUtile.Name = "radioButtonUtile";
            this.radioButtonUtile.Size = new System.Drawing.Size(50, 17);
            this.radioButtonUtile.TabIndex = 45;
            this.radioButtonUtile.TabStop = true;
            this.radioButtonUtile.Text = "Utile";
            this.radioButtonUtile.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label8.Location = new System.Drawing.Point(144, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Utilité";
            // 
            // comboBoxNoteFOrmateur
            // 
            this.comboBoxNoteFOrmateur.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.comboBoxNoteFOrmateur.FormattingEnabled = true;
            this.comboBoxNoteFOrmateur.Location = new System.Drawing.Point(12, 312);
            this.comboBoxNoteFOrmateur.Name = "comboBoxNoteFOrmateur";
            this.comboBoxNoteFOrmateur.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNoteFOrmateur.TabIndex = 43;
            // 
            // comboBoxNoteDocumentation
            // 
            this.comboBoxNoteDocumentation.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.comboBoxNoteDocumentation.FormattingEnabled = true;
            this.comboBoxNoteDocumentation.Location = new System.Drawing.Point(147, 312);
            this.comboBoxNoteDocumentation.Name = "comboBoxNoteDocumentation";
            this.comboBoxNoteDocumentation.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNoteDocumentation.TabIndex = 42;
            // 
            // comboBoxNoteContenu
            // 
            this.comboBoxNoteContenu.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.comboBoxNoteContenu.FormattingEnabled = true;
            this.comboBoxNoteContenu.Location = new System.Drawing.Point(12, 266);
            this.comboBoxNoteContenu.Name = "comboBoxNoteContenu";
            this.comboBoxNoteContenu.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNoteContenu.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label7.Location = new System.Drawing.Point(144, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Documentation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label6.Location = new System.Drawing.Point(12, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Formateur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label5.Location = new System.Drawing.Point(12, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Contenue";
            // 
            // textBoxTitreFormation
            // 
            this.textBoxTitreFormation.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.textBoxTitreFormation.Location = new System.Drawing.Point(147, 83);
            this.textBoxTitreFormation.Name = "textBoxTitreFormation";
            this.textBoxTitreFormation.Size = new System.Drawing.Size(129, 21);
            this.textBoxTitreFormation.TabIndex = 36;
            this.textBoxTitreFormation.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label4.Location = new System.Drawing.Point(12, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Titre";
            // 
            // textBoxNomOrganisme
            // 
            this.textBoxNomOrganisme.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.textBoxNomOrganisme.Location = new System.Drawing.Point(12, 44);
            this.textBoxNomOrganisme.Name = "textBoxNomOrganisme";
            this.textBoxNomOrganisme.Size = new System.Drawing.Size(129, 21);
            this.textBoxNomOrganisme.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Organisme";
            // 
            // comboBoxListeNomOrganisme
            // 
            this.comboBoxListeNomOrganisme.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.comboBoxListeNomOrganisme.FormattingEnabled = true;
            this.comboBoxListeNomOrganisme.Items.AddRange(new object[] {
            "",
            "Autre"});
            this.comboBoxListeNomOrganisme.Location = new System.Drawing.Point(12, 83);
            this.comboBoxListeNomOrganisme.Name = "comboBoxListeNomOrganisme";
            this.comboBoxListeNomOrganisme.Size = new System.Drawing.Size(129, 21);
            this.comboBoxListeNomOrganisme.TabIndex = 30;
            this.comboBoxListeNomOrganisme.SelectedIndexChanged += new System.EventHandler(this.comboBoxListeNomOrganisme_SelectedIndexChanged);
            // 
            // textBoxObjectifFOrmation
            // 
            this.textBoxObjectifFOrmation.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.textBoxObjectifFOrmation.Location = new System.Drawing.Point(12, 162);
            this.textBoxObjectifFOrmation.Multiline = true;
            this.textBoxObjectifFOrmation.Name = "textBoxObjectifFOrmation";
            this.textBoxObjectifFOrmation.Size = new System.Drawing.Size(387, 85);
            this.textBoxObjectifFOrmation.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label1.Location = new System.Drawing.Point(12, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Objectifs";
            // 
            // InformationPerso
            // 
            this.InformationPerso.AutoSize = true;
            this.InformationPerso.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.InformationPerso.Location = new System.Drawing.Point(159, 9);
            this.InformationPerso.Name = "InformationPerso";
            this.InformationPerso.Size = new System.Drawing.Size(87, 17);
            this.InformationPerso.TabIndex = 55;
            this.InformationPerso.Text = "Formation";
            // 
            // dateTimePickerDateFormation
            // 
            this.dateTimePickerDateFormation.Location = new System.Drawing.Point(12, 123);
            this.dateTimePickerDateFormation.Name = "dateTimePickerDateFormation";
            this.dateTimePickerDateFormation.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDateFormation.TabIndex = 56;
            // 
            // AjouterFormation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(411, 414);
            this.Controls.Add(this.dateTimePickerDateFormation);
            this.Controls.Add(this.InformationPerso);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.comboBoxInterneExterne);
            this.Controls.Add(this.comboBoxProgressionFormation);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.radioButtonInutile);
            this.Controls.Add(this.radioButtonUtile);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxNoteFOrmateur);
            this.Controls.Add(this.comboBoxNoteDocumentation);
            this.Controls.Add(this.comboBoxNoteContenu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTitreFormation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNomOrganisme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxListeNomOrganisme);
            this.Controls.Add(this.textBoxObjectifFOrmation);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AjouterFormation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AjouterFormation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.ComboBox comboBoxInterneExterne;
        private System.Windows.Forms.ComboBox comboBoxProgressionFormation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButtonInutile;
        private System.Windows.Forms.RadioButton radioButtonUtile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxNoteFOrmateur;
        private System.Windows.Forms.ComboBox comboBoxNoteDocumentation;
        private System.Windows.Forms.ComboBox comboBoxNoteContenu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTitreFormation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNomOrganisme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxListeNomOrganisme;
        private System.Windows.Forms.TextBox textBoxObjectifFOrmation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label InformationPerso;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateFormation;
    }
}