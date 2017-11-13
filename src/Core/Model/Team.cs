using System;

namespace fpl_api.Model
{
    public class Team
    {
        private readonly RawTeamStats _stats;
        public Team(RawTeamStats stats)
        {
            if (stats == null)
                throw new ArgumentNullException(nameof(stats));
            _stats = stats;
        }

        public int Id { get { return _stats.Id; } }
        public string Name { get; private set; }
        public string ShortName { get; private set; }
    }
}
