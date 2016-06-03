using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using IndividualProjectClasses.Helpers;

namespace IndividualProjectClasses.Objects.Enemy
{
    class Normalny : WrogiCzolg
    {
        public Normalny(short posX, short posY, int _direction) : base(posX, posY, _direction)
        {
            ImagePath = BitmapFactory.bitmaps["normalny"];
            armor = 1;
            speed = 1;
            interval = 1.5;
            difficulty = 2;
        }
    }
}
