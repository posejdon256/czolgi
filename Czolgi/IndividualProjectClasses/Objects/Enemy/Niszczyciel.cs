using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using IndividualProjectClasses.Helpers;

namespace IndividualProjectClasses.Objects.Enemy
{
    class Niszczyciel : WrogiCzolg
    {
        public Niszczyciel(short posX, short posY, int _direction) : base(posX, posY, _direction)
        {
            ImagePath = BitmapFactory.bitmaps["niszczyciel"];
            armor = 10;
            speed = 0.75;
            interval = 0.75;
            difficulty = 5;
        }
    }
}
