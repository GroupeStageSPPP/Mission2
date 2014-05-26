namespace EntretienSPPP.WinForm
{
    partial class AjouterInaptitude
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterInaptitude));
            this.dateTimePickerDateFinInaptitude = new System.Windows.Forms.DateTimePicker();
            this.labelCommentaires = new System.Windows.Forms.Label();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.radioButtonDéfinitif = new System.Windows.Forms.RadioButton();
            this.radioButtonTemporaire = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCommentaire = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxNomInaptitude = new System.Windows.Forms.TextBox();
            this.comboBoxTypeInaptitude = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InformationPerso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePickerDateFinInaptitude
            // 
            this.dateTimePickerDateFinInaptitude.Enabled = false;
            this.dateTimePickerDateFinInaptitude.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateFinInaptitude.Location = new System.Drawing.Point(167, 103);
            this.dateTimePickerDateFinInaptitude.Name = "dateTimePickerDateFinInaptitude";
            this.dateTimePickerDateFinInaptitude.Size = new System.Drawing.Size(218, 21);
            this.dateTimePickerDateFinInaptitude.TabIndex = 25;
            // 
            // labelCommentaires
            // 
            this.labelCommentaires.AutoSize = true;
            this.labelCommentaires.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommentaires.Location = new System.Drawing.Point(12, 129);
            this.labelCommentaires.Name = "labelCommentaires";
            this.labelCommentaires.Size = new System.Drawing.Size(91, 13);
            this.labelCommentaires.TabIndex = 24;
            this.labelCommentaires.Text = "Commentaires";
            // 
            // buttonRetour
            // 
            this.buttonRetour.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetour.Location = new System.Drawing.Point(10, 267);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(93, 23);
            this.buttonRetour.TabIndex = 23;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = true;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouter.Location = new System.Drawing.Point(292, 267);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(93, 23);
            this.buttonAjouter.TabIndex = 22;
            this.buttonAjouter.Text = "Enregistrer";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // radioButtonDéfinitif
            // 
            this.radioButtonDéfinitif.AutoSize = true;
            this.radioButtonDéfinitif.Checked = true;
            this.radioButtonDéfinitif.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDéfinitif.Location = new System.Drawing.Point(15, 82);
            this.radioButtonDéfinitif.Name = "radioButtonDéfinitif";
            this.radioButtonDéfinitif.Size = new System.Drawing.Size(69, 17);
            this.radioButtonDéfinitif.TabIndex = 21;
            this.radioButtonDéfinitif.TabStop = true;
            this.radioButtonDéfinitif.Text = "Définitif";
            this.radioButtonDéfinitif.UseVisualStyleBackColor = true;
            // 
            // radioButtonTemporaire
            // 
            this.radioButtonTemporaire.AutoSize = true;
            this.radioButtonTemporaire.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTemporaire.Location = new System.Drawing.Point(15, 105);
            this.radioButtonTemporaire.Name = "radioButtonTemporaire";
            this.radioButtonTemporaire.Size = new System.Drawing.Size(91, 17);
            this.radioButtonTemporaire.TabIndex = 20;
            this.radioButtonTemporaire.Text = "Temporaire";
            this.radioButtonTemporaire.UseVisualStyleBackColor = true;
            this.radioButtonTemporaire.CheckedChanged += new System.EventHandler(this.radioButtonTemporaire_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Durée";
            // 
            // textBoxCommentaire
            // 
            this.textBoxCommentaire.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCommentaire.Location = new System.Drawing.Point(12, 145);
            this.textBoxCommentaire.Multiline = true;
            this.textBoxCommentaire.Name = "textBoxCommentaire";
            this.textBoxCommentaire.Size = new System.Drawing.Size(373, 116);
            this.textBoxCommentaire.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Type";
            // 
            // TextBoxNomInaptitude
            // 
            this.TextBoxNomInaptitude.Enabled = false;
            this.TextBoxNomInaptitude.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNomInaptitude.Location = new System.Drawing.Point(167, 42);
            this.TextBoxNomInaptitude.Name = "TextBoxNomInaptitude";
            this.TextBoxNomInaptitude.Size = new System.Drawing.Size(218, 21);
            this.TextBoxNomInaptitude.TabIndex = 15;
            // 
            // comboBoxTypeInaptitude
            // 
            this.comboBoxTypeInaptitude.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTypeInaptitude.FormattingEnabled = true;
            this.comboBoxTypeInaptitude.Items.AddRange(new object[] {
            "",
            "Autre"});
            this.comboBoxTypeInaptitude.Location = new System.Drawing.Point(12, 42);
            this.comboBoxTypeInaptitude.Name = "comboBoxTypeInaptitude";
            this.comboBoxTypeInaptitude.Size = new System.Drawing.Size(149, 21);
            this.comboBoxTypeInaptitude.TabIndex = 14;
            this.comboBoxTypeInaptitude.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeInaptitude_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Fini le :";
            // 
            // InformationPerso
            // 
            this.InformationPerso.AutoSize = true;
            this.InformationPerso.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.InformationPerso.Location = new System.Drawing.Point(146, 9);
            this.InformationPerso.Name = "InformationPerso";
            this.InformationPerso.Size = new System.Drawing.Size(98, 17);
            this.InformationPerso.TabIndex = 28;
            this.InformationPerso.Text = "Inaptitudes";
            // 
            // AjouterInaptitude
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(397, 302);
            this.Controls.Add(this.InformationPerso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerDateFinInaptitude);
            this.Controls.Add(this.labelCommentaires);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.radioButtonDéfinitif);
            this.Controls.Add(this.radioButtonTemporaire);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCommentaire);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxNomInaptitude);
            this.Controls.Add(this.comboBoxTypeInaptitude);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AjouterInaptitude";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AjouterInaptitude";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerDateFinInaptitude;
        private System.Windows.Forms.Label labelCommentaires;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.RadioButton radioButtonDéfinitif;
        private System.Windows.Forms.RadioButton radioButtonTemporaire;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCommentaire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxNomInaptitude;
        private System.Windows.Forms.ComboBox comboBoxTypeInaptitude;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label InformationPerso;
    }
}