Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace Series_StackedAreaChart
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' Create a new chart.
            Dim stackedAreaChart As New ChartControl()

            ' Create two stacked area series.
            Dim series1 As New Series("Series 1", ViewType.StackedArea)
            Dim series2 As New Series("Series 2", ViewType.StackedArea)

            ' Add points to them.
            series1.Points.Add(New SeriesPoint(1, 10))
            series1.Points.Add(New SeriesPoint(2, 12))
            series1.Points.Add(New SeriesPoint(3, 14))
            series1.Points.Add(New SeriesPoint(4, 17))

            series2.Points.Add(New SeriesPoint(1, 15))
            series2.Points.Add(New SeriesPoint(2, 18))
            series2.Points.Add(New SeriesPoint(3, 25))
            series2.Points.Add(New SeriesPoint(4, 33))

            ' Add both series to the chart.
            stackedAreaChart.Series.AddRange(New Series() { series1, series2 })

            ' Set the numerical argument scale types for the series,
            ' as it is qualitative, by default.
            series1.ArgumentScaleType = ScaleType.Numerical
            series2.ArgumentScaleType = ScaleType.Numerical

            ' Access the view-type-specific options of the series.
            CType(series1.View, StackedAreaSeriesView).Transparency = 80

            ' Access the type-specific options of the diagram.
            CType(stackedAreaChart.Diagram, XYDiagram).Rotated = True

            ' Hide the legend (if necessary).
            stackedAreaChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False

            ' Add a title to the chart (if necessary).
            stackedAreaChart.Titles.Add(New ChartTitle())
            stackedAreaChart.Titles(0).Text = "A Stacked Area Chart"

            ' Add the chart to the form.
            stackedAreaChart.Dock = DockStyle.Fill
            Me.Controls.Add(stackedAreaChart)
        End Sub
    End Class
End Namespace