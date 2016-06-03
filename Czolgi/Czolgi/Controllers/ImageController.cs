using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using IndividualProjectClasses.Objects;

namespace Czolgi.Controllers
{
    internal class ImageController
    {
        internal static Image GetImage(Element el, ref List<Czolg> tanks, ref Czolg tank, Image im = null, bool shouldIAddTanks = true)
        {
            if (el == null)
                return null;
            BitmapImage bim = el.ImagePath;
            if(im == null)
                im = new Image();
            im.Source = bim;
            Grid.SetColumn(im, el.PosY+1);
            Grid.SetRow(im, el.PosX+1);
            im.Height = 20;
            if (el.GetType().Name.Contains("Czolg") || (el.GetType().BaseType != null && el.GetType().BaseType.ToString().Contains("Czolg")))
            {
                if (shouldIAddTanks && !el.GetType().Name.Contains("Czolg"))
                {
                    tanks.Add(el as Czolg);
                    tanks[tanks.Count-1].lastMove = DateTime.Now;
                    tanks[tanks.Count - 1].lastShot = DateTime.Now;
                }
                else if (el.GetType().Name.Contains("Czolg"))
                    tank = el as Czolg;
                im.Height = 20;
                im.Width = 20;
                im.RenderTransformOrigin = new Point(0.5,0.5);
                int dir = (el as Czolg).direction;
                RotateTransform rotateTransform = new RotateTransform(0);
                switch (dir)
                {
                    case 1:
                        rotateTransform = new RotateTransform(270);
                        break;
                    case 2:
                        rotateTransform = new RotateTransform(180);
                        break;
                    case 3:
                        rotateTransform = new RotateTransform(90);
                        break;
                }
                im.RenderTransform = rotateTransform;
            }
            //if (el.GetType().FullName.Contains("PowerUp"))
            //{
            //    Grid.SetColumnSpan(im, 2);
            //    Grid.SetRowSpan(im, 2);
            //    im.Height = 40;
            //}
            if (el.GetType().FullName.Contains("Orzel"))
            {
                Grid.SetColumnSpan(im, 3);
                Grid.SetRowSpan(im, 3);
                im.Height = 60;
            }
            return im;
        }

    }
}
