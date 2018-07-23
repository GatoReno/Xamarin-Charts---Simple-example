using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Microcharts;
using SkiaSharp;

namespace Chartz
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            var entries = new[] {
                new Microcharts.Entry(100){
                    Color = SKColor.Parse("#4286f4"),
                    Label = "x",
                    ValueLabel = "100%"
                },
                new Microcharts.Entry(90){
                    Color = SKColor.Parse("#ba1079"),
                    Label = "x",
                    ValueLabel = "90%"
                },
                new Microcharts.Entry(70){
                    Color = SKColor.Parse("#5ae273"),
                    Label = "x",
                    ValueLabel = "70%"
                },
            };

            Chart BarChartSample  = new DonutChart() { Entries = entries };
            this.chartView.Chart = BarChartSample;

            Chart BarChartSample2 = new LineChart() { Entries = entries };
            this.chartView2.Chart = BarChartSample2;
        }

        

	}
}
