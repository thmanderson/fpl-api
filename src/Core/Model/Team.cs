using System;

namespace Core.Model
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
