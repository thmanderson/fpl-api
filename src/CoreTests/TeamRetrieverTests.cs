using System.Linq;
using Xunit;
using System.Collections.Generic;
using fpl_api.Model;
using fpl_api.Helpers;

namespace Tests
{
    [Trait("TestCategory", "UnitTests")]
    public class TeamRetrieverTests
    {
        [Fact]
        public void GetAllTeamsGivesFullList()
        {
            // Arrange & Act
            var teams = TeamRetriever.GetAllTeams();
            List<Team> teamsList = teams.ToList();

            // Assert
            Assert.True(teamsList.Count == 20);
        }
    }
}
