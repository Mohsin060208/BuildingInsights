$(document).ready(function () {
    GetTotalCost();
    GetTotalSaving();
    google.charts.load("current", { packages: ['corechart'] });
    google.charts.setOnLoadCallback(drawChartElevatorFailure);
    google.charts.setOnLoadCallback(drawChartElevatorSpend);
    google.charts.setOnLoadCallback(drawChartPlumberSpend);
    google.charts.setOnLoadCallback(drawChartPlumberOperational);
    google.charts.setOnLoadCallback(drawChartBoilerFailure);
    google.charts.setOnLoadCallback(drawChartBoilerCost);
    google.charts.setOnLoadCallback(drawChartChillerFailure);
    google.charts.setOnLoadCallback(drawChartChillerCost);
})
$('#button-save-insights').click(function () {
    SaveTotalCost();
    SaveTotalSaving();
    SavePlumbingCost();
    SaveOperationalPlumbingCost();
    SaveElevatorFailure();
    SaveElevatorCost();
    SaveChillerFailure();
    SaveChillerCost();
    SaveBoilerFailure();
    SaveBoilerCost();
})
$('#button-total-cost-save').click(function () {
    SaveTotalCost();
})

$('#button-total-savings-save').click(function () {
    SaveTotalSaving()
})
$('#button-save-elevator-failure').click(function () {
    SaveElevatorFailure()
})
$('#button-save-elevator-cost').click(function () {
    SaveElevatorCost();
})

$('#button-save-plumbing-cost').click(function () {
    SavePlumbingCost();
})

$('#button-save-operational-plumbing').click(function () {
    SaveOperationalPlumbingCost();
})

$('#button-save-boiler-failure').click(function () {
    SaveBoilerFailure();
})

$('#button-save-boiler-cost').click(function () {
    SaveBoilerCost();
})

$('#button-save-chiller-failure').click(function () {
    SaveChillerFailure();
})

$('#button-save-chiller-cost').click(function () {
    SaveChillerCost();
})
$("#select-year-saving").change(function () {
    GetTotalSaving();
});
$("#select-year-cost").change(function () {
    GetTotalCost();
});
function SaveTotalCost() {
    var tb = document.getElementById("tb-total-cost").value;
    var p = "p-building-total-cost";
    var valid = Validation(tb, p);
    if (tb !== "" && valid == true) { 
        $.ajax({
            type: "POST",
            url: "/api/YearlyRecordBook/InsertUpdateTotalCost",
            data: {
                Year: $("#select-year-cost").val(),
                TotalCost: $("#tb-total-cost").val(),
                BuildingId: 1
            },
            success: function (r) {
                GetTotalCost();
                $("#tb-total-cost").val("")
            },
            failure: function (r) {
                alert(r);
            },
            error: function (r) {
                alert(r);
            }
        });
    }
}
function SaveTotalSaving() {
    var tb = document.getElementById("tb-total-savings").value;
    var p = "p-building-total-savings";
    var valid = Validation(tb, p);
    if (tb !== "" && valid == true) {
        $.ajax({
            type: "POST",
            url: "/api/YearlyRecordBook/InsertUpdateTotalSaving",
            data: {
                Year: $("#select-year-saving").val(),
                TotalSaving: $("#tb-total-savings").val(),
                BuildingId: 1
            },
            success: function (r) {
                GetTotalSaving();
                $("#tb-total-savings").val("");
            },
            failure: function (r) {
                alert(r);
            },
            error: function (r) {
                alert(r);
            }
        });
    }
}
function SaveElevatorFailure() {
    var model = {
        Tb: "tb-elevator-failure",
        P: "p-elevator-failure",
        Type: "Elevator",
        Year: $("#select-year-elevator-failure").val(),
        Failure: $("#tb-elevator-failure").val(),
        Function: drawChartElevatorFailure
    }
    SaveFailures(model);
}
function SaveBoilerFailure() {
    var model = {
        Tb: "tb-boiler-failure",
        P: "p-boiler-failure",
        Type: "Boiler",
        Year: $("#select-year-boiler-failure").val(),
        Failure: $("#tb-boiler-failure").val(),
        Function: drawChartBoilerFailure
    }
    SaveFailures(model);
}
function SaveChillerFailure() {
    var model = {
        Tb: "tb-chiller-failure",
        P: "p-chiller-failure",
        Type: "Chiller",
        Year: $("#select-year-chiller-failure").val(),
        Failure: $("#tb-chiller-failure").val(),
        Function: drawChartChillerFailure
    }
    SaveFailures(model);
}
function SaveElevatorCost() {
    var model = {
        Tb: "tb-elevator-cost",
        P: "p-elevator-cost",
        Type: "Elevator",
        Year: $("#select-year-elevator-cost").val(),
        Cost: $("#tb-elevator-cost").val(),
        Function: drawChartElevatorSpend
    }
    SaveCosts(model);
}

