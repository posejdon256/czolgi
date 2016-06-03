using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using IndividualProjectClasses.Helpers;

namespace IndividualProjectClasses.Objects.Enemy
{
    class Zaglada : WrogiCzolg
    {
        public Zaglada(short posX, short posY, int _direction) : base(posX, posY, _direction)
        {
            ImagePath = BitmapFactory.bitmaps["zaglada"];
            armor = 15;
            speed = 0.5;
            interval = 0.5;
            difficulty = 10;
        }
    }
}
