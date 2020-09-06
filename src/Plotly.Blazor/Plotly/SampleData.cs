using System;
using System.Collections.Generic;
using System.Text;

namespace Goke.Plotly.Blazor
{
    public static class SampleData
    {
        

        public static List<Trace> BarSample => new List<Trace>
        {
            new Trace
            {
                X = new string[]{ "X101", "X102", "X103", "X104", "X105", "X106" },
                Y = new object[]{ 4.0, 3.0, -1.0, 2.5, 1, 5.0 },
                Text = new string[]{ "1", "2", "3", "2", "1", "4" },
                Textposition = TextPosition.Auto,
                Hoverinfo = HoverInfo.None,
                Type = "bar",
                Name = "Grade",
                Marker = new Marker
                {
                    Color = new string[]{ "rgb(255,0,0)", "rgb(0,255,0)", "rgb(0,0,255)", "rgb(255,0,255)", "rgb(255,255,0)", "rgb(0,255,255)" },
                    Opacity = 0.7F,
                },
            }
        };

        public static List<Trace> BarGradeSample => new List<Trace>
        {
            new Trace
            {
                X = new string[]{ "X101" },
                Y = new object[]{ 4.0 },
                Text = new string[]{ "B" },
                Textposition = TextPosition.Auto,
                Hoverinfo = HoverInfo.None,
                Type = "bar",
                Name = "1 unit",
                Legendgroup = "1",
                Marker = new Marker
                {
                    Color = Color.Colors2[1],
                    Opacity = 0.7F,
                },
            },
            new Trace
            {
                X = new string[]{ "X102" },
                Y = new object[]{ 2.0 },
                Text = new string[]{ "D" },
                Textposition = TextPosition.Auto,
                Hoverinfo = HoverInfo.None,
                Type = "bar",
                Name = "3 unit",
                Legendgroup = "3",
                Marker = new Marker
                {
                    Color = Color.Colors2[3],
                    Opacity = 0.7F,
                },
            },
            new Trace
            {
                X = new string[]{ "X103" },
                Y = new object[]{ 3.0 },
                Text = new string[]{ "C" },
                Textposition = TextPosition.Auto,
                Hoverinfo = HoverInfo.None,
                Type = "bar",
                Name = "1 unit",
                Legendgroup = "1",
                Showlegend = false,
                Marker = new Marker
                {
                    Color = Color.Colors2[1],
                    Opacity = 0.7F,
                },
            },
            new Trace
            {
                X = new string[]{ "X104" },
                Y = new object[]{ 2.0 },
                Text = new string[]{ "D" },
                Textposition = TextPosition.Auto,
                Hoverinfo = HoverInfo.None,
                Type = "bar",
                Name = "2 unit",
                Legendgroup = "2",
                Marker = new Marker
                {
                    Color = Color.Colors2[2],
                    Opacity = 0.7F,
                },
            },

        };

        public static List<Trace> BarGroupSample => new List<Trace>
                {
                    new Trace
                    {
                        X = new string[]{"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" },
                        Y = new object[]{20, 14, 25, 16, 18, 22, 19, 15, 12, 16, 14, 17 },
                        Type= "bar",
                        Name= "Primary Product",
                        Marker = new Marker
                        {
                            Color = "rgb(49,130,189)",
                            Opacity= 0.7F,
                        }
                    },
                    new Trace
                    {
                        X = new string[]{"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" },
                        Y = new object[]{19, 14, 22, 14, 16, 19, 15, 14, 10, 12, 12, 16},
                        Type= "bar",
                        Name= "Secondary Product",
                        Marker = new Marker
                        {
                            Color ="rgb(204,204,204)",
                            Opacity= 0.5F,
                        }
                    }
                };

        public static List<Trace> LineSample => new List<Trace>
                {
                    new Trace
                    {
                        X = new object[]{1, 2, 3, 4 },
                        Y = new object[]{10, 15, 13, 17 },
                        Mode= Goke.Plotly.Blazor.Mode.Markers,
                        Marker = new Marker
                        {
                            Color = "rgb(219, 64, 82)",
                            Size = 12,
                        }
                    },
                    new Trace
                    {
                        X = new object[]{2, 3, 4, 5 },
                        Y = new object[]{16, 5, 11, 9},
                        Mode= Blazor.Mode.Lines,
                        Line = new Line
                        {
                            Color ="rgb(55, 128, 191)",
                            Width= 3,
                        }
                    },
                    new Trace
                    {
                        X = new object[]{1, 2, 3, 4},
                        Y = new object[]{12, 9, 15, 12},
                        Mode= Blazor.Mode.LinesMarkers,
                        Marker = new Marker
                        {
                            Color = "rgb(128, 0, 128)",
                            Size = 8,
                        },
                        Line = new Line
                        {
                            Color ="rgb(128, 0, 128)",
                            Width= 1,
                        }
                    }
                };

