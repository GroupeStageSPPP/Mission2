namespace EntretienSPPP.WinForm
{
    partial class AjouterDiplome
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIntituléDiplôme = new System.Windows.Forms.TextBox();
            this.comboBoxNiveauDiplôme = new System.Windows.Forms.ComboBox();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.buttonEnregistrerDiplôme = new System.Windows.Forms.Button();
            this.InformationPerso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Intitulé du diplôme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Niveau";
            // 
            // textBoxIntituléDiplôme
            // 
            this.textBoxIntituléDiplôme.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIntituléDiplôme.Location = new System.Drawing.Point(139, 48);
            this.textBoxIntituléDiplôme.Name = "textBoxIntituléDiplôme";
            this.textBoxIntituléDiplôme.Size = new System.Drawing.Size(178, 21);
            this.textBoxIntituléDiplôme.TabIndex = 9;
            // 
            // comboBoxNiveauDiplôme
            // 
            this.comboBoxNiveauDiplôme.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNiveauDiplôme.FormattingEnabled = true;
            this.comboBoxNiveauDiplôme.Location = new System.Drawing.Point(12, 48);
            this.comboBoxNiveauDiplôme.Name = "comboBoxNiveauDiplôme";
            this.comboBoxNiveauDiplôme.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNiveauDiplôme.TabIndex = 8;
            // 
            // buttonRetour
            // 
            this.buttonRetour.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetour.Location = new System.Drawing.Point(12, 75);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(81, 23);
            this.buttonRetour.TabIndex = 7;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = true;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // buttonEnregistrerDiplôme
            // 
            this.buttonEnregistrerDiplôme.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnregistrerDiplôme.Location = new System.Drawing.Point(236, 74);
            this.buttonEnregistrerDiplôme.Name = "buttonEnregistrerDiplôme";
            this.buttonEnregistrerDiplôme.Size = new System.Drawing.Size(81, 23);
            this.buttonEnregistrerDiplôme.TabIndex = 6;
            this.buttonEnregistrerDiplôme.Text = "Enregistrer";
            this.buttonEnregistrerDiplôme.UseVisualStyleBackColor = true;
            this.buttonEnregistrerDiplôme.Click += new System.EventHandler(this.buttonEnregistrerDiplôme_Click);
            // 
            // InformationPerso
            // 
            this.InformationPerso.AutoSize = true;
            this.InformationPerso.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.InformationPerso.Location = new System.Drawing.Point(122, 9);
            this.InformationPerso.Name = "InformationPerso";
            this.InformationPerso.Size = new System.Drawing.Size(70, 17);
            this.InformationPerso.TabIndex = 56;
            this.InformationPerso.Text = "Diplôme";
            // 
            // AjouterDiplome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(329, 107);
            this.Controls.Add(this.InformationPerso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIntituléDiplôme);
            this.Controls.Add(this.comboBoxNiveauDiplôme);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.buttonEnregistrerDiplôme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AjouterDiplome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AjouterDiplome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIntituléDiplôme;
        private System.Windows.Forms.ComboBox comboBoxNiveauDiplôme;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.Button buttonEnregistrerDiplôme;
        private System.Windows.Forms.Label InformationPerso;
    }
}