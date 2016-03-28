using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProjectClasses.Objects.Enemy;

namespace IndividualProjectClasses.Helpers
{
    public static class Points
    {
        #region private fields

        private static int PointsSummary { get; set; }

        #endregion
        #region public methods

        public static int DestroyCzolg(WrogiCzolg wg)
        {
            return 100;
        }

        public static int GetPowerUp()
        {
            return 100;
        }

        public static int NextLevel()
        {
            return 100;
        }

        #endregion
    }
}
