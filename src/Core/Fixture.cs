using System;
using Core.Data;

namespace Core
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
