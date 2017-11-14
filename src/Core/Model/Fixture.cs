using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Model
{
    public class Fixture
    {
        public RawFixtureData Data;
        public Fixture(RawFixtureData RawData)
        {
            Data = RawData ?? throw new ArgumentNullException(nameof(RawData));
        }
    }
}
