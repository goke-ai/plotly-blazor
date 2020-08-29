namespace Goke.Plotly.Blazor
{
    public class Marker
    {
        public object Color { get; set; }
        public object[] Colors { get; set; }
        public float? Opacity { get; set; }
        public Line Line { get; set; } = new Line();
        public int? Size { get; set; }
    }
}