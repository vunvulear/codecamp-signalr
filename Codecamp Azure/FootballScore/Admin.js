/// <reference path="../scripts/jquery-1.9.1.js" />
/// <reference path="../scripts/jquery.signalR-1.1.2.js" />

var footballScore = $.connection.footballScore;

$.connection.hub.start()
    .done(function() {
        $('#Start').click(function() {
            footballScore.server.start($('#TeamId').val(), $('#Team1Name').val(), $('#Team2Name').val());
        });
        $('#Stop').click(function () {
            footballScore.server.stop($('#TeamId').val());
        });
        
        $('#Goal').click(function () {
            footballScore.server.newScore($('#TeamIdScore').val(), $('#Team1Score').val(), $('#Team2Score').val(), $('#Player').val());
        });
    });
