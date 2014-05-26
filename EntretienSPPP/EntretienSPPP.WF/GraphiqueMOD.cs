using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using EntretienSPPP.DB;

namespace EntretienSPPP.WinForm
{
    public partial class GraphiqueMOD : Form
    {
        public GraphiqueMOD()
        {
            InitializeComponent();
        }
        private void Graphique_Load(object sender, EventArgs e)
        {


            chartEvaluationMOD.Dock = DockStyle.Fill;
            chartEvaluationMOD.Palette = ChartColorPalette.Fire;
            chartEvaluationMOD.Titles.Add("Title1");
            chartEvaluationMOD.Titles["Title1"].Text = "Graphique";

            ChartArea chartarea = new ChartArea();
            chartarea.Name = "NewChartArea";
            chartEvaluationMOD.ChartAreas.Add("NewChartArea");

            Legend legend = new Legend();
            legend.Name = "legend1";
            legend.Title = "Donnée du graphique";
            chartEvaluationMOD.Legends.Add("legend1");

            Series series1 = new Series();
            series1.LegendText = "Zone de notification";
            series1.Name = "series1";
            chartEvaluationMOD.Series.Add("series1");

            chartEvaluationMOD.Series["series1"].Legend = "legend1";
            chartEvaluationMOD.Series["series1"].IsVisibleInLegend = true;

            Evaluation evaluationMOD = new Evaluation();

            evaluationMOD.Relation =4 ;
            evaluationMOD.Qualite = 2;
            evaluationMOD.Realisation =3 ;
            evaluationMOD.Polyvalence = 4;
            evaluationMOD.Assiduite = 3;
            evaluationMOD. Motivation =4 ;
            evaluationMOD.Autonomie = 1;
            evaluationMOD.RespectConsigne =2 ;


            Double[] doubltte = new Double[] { evaluationMOD.Relation, evaluationMOD.Qualite, evaluationMOD.Realisation, evaluationMOD.Polyvalence, evaluationMOD.Assiduite, evaluationMOD.Motivation, evaluationMOD.Autonomie, evaluationMOD.RespectConsigne };

            String[] strinnng = new String[] { "Relation", "Qualité", "Réalisation", "Polyvalence", "Assiduite", "Motivation", "Autonomie", "Respect des Consigne" };


            chartEvaluationMOD.Series["series1"].Points.DataBindXY(strinnng, doubltte);

            chartEvaluationMOD.Series["series1"].ChartType = SeriesChartType.Radar;



        }//graphique evaluation MOD
    }
}
