using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectClasses.Objects.PowerUps
{
    class Granat : PowerUp
    {
        #region private fields
        #endregion
        public Granat(short posX, short posY, int _ElNumber) : base(posX, posY,_ElNumber)
        {
        }
        #region public methods
        /// <summary>
        /// Usuwa wszystkie czołgi z mapy
        /// </summary>
        private void DeleteAllCzolgs()
        { }


        #endregion
    }
}
