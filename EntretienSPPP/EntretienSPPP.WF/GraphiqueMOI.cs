using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntretienSPPP.DB;

using System.Windows.Forms.DataVisualization.Charting;

namespace EntretienSPPP.WinForm
{
    public partial class GraphiqueMOI : Form
    {
        public GraphiqueMOI()
        {
            InitializeComponent();
        }

        private void Graphique_Load(object sender, EventArgs e)
        {

            chartEvaluationMoi.Dock = DockStyle.Fill;
            chartEvaluationMoi.Palette = ChartColorPalette.Chocolate;
            chartEvaluationMoi.Titles.Add("Title1");
            chartEvaluationMoi.Titles["Title1"].Text = "Graphique";

            ChartArea chartarea = new ChartArea();
            chartarea.Name = "NewChartArea";
            chartEvaluationMoi.ChartAreas.Add("NewChartArea");

            Legend legend = new Legend();
            legend.Name = "legend1";
            legend.Title = "Donnée du graphique";
            chartEvaluationMoi.Legends.Add("legend1");

            Series series1 = new Series();
            series1.LegendText = "Zone de notification";
            series1.Name = "series1";
            chartEvaluationMoi.Series.Add("series1");

            chartEvaluationMoi.Series["series1"].Legend = "legend1";
            chartEvaluationMoi.Series["series1"].IsVisibleInLegend = true;

            EvaluationMoi evaluation = new EvaluationMoi();
            // rentrer les valeurs de la personne 
            evaluation.Communication = 1;
            evaluation.SensRelationnel = 2;
            evaluation.Implication = 5;
            evaluation.Competence = 2;
            evaluation.Performance = 3;
            evaluation.Management =4 ;
            evaluation.Objectifs = 2;

            Double[] Note = new Double[] {evaluation.Communication,evaluation.SensRelationnel,evaluation.Implication,evaluation.Competence,evaluation.Performance,evaluation.Management,evaluation.Objectifs};

            String[] Libelle = new String[] { "Communication", "Sens relationnel", "Implication", "Compétences", "Performances","Management","Objectifs" };


            chartEvaluationMoi.Series["series1"].Points.DataBindXY(Libelle, Note);

            chartEvaluationMoi.Series["series1"].ChartType = SeriesChartType.Radar;

        }// chargement du graphique MOI
    }
}
