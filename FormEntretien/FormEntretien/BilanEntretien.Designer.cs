namespace FormEntretien
{
    partial class BilanEntretien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxExprimer = new System.Windows.Forms.ComboBox();
            this.comboBoxObjectifClaire = new System.Windows.Forms.ComboBox();
            this.comboBoxDefinitionFonction = new System.Windows.Forms.ComboBox();
            this.comboBoxFOnctionCLaire = new System.Windows.Forms.ComboBox();
            this.buttonEndEntretien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bilan de l\'entretien :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "J\'ai pu m\'exprimer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mes objectifs sont clairs ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ma fonction est claire ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ma définition de ma fonction ";
            // 
            // comboBoxExprimer
            // 
            this.comboBoxExprimer.FormattingEnabled = true;
            this.comboBoxExprimer.Location = new System.Drawing.Point(175, 60);
            this.comboBoxExprimer.Name = "comboBoxExprimer";
            this.comboBoxExprimer.Size = new System.Drawing.Size(121, 21);
            this.comboBoxExprimer.TabIndex = 5;
            // 
            // comboBoxObjectifClaire
            // 
            this.comboBoxObjectifClaire.FormattingEnabled = true;
            this.comboBoxObjectifClaire.Location = new System.Drawing.Point(175, 219);
            this.comboBoxObjectifClaire.Name = "comboBoxObjectifClaire";
            this.comboBoxObjectifClaire.Size = new System.Drawing.Size(121, 21);
            this.comboBoxObjectifClaire.TabIndex = 6;
            // 
            // comboBoxDefinitionFonction
            // 
            this.comboBoxDefinitionFonction.FormattingEnabled = true;
            this.comboBoxDefinitionFonction.Location = new System.Drawing.Point(175, 117);
            this.comboBoxDefinitionFonction.Name = "comboBoxDefinitionFonction";
            this.comboBoxDefinitionFonction.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDefinitionFonction.TabIndex = 7;
            // 
            // comboBoxFOnctionCLaire
            // 
            this.comboBoxFOnctionCLaire.FormattingEnabled = true;
            this.comboBoxFOnctionCLaire.Location = new System.Drawing.Point(175, 169);
            this.comboBoxFOnctionCLaire.Name = "comboBoxFOnctionCLaire";
            this.comboBoxFOnctionCLaire.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFOnctionCLaire.TabIndex = 8;
            // 
            // buttonEndEntretien
            // 
            this.buttonEndEntretien.Location = new System.Drawing.Point(175, 287);
            this.buttonEndEntretien.Name = "buttonEndEntretien";
            this.buttonEndEntretien.Size = new System.Drawing.Size(121, 23);
            this.buttonEndEntretien.TabIndex = 9;
            this.buttonEndEntretien.Text = "Fin de l\'entretien ";
            this.buttonEndEntretien.UseVisualStyleBackColor = true;
            // 
            // BilanEntretien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 343);
            this.Controls.Add(this.buttonEndEntretien);
            this.Controls.Add(this.comboBoxFOnctionCLaire);
            this.Controls.Add(this.comboBoxDefinitionFonction);
            this.Controls.Add(this.comboBoxObjectifClaire);
            this.Controls.Add(this.comboBoxExprimer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BilanEntretien";
            this.Text = "BilanEntretien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxExprimer;
        private System.Windows.Forms.ComboBox comboBoxObjectifClaire;
        private System.Windows.Forms.ComboBox comboBoxDefinitionFonction;
        private System.Windows.Forms.ComboBox comboBoxFOnctionCLaire;
        private System.Windows.Forms.Button buttonEndEntretien;
    }
}