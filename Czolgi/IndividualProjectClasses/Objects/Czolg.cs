using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace IndividualProjectClasses.Objects
{
    public class Czolg : Element
    {
        public int direction;
        public Czolg(short posX, short posY, int _direction) : base(posX, posY)
        {
            direction = _direction;
            Size = 3;
            string help =
                System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName +
                @"\Resources\";
            ImagePath = new BitmapImage(new Uri(help + "czolg.png", UriKind.Absolute));
        }
        #region public methods
        public void MoveMe()
        { }
        #endregion
        #region private methods

        private Shot Shot()
        {
            return null;
        }
        #endregion
    }
}
