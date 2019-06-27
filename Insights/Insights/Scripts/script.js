$(document).ready(function () {
    google.charts.load("current", { packages: ['corechart'] });
    google.charts.setOnLoadCallback(drawChartElevatorFailure);
    google.charts.setOnLoadCallback(drawChartElevatorSpend);
    google.charts.setOnLoadCallback(drawChartPlumberSpend);
    google.charts.setOnLoadCallback(drawChartPlumberOperational);
    google.charts.setOnLoadCallback(drawChartBoilerFailure);
    google.charts.setOnLoadCallback(drawChartBoilerCost);
    google.charts.setOnLoadCallback(drawChartChillerFailure);
    google.charts.setOnLoadCallback(drawChartChillerCost);
    $.ajax({
        type: "POST",
        url: "/api/YearlyRecordBook/GetTotalCost",
        dataType: "json",
        data: {
            Year: 2018,
            BuildingId: 1
        },
        success: function (r) {            
            document.getElementById("p-total-cost").innerText = ("$" + r.TotalCost);
        },
        failure: function (r) {
            alert(r.d);
        },
        error: function (r) {
            alert(r.d);
        }
    });
    $.ajax({
        type: "POST",
        url: "/api/YearlyRecordBook/GetTotalSaving",
        data: {
            year: 2018,
            buildingid: 1
        },
        success: function (r) {
            document.getElementById("p-total-saving").innerText = ("$" + r.TotalSaving);
        },
        failure: function (r) {
            alert(r.d);
        },
        error: function (r) {
            alert(r.d);
        }
    });
});
$('#button-save-insights').click(function () {
    SaveInsights();
})
function SaveInsights() {
    SaveTotalCost();
}
function SaveTotalCost(model) {
    $.ajax({
        type: "POST",
        url: "/api/YearlyRecordBook/InsertUpdateTotalCost",
        data: {
            Year: model.Year,
            TotalCost: model.TotalCost,
            BuildingId: 1
        },
        success: function (r) {
           
            $.ajax({
                type: "GET",
                url: "/api/YearlyRecordBook/GetTotalCost",
                headers: {
                    'Content-Type': 'application/json'
                },
                data: {
                    "Year": 2018,
                    "BuildingId": 1
                },
                success: function (r) {
                    document.getElementById(model.P_TotalCost).innerText = ("$" + r.TotalCost);
                    document.getElementById(model.Tb_TotalCost).innerText = "";
                },
                failure: function (r) {
                    alert(r.d);
                },
                error: function (r) {
                    alert(r.d);
                }
            });
        },
        failure: function (r) {
            alert(r.d);
        },
        error: function (r) {
            alert(r.d);
        }
    });
}
function SaveTotalSaving(model) {
    $.ajax({
        type: "POST",
        url: "/api/YearlyRecordBook/InsertUpdateTotalSaving",
        data: {
            Year: model.Year,
            TotalSaving: model.TotalSaving,
            BuildingId: 1
        },
        success: function (r) {
            document.getElementById(model.P_TotalSaving).innerText = ("$" + r.TotalSaving);
            document.getElementById(model.Tb_TotalSaving).innerText = "";
        },
        failure: function (r) {
            alert(r.d);
        },
        error: function (r) {
            alert(r.d);
        }
    });
}
$('#button-total-cost-save').click(function () {
    var model = {
        Year: $("#select-year-cost").val(),
        TotalCost: $("#tb-total-cost").val(),
        P_TotalCost: "p-total-cost",
        Tb_TotalCost: "tb-total-cost"
    }
    SaveTotalCost(model)
})

