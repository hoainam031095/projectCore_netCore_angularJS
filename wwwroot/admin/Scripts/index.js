/*
 *  Document   : index.js
 *  Author     : pixelcave
 */
$(document).ready(function () {

    //Socket count user online
    var wss = "";
    var protocol = window.location.protocol;
    var host = window.location.host;
    if (protocol == "http:")
        wss = new WebSocket('ws://' + host + '/list-online');
    else
        wss = new WebSocket('wss://' + host + '/list-online');
    wss.onmessage = function (e) {
        var data = JSON.parse(e.data);
        $("#count-user-online").html(settingJS["TaiKhoan.TabOnline"] + " (" + data.length + ")");
        var tbodyHTML = "";
        data.forEach(function (item, index) {
            tbodyHTML += '<tr>\
                              <td class="text-center">'+ (index + 1) + '</td>\
                              <td>'+ item.sessionid + '</td>\
                              <td>'+ item.FullName + '</td>\
                         </tr>'
        })
        $("#list-user-online tbody").html(tbodyHTML);
    }
    //End socket count user online
});
var Index = function () {
    return {
        init: function () {
            var t = {
                type: "bar",
                barWidth: 8,
                barSpacing: 6,
                height: "64px",
                tooltipOffsetX: -25,
                tooltipOffsetY: 20,
                barColor: "#999999",
                tooltipPrefix: "+ ",
                tooltipSuffix: " Sales",
                tooltipFormat: "{{prefix}}{{value}}{{suffix}}"
            };
            var o = $("#dash-widget-chart"),
                i = [
                    [1, 1560],
                    [2, 1650],
                    [3, 1320],
                    [4, 1950],
                    [5, 1800],
                    [6, 2400],
                    [7, 2100],
                    [8, 2550],
                    [9, 3300],
                    [10, 3900],
                    [11, 4200],
                    [12, 4500]
                ],
                a = [
                    [1, 500],
                    [2, 420],
                    [3, 480],
                    [4, 350],
                    [5, 600],
                    [6, 850],
                    [7, 1100],
                    [8, 950],
                    [9, 1220],
                    [10, 1300],
                    [11, 1500],
                    [12, 1700]
                ],
                e = [
                    [1, "January"],
                    [2, "February"],
                    [3, "March"],
                    [4, "April"],
                    [5, "May"],
                    [6, "June"],
                    [7, "July"],
                    [8, "August"],
                    [9, "September"],
                    [10, "October"],
                    [11, "November"],
                    [12, "December"]
                ];
            var r = null,
                s = null;
            o.bind("plothover", function (t, o, i) {
                if (i) {
                    if (r !== i.dataIndex) {
                        r = i.dataIndex, $("#chart-tooltip").remove();
                        var a = (i.datapoint[0], i.datapoint[1]),
                            e = i.series.xaxis.options.ticks[i.dataIndex][1];
                        s = 1 === i.seriesIndex ? "<strong>" + a + "</strong> sales in <strong>" + e + "</strong>" : "$ <strong>" + a + "</strong> in <strong>" + e + "</strong>", $('<div id="chart-tooltip" class="chart-tooltip">' + s + "</div>").css({
                            top: i.pageY - 50,
                            left: i.pageX - 50
                        }).appendTo("body").show()
                    }
                } else $("#chart-tooltip").remove(), r = null
            })
        }
    }
}();

