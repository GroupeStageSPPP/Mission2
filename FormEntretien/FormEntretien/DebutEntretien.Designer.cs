namespace FormEntretien
{
    partial class DebutEntretien
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxListeEmployeENtretien = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.LabelNom = new System.Windows.Forms.Label();
            this.LabelDate = new System.Windows.Forms.Label();
            this.buttonCommencerEntretien = new System.Windows.Forms.Button();
            this.dateTimePickerDateDeEntretien = new System.Windows.Forms.DateTimePicker();
            this.labelAge = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxListeEmployeENtretien
            // 
            this.listBoxListeEmployeENtretien.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxListeEmployeENtretien.FormattingEnabled = true;
            this.listBoxListeEmployeENtretien.Location = new System.Drawing.Point(0, 0);
            this.listBoxListeEmployeENtretien.Name = "listBoxListeEmployeENtretien";
            this.listBoxListeEmployeENtretien.Size = new System.Drawing.Size(120, 284);
            this.listBoxListeEmployeENtretien.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entretien individuel :";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(250, 89);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(43, 13);
            this.labelPrenom.TabIndex = 2;
            this.labelPrenom.Text = "Prénom";
            // 
            // LabelNom
            // 
            this.LabelNom.AutoSize = true;
            this.LabelNom.Location = new System.Drawing.Point(159, 89);
            this.LabelNom.Name = "LabelNom";
            this.LabelNom.Size = new System.Drawing.Size(29, 13);
            this.LabelNom.TabIndex = 3;
            this.LabelNom.Text = "Nom";
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Location = new System.Drawing.Point(158, 155);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(36, 13);
            this.LabelDate.TabIndex = 4;
            this.LabelDate.Text = "Date :";
            // 
            // buttonCommencerEntretien
            // 
            this.buttonCommencerEntretien.Location = new System.Drawing.Point(378, 252);
            this.buttonCommencerEntretien.Name = "buttonCommencerEntretien";
            this.buttonCommencerEntretien.Size = new System.Drawing.Size(75, 23);
            this.buttonCommencerEntretien.TabIndex = 5;
            this.buttonCommencerEntretien.Text = "Commencer";
            this.buttonCommencerEntretien.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDateDeEntretien
            // 
            this.dateTimePickerDateDeEntretien.Location = new System.Drawing.Point(253, 155);
            this.dateTimePickerDateDeEntretien.Name = "dateTimePickerDateDeEntretien";
            this.dateTimePickerDateDeEntretien.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDateDeEntretien.TabIndex = 6;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(375, 89);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(26, 13);
            this.labelAge.TabIndex = 7;
            this.labelAge.Text = "Age";
            // 
            // DebutEntretien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 284);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.dateTimePickerDateDeEntretien);
            this.Controls.Add(this.buttonCommencerEntretien);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.LabelNom);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxListeEmployeENtretien);
            this.Name = "DebutEntretien";
            this.Text = "Sélection personne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxListeEmployeENtretien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label LabelNom;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Button buttonCommencerEntretien;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateDeEntretien;
        private System.Windows.Forms.Label labelAge;
    }
}

