namespace EntretienSPPP.WinForm
{
    partial class Identification_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Identification_Page));
            this.textBoxIdentifiant = new System.Windows.Forms.TextBox();
            this.labelIndentifiant = new System.Windows.Forms.Label();
            this.labelMotDePasse = new System.Windows.Forms.Label();
            this.textBoxMotDePasse = new System.Windows.Forms.TextBox();
            this.pictureBoxButtonClose = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonSeConnecter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxIdentifiant
            // 
            this.textBoxIdentifiant.Location = new System.Drawing.Point(113, 25);
            this.textBoxIdentifiant.Name = "textBoxIdentifiant";
            this.textBoxIdentifiant.Size = new System.Drawing.Size(156, 20);
            this.textBoxIdentifiant.TabIndex = 2;
            // 
            // labelIndentifiant
            // 
            this.labelIndentifiant.AutoSize = true;
            this.labelIndentifiant.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndentifiant.Location = new System.Drawing.Point(33, 28);
            this.labelIndentifiant.Name = "labelIndentifiant";
            this.labelIndentifiant.Size = new System.Drawing.Size(74, 13);
            this.labelIndentifiant.TabIndex = 3;
            this.labelIndentifiant.Text = "Identifiant :";
            // 
            // labelMotDePasse
            // 
            this.labelMotDePasse.AutoSize = true;
            this.labelMotDePasse.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotDePasse.Location = new System.Drawing.Point(16, 53);
            this.labelMotDePasse.Name = "labelMotDePasse";
            this.labelMotDePasse.Size = new System.Drawing.Size(91, 13);
            this.labelMotDePasse.TabIndex = 4;
            this.labelMotDePasse.Text = "Mot de passe :";
            // 
            // textBoxMotDePasse
            // 
            this.textBoxMotDePasse.Location = new System.Drawing.Point(113, 50);
            this.textBoxMotDePasse.Name = "textBoxMotDePasse";
            this.textBoxMotDePasse.PasswordChar = '●';
            this.textBoxMotDePasse.Size = new System.Drawing.Size(156, 20);
            this.textBoxMotDePasse.TabIndex = 5;
            // 
            // pictureBoxButtonClose
            // 
            this.pictureBoxButtonClose.BackgroundImage = global::EntretienSPPP.WinForm.Properties.Resources.fermer_croix_supprimer_erreurs_sortie_icone_4368_128;
            this.pictureBoxButtonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxButtonClose.Location = new System.Drawing.Point(263, 4);
            this.pictureBoxButtonClose.Name = "pictureBoxButtonClose";
            this.pictureBoxButtonClose.Size = new System.Drawing.Size(15, 15);
            this.pictureBoxButtonClose.TabIndex = 8;
            this.pictureBoxButtonClose.TabStop = false;
            this.pictureBoxButtonClose.Click += new System.EventHandler(this.pictureBoxButtonClose_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImage = global::EntretienSPPP.WinForm.Properties.Resources.SPPP_Nom_;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Location = new System.Drawing.Point(2, 75);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(135, 63);
            this.pictureBoxLogo.TabIndex = 7;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonSeConnecter
            // 
            this.buttonSeConnecter.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSeConnecter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSeConnecter.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeConnecter.Location = new System.Drawing.Point(143, 91);
            this.buttonSeConnecter.Name = "buttonSeConnecter";
            this.buttonSeConnecter.Size = new System.Drawing.Size(126, 23);
            this.buttonSeConnecter.TabIndex = 9;
            this.buttonSeConnecter.Text = "Se connecter";
            this.buttonSeConnecter.UseVisualStyleBackColor = false;
            this.buttonSeConnecter.Click += new System.EventHandler(this.buttonSeConnecter_Click);
            // 
            // Identification_Page
            // 
            this.AcceptButton = this.buttonSeConnecter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(282, 140);
            this.Controls.Add(this.buttonSeConnecter);
            this.Controls.Add(this.pictureBoxButtonClose);
            this.Controls.Add(this.textBoxMotDePasse);
            this.Controls.Add(this.labelMotDePasse);
            this.Controls.Add(this.labelIndentifiant);
            this.Controls.Add(this.textBoxIdentifiant);
            this.Controls.Add(this.pictureBoxLogo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(282, 140);
            this.MinimumSize = new System.Drawing.Size(282, 140);
            this.Name = "Identification_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Identification";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIdentifiant;
        private System.Windows.Forms.Label labelIndentifiant;
        private System.Windows.Forms.Label labelMotDePasse;
        private System.Windows.Forms.TextBox textBoxMotDePasse;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBoxButtonClose;
        private System.Windows.Forms.Button buttonSeConnecter;
    }
}