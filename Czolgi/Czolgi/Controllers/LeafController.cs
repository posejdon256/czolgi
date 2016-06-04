using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using IndividualProjectClasses.Helpers;

namespace Czolgi.Controllers
{
    internal static class LeafController
    {
        internal static List<int[]> leafs = new List<int[]>(); 
        internal static List<int[]> GetLeafs()
        {
            return leafs;
        }

        internal static void GenerateLeafs()
        {
            leafs = new List<int[]>();
            Random rand = new Random(DateTime.Now.Second);
            for (int i = 0; i < 10; i ++)
                leafs.Add(new int[] {rand.Next(0,38),rand.Next(0,38)});
        }

        internal static Image GetImageLeaf(int x, int y)
        {
            BitmapImage bim = BitmapFactory.bitmaps["lisc"];
            Image im = new Image();
            Grid.SetColumn(im, y+1);
            Grid.SetRow(im,x+1);
            im.Source = bim;
            im.Height = 20;
            return im;
        }
    }
}