function SavePlumbingCost() {
    var model = {
        Tb: "tb-plumbing-cost",
        P: "p-plumbing-cost",
        Type: "Plumbing",
        Year: $("#select-year-plumbing").val(),
        Cost: $("#tb-plumbing-cost").val(),
        Function: drawChartPlumberSpend
    }
    SaveCosts(model);
}
function SaveOperationalPlumbingCost() {
    var model = {
        Tb: "tb-operational-plumbing-cost",
        P: "p-operational-plumbing-cost",
        Type: "Operational Plumbing",
        Year: $("#select-year-operational-plumbing").val(),
        Cost: $("#tb-operational-plumbing-cost").val(),
        Function: drawChartPlumberOperational
    }
    SaveCosts(model);
}

function SaveBoilerCost() {
    var model = {
        Tb: "tb-boiler-cost",
        P: "p-boiler-cost",
        Type: "Boiler",
        Year: $("#select-year-boiler-cost").val(),
        Cost: $("#tb-boiler-cost").val(),
        Function: drawChartBoilerCost
    }
    SaveCosts(model);
}

function SaveChillerCost() {  
    var model = {
        Tb: "tb-chiller-cost",
        P: "p-chiller-cost",
        Type: "Chiller",
        Year: $("#select-year-chiller-cost").val(),
        Cost: $("#tb-chiller-cost").val(),
        Function: drawChartChillerCost
    }
    SaveCosts(model);
}



function drawChartElevatorFailure() {
    var model = {
        Type: "Elevator",
        Div: "chart-elevator-failure"
    }
    GetFailures(model);
}

function drawChartElevatorSpend() {
    var model = {
        Type: "Elevator",
        Div: "chart-elevator-spend"
    }
    GetCosts(model);
}

function drawChartPlumberSpend() {
    var model = {
        Type: "Plumbing",
        Div: "chart-plumber-spend"
    }
    GetCosts(model);
}

function drawChartPlumberOperational() {
    var model = {
        Type: "Operational Plumbing",
        Div: "chart-plumber-operational"
    }
    GetCosts(model);
}

function drawChartBoilerFailure() {
    var model = {
        Type: "Boiler",
        Div: "chart-boiler-failure"
    }
    GetFailures(model);
}

function drawChartBoilerCost() {
    var model = {
        Type: "Boiler",
        Div: "chart-boiler-cost"
    }
    GetCosts(model);
}

function drawChartChillerFailure() {
    var model = {
        Type: "Chiller",
        Div: "chart-chiller-failure"
    }
    GetFailures(model);
}

