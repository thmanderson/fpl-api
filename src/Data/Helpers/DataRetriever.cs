using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FPL.Data.Helpers
{
    public static class DataRetriever
    {
        private static string root_api_page = "https://fantasy.premierleague.com/drf";
        private static string player_data_page = root_api_page + "/elements";
        private static string detailed_player_root_page = root_api_page + "/element-summary/";
        private static string fixture_data_page = root_api_page + "/fixtures";
        private static string team_data_page = root_api_page + "/teams";

        // Detailed Player Retriever
        public static PlayerDataDetailed GetDetailedPlayerSummary(int id)
        {
            CookieContainer cookies = null;
            var detailed_page = detailed_player_root_page + id;
            var json = WebPageRequester.Get(detailed_page, ref cookies);
            var jsonData = JObject.Parse(json);
            
            var rawStats = jsonData.ToObject<PlayerDataDetailed>();
            return rawStats;

        }

        // Player Retrievers
        public static IEnumerable<PlayerDataSummary> GetAllPlayers()
        {
            CookieContainer cookies = null;
            var json = WebPageRequester.Get(player_data_page, ref cookies);
            var jsonData = JArray.Parse(json);

            foreach (var token in jsonData)
            {
                var rawStats = token.ToObject<PlayerDataSummary>();
                yield return rawStats;
            }
        }

        public static PlayerDataSummary GetPlayer(int playerId)
        {
            CookieContainer cookies = null;
            var json = WebPageRequester.Get(player_data_page, ref cookies);
            var jsonData = JArray.Parse(json);

            var token = jsonData[playerId];
            var rawStats = token.ToObject<PlayerDataSummary>();
            return rawStats;
        }

        public static IEnumerable<PlayerDataSummary> GetPlayer(string secondName)
        {
            CookieContainer cookies = null;
            var json = WebPageRequester.Get(player_data_page, ref cookies);
            var jsonData = JArray.Parse(json);

            foreach (var token in jsonData)
            {
                var rawStats = token.ToObject<PlayerDataSummary>();
                if (rawStats.SecondName.Equals(secondName)) yield return rawStats;
            }
        }

        // Fixture Retrievers
        public static IEnumerable<FixtureData> GetAllFixtures()
        {
            CookieContainer cookies = null;
            var json = WebPageRequester.Get(fixture_data_page, ref cookies);
            var jsonData = JArray.Parse(json);

            foreach (var token in jsonData)
            {
                var rawStats = token.ToObject<FixtureData>();
                yield return rawStats;
            }
        }

        // Team Retrievers
        public static IEnumerable<TeamData> GetAllTeams()
        {
            CookieContainer cookies = null;
            var json = WebPageRequester.Get(team_data_page, ref cookies);
            var jsonData = JArray.Parse(json);

            foreach (var token in jsonData)
            {
                var rawStats = token.ToObject<TeamData>();
                yield return rawStats;
            }
        }

    }
}
