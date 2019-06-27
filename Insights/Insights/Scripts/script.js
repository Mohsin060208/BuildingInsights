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
    function GetTotalCost() {
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
                "Year": 2018,
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

function SaveTotalCost() {
    var tb = document.getElementById("tb-total-cost").value;
    if (tb !== "") { 
        $.ajax({
            type: "POST",
            url: "/api/YearlyRecordBook/InsertUpdateTotalCost",
            data: {
                Year: $("#select-year-cost").val(),
                TotalCost: $("#tb-total-cost").val(),
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
                        document.getElementById("p-total-cost").innerText = ("$" + r.TotalCost);
                    },
                    failure: function (r) {
                        alert(r);
                    },
                    error: function (r) {
                        alert(r);
                    }
                });
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
    if (tb !== "") {
        $.ajax({
            type: "POST",
            url: "/api/YearlyRecordBook/InsertUpdateTotalSaving",
            data: {
                Year: $("#select-year-saving").val(),
                TotalSaving: $("#tb-total-savings").val(),
                BuildingId: 1
            },
            success: function (r) {
                $.ajax({
                    type: "GET",
                    url: "/api/YearlyRecordBook/GetTotalSaving",
                    headers: {
                        'Content-Type': 'application/json'
                    },
                    data: {
                        "Year": 2018,
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
    var tb = document.getElementById("tb-elevator-failure").value;
    if (tb !== "") {
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
                alert(r);
            },
            error: function (r) {
                alert(r);
            }
        });
    }
}
function SaveElevatorCost() {
    var tb = document.getElementById("tb-elevator-cost").value;
    if (tb !== "") {
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
                alert(r);
            },
            error: function (r) {
                alert(r);
            }
        });
    }
}
function SavePlumbingCost() {
    var tb = document.getElementById("tb-plumbing-cost").value;
    if (tb !== "") {
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
                alert(r);
            },
            error: function (r) {
                alert(r);
            }
        });
    }
}
function SaveOperationalPlumbingCost() {
    var tb = document.getElementById("tb-operational-plumbing-cost").value;
    if (tb !== "") {
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
                alert(r);
            },
            error: function (r) {
                alert(r);
            }
        });
    }
}
function SaveBoilerFailure() {
    var tb = document.getElementById("tb-boiler-failure").value;
    if (tb !== "") {
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
                alert(r);
            },
            error: function (r) {
                alert(r);
            }
        });
    }
}
function SaveBoilerCost() {
    var tb = document.getElementById("tb-boiler-cost").value;
    if (tb !== "") {
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
                alert(r);
            },
            error: function (r) {
                alert(r);
            }
        });
    }
}
function SaveChillerFailure() {
    var tb = document.getElementById("tb-chiller-failure").value;
    if (tb !== "") {
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
                alert(r);
            },
            error: function (r) {
                alert(r);
            }
        });
    }
}
function SaveChillerCost() {  
    var tb = document.getElementById("tb-chiller-cost").value;
    if (tb !== "") {
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
                alert(r);
            },
            error: function (r) {
                alert(r);
            }
        });
    }
}



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
            document.getElementById("chart-elevator-failure").innerHTML = "";
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
            alert(r);
        },
        error: function (r) {
            alert(r);
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
            document.getElementById("chart-elevator-spend").innerHTML = "";
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
            alert(r);
        },
        error: function (r) {
            alert(r);
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
            document.getElementById("chart-plumber-spend").innerHTML = "";
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
            alert(r);
        },
        error: function (r) {
            alert(r);
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
            document.getElementById("chart-plumber-operational").innerHTML = "";
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
            alert(r);
        },
        error: function (r) {
            alert(r);
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
            document.getElementById("chart-boiler-failure").innerHTML;
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
            alert(r);
        },
        error: function (r) {
            alert(r);
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
            document.getElementById("chart-boiler-cost").innerHTML = "";
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
            alert(r);
        },
        error: function (r) {
            alert(r);
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
            document.getElementById("chart-chiller-failure").innerHTML = "";
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
            alert(r);
        },
        error: function (r) {
            alert(r);
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
                document.getElementById("chart-chiller-cost").innerHTML = "";
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
                alert(r);
            },
            error: function (r) {
                alert(r);
            }
        });
    }