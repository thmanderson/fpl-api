using System.Collections.Generic;
using System.Net;
using FPL.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FPL.Data.Helpers
{
    public class DataRetriever : IPlayerGetter
    {
        private static string root_api_page = "https://fantasy.premierleague.com/drf";
        private static string player_data_page = root_api_page + "/elements";
        private static string detailed_player_root_page = root_api_page + "/element-summary/";
        // private static string fixture_data_page = root_api_page + "/fixtures";
        // private static string team_data_page = root_api_page + "/teams";

        public IPlayer GetPlayer(int PlayerId)
        {
            var jsonData = GetAllPlayersRaw();
            var token = jsonData[PlayerId];
            var summary = token.ToObject<PlayerDataSummary>();

            return new Player(summary);
        }

        public IPlayer GetPlayer(string FirstName, string SecondName)
        {
            var jsonData = GetAllPlayersRaw();
            foreach (var token in jsonData)
            {
                var rawStats = token.ToObject<PlayerDataSummary>();
                if (rawStats.FirstName == FirstName && rawStats.SecondName == SecondName) return new Player(rawStats);
            }

            return null;
        }

        public IEnumerable<IPlayer> GetAllPlayers()
        {
            var jsonData = GetAllPlayersRaw();

            foreach (var token in jsonData)
            {
                var rawStats = token.ToObject<PlayerDataSummary>();
                yield return new Player(rawStats);
            }
        }

        internal JArray GetAllPlayersRaw()
        {
            CookieContainer cookies = null;
            var json = WebPageRequester.Get(player_data_page, ref cookies);
            return JArray.Parse(json);
        }

        /*

        // Detailed Player Retriever
        public static PlayerDataDetailed GetPlayerDetailed(int id)
        {
            CookieContainer cookies = null;
            var detailed_page = detailed_player_root_page + id;
            var json = WebPageRequester.Get(detailed_page, ref cookies);
            var jsonData = JObject.Parse(json);
            
            var rawStats = jsonData.ToObject<PlayerDataDetailed>();
            return rawStats;

        }

        // Player Retrievers


        public static PlayerDataSummary GetPlayerSummary(string FirstName, string SecondName)
        {
            CookieContainer cookies = null;
            var json = WebPageRequester.Get(player_data_page, ref cookies);
            var jsonData = JArray.Parse(json);

            foreach (var token in jsonData)
            {
                var rawStats = token.ToObject<PlayerDataSummary>();
                if (rawStats.SecondName.Equals(SecondName) && rawStats.FirstName.Equals(FirstName)) return rawStats;
            }

            return null;
        }
        public static IEnumerable<PlayerDataSummary> GetAllPlayerSummaries()
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

    */

    }
}
