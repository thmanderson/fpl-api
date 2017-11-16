using System;
using Core.Data;

namespace Core
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