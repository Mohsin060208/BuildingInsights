$(document).ready(function () {
    google.charts.load("current", { packages: ['corechart'] });
    google.charts.setOnLoadCallback(GetRecords);
})
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
            array.push(new Array("Year", "Failure"));
            arr = jQuery.grep(r[1], function (item) {
                return (item.Type == "Elevator");
            });
            arr.map(function (obj) {
                array.push(new Array(obj.Year, obj.Failure));
            });
            drawChartElevatorFailure(array);
            var array = new Array();
            array.push(new Array("Year", "Failure"));
            arr = jQuery.grep(r[1], function (item) {
                return (item.Type == "Boiler");
            });
            arr.map(function (obj) {
                array.push(new Array(obj.Year, obj.Failure));
            });
            drawChartBoilerFailure(array);
            var array = new Array();
            array.push(new Array("Year", "Failure"));
            arr = jQuery.grep(r[1], function (item) {
                return (item.Type == "Chiller");
            });
            arr.map(function (obj) {
                array.push(new Array(obj.Year, obj.Failure));
            });
            drawChartChillerFailure(array);
            var array = new Array();
            array.push(new Array("Year", "Cost"));
            arr = jQuery.grep(r[1], function (item) {
                return (item.Type == "Elevator");
            });
            arr.map(function (obj) {
                array.push(new Array(obj.Year, obj.Cost));
            });
            drawChartElevatorSpend(array);
            var array = new Array();
            array.push(new Array("Year", "Cost"));
            arr = jQuery.grep(r[1], function (item) {
                return (item.Type == "Boiler");
            });
            arr.map(function (obj) {
                array.push(new Array(obj.Year, obj.Cost));
            });
            drawChartBoilerCost(array);
            var array = new Array();
            array.push(new Array("Year", "Cost"));
            arr = jQuery.grep(r[1], function (item) {
                return (item.Type == "Operational Plumbing");
            });
            arr.map(function (obj) {
                array.push(new Array(obj.Year, obj.Cost));
            });
            drawChartPlumberOperational(array);
            var array = new Array();
            array.push(new Array("Year", "Cost"));
            arr = jQuery.grep(r[1], function (item) {
                return (item.Type == "Plumbing");
            });
            arr.map(function (obj) {
                array.push(new Array(obj.Year, obj.Cost));
            });
            drawChartPlumberSpend(array);
            var array = new Array();
            array.push(new Array("Year", "Cost"));
            arr = jQuery.grep(r[1], function (item) {
                return (item.Type == "Chiller");
            });
            arr.map(function (obj) {
                array.push(new Array(obj.Year, obj.Cost));
            });
            drawChartChillerCost(array);
        },
        failure: function (r) {
            alert(r);
        },
        error: function (r) {
            alert(r);
        }
    });
}