        public static List<Trace> PieSample => new List<Trace>
            {
                new Trace
                {
                    Values = new object[]{ 19, 26, 55 },
                    Labels = new object[]{ "Residential", "Non-Residential", "Utility" },
                    Type= Goke.Plotly.Blazor.Type.Pie,
                },
            };

        public static List<Trace> DonutSample => new List<Trace>
            {
                new Trace
                {
                    Values = new object[]{ 16, 15, 12, 6, 5, 4, 42 },
                    Labels = new object[]{ "US", "China", "European Union", "Russian Federation", "Brazil", "India", "Rest of World" },
                    Domain= new Domain {Column= 0},
                    Name= "GHG Emissions",
                    Hoverinfo= "label+percent+name",
                    Hole= 0.4F,
                    Type= Goke.Plotly.Blazor.Type.Pie,
                },
                new Trace
                {
                    Values = new object[]{ 27, 11, 25, 8, 1, 3, 25 },
                    Labels = new object[]{ "US", "China", "European Union", "Russian Federation", "Brazil", "India", "Rest of World" },
                    Text = "CO22",
                    Textposition = TextPosition.Inside,
                    Domain= new Domain {Column= 1},
                    Name= "CO2 Emissions",
                    Hoverinfo= "label+percent+name",
                    Hole= 0.4F,
                    Type= Goke.Plotly.Blazor.Type.Pie,
                },
            };

        // scatter
        public static List<Trace> ScatterLineScatterPlot => new List<Trace>
        {
            new Trace
            {
                X = new object[]{1, 2, 3, 4 },
                Y = new object[]{10, 15, 13, 17 },
                Mode= Goke.Plotly.Blazor.Mode.Markers,
                Type = Type.Scatter,
            },
            new Trace
            {
                X = new object[]{2, 3, 4, 5 },
                Y = new object[]{16, 5, 11, 9},
                Mode= Blazor.Mode.Lines,
                Type = Type.Scatter,
            },
            new Trace
            {
                X = new object[]{1, 2, 3, 4},
                Y = new object[]{12, 9, 15, 12},
                Mode= Blazor.Mode.LinesMarkers,
                Type = Type.Scatter,
            }
        };

        public static List<Trace> ScatterDataLabelHover => new List<Trace>
        {
            new Trace
            {
                X = new object[]{ 1, 2, 3, 4, 5 },
                Y = new object[]{ 1, 6, 3, 6, 1 },
                Mode= Goke.Plotly.Blazor.Mode.Markers,
                Type = Type.Scatter,
                Name= "Team A",
                Text= new object[]{ "A-1", "A-2", "A-3", "A-4", "A-5" },
                Marker= new Marker { Size= 12 },
            },
            new Trace
            {
                X = new object[]{ 1.5, 2.5, 3.5, 4.5, 5.5 },
                Y = new object[]{ 4, 1, 7, 1, 4 },
                Mode= Goke.Plotly.Blazor.Mode.Markers,
                Type = Type.Scatter,
                Name= "Team B",
                Text= new object[]{ "B-a", "B-b", "B-c", "B-d", "B-e" },
                Marker= new Marker { Size= 12 },
            },
        };

        public static List<Trace> ScatterDataLabelOnPlot => new List<Trace>
        {
            new Trace
            {
                X = new object[]{ 1, 2, 3, 4, 5 },
                Y = new object[]{ 1, 6, 3, 6, 1 },
                Mode= Goke.Plotly.Blazor.Mode.MarkersText,
                Type = Type.Scatter,
                Name= "Team A",
                Text= new object[]{ "A-1", "A-2", "A-3", "A-4", "A-5" },
                Textposition= TextPosition.TopCenter,
                Textfont= new Font {
                    Family= "Raleway, sans-serif"
                },
                Marker= new Marker { Size= 12 },
            },
            new Trace
            {
                X = new object[]{ 1.5, 2.5, 3.5, 4.5, 5.5 },
                Y = new object[]{ 4, 1, 7, 1, 4 },
                Mode= Goke.Plotly.Blazor.Mode.MarkersText,
                Type = Type.Scatter,
                Name= "Team B",
                Text= new object[]{ "B-a", "B-b", "B-c", "B-d", "B-e" },
                Textposition= TextPosition.BottomCenter,
                Textfont= new Font {
                    Family= "Times New Roman"
                },
                Marker= new Marker { Size= 12 },
            },
        };

