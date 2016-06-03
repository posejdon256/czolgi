using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProjectClasses.Helpers;
using IndividualProjectClasses.Objects;

namespace Czolgi.Controllers
{
    internal static class LoadBoard
    {
        internal static void LoadElements(ref Element[,] elementsTable, int level)
        {
            string[][] map = FileHelper.GetMap(level);
            elementsTable = new Element[39,39];
            for(int i=0; i < 39; i ++)
                for (int j = 0; j < 39; j ++)
                   elementsTable[i,j]=Factory.Get(map[i][j], (short)i, (short)j);
        }
    }
}
