using System;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace Codecamp.FootballScore
{
     [HubName("footballScore")]
    public class ScoreHub : Hub
    {
        public void Start(string matchId, string team1Name, string team2Name)
        {
            DateTime when = DateTime.Now;
            Clients.All.matchStart(matchId, team1Name, team2Name, when.ToShortTimeString());
        }

        public void Stop(string matchId)
        {
            DateTime when = DateTime.Now;
            Clients.All.matchEnded(matchId, when.ToShortTimeString());
        }

        public void NewScore(string matchId, string team1Score, string team2Score, string playerName)
        {
            Clients.All.goal(matchId, team1Score, team2Score, playerName);
        }        
    }
}