using System;

namespace Core.Model
{
    public class Team
    {
        private readonly RawTeamData data;

        public Team(RawTeamData RawData)
        {
            data = RawData ?? throw new ArgumentNullException(nameof(RawData));
        }

        public int Id { get => data.Id; }
        public string Name { get { return data.Name; } }
        public string ShortName { get { return data.ShortCode; } }
    }
}
