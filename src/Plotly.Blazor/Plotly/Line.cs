using System.Collections.Generic;

namespace Goke.Plotly.Blazor
{
    public struct Shape
    {
        public const string Default = "";
        public const string Linear = "linear";
        public const string Spline = "spline";
        public const string Vhv = "vhv";
        public const string Hvh = "hvh";
        public const string Vh = "vh";
        public const string Hv = "hv";
    }

    public struct Dash
    {
        public const string Default = "";
        public const string Solid = "solid";
        public const string Dot = "dot";
    }

    public class Line
    {
        public string Color { get; set; }
        public float? Width { get; set; }
        public string Shape { get; set; } = Goke.Plotly.Blazor.Shape.Default;
        public string Dash { get; set; } = Goke.Plotly.Blazor.Dash.Default;


        public static List<Trace> Sample1 => new List<Trace>
        {
            new Trace
            {
                X = new object[]{1, 2, 3, 4 },
                Y = new object[]{10, 15, 13, 17 },
                Mode= Goke.Plotly.Blazor.Mode.Markers,
                Type = Type.Scatter,
                //Marker = new Marker
                //{
                //    Color = "rgb(219, 64, 82)",
                //    Size = 12,
                //},
                
            },
            new Trace
            {
                X = new object[]{2, 3, 4, 5 },
                Y = new object[]{16, 5, 11, 9},
                Mode= Blazor.Mode.Lines,
                Type = Type.Scatter,
                //Line = new Line
                //{
                //    Color ="rgb(55, 128, 191)",
                //    Width= 3,
                //},
            },
            new Trace
            {
                X = new object[]{1, 2, 3, 4},
                Y = new object[]{12, 9, 15, 12},
                Mode= Blazor.Mode.LinesMarkers,
                Type = Type.Scatter,
                //Marker = new Marker
                //{
                //    Color = "rgb(128, 0, 128)",
                //    Size = 8,
                //},
                //Line = new Line
                //{
                //    Color ="rgb(128, 0, 128)",
                //    Width= 1,
                //}
            }
        };
    }
}