function drawChartChillerCost() {
    var model = {
        Type: "Chiller",
        Div: "chart-chiller-cost"
    }
    GetCosts(model);
}
function GetTotalCost() {
    $.ajax({
        type: "GET",
        url: "/api/YearlyRecordBook/GetTotalCost",
        headers: {
            'Content-Type': 'application/json'
        },
        data: {
            "Year": $("#select-year-cost").val(),
            "BuildingId": 1
        },
        success: function (r) {
            document.getElementById("p-total-cost").innerText = ("$" + r.TotalCost);
        },
        failure: function (r) {
            alert(r);
        },
        error: function (r) {
            alert(r);
        }
    });
}
function GetTotalSaving() {
    $.ajax({
        type: "GET",
        url: "/api/YearlyRecordBook/GetTotalSaving",
        headers: {
            'Content-Type': 'application/json'
        },
        data: {
            "Year": $("#select-year-saving").val(),
            "BuildingId": 1
        },
        success: function (r) {
            document.getElementById("p-total-saving").innerText = ("$" + r.TotalSaving);
        },
        failure: function (r) {
            alert(r);
        },
        error: function (r) {
            alert(r);
        }
    });
}
function Validation(tb, p) {    
    for (var i = 0; i < tb.length; i++) {
        var thisChar = parseInt(tb[i]);
        if (isNaN(thisChar)) {
            document.getElementById(p).className = "error";
            return false;
        }
    }
    document.getElementById(p).className = "d-none";
    return true;
}
function SaveFailures(model) {
    var tb = document.getElementById(model.Tb).value;
    var valid = Validation(tb, model.P);
    if (tb !== "" && valid == true) {
        $.ajax({
            type: "POST",
            url: "/api/mechanics/InsertUpdateMechanicsFailure",
            data: {
                Type: model.Type,
                Year: model.Year,
                Failure: model.Failure,
                BuildingId: 1
            },
            success: function (r) {
                document.getElementById(model.Tb).value = "";
                model.Function();
            },
            failure: function (r) {
                alert(r);
            },
            error: function (r) {
                alert(r);
            }
        });
    }
}

function SaveCosts(model) {
    var tb = document.getElementById(model.Tb).value;    
    var valid = Validation(tb,model.P);
    if (tb !== null && valid == true) {
        $.ajax({
            type: "POST",
            url: "/api/mechanics/InsertUpdateMechanicsCost",
            data: {
                Type: model.Type,
                Year: model.Year,
                Cost: model.Cost,
                BuildingId: 1
            },
            success: function (r) {
                document.getElementById(model.Tb).value = "";
                model.Function();
            },
            failure: function (r) {
                alert(r);
            },
            error: function (r) {
                alert(r);
            }
        });
    }
}
function GetFailures(model) {
    var options = {
        bar: { groupWidth: "100%" },
        legend: { position: "none" },
    };
    $.ajax({
        type: "GET",
        url: "/api/mechanics/GetFailureChartData",
        data: { "Type": model.Type },
        headers: {
            'Content-Type': 'application/json'
        },
        success: function (r) {
            document.getElementById(model.Div).innerHTML = "";
            var data = google.visualization.arrayToDataTable(r);
            var chart = new google.visualization.ColumnChart(document.getElementById(model.Div));
            var view = new google.visualization.DataView(data);
            chart.draw(view, options);
            $(window).resize(function () {
                var view = new google.visualization.DataView(data);
                chart.draw(view, options);
            })
        },
        failure: function (r) {
            alert(r);
        },
        error: function (r) {
            alert(r);
        }
    });
}
function GetCosts(model) {
    var options = {
        bar: { groupWidth: "100%" },
        legend: { position: "none" },
    };
    $.ajax({
        type: "GET",
        url: "/api/mechanics/GetCostChartData",
        data: { "Type": model.Type },
        headers: {
            'Content-Type': 'application/json'
        },
        success: function (r) {
            document.getElementById(model.Div).innerHTML = "";
            var data = google.visualization.arrayToDataTable(r);
            var chart = new google.visualization.ColumnChart(document.getElementById(model.Div));
            var view = new google.visualization.DataView(data);
            chart.draw(view, options);
            $(window).resize(function () {
                var view = new google.visualization.DataView(data);
                chart.draw(view, options);
            })
        },
        failure: function (r) {
            alert(r);
        },
        error: function (r) {
            alert(r);
        }
    });
}