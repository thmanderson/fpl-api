using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Model
{
    public class Player
    {
        public RawPlayerData Data;
        public Player(RawPlayerData RawData)
        {
            Data = RawData ?? throw new ArgumentNullException(nameof(RawData));
        }
    }
}
