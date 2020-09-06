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
        public const string Surface = "surface";
        public const string Histogram = "histogram";
        public const string Histogram2dcontour = "histogram2dcontour";
    }
    public struct Mode
    {
        public const string Default = "";
        public const string Markers = "markers";
        public const string MarkersText = "markers+text";
        public const string Lines = "lines";
        public const string LinesMarkers = "lines+markers";
    }

    public class Trace
    {
        public object X { get; set; }
        public object Y { get; set; }
        public object Z { get; set; }

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
        public object Values { get; set; }
        public object Labels { get; set; }
        public Domain Domain { get; set; }
        public float? Hole { get; set; }

        // legend
        public string Legendgroup { get; set; }
        public bool? Showlegend { get; set; }

        //axis
        public string Xaxis { get; set; }
        public string Yaxis { get; set; }
        public string Zaxis { get; set; }

        //
        public Font Textfont { get; set; } = new Font();
        public string Textinfo { get; set; }
        public object Colorscale { get; set; }
        public bool? Showscale { get; set; }
        public bool? Reversescale { get; set; }
        public int? Ncontours { get; set; }

        

    }
}
