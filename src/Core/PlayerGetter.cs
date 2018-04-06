using System;
using System.Collections.Generic;
using System.Text;
using FPL.Core.Model;
using FPL.Core.Data;

namespace FPL.Core
{
    public class PlayerGetter : IPlayerGetter
    {
        IDataGetter DataGetter;

        public PlayerGetter(IDataGetter DataGetter)
        {
            this.DataGetter = DataGetter;
        }

        public IPlayer GetPlayer(int Id, bool GetDetailed)
        {
            var dataSummary = this.DataGetter.GetPlayerSummary(Id);
            PlayerDataDetailed dataDetailed = null;

            if (GetDetailed)
            {
                dataDetailed = this.DataGetter.GetPlayerDetails(Id);
            }

            return new Player(dataSummary, dataDetailed);
        }

        public IEnumerable<IPlayer> GetAllPlayers(bool GetDetailed)
        {
            var playerData = this.DataGetter.GetPlayerSummaryAll();
            foreach (var player in playerData)
            {
                PlayerDataDetailed playerDataDetailed = GetDetailed ? this.DataGetter.GetPlayerDetails(player.Id) : null;
                yield return new Player(player, playerDataDetailed);
            }
        }
    }
}