        public static List<Trace> ScatterPlotWwithAColorDimension => new List<Trace>
        {
            new Trace
            {
                Y = new object[]{5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 },
                Mode= Goke.Plotly.Blazor.Mode.Markers,
                Marker= new Marker {
                    Size= 40,
                    Color= new object[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39 }
                },
            },
        };

        // line
        public static List<Trace> BasicLinePlot => new List<Trace>
        {
            new Trace
            {
                X = new object[]{1, 2, 3, 4 },
                Y = new object[]{10, 15, 13, 17 },
                Mode= Goke.Plotly.Blazor.Mode.Markers,
                Type = Type.Scatter,
            },
            new Trace
            {
                X = new object[]{2, 3, 4, 5 },
                Y = new object[]{16, 5, 11, 9},
                Mode= Blazor.Mode.Lines,
                Type = Type.Scatter,
            },
        };

        public static List<Trace> LineScatterPlot => new List<Trace>
        {
            new Trace
            {
                X = new object[]{1, 2, 3, 4 },
                Y = new object[]{10, 15, 13, 17 },
                Mode= Goke.Plotly.Blazor.Mode.Markers,
            },
            new Trace
            {
                X = new object[]{2, 3, 4, 5 },
                Y = new object[]{16, 5, 11, 9},
                Mode= Blazor.Mode.Lines,
            },
            new Trace
            {
                X = new object[]{1, 2, 3, 4},
                Y = new object[]{12, 9, 15, 12},
                Mode= Blazor.Mode.LinesMarkers,
            }
        };

        public static List<Trace> AddingNamesToLineAndScatterPlot => new List<Trace>
        {
            new Trace
            {
                X = new object[]{1, 2, 3, 4 },
                Y = new object[]{10, 15, 13, 17 },
                Mode= Goke.Plotly.Blazor.Mode.Markers,
                Name="Scatter",
            },
            new Trace
            {
                X = new object[]{2, 3, 4, 5 },
                Y = new object[]{16, 5, 11, 9},
                Mode= Blazor.Mode.Lines,
                Name="Lines",
            },
            new Trace
            {
                X = new object[]{1, 2, 3, 4},
                Y = new object[]{12, 9, 15, 12},
                Mode= Blazor.Mode.LinesMarkers,
                Name="Scatter + Lines",
            }
        };

        public static List<Trace> LineAndScatterStyling => new List<Trace>
        {
            new Trace
            {
                X = new object[]{1, 2, 3, 4 },
                Y = new object[]{10, 15, 13, 17 },
                Mode= Goke.Plotly.Blazor.Mode.Markers,
                Marker= new Marker {
                    Color= "rgb(219, 64, 82)",
                    Size= 12,
                }
            },
            new Trace
            {
                X = new object[]{2, 3, 4, 5 },
                Y = new object[]{16, 5, 11, 9},
                Mode= Blazor.Mode.Lines,
                Line= new Line{
                    Color= "rgb(55, 128, 191)",
                    Width= 3
                }
            },
            new Trace
            {
                X = new object[]{1, 2, 3, 4},
                Y = new object[]{12, 9, 15, 12},
                Mode= Blazor.Mode.LinesMarkers,
                Marker= new Marker {
                    Color= "rgb(128, 0, 128)",
                    Size= 8,
                },
                Line= new Line{
                    Color= "rgb(128, 0, 128)",
                    Width= 1
                }
            }
        };


        //bar
        public static List<Trace> BasicBarChart => new List<Trace>
        {
            new Trace
            {
                X = new object[]{"giraffes", "orangutans", "monkeys"},
                Y = new object[]{20, 14, 23 },
                Type= Type.Bar,
            },
        };

        public static List<Trace> GroupedBarChart => new List<Trace>
        {
            new Trace
            {
                X = new object[]{"giraffes", "orangutans", "monkeys"},
                Y = new object[]{20, 14, 23 },
                Name= "SF Zoo",
                Type= Type.Bar,
            },
            new Trace
            {
                X = new object[]{"giraffes", "orangutans", "monkeys"},
                Y = new object[]{12, 18, 29 },
                Name= "LA Zoo",
                Type= Type.Bar
            },
        };

