using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Core.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Core.Helpers
{
    public static class PlayerRetriever
    {
        private static string player_data_page = "https://fantasy.premierleague.com/drf/elements";
        public static IEnumerable<Player> GetAllPlayers()
        {
            CookieContainer cookies = null;
            var json = WebPageRequester.Get(player_data_page, ref cookies);
            var jsonData = JArray.Parse(json);

            foreach (var token in jsonData)
            {
                var rawStats = token.ToObject<RawPlayerData>();
                var player = new Player(rawStats);
                yield return player;
            }
        }

        public static Player GetPlayer(int playerId)
        {
            CookieContainer cookies = null;
            var json = WebPageRequester.Get(player_data_page, ref cookies);
            var jsonData = JArray.Parse(json);

            var token = jsonData[playerId];
            var rawStats = token.ToObject<RawPlayerData>();
            return new Player(rawStats);
        }
    }
}
