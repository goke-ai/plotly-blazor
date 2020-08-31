// This file is to show how a library package may provide JavaScript interop features
// wrapped in a .NET API


window.plotlyDrawChart = (element, chart) => {

    var dataSets = chart.dataSets
    var title = chart.title
    var xLabel = chart.xLabel; // ;
    var yLabel = chart.yLabel; //

    console.log(xLabel);

    var data = [];
    var n = 1;

    for (var dataset of dataSets) {
        var x = [];
        var y = [];

        for (var d of dataset.data) {

            // for (var i = 0; i < d.length; i++) {
            x.push(d[0]);
            y.push(d[1]);
            // }
        }

        var series = {
            x: x,
            y: y,
            name: dataset.name,
            line: { shape: 'spline' },
            type: 'scatter'
        };

        data.push(series);
        n += 1;
    }

    var layout = {
        title: title,
        // width: 900,
        // height: 500,
        // margin: { t: 0 },
        xaxis: {
            type: 'linear',
            //range: [0, 6],
            ticks: 'outside',
            title: { text: xLabel },
            mirror: 'ticks',
            nticks: -1,
            ticklen: 5,
            showgrid: true,
            showline: true,
            zeroline: false,
            autorange: true,
            linewidth: 1,
            automargin: false,
            zerolinewidth: 1,
            showticklabels: true,
            separatethousands: false
        },
        yaxis: {
            type: 'linear',
            //range: [0.5555555555555555, 9.444444444444445],
            ticks: 'outside',
            title: { text: yLabel },
            mirror: 'ticks',
            nticks: -1,
            ticklen: 5,
            showline: true,
            zeroline: false,
            autorange: true,
            linewidth: 1,
            automargin: false,
            zerolinewidth: 1,
            showticklabels: true,
            separatethousands: false
        },
        legend: {
            //title: { text: '<br>' },
            //valign: 'middle',
            //xanchor: 'left',
            //yanchor: 'auto',
            bordercolor: '#eeeeee',
            borderwidth: 1,
            //orientation: 'v'
        },
        autosize: true,
        showlegend: true
    };

    // console.log(layout);

    var config = {
        responsive: true,
        toImageButtonOptions: {
            format: 'svg', // one of png, svg, jpeg, webp
            filename: 'custom_image',
            //height: 500,
            //width: 700,
            scale: 1 // Multiply title/legend/axis/canvas sizes by this factor
        }
    };

    Plotly.newPlot(element, data, layout, config);
}

window.plotlyBarChart = (element, chart) => {

    var data = chart.traces;
    var layout = chart.layout;
    var config = chart.config;

    Plotly.newPlot(element, data, layout, config);
}

window.plotlyPieChart = (element, chart) => {

    var data = chart.traces;
    var layout = chart.layout;
    var config = chart.config;

    Plotly.newPlot(element, data, layout, config);
}

window.plotlyChart = (element, chart) => {

    var data = chart.traces;
    var layout = chart.layout;
    var config = chart.config;

    Plotly.newPlot(element, data, layout, config);
}

window.plotlyChart2 = (element, chart) => {

    var data = chart.traces;
    var layout = chart.layout;
    var config = chart.config;

    Plotly.newPlot(element, data, layout, config);
}