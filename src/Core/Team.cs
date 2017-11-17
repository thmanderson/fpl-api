﻿using System;
using Core.Data;

namespace Core
{
    public class Team
    {
        public readonly RawTeamData Data;

        public Team(RawTeamData RawData)
        {
            Data = RawData ?? throw new ArgumentNullException(nameof(RawData));
        }
    }
}