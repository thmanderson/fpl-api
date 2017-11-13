using System;

namespace Core.Model
{
    public class Team
    {
        private readonly RawTeamStats stats;

        public Team(RawTeamStats rawStats)
        {
            stats = rawStats ?? throw new ArgumentNullException(nameof(rawStats));
        }

        public int Id { get => stats.Id; }
        public string Name { get { return stats.Name; } }
        public string ShortName { get { return stats.ShortCode; } }
    }
}
