using System.Collections.Generic;
using System.Net;
using FPL.Core.Helpers;
using FPL.Core.Data;
using FPL.Core.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FPL.Core
{
    public class PlayerGetter : IPlayerGetter
    {
        public IPlayer GetPlayer(int PlayerId)
        {
            var playerSummary = DataGetter.GetPlayerSummary(PlayerId);
            return new Player(playerSummary);
        }

        public IPlayer GetPlayer(string FirstName, string SecondName)
        {
            var playerSummary = DataGetter.GetPlayerSummary(FirstName, SecondName);
            return new Player(playerSummary);
        }

        public IEnumerable<IPlayer> GetAllPlayers()
        {
            foreach (var data in DataGetter.GetPlayerSummaryAll())
            {
                yield return new Player(data);
            }
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
