using System;
using System.Collections.Generic;
using System.Text;
using FPL.Core.Model;

namespace FPL.Core
{
    public class PlayerFactory
    {
        public PlayerFactory()
        {

        }

        public IPlayer CreatePlayer(int playerId, bool getDetailed = false)
        {
            return new Player(playerId, getDetailed);
        }

        public IPlayer CreatePlayer(string firstName, string secondName, bool getDetailed = false)
        {
            return new Player(firstName, secondName, getDetailed);
        }
    }
}