        //pie
        public static List<Trace> BasicPieChart => new List<Trace>
        {
            new Trace
            {
                Values = new object[]{19, 26, 55},
                Labels = new object[]{"Residential", "Non-Residential", "Utility" },
                Type= Type.Pie,
            },
        };

        static string[] allLabels = { "1st", "2nd", "3rd", "4th", "5th" };

        static List<List<object>> allValues = new List<List<object>> {
            new List<object>{38, 27, 18, 10, 7 },
            new List<object>{28, 26, 21, 15, 10 },
            new List<object>{38, 19, 16, 14, 13},
            new List<object>{31, 24, 19, 18, 8}
        };

        static List<List<string>> ultimateColors = new List<List<string>> {
            new List<string>{"rgb(56, 75, 126)", "rgb(18, 36, 37)", "rgb(34, 53, 101)", "rgb(36, 55, 57)", "rgb(6, 4, 4)"},
            new List<string>{"rgb(177, 127, 38)", "rgb(205, 152, 36)", "rgb(99, 79, 37)", "rgb(129, 180, 179)", "rgb(124, 103, 37)"},
            new List<string>{"rgb(33, 75, 99)", "rgb(79, 129, 102)", "rgb(151, 179, 100)", "rgb(175, 49, 35)", "rgb(36, 73, 147)"},
            new List<string>{"rgb(146, 123, 21)", "rgb(177, 180, 34)", "rgb(206, 206, 40)", "rgb(175, 51, 21)", "rgb(35, 36, 21)"}
        };

        public static List<Trace> PieChartSubplots => new List<Trace>
        {
            new Trace
            {
                Values = allValues[0].ToArray(),
                Labels = allLabels,
                Type= Type.Pie,
                Name= "Starry Night",
                Marker= new Marker{
                    Colors= ultimateColors[0].ToArray(),
                },
                Domain= new Domain{
                    Row= 0,
                    Column= 0
                },
                Hoverinfo= HoverInfo.LabelPercentName,
                Textinfo= TextInfo.None,
            },
            new Trace
            {
                Values = allValues[1].ToArray(),
                Labels = allLabels,
                Type= Type.Pie,
                Name= "Sunflowers",
                Marker= new Marker{
                    Colors= ultimateColors[1].ToArray(),
                },
                Domain= new Domain{
                    Row= 1,
                    Column= 0
                },
                Hoverinfo= HoverInfo.LabelPercentName,
                Textinfo= TextInfo.None,
            },
            new Trace
            {
                Values = allValues[2].ToArray(),
                Labels = allLabels,
                Type= Type.Pie,
                Name= "Irises",
                Marker= new Marker{
                    Colors= ultimateColors[2].ToArray(),
                },
                Domain= new Domain{
                    Row= 0,
                    Column= 1
                },
                Hoverinfo= HoverInfo.LabelPercentName,
                Textinfo= TextInfo.None,
            },
            new Trace
            {
                Values = allValues[3].ToArray(),
                Labels = allLabels,
                Type= Type.Pie,
                Name= "The Night Cafe",
                Marker= new Marker{
                    Colors= ultimateColors[3].ToArray(),
                },
                Domain= new Domain{
                    X= new object[]{ 0.52,1},
                    Y= new object[]{ 0,0.48},
                },
                Hoverinfo= HoverInfo.LabelPercentName,
                Textinfo= TextInfo.None,
            },

        };


        // subplots
        public static List<Trace> MultipleSubplots => new List<Trace>
        {
            new Trace
            {
                X= new object[]{ 1, 2, 3},
                Y= new object[]{ 4, 5, 6},
                Type= Type.Scatter,
            },
            new Trace
            {
                X= new object[]{ 20, 30, 40},
                Y= new object[]{ 50, 60, 70},
                Xaxis= "x2",
                Yaxis= "y2",
                Type= Type.Scatter,
            },
            new Trace
            {
                X= new object[]{ 300, 400, 500 },
                Y= new object[]{ 600, 700, 800 },
                Xaxis= "x3",
                Yaxis= "y3",
                Type= Type.Scatter,
            },
            new Trace
            {
                X= new object[]{ 4000, 5000, 6000 },
                Y= new object[]{ 7000, 8000, 9000 },
                Xaxis= "x4",
                Yaxis= "y4",
                Type= Type.Scatter,
            },

        };
    }
}
