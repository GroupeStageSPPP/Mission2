namespace EntretienSPPP.WinForm
{
    partial class AjouterHabilitation
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNouveauNom = new System.Windows.Forms.TextBox();
            this.comboBoxNomOrganisme = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDateFinValidité = new System.Windows.Forms.DateTimePicker();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.buttonValiderHabilité = new System.Windows.Forms.Button();
            this.comboBoxTypeHabilité = new System.Windows.Forms.ComboBox();
            this.InformationPerso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label3.Location = new System.Drawing.Point(156, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "fin de validité";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label2.Location = new System.Drawing.Point(9, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Organisme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Type";
            // 
            // textBoxNouveauNom
            // 
            this.textBoxNouveauNom.Enabled = false;
            this.textBoxNouveauNom.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.textBoxNouveauNom.Location = new System.Drawing.Point(159, 92);
            this.textBoxNouveauNom.Name = "textBoxNouveauNom";
            this.textBoxNouveauNom.Size = new System.Drawing.Size(200, 21);
            this.textBoxNouveauNom.TabIndex = 4;
            // 
            // comboBoxNomOrganisme
            // 
            this.comboBoxNomOrganisme.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.comboBoxNomOrganisme.FormattingEnabled = true;
            this.comboBoxNomOrganisme.Items.AddRange(new object[] {
            "",
            "Test",
            "Autre"});
            this.comboBoxNomOrganisme.Location = new System.Drawing.Point(12, 92);
            this.comboBoxNomOrganisme.Name = "comboBoxNomOrganisme";
            this.comboBoxNomOrganisme.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNomOrganisme.TabIndex = 2;
            this.comboBoxNomOrganisme.SelectedIndexChanged += new System.EventHandler(this.comboBoxNomOrganisme_SelectedIndexChanged);
            // 
            // dateTimePickerDateFinValidité
            // 
            this.dateTimePickerDateFinValidité.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.dateTimePickerDateFinValidité.Location = new System.Drawing.Point(159, 52);
            this.dateTimePickerDateFinValidité.Name = "dateTimePickerDateFinValidité";
            this.dateTimePickerDateFinValidité.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerDateFinValidité.TabIndex = 3;
            // 
            // buttonRetour
            // 
            this.buttonRetour.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.buttonRetour.Location = new System.Drawing.Point(12, 119);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(81, 23);
            this.buttonRetour.TabIndex = 5;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = true;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // buttonValiderHabilité
            // 
            this.buttonValiderHabilité.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.buttonValiderHabilité.Location = new System.Drawing.Point(278, 119);
            this.buttonValiderHabilité.Name = "buttonValiderHabilité";
            this.buttonValiderHabilité.Size = new System.Drawing.Size(81, 23);
            this.buttonValiderHabilité.TabIndex = 6;
            this.buttonValiderHabilité.Text = "Enregistrer";
            this.buttonValiderHabilité.UseVisualStyleBackColor = true;
            this.buttonValiderHabilité.Click += new System.EventHandler(this.buttonValiderHabilité_Click);
            // 
            // comboBoxTypeHabilité
            // 
            this.comboBoxTypeHabilité.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.comboBoxTypeHabilité.FormattingEnabled = true;
            this.comboBoxTypeHabilité.Location = new System.Drawing.Point(12, 52);
            this.comboBoxTypeHabilité.Name = "comboBoxTypeHabilité";
            this.comboBoxTypeHabilité.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTypeHabilité.TabIndex = 1;
            // 
            // InformationPerso
            // 
            this.InformationPerso.AutoSize = true;
            this.InformationPerso.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.InformationPerso.Location = new System.Drawing.Point(145, 9);
            this.InformationPerso.Name = "InformationPerso";
            this.InformationPerso.Size = new System.Drawing.Size(95, 17);
            this.InformationPerso.TabIndex = 27;
            this.InformationPerso.Text = "Habilitation";
            // 
            // AjouterHabilitation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(371, 154);
            this.Controls.Add(this.InformationPerso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNouveauNom);
            this.Controls.Add(this.comboBoxNomOrganisme);
            this.Controls.Add(this.dateTimePickerDateFinValidité);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.buttonValiderHabilité);
            this.Controls.Add(this.comboBoxTypeHabilité);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(371, 154);
            this.MinimumSize = new System.Drawing.Size(371, 154);
            this.Name = "AjouterHabilitation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AjouterHabilite_Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNouveauNom;
        private System.Windows.Forms.ComboBox comboBoxNomOrganisme;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateFinValidité;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.Button buttonValiderHabilité;
        private System.Windows.Forms.ComboBox comboBoxTypeHabilité;
        private System.Windows.Forms.Label InformationPerso;
    }
}