using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Model
{
    public class Fixture
    {
        private RawFixtureStats stats;
        public Fixture(RawFixtureStats rawStats) => stats = rawStats;
        public int Id { get => stats.Id; }
        public Team HomeTeam { get; private set; }
        public Team AwayTeam { get; private set; }
    }
}
