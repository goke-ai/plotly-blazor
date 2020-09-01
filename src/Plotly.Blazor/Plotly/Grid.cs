namespace Goke.Plotly.Blazor
{
    public struct Pattern
    {
        public const string Default = "";
        public const string Independent = "independent";
    }

    public class Grid
    {
        public int? Rows { get; set; }
        public int? Columns { get; set; }
        public string Pattern { get; set; }
    }
}