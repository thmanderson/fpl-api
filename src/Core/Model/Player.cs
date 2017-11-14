using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Model
{
    public class Player
    {
        private RawPlayerData data;
        public Player(RawPlayerData RawData)
        {
            data = RawData ?? throw new ArgumentNullException(nameof(RawData));
        }

        public int Id;
        public string Name;
    }
}
