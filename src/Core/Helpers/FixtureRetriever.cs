using System;
using System.Collections.Generic;
using System.Net;
using Core.Model;
using Newtonsoft.Json.Linq;

namespace Core.Helpers
{
    public static class FixtureRetriever
    {
        private static string team_data_page = "https://fantasy.premierleague.com/drf/fixtures";
        public static IEnumerable<Fixture> GetAllFixtures()
        {
            CookieContainer cookies = null;
            var json = WebPageRequester.Get(team_data_page, ref cookies);
            var jsonData = JArray.Parse(json);

            foreach (var token in jsonData)
            {
                var rawStats = token.ToObject<RawFixtureStats>();
                var fixture = new Fixture(rawStats);
                yield return fixture;
            }
        }
    }
}
