using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using IndividualProjectClasses.Helpers;

namespace IndividualProjectClasses.Objects
{
    public class Lisc : Element
    {
        public Lisc(short posX, short posY) : base(posX, posY)
        {
            Size = 1;
            ImagePath = BitmapFactory.bitmaps["lisc"];
        }
    }
}
