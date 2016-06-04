using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Czolgi.Helpers;
using IndividualProjectClasses.Helpers;
using IndividualProjectClasses.Objects;

namespace Czolgi.Controllers
{
    internal static class KeyController
    {
        private static string[][] settings = FileHelper.GetSettings();
        internal static List<int[]> ClientWantMove(ref Czolg tank, ref Element[,] elements, KeyEventArgs args, ref List<Czolg> tanks )
        {
            if (args.Key == (Key)Enum.Parse(typeof(Key), settings[1][2]))
                tank.direction = 1;
            else if (args.Key == (Key)Enum.Parse(typeof(Key), settings[1][0]))
                tank.direction = 0;
            else if (args.Key == (Key)Enum.Parse(typeof(Key), settings[1][3]))
                tank.direction = 3;
            else if (args.Key == (Key)Enum.Parse(typeof(Key), settings[1][1]))
                tank.direction = 2;
            else if (args.Key == (Key)Enum.Parse(typeof(Key), settings[1][4]))
            {
                return null;
            }
            tank.lastMove = DateTime.Now;
            List<int[]> points = new List<int[]>();
            int[] help = PointsHelper.NextPoint(tank);
            if (elements[help[0], help[1]]!= null && elements[help[0], help[1]].GetType().FullName.Contains("Granat"))
            {
                for (int i = 0; i < tanks.Count; i ++)
                {
                    elements[tanks[i].PosX, tanks[i].PosY] = null;
                    points.Add(new int[] { tanks[i].PosX, tanks[i].PosY });
                }
                elements[help[0], help[1]] = null;
                points.Add(new int[] { help[0], help[1] });
                tanks.Clear();
            }
            else if (elements[help[0], help[1]] != null &&
                     elements[help[0], help[1]].GetType().FullName.Contains("Zycie"))
            {
                elements[help[0], help[1]] = null;
                tank.armor++;
            }
            else if (elements[help[0], help[1]] != null &&
                    elements[help[0], help[1]].GetType().FullName.Contains("Zamrozenie"))
            {
                elements[help[0], help[1]] = null;
                Thread.Sleep(10000);
            }
            int[] helpTab = tank.MoveMe(elements[help[0],help[1]], ref elements);
            if (helpTab != null)
                points.Add(helpTab);
            points.Add(new int[] { tank.PosX, tank.PosY });
            return points;
        }

        internal static Shot ClientWantShoot(Czolg tank, KeyEventArgs args)
        {
            Shot shot;
            int px = tank.PosX, py = tank.PosY;
            if (args.Key != (Key)Enum.Parse(typeof(Key), settings[1][4]))
                return null;
            if (tank.direction == 0)
                shot = new Shot((short)(px-1), (short)py,0);
            else if(tank.direction == 1)
                shot = new Shot((short)px, (short)(py-1), 1);
            else if (tank.direction == 2)
                shot = new Shot((short)(px+1), (short)py, 2);
            else
                shot = new Shot((short)px, (short)(py+1), 3);
            return shot;
        } 
    }
}
