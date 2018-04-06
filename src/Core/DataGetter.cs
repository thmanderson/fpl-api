using System;
using System.Collections.Generic;
using System.Text;
using FPL.Core.Data;
using FPL.Core.Helpers;
using FPL.Core.Model;

namespace FPL.Core
{
    public class DataGetter : IDataGetter
    {
        private static string root_api_page = "https://fantasy.premierleague.com/drf";
        private static string player_data_page = root_api_page + "/elements";
        private static string detailed_player_root_page = root_api_page + "/element-summary/";
        private static string fixture_data_page = root_api_page + "/fixtures";
        private static string team_data_page = root_api_page + "/teams";
        private static string transfer_data_page = root_api_page + "/transfers";

        // Player Data Getters
        public IEnumerable<PlayerDataSummary> GetPlayerSummaryAll()
        {
            var jsonData = WebPageRequester.GetJArray(player_data_page);

            foreach (var token in jsonData)
            {
                var rawStats = token.ToObject<PlayerDataSummary>();
                yield return rawStats;
            }
        }

        public PlayerDataSummary GetPlayerSummary(int PlayerId)
        {
            var jsonData = WebPageRequester.GetJArray(player_data_page);
            return jsonData[PlayerId].ToObject<PlayerDataSummary>();
        }

        public PlayerDataDetailed GetPlayerDetails(int PlayerId)
        {
            var jsonData = WebPageRequester.GetJObject(detailed_player_root_page + PlayerId);
            return jsonData.ToObject<PlayerDataDetailed>();
        }

        // Team Getters
        public IEnumerable<TeamData> GetAllTeamData()
        {
            var jsonData = WebPageRequester.GetJArray(team_data_page);

            foreach (var token in jsonData)
            {
                var rawStats = token.ToObject<TeamData>();
                yield return rawStats;
            }
        }

        public TeamData GetTeamData(int TeamId)
        {
            var jsonData = WebPageRequester.GetJArray(team_data_page);
            return jsonData[TeamId].ToObject<TeamData>();
        }

        // Fixtures Getter
        public IEnumerable<FixtureData> GetAllFixtureData()
        {
            var jsonData = WebPageRequester.GetJArray(fixture_data_page);
            foreach (var token in jsonData)
            {
                var data = token.ToObject<FixtureData>();
                yield return data;
            }
        }
    }
}
