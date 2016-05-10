using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace IndividualProjectClasses.Objects
{
    public class NiezniszczalnyMur : Mur
    {
        public NiezniszczalnyMur(short _posX, short _posY) : base(_posX, _posY)
        {
            Size = 1;
            ImagePath =
                new BitmapImage(new Uri(
                    System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName +
                    @"\Resources\niezniszczalnyMur.png", UriKind.Absolute));
        }
    }
}
