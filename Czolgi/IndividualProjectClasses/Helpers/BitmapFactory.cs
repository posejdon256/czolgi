using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace IndividualProjectClasses.Helpers
{
    public static class BitmapFactory
    {
        public static Dictionary<string, BitmapImage> bitmaps = new Dictionary<string, BitmapImage>()
        {
            {"slaby",new BitmapImage(new Uri(System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName +
                    @"\Resources\" + "slaby.png", UriKind.Absolute))},
            {"niezniszczalnyMur", new BitmapImage(new Uri(System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName +
                    @"\Resources\niezniszczalnyMur.png", UriKind.Absolute))},
            {"mur",new BitmapImage(new Uri(System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName +
                    @"\Resources\mur.png", UriKind.Absolute)) },
            {"czolg",new BitmapImage(new Uri(System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName +
                    @"\Resources\" + "czolg.png", UriKind.Absolute))},
            {"lisc", new BitmapImage(new Uri(System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName +
                    @"\Resources\lisc.png", UriKind.Absolute))},
            {"niszczyciel",new BitmapImage(new Uri(System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName +
                    @"\Resources\niszczyciel.png", UriKind.Absolute)) },
            {"normalny",new BitmapImage(new Uri(System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName +
                    @"\Resources\" + "normalny.png", UriKind.Absolute))},
            {"pocisk", new BitmapImage(new Uri(System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName +
                    @"\Resources\pocisk.png", UriKind.Absolute))},
            {"powerUp",new BitmapImage(new Uri(System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName +
                    @"\Resources\powerUp.png", UriKind.Absolute)) },
            {"silny", new BitmapImage(new Uri(System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName +
                    @"\Resources\silny.png", UriKind.Absolute))},
            {"zaglada",new BitmapImage(new Uri(System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName +
                    @"\Resources\zaglada.png", UriKind.Absolute)) },
            {"orzel",new BitmapImage(new Uri(System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName +
                    @"\Resources\eagle.png", UriKind.Absolute)) }
        }; 
    }
}
