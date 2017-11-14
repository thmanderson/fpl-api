using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Model
{
    public class Fixture
    {
        private RawFixtureData data;
        public Fixture(RawFixtureData RawData)
        {
            data = RawData ?? throw new ArgumentNullException(nameof(RawData));
        }
        public int Id { get => data.Id; }
        public Team HomeTeam { get; private set; }
        public Team AwayTeam { get; private set; }
    }
}
