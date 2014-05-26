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

using EntretienSPPP.WinForm;

namespace EntretienSPPP.WinForm
{
    public partial class GraphiqueSatisfaction : Form
    {
        public GraphiqueSatisfaction()
        {
            InitializeComponent();
        }

        private void Graphique_Load(object sender, EventArgs e)
        {


            chart1.Dock = DockStyle.Fill;
            chart1.Palette = ChartColorPalette.SeaGreen;
            chart1.Titles.Add("Title1");
            chart1.Titles["Title1"].Text = "Graphique";

            ChartArea chartarea = new ChartArea();
            chartarea.Name = "NewChartArea";
            chart1.ChartAreas.Add("NewChartArea");

            Legend legend = new Legend();
            legend.Name = "legend1";
            legend.Title = "Satisfaction de moi et de la SPPP";
            chart1.Legends.Add("legend1");

            Series series1 = new Series();
            series1.LegendText = "Zone de notification";
            series1.Name = "series1";
            chart1.Series.Add("series1");

            chart1.Series["series1"].Legend = "legend1";
            chart1.Series["series1"].IsVisibleInLegend = true;

            Satisfaction satisfaction = new Satisfaction();
             satisfaction.Ambiance = 1 ; 
             satisfaction.Materiel =  2; 
             satisfaction.Secteur=  3; 
             satisfaction.Cadre =  4; 
             satisfaction.Futur =  5; 


            Double[] doubltte = new Double[] { satisfaction.Ambiance ,
             satisfaction.Materiel ,
             satisfaction.Secteur,
             satisfaction.Cadre, 
             satisfaction.Futur  };

            String[] strinnng = new String[] { "Ambiance", "Materiel", "Secteur", "Cadre",                      "Futur" };


            chart1.Series["series1"].Points.DataBindXY(strinnng, doubltte);

            chart1.Series["series1"].ChartType = SeriesChartType.Radar;








        }
    }
}
