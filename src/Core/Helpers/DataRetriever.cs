using System.Collections.Generic;
using System.Net;
using Core;
using Core.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Core.Helpers
{
    public static class DataRetriever
    {
        private static string root_api_page = "https://fantasy.premierleague.com/drf";
        private static string player_data_page = root_api_page + "/elements";
        private static string fixture_data_page = root_api_page + "/fixtures";
        private static string team_data_page = root_api_page + "/teams";

        // Player Retrievers
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

        public static Player GetPlayer(string secondName)
        {
            CookieContainer cookies = null;
            var json = WebPageRequester.Get(player_data_page, ref cookies);
            var jsonData = JArray.Parse(json);

            foreach (var token in jsonData)
            {
                var rawStats = token.ToObject<RawPlayerData>();
                if (rawStats.SecondName.Equals(secondName)) return new Player(rawStats);
            }

            return null;
        }

        // Fixture Retrievers
        public static IEnumerable<Fixture> GetAllFixtures()
        {
            CookieContainer cookies = null;
            var json = WebPageRequester.Get(fixture_data_page, ref cookies);
            var jsonData = JArray.Parse(json);

            foreach (var token in jsonData)
            {
                var rawStats = token.ToObject<RawFixtureData>();
                var fixture = new Fixture(rawStats);
                yield return fixture;
            }
        }

        // Team Retrievers
        public static IEnumerable<Team> GetAllTeams()
        {
            CookieContainer cookies = null;
            var json = WebPageRequester.Get(team_data_page, ref cookies);
            var jsonData = JArray.Parse(json);

            foreach (var token in jsonData)
            {
                var rawStats = token.ToObject<RawTeamData>();
                var team = new Team(rawStats);
                yield return team;
            }
        }

    }
}
