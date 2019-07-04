// Save Insights Button
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

// Saving Total Cost
$('#button-total-cost-save').click(function () {
    SaveTotalCost();
})

// Saving Total Savings
$('#button-total-savings-save').click(function () {
    SaveTotalSaving()
})

// Saving Elevator Failure
$('#button-save-elevator-failure').click(function () {
    SaveElevatorFailure()
})

// Saving Elevator Cost
$('#button-save-elevator-cost').click(function () {
    SaveElevatorCost();
})

// Saving Plumbing Cost
$('#button-save-plumbing-cost').click(function () {
    SavePlumbingCost();
})

// Saving Operational Plumbing Cost
$('#button-save-operational-plumbing').click(function () {
    SaveOperationalPlumbingCost();
})

// Saving Boiler Failure
$('#button-save-boiler-failure').click(function () {
    SaveBoilerFailure();
})

// Saving Boiler Cost
$('#button-save-boiler-cost').click(function () {
    SaveBoilerCost();
})

// Saving Chiller Failure
$('#button-save-chiller-failure').click(function () {
    SaveChillerFailure();
})

// Saving Chiller Cost
$('#button-save-chiller-cost').click(function () {
    SaveChillerCost();
})

// Getting Total Saving on Year Selection
$("#select-year-saving").change(function () {
    GetTotalSaving();
});

// Getting Total Cost on Year Selection
$("#select-year-cost").change(function () {
    GetTotalCost();
});

/* All the functions are below
---------------------------------------------------------------------------------------
 */

// functions for saving

function SaveTotalCost() {
    var tb = document.getElementById("tb-total-cost").value;
    var p = "p-building-total-cost";
    var valid = Validation(tb, p);
    if (valid == true) { 
        $.ajax({
            type: "POST",
            url: "/api/YearlyRecordBook/InsertUpdateTotalCost",
            data: {
                Year: $("#select-year-cost").val(),
                TotalCost: $("#tb-total-cost").val(),
                BuildingId: 1
            },
            success: function (r) {
                document.getElementById("p-total-cost").innerText = ("$" + r.TotalCost);
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
    if (valid == true) {
        $.ajax({
            type: "POST",
            url: "/api/YearlyRecordBook/InsertUpdateTotalSaving",
            data: {
                Year: $("#select-year-saving").val(),
                TotalSaving: $("#tb-total-savings").val(),
                BuildingId: 1
            },
            success: function (r) {
                document.getElementById("p-total-saving").innerText = ("$" + r.TotalSaving);
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
function SaveFailures(model) {
    var tb = document.getElementById(model.Tb).value;
    var valid = Validation(tb, model.P);
    if (valid == true) {
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
                var array = new Array();
                var colors = ["#f37277", "#8de9aa","#c3c3c3"];
                array.push(new Array("Year", "Failure",
                {role: "style"}));
                arr = jQuery.grep(r, function (item) {
                    return (item.Type == model.Type);
                });
                arr.map(function (obj,i) {
                    array.push(new Array(obj.Year, obj.Failure, colors[i]));
                });
                model.Function(array);
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
    var valid = Validation(tb, model.P);
    if (valid == true) {
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
                var array = new Array();
                var colors = ["#f37277", "#8de9aa", "#c3c3c3"];
                array.push(new Array("Year", "Cost",
                    { role: "style" }));
                arr = jQuery.grep(r, function (item) {
                    return (item.Type == model.Type);
                });
                arr.map(function (obj,i) {
                    array.push(new Array(obj.Year, obj.Cost, colors[i]));
                });
                model.Function(array);
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

// Functions for Getting Data

function drawChartElevatorFailure(data) {
    var model = {
        Div: "chart-elevator-failure",
        Data: data
    }
    drawChart(model);
}

function drawChartElevatorSpend(data) {
    var model = {
        Data: data,
        Div: "chart-elevator-spend"
    }
    drawChart(model);
}

function drawChartPlumberSpend(data) {
    var model = {
        Data: data,
        Div: "chart-plumber-spend"
    }
    drawChart(model);
}

function drawChartPlumberOperational(data) {
    var model = {
        Data: data,
        Div: "chart-plumber-operational"
    }
    drawChart(model);
}

function drawChartBoilerFailure(data) {
    var model = {
        Div: "chart-boiler-failure",
        Data: data
    }
    drawChart(model);
}

function drawChartBoilerCost(data) {
    var model = {
        Div: "chart-boiler-cost",
        Data: data
    }
    drawChart(model);
}

function drawChartChillerFailure(data) {
    var model = {
        Div: "chart-chiller-failure",
        Data: data
    }
    drawChart(model);
}

function drawChartChillerCost(data) {
    var model = {
        Div: "chart-chiller-cost",
        Data: data
    }
    drawChart(model);
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

function drawChart(model) {
    var options = {
        bar: { groupWidth: "100%" },
        //legend: { position: "none" }
    };
    document.getElementById(model.Div).innerHTML = "";
    var data = google.visualization.arrayToDataTable(model.Data);
    var chart = new google.visualization.ColumnChart(document.getElementById(model.Div));
    var view = new google.visualization.DataView(data);
    chart.draw(view, options);
    $(window).resize(function () {
        var view = new google.visualization.DataView(data);
        chart.draw(view, options);
    })
}

// Function for Validation of input

function Validation(tb, p) {
    if (tb.length == 0) {
        document.getElementById(p).className = "d-none";
        return false;
    }
    else {
        for (var i = 0; i < tb.length; i++) {
            var thisChar = parseInt(tb[i]);
            if (isNaN(thisChar)) {
                document.getElementById(p).className = "error";
                return false;
            }
        }
    }
        document.getElementById(p).className = "d-none";
        return true;
}