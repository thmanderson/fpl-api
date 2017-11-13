﻿using System;
using System.Collections.Generic;
using System.Net;
using fpl_api.Model;
using Newtonsoft.Json.Linq;

namespace fpl_api.Helpers
{
    public static class TeamRetriever
    {
        private static string team_data_page = "https://fantasy.premierleague.com/drf/teams";
        public static IEnumerable<Team> GetAllTeams()
        {
            CookieContainer cookies = null;
            var json = WebPageRequester.Get(team_data_page, ref cookies);
            var jsonData = JArray.Parse(json);

            foreach (var token in jsonData)
            {
                var rawStats = token.ToObject<RawTeamStats>();
                var team = new Team(rawStats);
                yield return team;
            }
        }
        public static Team GetTeam(int id)
        {
            return null;
        }

    }
}