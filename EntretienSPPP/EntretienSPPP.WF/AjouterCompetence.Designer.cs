namespace EntretienSPPP.WinForm
{
    partial class AjouterCompetence
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
            this.textBoxNomNewCompetence = new System.Windows.Forms.TextBox();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.buttonAjouterCompétence = new System.Windows.Forms.Button();
            this.comboBoxCompétences = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InformationPerso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNomNewCompetence
            // 
            this.textBoxNomNewCompetence.Enabled = false;
            this.textBoxNomNewCompetence.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomNewCompetence.Location = new System.Drawing.Point(139, 51);
            this.textBoxNomNewCompetence.Name = "textBoxNomNewCompetence";
            this.textBoxNomNewCompetence.Size = new System.Drawing.Size(151, 21);
            this.textBoxNomNewCompetence.TabIndex = 12;
            // 
            // buttonRetour
            // 
            this.buttonRetour.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetour.Location = new System.Drawing.Point(12, 78);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(80, 23);
            this.buttonRetour.TabIndex = 11;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = true;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // buttonAjouterCompétence
            // 
            this.buttonAjouterCompétence.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterCompétence.Location = new System.Drawing.Point(210, 78);
            this.buttonAjouterCompétence.Name = "buttonAjouterCompétence";
            this.buttonAjouterCompétence.Size = new System.Drawing.Size(80, 23);
            this.buttonAjouterCompétence.TabIndex = 9;
            this.buttonAjouterCompétence.Text = "Enregistrer";
            this.buttonAjouterCompétence.UseVisualStyleBackColor = true;
            this.buttonAjouterCompétence.Click += new System.EventHandler(this.buttonAjouterCompétence_Click);
            // 
            // comboBoxCompétences
            // 
            this.comboBoxCompétences.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCompétences.FormattingEnabled = true;
            this.comboBoxCompétences.Items.AddRange(new object[] {
            "",
            "Autre"});
            this.comboBoxCompétences.Location = new System.Drawing.Point(12, 51);
            this.comboBoxCompétences.Name = "comboBoxCompétences";
            this.comboBoxCompétences.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCompétences.TabIndex = 8;
            this.comboBoxCompétences.SelectedIndexChanged += new System.EventHandler(this.comboBoxCompétences_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Compétences";
            // 
            // InformationPerso
            // 
            this.InformationPerso.AutoSize = true;
            this.InformationPerso.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.InformationPerso.Location = new System.Drawing.Point(88, 9);
            this.InformationPerso.Name = "InformationPerso";
            this.InformationPerso.Size = new System.Drawing.Size(104, 17);
            this.InformationPerso.TabIndex = 27;
            this.InformationPerso.Text = "Compétence";
            // 
            // AjouterCompetence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(302, 113);
            this.Controls.Add(this.InformationPerso);
            this.Controls.Add(this.textBoxNomNewCompetence);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.buttonAjouterCompétence);
            this.Controls.Add(this.comboBoxCompétences);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(302, 113);
            this.MinimumSize = new System.Drawing.Size(302, 113);
            this.Name = "AjouterCompetence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AjoutCompetence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNomNewCompetence;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.Button buttonAjouterCompétence;
        private System.Windows.Forms.ComboBox comboBoxCompétences;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label InformationPerso;
    }
}