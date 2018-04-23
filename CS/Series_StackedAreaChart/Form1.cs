using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace Series_StackedAreaChart {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create a new chart.
            ChartControl stackedAreaChart = new ChartControl();

            // Create two stacked area series.
            Series series1 = new Series("Series 1", ViewType.StackedArea);
            Series series2 = new Series("Series 2", ViewType.StackedArea);

            // Add points to them.
            series1.Points.Add(new SeriesPoint(1, 10));
            series1.Points.Add(new SeriesPoint(2, 12));
            series1.Points.Add(new SeriesPoint(3, 14));
            series1.Points.Add(new SeriesPoint(4, 17));

            series2.Points.Add(new SeriesPoint(1, 15));
            series2.Points.Add(new SeriesPoint(2, 18));
            series2.Points.Add(new SeriesPoint(3, 25));
            series2.Points.Add(new SeriesPoint(4, 33));

            // Add both series to the chart.
            stackedAreaChart.Series.AddRange(new Series[] { series1, series2 });

            // Set the numerical argument scale types for the series,
            // as it is qualitative, by default.
            series1.ArgumentScaleType = ScaleType.Numerical;
            series2.ArgumentScaleType = ScaleType.Numerical;

            // Access the view-type-specific options of the series.
            ((StackedAreaSeriesView)series1.View).Transparency = 80;

            // Access the type-specific options of the diagram.
            ((XYDiagram)stackedAreaChart.Diagram).Rotated = true;

            // Hide the legend (if necessary).
            stackedAreaChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

            // Add a title to the chart (if necessary).
            stackedAreaChart.Titles.Add(new ChartTitle());
            stackedAreaChart.Titles[0].Text = "A Stacked Area Chart";

            // Add the chart to the form.
            stackedAreaChart.Dock = DockStyle.Fill;
            this.Controls.Add(stackedAreaChart);
        }
    }
}