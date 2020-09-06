namespace Goke.Plotly.Blazor
{
    public class Marker
    {
        public object Color { get; set; }
        public object[] Colors { get; set; }
        public float? Opacity { get; set; }
        public Line Line { get; set; } = new Line();
        public int? Size { get; set; }

        public bool? Cauto { get; set; }
        public bool? Autocolorscale { get; set; }
        public bool? Reversescale { get; set; }
        public object Cmin { get; set; }
        public object Cmax { get; set; }
        public object Colorscale { get; set; }
        public bool? Showscale { get; set; }
    }
}