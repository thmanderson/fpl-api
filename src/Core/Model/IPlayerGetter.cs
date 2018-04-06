using System;
using System.Collections.Generic;
using System.Text;

namespace FPL.Core.Model
{
    public interface IPlayerGetter
    {
        IPlayer GetPlayer(int Id, bool GetDetailed);

        IEnumerable<IPlayer> GetAllPlayers(bool GetDetailed);
    }
}
