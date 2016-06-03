using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProjectClasses.Objects;

namespace Czolgi.Helpers
{
    internal class PointsHelper
    {
        internal static int[] NextPoint(Czolg tank)
        {
            if (tank.direction == 0)
                return new[] { tank.PosX - 1, tank.PosY };
            if (tank.direction == 1)
                return new[] { tank.PosX, tank.PosY - 1 };
            if (tank.direction == 2)
                return new[] { tank.PosX + 1, tank.PosY };
            return new[] { tank.PosX, tank.PosY + 1 };
        }
        internal static int[] NextShot(Shot tank)
        {
            if (tank.direction == 0)
                return new[] { tank.PosX - 1, tank.PosY };
            if (tank.direction == 1)
                return new[] { tank.PosX, tank.PosY - 1 };
            if (tank.direction == 2)
                return new[] { tank.PosX + 1, tank.PosY };
            return new[] { tank.PosX, tank.PosY + 1 };
        }
    }
}