$('#button-total-savings-save').click(function () {
    var model = {
        Year: $("#select-year-saving").val(),
        TotalSaving: $("#tb-total-savings").val(),
        P_TotalSaving: "p-total-saving",
        Tb_TotalSaving: "tb-total-savings"
    }
    SaveTotalSaving(model)
})
    $('#button-save-elevator-failure').click(function () {
        $.ajax({
            type: "POST",
            url: "/api/mechanics/InsertUpdateMechanicsFailure",
            data: {
                Type: "Elevator",
                Year: $("#select-year-elevator-failure").val(),
                Failure: $("#tb-elevator-failure").val(),
                BuildingId: 1
            },
            success: function (r) {
                $("#tb-elevator-failure").val("");
                drawChartElevatorFailure();
            },
            failure: function (r) {
                alert(r.d);
            },
            error: function (r) {
                alert(r.d);
            }
        });
    })
    $('#button-save-elevator-cost').click(function () {
        $.ajax({
            type: "POST",
            url: "/api/mechanics/InsertUpdateMechanicsCost",
            data: {
                Type: "Elevator",
                Year: $("#select-year-elevator-cost").val(),
                Cost: $("#tb-elevator-cost").val(),
                BuildingId: 1
            },
            success: function (r) {
                $("#tb-elevator-cost").val("");
                drawChartElevatorSpend();
            },
            failure: function (r) {
                alert(r.d);
            },
            error: function (r) {
                alert(r.d);
            }
        });
    })

    $('#button-save-plumbing-cost').click(function () {
        $.ajax({
            type: "POST",
            url: "/api/mechanics/InsertUpdateMechanicsCost",
            data: {
                Type: "Plumbing",
                Year: $("#select-year-plumbing").val(),
                Cost: $("#tb-plumbing-cost").val(),
                BuildingId: 1
            },
            success: function (r) {
                $("#tb-plumbing-cost").val("");
                drawChartPlumberSpend();
            },
            failure: function (r) {
                alert(r.d);
            },
            error: function (r) {
                alert(r.d);
            }
        });
    })

    $('#button-save-operational-plumbing').click(function () {
        $.ajax({
            type: "POST",
            url: "/api/mechanics/InsertUpdateMechanicsCost",
            data: {
                Type: "Operational Plumbing",
                Year: $("#select-year-operational-plumbing").val(),
                Cost: $("#tb-operational-plumbing-cost").val(),
                BuildingId: 1
            },
            success: function (r) {
                $("#tb-operational-plumbing-cost").val("");
                drawChartPlumberOperational();
            },
            failure: function (r) {
                alert(r.d);
            },
            error: function (r) {
                alert(r.d);
            }
        });
    })

    $('#button-save-boiler-failure').click(function () {
        $.ajax({
            type: "POST",
            url: "/api/mechanics/InsertUpdateMechanicsFailure",
            data: {
                Type: "Boiler",
                Year: $("#select-year-boiler-failure").val(),
                Failure: $("#tb-boiler-failure").val(),
                BuildingId: 1
            },
            success: function (r) {
                $("#tb-boiler-failure").val("");
                drawChartBoilerFailure();
            },
            failure: function (r) {
                alert(r.d);
            },
            error: function (r) {
                alert(r.d);
            }
        });
    })

    $('#button-save-boiler-cost').click(function () {
        $.ajax({
            type: "POST",
            url: "/api/mechanics/InsertUpdateMechanicsCost",
            data: {
                Type: "Boiler",
                Year: $("#select-year-boiler-cost").val(),
                Cost: $("#tb-boiler-cost").val(),
                BuildingId: 1
            },
            success: function (r) {
                $("#tb-boiler-cost").val("");
                drawChartBoilerCost();
            },
            failure: function (r) {
                alert(r.d);
            },
            error: function (r) {
                alert(r.d);
            }
        });
    })

    $('#button-save-chiller-failure').click(function () {
        $.ajax({
            type: "POST",
            url: "/api/mechanics/InsertUpdateMechanicsFailure",
            data: {
                Type: "Chiller",
                Year: $("#select-year-chiller-failure").val(),
                Failure: $("#tb-chiller-failure").val(),
                BuildingId: 1
            },
            success: function (r) {
                $("#tb-chiller-failure").val("");
                drawChartChillerFailure();
            },
            failure: function (r) {
                alert(r.d);
            },
            error: function (r) {
                alert(r.d);
            }
        });
    })

    $('#button-save-chiller-cost').click(function () {
        $.ajax({
            type: "POST",
            url: "/api/mechanics/InsertUpdateMechanicsCost",
            data: {
                Type: "Chiller",
                Year: $("#select-year-chiller-cost").val(),
                Cost: $("#tb-chiller-cost").val(),
                BuildingId: 1
            },
            success: function (r) {
                $("#tb-chiller-cost").val("");
                drawChartChillerCost();
            },
            failure: function (r) {
                alert(r.d);
            },
            error: function (r) {
                alert(r.d);
            }
        });
    })


function drawChartElevatorFailure() {
    var options = {
        bar: { groupWidth: "100%" },
        legend: { position: "none" },
    };
    $.ajax({
        type: "GET",
        url: "/api/mechanics/GetFailureChartData",
        data: {"Type": "Elevator"},
        headers: {
            'Content-Type': 'application/json'
        },
        success: function (r) {
            var data = google.visualization.arrayToDataTable(r);
            var chart = new google.visualization.ColumnChart(document.getElementById("chart-elevator-failure"));
            var view = new google.visualization.DataView(data);
            chart.draw(view, options);
            $(window).resize(function () {
                var view = new google.visualization.DataView(data);
                chart.draw(view, options);
            })
        },
        failure: function (r) {
            alert(r.d);
        },
        error: function (r) {
            alert(r.d);
        }
    });


}

function drawChartElevatorSpend() {
    var options = {
        bar: { groupWidth: "100%" },
        legend: { position: "none" },
    };
    $.ajax({
        type: "GET",
        url: "/api/mechanics/GetCostChartData",
        data: { "Type": "Elevator" },
        headers: {
            'Content-Type': 'application/json'
        },
        success: function (r) {
            var data = google.visualization.arrayToDataTable(r);
            var chart = new google.visualization.ColumnChart(document.getElementById("chart-elevator-spend"));
            var view = new google.visualization.DataView(data);
            chart.draw(view, options);
            $(window).resize(function () {
                var view = new google.visualization.DataView(data);
                chart.draw(view, options);
            })
        },
        failure: function (r) {
            alert(r.d);
        },
        error: function (r) {
            alert(r.d);
        }
    });
}

