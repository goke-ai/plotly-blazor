// This file is to show how a library package may provide JavaScript interop features
// wrapped in a .NET API

window.plotlyChart = (element, chart, dotnetHelper) => {

    var myPlot = element,
        d3 = Plotly.d3,
        data = chart.traces,
        layout = chart.layout,
        config = chart.config;

    Plotly.newPlot(element, data, layout, config);

    myPlot.on('plotly_click', function (eventData) {

        var dataClicked = {
            event: eventData.event,
        };
        var points = [];

        for (var i = 0; i < eventData.points.length; i++) {

            var point = {
                curveNumber: eventData.points[i].curveNumber,
                pointIndex: eventData.points[i].pointIndex,
                pointNumber: eventData.points[i].pointNumber,
                text: eventData.points[i].text,
                x: eventData.points[i].x,
                y: eventData.points[i].y,
                z: eventData.points[i].z,
                i: eventData.points[i].i,
                v: eventData.points[i].v,
                value: eventData.points[i].value,
                label: eventData.points[i].label,
                percent: eventData.points[i].percent,
                color: eventData.points[i].color,
                trace: eventData.points[i].data,
            };

            points.push(point);
        }
        
        dataClicked['points'] = points;
        // fix layout title
        var layout = myPlot.layout;
        layout.title = layout.title?.text;
        dataClicked['layout'] = layout;

        dotnetHelper.invokeMethodAsync('Clicked', (dataClicked))
            .then(r => {
                switch (r.mode) {
                    case "l":
                        Plotly.relayout(element, r.data);
                        break;
                    default:
                        break;
                }
            });

    });
}
