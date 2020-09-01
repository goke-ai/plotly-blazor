namespace Goke.Plotly.Blazor
{
    public class Axis
    {
        public string Title { get; set; }
        public TitleFont Titlefont { get; set; }
        public TickFont Tickfont { get; set; }

        public double? Tickangle { get; set; }

        public float? Gridwidth { get; set; }

        public bool? Showgrid { get; set; }
        public bool? Showline { get; set; }
        public bool? Zeroline { get; set; }

        public object Range { get; set; }
        public bool? Autorange { get; set; }
        public bool? Automargin { get; set; }

        public object Domain { get; set; } = new object();

    }
}