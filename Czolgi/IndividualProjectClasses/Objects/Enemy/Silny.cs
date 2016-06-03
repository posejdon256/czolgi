using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using IndividualProjectClasses.Helpers;

namespace IndividualProjectClasses.Objects.Enemy
{
    class Silny : WrogiCzolg
    {
        public Silny(short posX, short posY, int _direction) : base(posX, posY, _direction)
        {
            ImagePath = BitmapFactory.bitmaps["silny"];
            armor = 5;
            speed = 2;
            interval = 2;
            difficulty = 3;
        }
    }
}
