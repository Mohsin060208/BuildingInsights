google.charts.load("current", { packages: ['corechart'] });
google.charts.setOnLoadCallback(GetRecords);

function GetRecords() {
    $.ajax({
        type: "GET",
        url: "/api/Insights/Get",
        headers: {
            'Content-Type': 'application/json'
        },
        data: {
            "Year": 2018,
            "BuildingId": 1
        },
        success: function (r) {
            document.getElementById("p-total-saving").innerText = ("$" + r[0].TotalSaving);
            document.getElementById("p-total-cost").innerText = ("$" + r[0].TotalCost);
            var array = new Array();
            var colors = ["#f37277", "#8de9aa", "#c3c3c3"];
            array.push(new Array("Year", "Failure",
                { role: "style" }));
            arr = jQuery.grep(r[1], function (item) {
                return (item.Type == "Elevator");
            });
            arr.map(function (obj,i) {
                array.push(new Array(obj.Year, obj.Failure, colors[i]));
            });
            drawChartElevatorFailure(array);
            var array = new Array();
            array.push(new Array("Year", "Failure",
                { role: "style" }));
            arr = jQuery.grep(r[1], function (item) {
                return (item.Type == "Boiler");
            });
            arr.map(function (obj,i) {
                array.push(new Array(obj.Year, obj.Failure, colors[i]));
            });
            drawChartBoilerFailure(array);
            var array = new Array();
            array.push(new Array("Year", "Failure",
                { role: "style" }));
            arr = jQuery.grep(r[1], function (item) {
                return (item.Type == "Chiller");
            });
            arr.map(function (obj,i) {
                array.push(new Array(obj.Year, obj.Failure, colors[i]));
            });
            drawChartChillerFailure(array);
            var array = new Array();
            array.push(new Array("Year", "Cost",
                { role: "style" }));
            arr = jQuery.grep(r[1], function (item) {
                return (item.Type == "Elevator");
            });
            arr.map(function (obj,i) {
                array.push(new Array(obj.Year, obj.Cost, colors[i]));
            });
            drawChartElevatorSpend(array);
            var array = new Array();
            array.push(new Array("Year", "Cost",
                { role: "style" }));
            arr = jQuery.grep(r[1], function (item) {
                return (item.Type == "Boiler");
            });
            arr.map(function (obj,i) {
                array.push(new Array(obj.Year, obj.Cost, colors[i]));
            });
            drawChartBoilerCost(array);
            var array = new Array();
            array.push(new Array("Year", "Cost",
                { role: "style" }));
            arr = jQuery.grep(r[1], function (item) {
                return (item.Type == "Operational Plumbing");
            });
            arr.map(function (obj,i) {
                array.push(new Array(obj.Year, obj.Cost, colors[i]));
            });
            drawChartPlumberOperational(array);
            var array = new Array();
            array.push(new Array("Year", "Cost",
                { role: "style" }));
            arr = jQuery.grep(r[1], function (item) {
                return (item.Type == "Plumbing");
            });
            arr.map(function (obj,i) {
                array.push(new Array(obj.Year, obj.Cost, colors[i]));
            });
            drawChartPlumberSpend(array);
            var array = new Array();
            array.push(new Array("Year", "Cost",
                { role: "style" }));
            arr = jQuery.grep(r[1], function (item) {
                return (item.Type == "Chiller");
            });
            arr.map(function (obj,i) {
                array.push(new Array(obj.Year, obj.Cost, colors[i]));
            });
            drawChartChillerCost(array);
        },
        failure: function (r) {
            alert("Failed");
        },
        error: function (r) {
            alert(r);
        }
    });
}