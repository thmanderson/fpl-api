using System;
using System.Collections.Generic;
using System.Text;

namespace fpl_api.Model
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
