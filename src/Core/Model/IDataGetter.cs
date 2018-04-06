using System;
using System.Collections.Generic;
using System.Text;
using FPL.Core.Data;

namespace FPL.Core.Model
{
    public interface IDataGetter
    {
        IEnumerable<PlayerDataSummary> GetPlayerSummaryAll();
        PlayerDataSummary GetPlayerSummary(int id);
        PlayerDataDetailed GetPlayerDetails(int id);

        TeamData GetTeamData(int id);
        IEnumerable<TeamData> GetAllTeamData();

        IEnumerable<FixtureData> GetAllFixtureData();
    }
}
