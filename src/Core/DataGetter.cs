﻿using System;
using System.Collections.Generic;
using System.Text;
using FPL.Core.Data;
using FPL.Core.Helpers;

namespace FPL.Core
{
    public static class DataGetter
    {
        private static string root_api_page = "https://fantasy.premierleague.com/drf";
        private static string player_data_page = root_api_page + "/elements";
        private static string detailed_player_root_page = root_api_page + "/element-summary/";
        private static string fixture_data_page = root_api_page + "/fixtures";
        private static string team_data_page = root_api_page + "/teams";
        private static string transfer_data_page = root_api_page + "/transfers";

        // Player Data Getters
        public static IEnumerable<PlayerDataSummary> GetPlayerSummaryAll()
        {
            var jsonData = WebPageRequester.GetJArray(player_data_page);

            foreach (var token in jsonData)
            {
                var rawStats = token.ToObject<PlayerDataSummary>();
                yield return rawStats;
            }
        }

        public static PlayerDataSummary GetPlayerSummary(int PlayerId)
        {
            var jsonData = WebPageRequester.GetJArray(player_data_page);
            return jsonData[PlayerId].ToObject<PlayerDataSummary>();
        }

        public static PlayerDataSummary GetPlayerSummary(string FirstName, string SecondName)
        {
            var jsonData = WebPageRequester.GetJArray(player_data_page);

            foreach (var token in jsonData)
            {
                var rawStats = token.ToObject<PlayerDataSummary>();
                if (rawStats.FirstName == FirstName && rawStats.SecondName == SecondName) return rawStats;
            }

            return null;
        }

        public static PlayerDataDetailed GetPlayerDetails(int PlayerId)
        {
            var jsonData = WebPageRequester.GetJObject(detailed_player_root_page + PlayerId);
            return jsonData.ToObject<PlayerDataDetailed>();
        }

        // Team Getters
        public static IEnumerable<TeamData> GetAllTeams()
        {
            var jsonData = WebPageRequester.GetJArray(team_data_page);

            foreach (var token in jsonData)
            {
                var rawStats = token.ToObject<TeamData>();
                yield return rawStats;
            }
        }

        public static TeamData GetTeam(int TeamId)
        {
            var jsonData = WebPageRequester.GetJArray(team_data_page);
            return jsonData[TeamId].ToObject<TeamData>();
        }

        // Transfer Getter
        public static TransferData GetTransferData()
        {
            var jsonData = WebPageRequester.GetJArray(transfer_data_page);

            return jsonData.ToObject<TransferData>();
        }
    }
}
