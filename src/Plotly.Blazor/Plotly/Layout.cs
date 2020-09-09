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
        public object Title { get; set; }

        public Axis Xaxis { get; set; } = new Axis();
        public Axis Yaxis { get; set; } = new Axis();
        public Axis Zaxis { get; set; } = new Axis();

        public Font Font { get; set; }

        public string Barmode { get; set; } = BarMode.Default;
        public double? Bargap { get; set; } = 0.1F;
        public double? Bargroupgap { get; set; }

        public int? Width { get; set; }
        public int? Height { get; set; }
        public Grid Grid { get; set; }

        public bool? Showlegend { get; set; }
        public Legend Legend { get; set; }

        public Annotation[] Annotations { get; set; }

        public Margin Margin { get; set; }

        public string Hovermode { get; set; }
        public Scene Scene { get; set; } = new Scene();
        public bool? Autosize { get; set; }


        // extra axis
        public Axis Xaxis2 { get; set; } = new Axis();
        public Axis Yaxis2 { get; set; } = new Axis();
        public Axis Zaxis2 { get; set; } = new Axis();

        public Axis Xaxis3 { get; set; } = new Axis();
        public Axis Yaxis3 { get; set; } = new Axis();
        public Axis Zaxis3 { get; set; } = new Axis();

        public Axis Xaxis4 { get; set; } = new Axis();
        public Axis Yaxis4 { get; set; } = new Axis();
        public Axis Zaxis4 { get; set; } = new Axis();

        public Axis Xaxis5 { get; set; } = new Axis();
        public Axis Yaxis5 { get; set; } = new Axis();
        public Axis Zaxis5 { get; set; } = new Axis();

        public Axis Xaxis6 { get; set; } = new Axis();
        public Axis Yaxis6 { get; set; } = new Axis();
        public Axis Zaxis6 { get; set; } = new Axis();

        public Axis Xaxis7 { get; set; } = new Axis();
        public Axis Yaxis7 { get; set; } = new Axis();
        public Axis Zaxis7 { get; set; } = new Axis();

        public Axis Xaxis8 { get; set; } = new Axis();
        public Axis Yaxis8 { get; set; } = new Axis();
        public Axis Zaxis8 { get; set; } = new Axis();

        public Axis Xaxis9 { get; set; } = new Axis();
        public Axis Yaxis9 { get; set; } = new Axis();
        public Axis Zaxis9 { get; set; } = new Axis();

        public Axis Xaxis10 { get; set; } = new Axis();
        public Axis Yaxis10 { get; set; } = new Axis();
        public Axis Zaxis10 { get; set; } = new Axis();

        public Axis Xaxis11 { get; set; } = new Axis();
        public Axis Yaxis11 { get; set; } = new Axis();
        public Axis Zaxis11 { get; set; } = new Axis();

        public Axis Xaxis12 { get; set; } = new Axis();
        public Axis Yaxis12 { get; set; } = new Axis();
        public Axis Zaxis12 { get; set; } = new Axis();

    }


}