// This file is to show how a library package may provide JavaScript interop features
// wrapped in a .NET API

window.plotlyChart = (element, chart) => {

    var data = chart.traces;
    var layout = chart.layout;
    var config = chart.config;

    Plotly.newPlot(element, data, layout, config);
}
