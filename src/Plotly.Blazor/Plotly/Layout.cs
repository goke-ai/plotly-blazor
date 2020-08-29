namespace Goke.Plotly.Blazor
{
    public struct BarMode
    {
        public const string Default = "";
        public const string Group = "group";
        public const string Stack = "stack";
        public const string Relative = "relative";
    }
    public struct HoverMode
    {
        public const string Default = "";
        public const string Closest = "closest";
    }

    public class Layout
    {
        public string Title { get; set; }

        public XYAxis Xaxis { get; set; } = new XYAxis();
        public XYAxis Yaxis { get; set; } = new XYAxis();

        public Font Font { get; set; }

        public string Barmode { get; set; } = BarMode.Default;
        public float? Bargap { get; set; } = 0.1F;
        public float? Bargroupgap { get; set; }

        public int? Width { get; set; }
        public int? Height { get; set; }
        public Grid Grid { get; set; }

        public bool? Showlegend { get; set; }
        public Legend Legend { get; set; }

        public Annotation[] Annotations { get; set; }

        public Margin Margin { get; set; }

        public string Hovermode { get; set; }

    }


}