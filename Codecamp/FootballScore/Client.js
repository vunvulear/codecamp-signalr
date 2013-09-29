/// <reference path="../scripts/jquery-1.9.1.js" />
/// <reference path="../scripts/jquery.signalR-1.1.2.js" />

var footballScore = $.connection.footballScore;

$.extend(footballScore.client, {
    matchStart: function (matchId, team1Name, team2Name, when) {
        $('#status').append('<br /> Started at ' + when + ' - ' + team1Name + ' vs ' + team2Name);        
    },
    
    matchEnded: function (matchId, when) {
        $('#status').append('<br /> Ended: ' + when + ' - ' + matchId);
    },
    
    goal: function (matchId, team1Score, team2Score, playerName) {
        $('#status').append('<br /> New Score: ' + matchId + '. A new goal was scored by' + playerName + '. New score is: ' + team1Score + '-' + team2Score);
    },
});

$.connection.hub.start();
