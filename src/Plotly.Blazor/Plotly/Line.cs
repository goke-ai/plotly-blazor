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
    }
}