anychart.onDocumentReady(function () {
    // create area chart
    var chart = anychart.area();

    // set chart title text settings
    chart
        .title()
        .enabled(true)
        .useHtml(true)
        .text(
            'WebSite Metrics 2017<br/>' +
            '<span style="color:#212121; font-size: 13px;">(unique visitors)</span>'
        );

    // axis title
    chart.yAxis().title('Number of Visitors');

    // create a logarithmic scale
    var logScale = anychart.scales.log();
    // set scale for the chart
    chart.yScale(logScale);

    // create area series on passed data
    var series = chart.area([
        ['Jan', 12],
        ['Feb', 120],
        ['Mar', 229],
        ['Apr', 990],
        ['May', 4104],
        ['Jun', 3250],
        ['Jul', 5720],
        ['Aug', 43152],
        ['Sep', 41251],
        ['Oct', 50458],
        ['Nov', 45012],
        ['Dec', 62548]
    ]);

    // set series data labels settings
    series
        .labels()
        .enabled(true)
        .fontColor('#212121')
        .position('center-top')
        .anchor('center-bottom');

    // turn on series markers
    series.markers().enabled(true).fill('#1976d2');

    // set series name
    series
        .name('Number of Visitors')
        // set stroke for series
        .stroke('2 #1976d2')
        // set fill for series
        .fill(['#64b5f6', '#fff'], -90);

    var annotation = chart.annotations();
    // create first label annotation and set settings
    annotation
        .label()
        .xAnchor('Jan')
        .valueAnchor(12)
        .anchor('left-top')
        .padding(6)
        .offsetY(15)
        .text('Release')
        .fontColor('#fff')
        .background({
            fill: '#1976d2 0.85',
            stroke: '#1976d2',
            corners: 7
        })
        .allowEdit(false);

    // create second label annotation and set settings
    annotation
        .label()
        .xAnchor('May')
        .valueAnchor(4104)
        .anchor('center-top')
        .padding(6)
        .offsetY(-55)
        .text('Radio advertisement')
        .fontColor('#fff')
        .background({
            fill: 'green 0.75',
            stroke: '0.85 green',
            corners: 7
        })
        .allowEdit(false);

    // create third label annotation and set settings
    annotation
        .label()
        .xAnchor('Aug')
        .valueAnchor(43152)
        .anchor('center-top')
        .padding(6)
        .offsetY(-55)
        .text('TV advertisement')
        .fontColor('#fff')
        .background({
            fill: 'green 0.75',
            stroke: '0.85 green',
            corners: 7
        })
        .allowEdit(false);

    // set up tooltips and interactivity settings
    series
        .tooltip()
        .position('center-top')
        .positionMode('point')
        .anchor('left-top')
        .offsetX(5)
        .offsetY(5);

    // set interactivity
    chart.interactivity().hoverMode('by-x');

    // set container for the chart
    chart.container('container');
    // initiate chart drawing
    chart.draw();
});