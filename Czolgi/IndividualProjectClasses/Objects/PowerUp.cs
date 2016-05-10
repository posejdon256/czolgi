using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace IndividualProjectClasses.Objects
{
    public class PowerUp : Element
    {
        private int ElNumer;
        public PowerUp(short posX, short posY, int _ElNumber) : base(posX, posY)
        {
            Size = 2;
            string help =
                System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName +
                @"\Resources\";
            ImagePath = new BitmapImage(new Uri(help+ "powerUp.png", UriKind.Absolute));
        }
        #region public methods

        #endregion
    }
}
