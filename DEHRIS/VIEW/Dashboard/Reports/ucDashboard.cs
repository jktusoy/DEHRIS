using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using System.Drawing.Drawing2D;

namespace DEHRIS.Dashboard.Reports
{
    public partial class ucDashboard : UserControl
    {
        public ucDashboard()
        {
            InitializeComponent();
            FillGenderData();
            Chart3();
            FillCivilStatus();
            InitializeChartData();
        }

        public void FillGenderData()
        {

            Font customfont = new Font("Eras Light", 8);
            chartGender.Series.Clear();
            chartGender.Title.Font = customfont;
            chartGender.Legend.Font = customfont;
            chartGender.ElementsSpacing = 1;


            chartGender.Series.Clear();
            chartGender.Legend.Visible = false;
            chartGender.Text = "Gender";
            chartGender.Palette = ChartColorPalette.Pastel;
            ChartSeries series1 = new ChartSeries();
            series1.Points.Add(0, 20);
            series1.Points.Add(1, 80);
            series1.Type = ChartSeriesType.Pie;
            this.chartGender.Series.Add(series1);

            for (int i = 0; i < series1.Points.Count; i++)
            series1.Styles[i].Border.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

            series1.Styles[0].Text = string.Format("MALE {0}%", series1.Points[0].YValues[0]);
            series1.Styles[1].Text = string.Format("FEMALE {0}%", series1.Points[1].YValues[0]);
            series1.ConfigItems.PieItem.LabelStyle = ChartAccumulationLabelStyle.OutsideInArea;
            series1.Style.DisplayText = true;
            series1.Style.Font.Size = 8.0f;
            series1.ConfigItems.PieItem.AngleOffset = 10;



        }

        public void Chart3()
        {


            //ChartSeries series1 = new ChartSeries();
            //series1.Name = "Civil";
            //series1.Text = series1.Name;
            //series1.Points.Add(0, 30);
            //series1.Points.Add(1, 20);
            //series1.Points.Add(2, 15);
            //series1.Points.Add(3, 35);
            //SeriesSettings(series1);
            //this.chartCivil.Series.Add(series1);
            //series1.ConfigItems.PieItem.ShowSeriesTitle = true;
            //series1.ConfigItems.PieItem.LabelStyle = ChartAccumulationLabelStyle.Inside;



            //this.chartCivil.ChartArea.DivideArea = true;
            //ChartLegend chartLegend = new ChartLegend();
            //chartLegend.Name = "Legend 1";
            //string[] label = new string[] { "Engineering", "Medical Sciences", "BioTechnology", "Information Services" };
            //List<ChartLegendItem> items = new List<ChartLegendItem>();
            //for (int i = 0; i < 3; i++)
            //{
            //    ChartLegendItem legendItem = new ChartLegendItem(label[i]);
            //    legendItem.Font = new Font("Segoe UI", 8F);
            //    legendItem.RepresentationSize = new Size(15, 15);
            //    legendItem.TextColor = Color.Black;
            //    legendItem.Border.Color = Color.Transparent;
            //    items.Add(legendItem);
            //}
            //chartCivil.Legend.RepresentationType = ChartLegendRepresentationType.SeriesType;

            ////chartCivil.Legend.CustomItems = items.ToArray();
            ////chartCivil.Legend.RowsCount = 2;
            ////this.chartCivil.LegendAlignment = ChartAlignment.Center;
            ////this.chartCivil.LegendPosition = ChartDock.Bottom;
            ////this.chartCivil.LegendsPlacement = ChartPlacement.Outside;
            ////this.chartCivil.LegendsPlacement = ChartPlacement.Outside;
            ////this.chartCivil.ShowLegend = true;
            ////this.chartCivil.SmoothingMode = SmoothingMode.AntiAlias;
            
        
        }

        protected void SeriesSettings(ChartSeries series)
        {
            ChartSeries newSeries = series;
            newSeries.Style.DisplayText = true;
            newSeries.Type = ChartSeriesType.Pie;
            newSeries.LegendName = "Legend 1";
           // newSeries.PrepareStyle += new ChartPrepareStyleInfoHandler(series1_PrepareStyle);

            for (int i = 0; i < 3; i++)
            {
                series.Styles[i].Font.Size = 8f;
                series.Styles[i].TextFormat = string.Format("{0}%", series.Points[i].YValues[0]);
            }
        }


