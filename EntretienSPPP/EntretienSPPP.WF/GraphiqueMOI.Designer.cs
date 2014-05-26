namespace EntretienSPPP.WinForm
{
    partial class GraphiqueMOI
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
            this.chartEvaluationMoi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartEvaluationMoi)).BeginInit();
            this.SuspendLayout();
            // 
            // chartEvaluationMoi
            // 
            this.chartEvaluationMoi.Location = new System.Drawing.Point(164, 22);
            this.chartEvaluationMoi.Name = "chartEvaluationMoi";
            this.chartEvaluationMoi.Size = new System.Drawing.Size(300, 300);
            this.chartEvaluationMoi.TabIndex = 0;
            this.chartEvaluationMoi.Text = "chart1";
            // 
            // GraphiqueMOI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 375);
            this.Controls.Add(this.chartEvaluationMoi);
            this.Name = "GraphiqueMOI";
            this.Text = "GraphiqueMOI";
            this.Load += new System.EventHandler(this.Graphique_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartEvaluationMoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartEvaluationMoi;
    }
}