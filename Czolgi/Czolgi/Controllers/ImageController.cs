using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using IndividualProjectClasses.Objects;

namespace Czolgi.Controllers
{
    internal class ImageController
    {
        internal static Image GetImage(Element el)
        {
            BitmapImage bim = el.ImagePath;

            Image im = new Image();
            im.Source = bim;
            Grid.SetColumn(im, el.PosY);
            Grid.SetRow(im, el.PosX);
            im.Height = 20;
            if (el.GetType().Name.Contains("Czolg") || (el.GetType().BaseType != null && el.GetType().BaseType.ToString().Contains("Czolg")))
            {
                Grid.SetColumnSpan(im, 3);
                Grid.SetRowSpan(im, 3);
                im.Height = 60;
                int dir = (el as Czolg).direction;
                RotateTransform rotateTransform = new RotateTransform(0);
                switch (dir)
                {
                    case 0:
                        rotateTransform = new RotateTransform(270);
                        break;
                    case 2:
                        rotateTransform = new RotateTransform(90);
                        break;
                    case 3:
                        rotateTransform = new RotateTransform(180);
                        break;
                }
                im.RenderTransform = rotateTransform;
            }
            if (el.GetType().FullName.Contains("PowerUp"))
            {
                Grid.SetColumnSpan(im, 2);
                Grid.SetRowSpan(im, 2);
                im.Height = 40;
            }
            return im;
        }

    }
}
