using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using IndividualProjectClasses.Helpers;

namespace IndividualProjectClasses.Objects.Enemy
{
    class Slaby : WrogiCzolg
    {
        public Slaby(short posX, short posY, int _direction) : base(posX, posY, _direction)
        {
            ImagePath = BitmapFactory.bitmaps["slaby"];
            armor = 1;
            speed = 2;
            interval = 3;
            difficulty = 1;
        }
    }
}
