namespace Goke.Plotly.Blazor
{
    public struct AxisType
    {
        public const string Default = "";
        public const string Linear = "linear";
        public const string Categorical = "categorical";
        public const string Log = "log";
        public const string Date = "date";
        public const string Multicategorical = "multicategorical";
    }

    public class Axis
    {
        public string Anchor { get; set; }

        public string Type { get; set; }
        public string Title { get; set; }
        public TitleFont Titlefont { get; set; }
        public TickFont Tickfont { get; set; }

        public double? Tickangle { get; set; }

        public double? Gridwidth { get; set; }

        public bool? Showgrid { get; set; }
        public bool? Showline { get; set; }
        public bool? Zeroline { get; set; }

        public object Range { get; set; }
        public bool? Autorange { get; set; }
        public bool? Automargin { get; set; }

        public object Domain { get; set; } = new object();

        public object Tickvals { get; set; }
        public double? Dtick { get; set; }
        public double? Tick0 { get; set; }
        public double? Ntick { get; set; }
        public bool? Visible { get; set; }

    }
}