using System;
using System.Collections.Generic;
using System.Text;

namespace Goke.Plotly.Blazor
{
    public struct TextPosition
    {
        public const string Default = "";
        public const string Auto = "auto";
        public const string TopCenter = "top center";
        public const string BottomCenter = "bottom center";
        public const string Inside = "inside";
        public const string Outside = "outside";
    }
    public struct TextInfo
    {
        public const string Default = "";
        public const string None = "none";
        public const string LabelPercent = "label+percent";
        public const string LabelPercentName = "label+percent+name";
    }

    public struct InsideTextOrientation
    {
        public const string Default = "";
        public const string radial = "radial";
    }

    public struct HoverInfo
    {
        public const string Default = "";
        public const string None = "none";
        public const string LabelPercent = "label+percent";
        public const string LabelPercentName = "label+percent+name";
    }

    public struct Type
    {
        public const string Default = "";
        public const string Bar = "bar";
        public const string Scatter = "scatter";
        public const string Pie = "pie";
    }
    public struct Mode
    {
        public const string Default = "";
        public const string Markers = "markers";
        public const string Lines = "lines";
        public const string LinesMarkers = "lines+markers";
    }

    public class Trace
    {
        public object[] X { get; set; }
        public object[] Y { get; set; }

        public object Text { get; set; }
        public float[] Width { get; set; }

        public object Base { get; set; }

        public string Textposition { get; set; } = TextPosition.Default;
        public string Testinfo { get; set; } = TextInfo.Default;
        public string Hoverinfo { get; set; } = HoverInfo.Default;
        public bool? Automargin { get; set; }

        public string Mode { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public float Opacity { get; set; } = 1.0F;

        public Marker Marker { get; set; } = new Marker();
        public Line Line { get; set; } = new Line();

        // pie
        public object[] Values { get; set; }
        public object[] Labels { get; set; }
        public Domain Domain { get; set; }
        public float? Hole { get; set; }

        // legend
        public string Legendgroup { get; set; }
        public bool? Showlegend { get; set; }

        //axis
        public string Xaxis { get; set; }
        public string Yaxis { get; set; }

        public static string[] Colors = new string[] { "rgb(255,0,0)", "rgb(0,255,0)", "rgb(0,0,255)", "rgb(255,0,255)", "rgb(255,255,0)", "rgb(0,255,255)" };
        
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
                    Color = Colors[1],
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
                    Color = Colors[3],
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
                    Color = Colors[1],
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
                    Color = Colors[2],
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
    }
}
