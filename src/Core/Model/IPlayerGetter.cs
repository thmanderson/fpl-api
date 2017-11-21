using System;
using System.Collections.Generic;
using System.Text;

namespace FPL.Core.Model
{
    public interface IPlayerGetter
    {
        IPlayer GetPlayer(int PlayerId);
        IPlayer GetPlayer(string FirstName, string SecondName);
        IEnumerable<IPlayer> GetAllPlayers();
    }
}
