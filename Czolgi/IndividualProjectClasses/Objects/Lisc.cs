using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace IndividualProjectClasses.Objects
{
    public class Lisc : Element
    {
        public Lisc(short posX, short posY) : base(posX, posY)
        {
            Size = 1;
            string help =
                System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName +
                @"\Resources\";
                        ImagePath = new BitmapImage(new Uri(help + "lisc.png", UriKind.Absolute));
        }
    }
}
