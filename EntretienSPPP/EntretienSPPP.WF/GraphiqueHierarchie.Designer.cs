namespace EntretienSPPP.WinForm
{
    partial class GraphiqueHierarchie
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
            this.chartGraphiqueHierarchie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraphiqueHierarchie)).BeginInit();
            this.SuspendLayout();
            // 
            // chartGraphiqueHierarchie
            // 
            this.chartGraphiqueHierarchie.Location = new System.Drawing.Point(212, 21);
            this.chartGraphiqueHierarchie.Name = "chartGraphiqueHierarchie";
            this.chartGraphiqueHierarchie.Size = new System.Drawing.Size(300, 300);
            this.chartGraphiqueHierarchie.TabIndex = 0;
            this.chartGraphiqueHierarchie.Text = "chart1";
            // 
            // GraphiqueHierarchie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 353);
            this.Controls.Add(this.chartGraphiqueHierarchie);
            this.Name = "GraphiqueHierarchie";
            this.Text = "GraphiqueHierarchie";
            this.Load += new System.EventHandler(this.Graphique_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartGraphiqueHierarchie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraphiqueHierarchie;
    }
}