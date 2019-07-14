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
            "BuildingId": 1,
        },
        success: function (r) {
            var arr = jQuery.grep(r, function (item) {
                return (item.Type == "MaintenanceCost" && item.Year == "2018");
            });
            arr.map(function (obj) {
                document.getElementById("p-total-cost").innerText = ("$" + obj.Cost);    
            });
            var arr = jQuery.grep(r, function (item) {
                return (item.Type == "MaintenanceSaving" && item.Year == "2018");
            });
            arr.map(function (obj) {
                document.getElementById("p-total-saving").innerText = ("$" + obj.Cost);
            });
            drawFailureCharts(r)
            drawCostCharts(r);
        },
        failure: function (r) {
            alert("Failed");
        },
        error: function (r) {
            alert(r);
        }
    });
}
function drawFailureCharts(r) {
    drawChartElevatorFailure(r);
    drawChartChillerFailure(r);
    drawChartBoilerFailure(r);
}
function drawCostCharts(r) {
    drawChartElevatorSpend(r);
    drawChartChillerCost(r);
    drawChartBoilerCost(r);
    drawChartPlumberSpend(r);
    drawChartPlumberOperational(r);
}