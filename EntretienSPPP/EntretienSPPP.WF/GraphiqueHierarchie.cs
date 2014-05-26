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
    public partial class GraphiqueHierarchie : Form
    {
        public GraphiqueHierarchie()
        {
            InitializeComponent();
        }
        private void Graphique_Load(object sender, EventArgs e)
        {


            chartGraphiqueHierarchie.Dock = DockStyle.Fill;
            chartGraphiqueHierarchie.Palette = ChartColorPalette.EarthTones;
            chartGraphiqueHierarchie.Titles.Add("Title1");
            chartGraphiqueHierarchie.Titles["Title1"].Text = "Graphique";

            ChartArea chartarea = new ChartArea();
            chartarea.Name = "NewChartArea";
            chartGraphiqueHierarchie.ChartAreas.Add("NewChartArea");

            Legend legend = new Legend();
            legend.Name = "legend1";
            legend.Title = "Ma hiérarchie et moi ";
            chartGraphiqueHierarchie.Legends.Add("legend1");

            Series series1 = new Series();
            series1.LegendText = "Zone de notification";
            series1.Name = "series1";
            chartGraphiqueHierarchie.Series.Add("series1");

            chartGraphiqueHierarchie.Series["series1"].Legend = "legend1";
            chartGraphiqueHierarchie.Series["series1"].IsVisibleInLegend = true;

            Satisfaction satisfaction = new Satisfaction();

            satisfaction.MesIdees = 3;
            satisfaction.ReunionService = 2;
            satisfaction.LaDirection = 4;




            Double[] doubltte = new Double[] { satisfaction.MesIdees, satisfaction.ReunionService, satisfaction.LaDirection};
            String[] strinnng = new String[] { "Mes Idées", "Réunion de Service", "La Direction"};


            chartGraphiqueHierarchie.Series["series1"].Points.DataBindXY(strinnng, doubltte);

            chartGraphiqueHierarchie.Series["series1"].ChartType = SeriesChartType.Radar;








        }
    }
}
