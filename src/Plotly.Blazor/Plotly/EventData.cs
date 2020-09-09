using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Text;

namespace Goke.Plotly.Blazor
{
    public class EventData
    {
        public Point[] Points { get; set; }
        public MouseEventArgs Event { get; set; }
        public Layout Layout { get; set; }


        public class Point
        {
            public int? CurveNumber { get; set; }
            public int? PointIndex { get; set; }
            public int? PointNumber { get; set; }
            public object X { get; set; }
            public object Y { get; set; }
            public object Z { get; set; }
            public string Text { get; set; }
            public string Name { get; set; }
            public string Label { get; set; }

            //pie
            public int? I { get; set; }
            public int? V { get; set; }
            public object Value { get; set; }
            public object Color { get; set; }
            public double? Percent { get; set; }

            //
            public Trace Trace { get; set; }

            //public Axis Xaxis { get; set; }
            //public Axis Yaxis { get; set; }


        }

    }
    public class ReturnData
    {
        public string Mode { get; set; }
        public Dictionary<string, object> Data { get; set; }

    }

}
