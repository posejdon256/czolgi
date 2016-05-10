using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace IndividualProjectClasses.Objects
{
    public class Mur : Element
    {
        public Mur(Int16 _posX, Int16 _posY):base(_posX,_posY)
        {
            Size = 1;
            ImagePath =
                new BitmapImage(new Uri(
                    System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName +
                    @"\Resources\mur.png", UriKind.Absolute));
        }
    }
}
