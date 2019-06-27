google.charts.load("current", { packages: ['corechart'] });
google.charts.setOnLoadCallback(drawChartElevatorFailure);
google.charts.setOnLoadCallback(drawChartElevatorSpend);
google.charts.setOnLoadCallback(drawChartPlumberSpend);
google.charts.setOnLoadCallback(drawChartPlumberOperational);
google.charts.setOnLoadCallback(drawChartBoilerFailure);
google.charts.setOnLoadCallback(drawChartBoilerCost);
google.charts.setOnLoadCallback(drawChartChillerFailure);
google.charts.setOnLoadCallback(drawChartChillerCost);

function drawChartElevatorFailure() {
    var data = google.visualization.arrayToDataTable([
        ["Year", "Rate", { role: "style" }],
        ["2017", 70, "#8de9aa"],
        ["2018", 5, "#f37277"],
        ["2019", 55, "#c3c3c3"],
    ]);
    var view = new google.visualization.DataView(data);
    var options = {
        bar: { groupWidth: "100%" },
        legend: { position: "none" },
    };
    var chart = new google.visualization.ColumnChart(document.getElementById("chart-elevator-failure"));
    chart.draw(view, options);
    $(window).resize(function () {
        var view = new google.visualization.DataView(data);
        chart.draw(view, options);
    })
}

function drawChartElevatorSpend() {
    var data = google.visualization.arrayToDataTable([
        ["Year", "Rate", { role: "style" }],
        ["2017", 6600, "#f37277"],
        ["2018", 4300, "#8de9aa"],
        ["2019", 5100, "#c3c3c3"],
    ]);

    var view = new google.visualization.DataView(data);
    var options = {
        bar: { groupWidth: "100%" },
        legend: { position: "none" },
    };
    var chart = new google.visualization.ColumnChart(document.getElementById("chart-elevator-spend"));
    chart.draw(view, options);
    $(window).resize(function () {
        var view = new google.visualization.DataView(data);
        chart.draw(view, options);
    })
}

function drawChartPlumberSpend() {
    var data = google.visualization.arrayToDataTable([
        ["Year", "Rate", { role: "style" }],
        ["2017", 2000, "#f37277"],
        ["2018", 5100, "#8de9aa"],
        ["2019", 2000, "#c3c3c3"],
    ]);

    var view = new google.visualization.DataView(data);
    var options = {
        bar: { groupWidth: "100%" },
        legend: { position: "none" },
    };
    var chart = new google.visualization.ColumnChart(document.getElementById("chart-plumber-spend"));
    chart.draw(view, options);
    $(window).resize(function () {
        var view = new google.visualization.DataView(data);
        chart.draw(view, options);
    })
}

function drawChartPlumberOperational() {
    var data = google.visualization.arrayToDataTable([
        ["Year", "Rate", { role: "style" }],
        ["2017", 17000000000, "#f37277"],
        ["2018", 19000000000, "#8de9aa"],
        ["2019", 5000000000, "#c3c3c3"],
    ]);

    var view = new google.visualization.DataView(data);
    var options = {
        bar: { groupWidth: "100%" },
        legend: { position: "none" },
    };
    var chart = new google.visualization.ColumnChart(document.getElementById("chart-plumber-operational"));
    chart.draw(view, options);
    $(window).resize(function () {
        var view = new google.visualization.DataView(data);
        chart.draw(view, options);
    })
}

function drawChartBoilerFailure() {
    var data = google.visualization.arrayToDataTable([
        ["Year", "Rate", { role: "style" }],
        ["2017", 200, "#f37277"],
        ["2018", 1900, "#8de9aa"],
        ["2019", 1900, "#c3c3c3"],
    ]);

    var view = new google.visualization.DataView(data);
    var options = {
        bar: { groupWidth: "100%" },
        legend: { position: "none" },
    };
    var chart = new google.visualization.ColumnChart(document.getElementById("chart-boiler-failure"));
    chart.draw(view, options);
    $(window).resize(function () {
        var view = new google.visualization.DataView(data);
        chart.draw(view, options);
    })
}

function drawChartBoilerCost() {
    var data = google.visualization.arrayToDataTable([
        ["Year", "Rate", { role: "style" }],
        ["2017", 221, "#f37277"],
        ["2018", 219, "#8de9aa"],
        ["2019", 220, "#c3c3c3"],
    ]);

    var view = new google.visualization.DataView(data);
    var options = {
        bar: { groupWidth: "100%" },
        legend: { position: "none" },
    };
    var chart = new google.visualization.ColumnChart(document.getElementById("chart-boiler-cost"));
    chart.draw(view, options);
    $(window).resize(function () {
        var view = new google.visualization.DataView(data);
        chart.draw(view, options);
    })
}

function drawChartChillerFailure() {
    var data = google.visualization.arrayToDataTable([
        ["Year", "Rate", { role: "style" }],
        ["2017", 2018, "#f37277"],
        ["2018", 2017, "#8de9aa"],
        ["2019", 1800, "#c3c3c3"],
    ]);

    var view = new google.visualization.DataView(data);
    var options = {
        bar: { groupWidth: "100%" },
        legend: { position: "none" },
    };
    var chart = new google.visualization.ColumnChart(document.getElementById("chart-chiller-failure"));
    chart.draw(view, options);
    $(window).resize(function () {
        var view = new google.visualization.DataView(data);
        chart.draw(view, options);
    })
}

function drawChartChillerCost() {
    var data = google.visualization.arrayToDataTable([
        ["Year", "Rate", { role: "style" }],
        ["2017", 2018000, "#f37277"],
        ["2018", 2018000, "#8de9aa"],
        ["2019", 2000000, "#c3c3c3"],
    ]);

    var view = new google.visualization.DataView(data);
    var options = {
        bar: { groupWidth: "100%" },
        legend: { position: "none" },
    };
    var chart = new google.visualization.ColumnChart(document.getElementById("chart-chiller-cost"));
    chart.draw(view, options);
    $(window).resize(function () {
        var view = new google.visualization.DataView(data);
        chart.draw(view, options);
    })
}