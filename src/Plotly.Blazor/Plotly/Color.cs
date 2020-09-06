using System;
using System.Collections.Generic;
using System.Text;

namespace Goke.Plotly.Blazor
{
    public class Color
    {
        public static string[] Colors = { "#1f77b4", "#ff7f0e", "#2ca02c", "#d62728", "#9467bd", "#8c564b", "#e377c2", "#7f7f7f", "#bcbd22", "#17becf" };
        // in trace originally
        public static string[] Colors2 = { "rgb(255,0,0)", "rgb(0,255,0)", "rgb(0,0,255)", "rgb(255,0,255)", "rgb(255,255,0)", "rgb(0,255,255)" };

        private string[] _colors;

        public Color(string[] colors)
        {
            _colors = colors;
        }

    }
}
