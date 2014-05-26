namespace EntretienSPPP.WinForm
{
    partial class AjouterAncienEmplois
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterAncienEmplois));
            this.textBoxIntituleDuPoste = new System.Windows.Forms.TextBox();
            this.textBoxEntreprise = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonConfirmerAjoutEmploi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDateDebutAncienEmploi = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateFinAncienEmploi = new System.Windows.Forms.DateTimePicker();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.InformationPerso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxIntituleDuPoste
            // 
            this.textBoxIntituleDuPoste.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.textBoxIntituleDuPoste.Location = new System.Drawing.Point(12, 93);
            this.textBoxIntituleDuPoste.Name = "textBoxIntituleDuPoste";
            this.textBoxIntituleDuPoste.Size = new System.Drawing.Size(200, 21);
            this.textBoxIntituleDuPoste.TabIndex = 17;
            // 
            // textBoxEntreprise
            // 
            this.textBoxEntreprise.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.textBoxEntreprise.Location = new System.Drawing.Point(12, 53);
            this.textBoxEntreprise.Name = "textBoxEntreprise";
            this.textBoxEntreprise.Size = new System.Drawing.Size(200, 21);
            this.textBoxEntreprise.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label4.Location = new System.Drawing.Point(9, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Intitulé du poste";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label3.Location = new System.Drawing.Point(9, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nom de l\'entreprise";
            // 
            // buttonConfirmerAjoutEmploi
            // 
            this.buttonConfirmerAjoutEmploi.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.buttonConfirmerAjoutEmploi.Location = new System.Drawing.Point(346, 120);
            this.buttonConfirmerAjoutEmploi.Name = "buttonConfirmerAjoutEmploi";
            this.buttonConfirmerAjoutEmploi.Size = new System.Drawing.Size(75, 22);
            this.buttonConfirmerAjoutEmploi.TabIndex = 13;
            this.buttonConfirmerAjoutEmploi.Text = "Enregister";
            this.buttonConfirmerAjoutEmploi.UseVisualStyleBackColor = true;
            this.buttonConfirmerAjoutEmploi.Click += new System.EventHandler(this.buttonConfirmerAjoutEmploi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label2.Location = new System.Drawing.Point(237, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Date de fin :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label1.Location = new System.Drawing.Point(237, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Date de début :";
            // 
            // dateTimePickerDateDebutAncienEmploi
            // 
            this.dateTimePickerDateDebutAncienEmploi.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.dateTimePickerDateDebutAncienEmploi.Location = new System.Drawing.Point(240, 53);
            this.dateTimePickerDateDebutAncienEmploi.Name = "dateTimePickerDateDebutAncienEmploi";
            this.dateTimePickerDateDebutAncienEmploi.Size = new System.Drawing.Size(181, 21);
            this.dateTimePickerDateDebutAncienEmploi.TabIndex = 10;
            // 
            // dateTimePickerDateFinAncienEmploi
            // 
            this.dateTimePickerDateFinAncienEmploi.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.dateTimePickerDateFinAncienEmploi.Location = new System.Drawing.Point(240, 93);
            this.dateTimePickerDateFinAncienEmploi.Name = "dateTimePickerDateFinAncienEmploi";
            this.dateTimePickerDateFinAncienEmploi.Size = new System.Drawing.Size(181, 21);
            this.dateTimePickerDateFinAncienEmploi.TabIndex = 9;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.buttonAnnuler.Location = new System.Drawing.Point(12, 120);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 22);
            this.buttonAnnuler.TabIndex = 18;
            this.buttonAnnuler.Text = "Retour";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // InformationPerso
            // 
            this.InformationPerso.AutoSize = true;
            this.InformationPerso.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.InformationPerso.Location = new System.Drawing.Point(166, 9);
            this.InformationPerso.Name = "InformationPerso";
            this.InformationPerso.Size = new System.Drawing.Size(124, 17);
            this.InformationPerso.TabIndex = 26;
            this.InformationPerso.Text = "Ancien emplois";
            // 
            // AjouterAncienEmplois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(433, 154);
            this.Controls.Add(this.InformationPerso);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.textBoxIntituleDuPoste);
            this.Controls.Add(this.textBoxEntreprise);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonConfirmerAjoutEmploi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerDateDebutAncienEmploi);
            this.Controls.Add(this.dateTimePickerDateFinAncienEmploi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(433, 154);
            this.MinimumSize = new System.Drawing.Size(433, 154);
            this.Name = "AjouterAncienEmplois";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AjouterAncienEmplois";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIntituleDuPoste;
        private System.Windows.Forms.TextBox textBoxEntreprise;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonConfirmerAjoutEmploi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateDebutAncienEmploi;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateFinAncienEmploi;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Label InformationPerso;
    }
}