using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace IndividualProjectClasses.Objects.Enemy
{
    class Niszczyciel : WrogiCzolg
    {
        public Niszczyciel(short posX, short posY, int _direction) : base(posX, posY, _direction)
        {
            string help =
    System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName +
    @"\Resources\";
            ImagePath = new BitmapImage(new Uri(help + "normalny.png", UriKind.Absolute));
        }
    }
}