        public void FillCivilStatus()
        {
            Font customfont = new Font("Eras Light", 8);
            chartCivil.Series.Clear();
            chartCivil.Title.Font = customfont;
            chartCivil.Legend.Font = customfont;
            chartCivil.ElementsSpacing = 1;

            chartCivil.Spacing = 1;
            chartCivil.SpacingBetweenPoints = 1;
            chartCivil.SpacingBetweenSeries = 1;
            chartCivil.Legend.Visible = false;
            chartCivil.Text = "Gender";
            chartCivil.Palette = ChartColorPalette.Pastel;
            ChartSeries series1 = new ChartSeries();
            series1.Points.Add(0, 38);
            series1.Points.Add(1, 42);
            series1.Points.Add(2, 18);
            series1.Points.Add(3, 2);
            series1.Type = ChartSeriesType.Pie;
            this.chartCivil.Series.Add(series1);

            for (int i = 0; i < series1.Points.Count; i++)
                series1.Styles[i].Border.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;


            ChartFontInfo infofont = new ChartFontInfo();
            infofont.FontStyle = FontStyle.Regular;
            infofont.Size = 8;


            series1.ConfigItems.PieItem.LabelStyle = ChartAccumulationLabelStyle.Disabled;
            series1.Style.DisplayText = true;
            series1.Style.Font.Size = 8.0f;
            series1.ConfigItems.PieItem.AngleOffset = 5;

            string[] label = new string[] { "Single", "Married", "Widow", "Separated" };
            List<ChartLegendItem> items = new List<ChartLegendItem>();

            for (int i = 0; i < 4; i++)
            {
           
                  this.chartCivil.Legend.Items[i].Font  = new Font("Segoe UI", 8F);
                  this.chartCivil.Legend.Items[i].Text = this.chartCivil.Legend.Items[i].Text + " " + label[i];
           }
            this.chartCivil.ShowLegend = true;
         
       

        }


        //public void FillBirthDate()
        //{
        //    Font customfont = new Font("Eras Light", 8);
        //    chartBirth.Series.Clear();
        //    chartBirth.Title.Font = customfont;
        //    chartBirth.Legend.Font = customfont;
        //    chartBirth.ElementsSpacing = 1;

        //    chartBirth.Spacing = 1;
        //    chartBirth.SpacingBetweenPoints = 1;
        //    chartBirth.SpacingBetweenSeries = 1;
        //    chartBirth.Legend.Visible = false;
        //    chartBirth.Text = "Gender";
        //    chartBirth.Palette = ChartColorPalette.Pastel;
        //    ChartSeries series1 = new ChartSeries();
        //    series1.Points.Add(0, 38);
        //    series1.Points.Add(1, 42);
        //    series1.Points.Add(2, 18);
        //    series1.Points.Add(3, 2);
        //    series1.Points.Add(4, 38);
        //    series1.Points.Add(5, 42);
        //    series1.Points.Add(6, 18);
        //    series1.Points.Add(7, 2);
        //    series1.Points.Add(8, 38);
        //    series1.Points.Add(9, 42);
        //    series1.Points.Add(10, 18);
        //    series1.Points.Add(11, 2);
        //    series1.Points.Add(12, 2);
        //    series1.Type = ChartSeriesType.Bar;
        //    this.chartBirth.Series.Add(series1);

        //    for (int i = 0; i < series1.Points.Count; i++)
        //        series1.Styles[i].Border.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;


        //    ChartFontInfo infofont = new ChartFontInfo();
        //    infofont.FontStyle = FontStyle.Regular;
        //    infofont.Size = 8;


        //    series1.ConfigItems.PieItem.LabelStyle = ChartAccumulationLabelStyle.Disabled;
        //    series1.Style.DisplayText = true;
        //    series1.Style.Font.Size = 8.0f;
        //    series1.ConfigItems.PieItem.AngleOffset = 5;

        //    string[] label = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        //    List<ChartLegendItem> items = new List<ChartLegendItem>();

        //    for (int i = 0; i < 4; i++)
        //    {

        //        this.chartBirth.Legend.Items[i].Font = new Font("Segoe UI", 8F);
        //        this.chartBirth.Legend.Items[i].Text = this.chartCivil.Legend.Items[i].Text + " " + label[i];
        //    }
        //    this.chartBirth.ShowLegend = true;



        //}



        private void InitializeChartData()
        {
            this.chartBirth.Series.Clear();

            ChartSeries series2 = new ChartSeries();

            series2.Name = "Sales";
            series2.Points.Add("1 Jan", 370);
            series2.Points.Add("2 Feb", 420);
            series2.Points.Add("3 Mar", 330);
            series2.Points.Add("4 Apr", 440);
            series2.Points.Add("5 May", 230);
            series2.Points.Add("6 Jun", 540);
            series2.Points.Add("7 Jul", 370);
            series2.Points.Add("8 Aug", 420);
            series2.Points.Add("9 Sep", 330);
            series2.Points.Add("10 Oct", 440);
            series2.Points.Add("11 Nov", 230);
            series2.Points.Add("12 Dec", 540);
            series2.Type = ChartSeriesType.Column;
            series2.Text = series2.Name;
            this.chartBirth.Series.Add(series2);

            //ChartSeries series1 = new ChartSeries();

            //series1.Name = "Profit";
            //series1.Points.Add(1995, 300);
            //series1.Points.Add(1996, 240);
            //series1.Points.Add(1997, 300);
            //series1.Points.Add(1998, 240);
            //series1.Points.Add(1999, 300);
            //series1.Points.Add(2000, 240);
            //series1.Type = ChartSeriesType.Column;
            //series1.Text = series1.Name;
            //this.chartBirth.Series.Add(series1);
        }




    }
}
