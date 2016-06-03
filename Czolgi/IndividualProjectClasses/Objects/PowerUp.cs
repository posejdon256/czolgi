using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using IndividualProjectClasses.Helpers;

namespace IndividualProjectClasses.Objects
{
    public class PowerUp : Element
    {
        private int ElNumer;
        public PowerUp(short posX, short posY, int _ElNumber) : base(posX, posY)
        {
            Size = 2;
            ImagePath = BitmapFactory.bitmaps["powerUp"];
        }
        #region public methods

        #endregion
    }
}
