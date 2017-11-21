using System;
using System.Collections.Generic;
using System.Text;

namespace FPL.Core.Model
{
    public interface IPlayer
    {
        double PointsPerGame();
        double PointsPerNinety();
        double PointsPerNinetyPerMillion();
    }
}
