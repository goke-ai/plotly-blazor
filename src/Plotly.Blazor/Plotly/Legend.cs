namespace Goke.Plotly.Blazor
{
    public struct XAnchor
    {
        public const string Default = "";
        public const string Right = "right";
    }

    public struct TraceOrder
    {
        public const string Default = "";
        public const string Normal = "normal";
    }
    public struct Orientation
    {
        public const string Default = "";
        public const string Vertical = "v";
        public const string Horizontal = "h";
    }

    public class Legend
    {
        public float? X { get; set; }
        public float? Y { get; set; }
        public string Bgcolor { get; set; }
        public string bordercolor { get; set; }
        public float? borderwidth { get; set; }

        public Font Font { get; set; }
        public string Xanchor { get; set; }
        public string Traceorder { get; set; }
        public string Orientation { get; set; }
    }
}