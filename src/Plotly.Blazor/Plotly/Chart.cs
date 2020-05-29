using System;
using System.Collections.Generic;
using System.Text;

namespace Goke.Plotly.Blazor
{
    public class Chart
    {
        public string Title { get; set; }
        public string XLabel { get; set; }
        public string YLabel { get; set; }
        public List<ChartDataSet> DataSets { get; set; }
    }
}