function drawChartPlumberSpend() {
    var options = {
        bar: { groupWidth: "100%" },
        legend: { position: "none" },
    };
    $.ajax({
        type: "GET",
        url: "/api/mechanics/GetCostChartData",
        data: { "Type": "Plumbing" },
        headers: {
            'Content-Type': 'application/json'
        },
        success: function (r) {
            var data = google.visualization.arrayToDataTable(r);
            var chart = new google.visualization.ColumnChart(document.getElementById("chart-plumber-spend"));
            var view = new google.visualization.DataView(data);
            chart.draw(view, options);
            $(window).resize(function () {
                var view = new google.visualization.DataView(data);
                chart.draw(view, options);
            })
        },
        failure: function (r) {
            alert(r.d);
        },
        error: function (r) {
            alert(r.d);
        }
    });
}

function drawChartPlumberOperational() {
    var options = {
        bar: { groupWidth: "100%" },
        legend: { position: "none" },
    };
    $.ajax({
        type: "GET",
        url: "/api/mechanics/GetCostChartData",
        data: { "Type": "Operational Plumbing" },
        headers: {
            'Content-Type': 'application/json'
        },
        success: function (r) {
            var data = google.visualization.arrayToDataTable(r);
            var chart = new google.visualization.ColumnChart(document.getElementById("chart-plumber-operational"));
            var view = new google.visualization.DataView(data);
            chart.draw(view, options);
            $(window).resize(function () {
                var view = new google.visualization.DataView(data);
                chart.draw(view, options);
            })
        },
        failure: function (r) {
            alert(r.d);
        },
        error: function (r) {
            alert(r.d);
        }
    });
}

function drawChartBoilerFailure() {
    var options = {
        bar: { groupWidth: "100%" },
        legend: { position: "none" },
    };
    $.ajax({
        type: "GET",
        url: "/api/mechanics/GetFailureChartData",
        data: { "Type": "Boiler" },
        headers: {
            'Content-Type': 'application/json'
        },
        success: function (r) {
            var data = google.visualization.arrayToDataTable(r);
            var chart = new google.visualization.ColumnChart(document.getElementById("chart-boiler-failure"));
            var view = new google.visualization.DataView(data);
            chart.draw(view, options);
            $(window).resize(function () {
                var view = new google.visualization.DataView(data);
                chart.draw(view, options);
            })
        },
        failure: function (r) {
            alert(r.d);
        },
        error: function (r) {
            alert(r.d);
        }
    });
}

function drawChartBoilerCost() {
    var options = {
        bar: { groupWidth: "100%" },
        legend: { position: "none" },
    };
    $.ajax({
        type: "GET",
        url: "/api/mechanics/GetCostChartData",
        data: { Type: "Boiler" },
        headers: {
            'Content-Type': 'application/json'
        },
        success: function (r) {
            var data = google.visualization.arrayToDataTable(r);
            var chart = new google.visualization.ColumnChart(document.getElementById("chart-boiler-cost"));
            var view = new google.visualization.DataView(data);
            chart.draw(view, options);
            $(window).resize(function () {
                var view = new google.visualization.DataView(data);
                chart.draw(view, options);
            })
        },
        failure: function (r) {
            alert(r.d);
        },
        error: function (r) {
            alert(r.d);
        }
    });
}

function drawChartChillerFailure() {
    var options = {
        bar: { groupWidth: "100%" },
        legend: { position: "none" },
    };
    $.ajax({
        type: "GET",
        url: "/api/mechanics/GetFailureChartData",
        data: { "Type": "Chiller" },
        headers: {
            'Content-Type': 'application/json'
        },
        success: function (r) {
            var data = google.visualization.arrayToDataTable(r);
            var chart = new google.visualization.ColumnChart(document.getElementById("chart-chiller-failure"));
            var view = new google.visualization.DataView(data);
            chart.draw(view, options);
            $(window).resize(function () {
                var view = new google.visualization.DataView(data);
                chart.draw(view, options);
            })
        },
        failure: function (r) {
            alert(r.d);
        },
        error: function (r) {
            alert(r.d);
        }
    });
}

function drawChartChillerCost() {
    var options = {
        bar: { groupWidth: "100%" },
        legend: { position: "none" },
    };
    $.ajax({
        type: "GET",
        url: "/api/mechanics/GetCostChartData",
        data: { Type: "Chiller" },
        headers: {
            'Content-Type': 'application/json'
        },
        success: function (r) {
            var data = google.visualization.arrayToDataTable(r);
            var chart = new google.visualization.ColumnChart(document.getElementById("chart-chiller-cost"));
            var view = new google.visualization.DataView(data);
            chart.draw(view, options);
            $(window).resize(function () {
                var view = new google.visualization.DataView(data);
                chart.draw(view, options);
            })
        },
        failure: function (r) {
            alert(r.d);
        },
        error: function (r) {
            alert(r.d);
        }
    });
}