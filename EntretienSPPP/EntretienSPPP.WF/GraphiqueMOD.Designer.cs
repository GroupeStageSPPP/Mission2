namespace EntretienSPPP.WinForm
{
    partial class GraphiqueMOD
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
            this.chartEvaluationMOD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartEvaluationMOD)).BeginInit();
            this.SuspendLayout();
            // 
            // chartEvaluationMOD
            // 
            this.chartEvaluationMOD.Location = new System.Drawing.Point(188, 24);
            this.chartEvaluationMOD.Name = "chartEvaluationMOD";
            this.chartEvaluationMOD.Size = new System.Drawing.Size(300, 300);
            this.chartEvaluationMOD.TabIndex = 0;
            this.chartEvaluationMOD.Text = "EvaluationMOD";
            // 
            // GraphiqueMOD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 359);
            this.Controls.Add(this.chartEvaluationMOD);
            this.Name = "GraphiqueMOD";
            this.Text = "GraphiqueMOD";
            this.Load += new System.EventHandler(this.Graphique_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartEvaluationMOD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartEvaluationMOD;
    }
}