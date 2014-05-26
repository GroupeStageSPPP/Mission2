namespace EntretienSPPP.WinForm
{
    partial class AjouterLangue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterLangue));
            this.buttonEnregistrer = new System.Windows.Forms.Button();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxNiveauLangue = new System.Windows.Forms.ComboBox();
            this.comboBoxLangue = new System.Windows.Forms.ComboBox();
            this.InformationPerso = new System.Windows.Forms.Label();
            this.textBoxAjoutLangue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonEnregistrer
            // 
            this.buttonEnregistrer.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnregistrer.Location = new System.Drawing.Point(187, 131);
            this.buttonEnregistrer.Name = "buttonEnregistrer";
            this.buttonEnregistrer.Size = new System.Drawing.Size(78, 23);
            this.buttonEnregistrer.TabIndex = 11;
            this.buttonEnregistrer.Text = "Enregistrer";
            this.buttonEnregistrer.UseVisualStyleBackColor = true;
            this.buttonEnregistrer.Click += new System.EventHandler(this.buttonEnregistrer_Click);
            // 
            // buttonRetour
            // 
            this.buttonRetour.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetour.Location = new System.Drawing.Point(12, 131);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(78, 23);
            this.buttonRetour.TabIndex = 10;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = true;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Niveau";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Langue";
            // 
            // comboBoxNiveauLangue
            // 
            this.comboBoxNiveauLangue.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNiveauLangue.FormattingEnabled = true;
            this.comboBoxNiveauLangue.Location = new System.Drawing.Point(12, 104);
            this.comboBoxNiveauLangue.Name = "comboBoxNiveauLangue";
            this.comboBoxNiveauLangue.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNiveauLangue.TabIndex = 7;
            // 
            // comboBoxLangue
            // 
            this.comboBoxLangue.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLangue.FormattingEnabled = true;
            this.comboBoxLangue.Items.AddRange(new object[] {
            "",
            "Autre"});
            this.comboBoxLangue.Location = new System.Drawing.Point(12, 64);
            this.comboBoxLangue.Name = "comboBoxLangue";
            this.comboBoxLangue.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLangue.TabIndex = 6;
            this.comboBoxLangue.SelectedIndexChanged += new System.EventHandler(this.comboBoxLangue_SelectedIndexChanged);
            // 
            // InformationPerso
            // 
            this.InformationPerso.AutoSize = true;
            this.InformationPerso.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.InformationPerso.Location = new System.Drawing.Point(103, 9);
            this.InformationPerso.Name = "InformationPerso";
            this.InformationPerso.Size = new System.Drawing.Size(65, 17);
            this.InformationPerso.TabIndex = 28;
            this.InformationPerso.Text = "Langue";
            // 
            // textBoxAjoutLangue
            // 
            this.textBoxAjoutLangue.Enabled = false;
            this.textBoxAjoutLangue.Location = new System.Drawing.Point(139, 64);
            this.textBoxAjoutLangue.Name = "textBoxAjoutLangue";
            this.textBoxAjoutLangue.Size = new System.Drawing.Size(126, 20);
            this.textBoxAjoutLangue.TabIndex = 29;
            // 
            // AjouterLangue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(277, 166);
            this.Controls.Add(this.textBoxAjoutLangue);
            this.Controls.Add(this.InformationPerso);
            this.Controls.Add(this.buttonEnregistrer);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxNiveauLangue);
            this.Controls.Add(this.comboBoxLangue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AjouterLangue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AjouterLangue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEnregistrer;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxNiveauLangue;
        private System.Windows.Forms.ComboBox comboBoxLangue;
        private System.Windows.Forms.Label InformationPerso;
        private System.Windows.Forms.TextBox textBoxAjoutLangue;
    }
}