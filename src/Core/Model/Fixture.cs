using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Model
{
    public class Fixture
    {
        public Fixture(RawFixtureStats rawStats)
        {

        }
        public Team HomeTeam { get; private set; }
        public Team AwayTeam { get; private set; }
    }
}
