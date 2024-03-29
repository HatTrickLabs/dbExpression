﻿using Blazorise;
using Blazorise.Charts;
using Microsoft.AspNetCore.Components;
using ServerSideBlazorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerSideBlazorApp.Shared
{
    public partial class SingleMetricChart : ComponentBase
    {
        private LineChart<object> lineChart = new();
        private PieChart<object> pieChart = new();
        private BarChart<object> barChart = new();
        private DoughnutChart<object> doughnutChart = new();
        private PolarAreaChart<object> polarAreaChart = new();

        private readonly List<string> backgroundColors = new()
        { 
            ChartColor.FromRgba(255, 99, 132, 0.8f), 
            ChartColor.FromRgba(54, 162, 235, 0.8f), 
            ChartColor.FromRgba(255, 206, 86, 0.8f), 
            ChartColor.FromRgba(75, 192, 192, 0.8f), 
            ChartColor.FromRgba(153, 102, 255, 0.8f), 
            ChartColor.FromRgba(255, 159, 64, 0.8f) 
        };

        private readonly List<string> borderColors = new()
        { 
            ChartColor.FromRgba(255, 99, 132, 1f), 
            ChartColor.FromRgba(54, 162, 235, 1f), 
            ChartColor.FromRgba(255, 206, 86, 1f), 
            ChartColor.FromRgba(75, 192, 192, 1f), 
            ChartColor.FromRgba(153, 102, 255, 1f), 
            ChartColor.FromRgba(255, 159, 64, 1f) 
        };

        private LineChartOptions LineChartOptions => BuildChartOptions<LineChartOptions>();
        private PieChartOptions PieChartOptions => BuildChartOptions<PieChartOptions>();
        private BarChartOptions BarChartOptions => BuildChartOptions<BarChartOptions>();

        private T BuildChartOptions<T>()
            where T : ChartOptions, new()
        {
            T options = new();
            options.Plugins = new()
            {
                Legend = new() { Display = ShowLegend },
                Title = new() { Display = true }
            };
            return options;
        }

        [Parameter] public Func<Task<IEnumerable<SingleMetricDatasetModel>>> Data { get; set; } = new Func<Task<IEnumerable<SingleMetricDatasetModel>>>(() => Task.FromResult(Enumerable.Empty<SingleMetricDatasetModel>()));
        [Parameter] public ChartType Type { get; set; }
        [Parameter] public bool ShowLegend { get; set; } = true;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await Render();
            }
        }

        protected async Task Render()
        {
            switch (Type)
            {
                case ChartType.Line: await RedrawLineChart(); break;
                case ChartType.Pie: await RedrawPieChart(); break;
                case ChartType.Bar: await RedrawBarChart(); break;
                case ChartType.Doughnut: await RedrawDoughnutChart(); break;
                case ChartType.PolarArea: await RedrawPolarAreaChart(); break;
                default: throw new NotImplementedException($"{Type} has not been implemented.");
            }
        }

        private async Task RedrawLineChart()
        {
            await lineChart.Clear();
            var data = (await Data()).ToList();

            await lineChart.AddLabelsDatasetsAndUpdate(
                data.Select(x => x.Label).ToList().AsReadOnly(),
                new LineChartDataset<object>
                {
                    Data = data.Where(x => x is not null).Select(x => x.Value).ToList()!,
                    BackgroundColor = data.Select((x, i) => backgroundColors[i % backgroundColors.Count]).ToList(),
                    BorderColor = data.Select((x, i) => borderColors[i % borderColors.Count]).ToList(),
                    PointRadius = 3
                }
            );
        }

        private async Task RedrawPieChart()
        {
            await pieChart.Clear();
            var data = (await Data()).ToList();

            await pieChart.AddLabelsDatasetsAndUpdate(
                data.Select(x => x.Label).ToList().AsReadOnly(),
                new PieChartDataset<object>
                {
                    Data = data.Where(x => x is not null).Select(x => x.Value).ToList()!,
                    BackgroundColor = data.Select((x, i) => backgroundColors[i % backgroundColors.Count]).ToList(),
                    BorderColor = data.Select((x, i) => borderColors[i % borderColors.Count]).ToList()
                }
            );
        }

        private async Task RedrawBarChart()
        {
            await barChart.Clear();
            var data = (await Data()).ToList();

            await barChart.AddLabelsDatasetsAndUpdate(
                data.Select(x => x.Label).ToList().AsReadOnly(),
                new BarChartDataset<object>
                {
                    Data = data.Where(x => x is not null).Select(x => x.Value).ToList()!,
                    BackgroundColor = data.Select((x, i) => backgroundColors[i % backgroundColors.Count]).ToList(),
                    BorderColor = data.Select((x, i) => borderColors[i % borderColors.Count]).ToList()
                }
            );
        }

        private async Task RedrawDoughnutChart()
        {
            await doughnutChart.Clear();
            var data = (await Data()).ToList();

            await doughnutChart.AddLabelsDatasetsAndUpdate(
                data.Select(x => x.Label).ToList().AsReadOnly(),
                new DoughnutChartDataset<object>
                {
                    Data = data.Where(x => x is not null).Select(x => x.Value).ToList()!,
                    BackgroundColor = data.Select((x, i) => backgroundColors[i % backgroundColors.Count]).ToList(),
                    BorderColor = data.Select((x, i) => borderColors[i % borderColors.Count]).ToList()
                }
            );
        }

        private async Task RedrawPolarAreaChart()
        {
            await polarAreaChart.Clear();
            var data = (await Data()).ToList();

            await polarAreaChart.AddLabelsDatasetsAndUpdate(
                data.Select(x => x.Label).ToList().AsReadOnly(),
                new PolarAreaChartDataset<object>
                {
                    Data = data.Where(x => x is not null).Select(x => x.Value).ToList()!,
                    BackgroundColor = data.Select((x, i) => backgroundColors[i % backgroundColors.Count]).ToList(),
                    BorderColor = data.Select((x, i) => borderColors[i % borderColors.Count]).ToList()
                }
            );
        }
    }
}
