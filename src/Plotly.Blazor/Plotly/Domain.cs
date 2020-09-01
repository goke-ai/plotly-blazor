namespace Goke.Plotly.Blazor
{
    public class Domain
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public object[] X { get; internal set; }
        public object[] Y { get; internal set; }
    }
}