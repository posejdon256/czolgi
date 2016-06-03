using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using IndividualProjectClasses.Helpers;
using IndividualProjectClasses.Objects;
using Czolgi.Helpers;

namespace Czolgi.Controllers
{
    internal class UpdateElements
    {
        internal static List<int[]> ImagesToUpdate(ref Element[,] elements, ref List<Czolg> tanks, ref List<Shot> shots, ref int poitsInGame )
        {
            List<int[]> points = new List<int[]>();
            for (int i = 0; i < tanks.Count; i ++)
            {
                int[] next = PointsHelper.NextPoint(tanks[i]);
                if (Math.Abs((tanks[i].lastMove - DateTime.Now).TotalMilliseconds) >= tanks[i].speed*1000 )
                { 
                    tanks[i].lastMove = DateTime.Now;
                    int[] helpTab = tanks[i].MoveMe(elements[next[0],next[1]],ref elements);
                    if (helpTab != null)
                        points.Add(helpTab);
                    points.Add(new int[]{tanks[i].PosX,tanks[i].PosY});
                }
                next = PointsHelper.NextPoint(tanks[i]);
                if (Math.Abs((tanks[i].lastShot - DateTime.Now).TotalMilliseconds) >= tanks[i].interval*1000)
                {
                    shots.Add(new Shot((short)next[0], (short)next[1], tanks[i].direction));
                    tanks[i].lastShot = DateTime.Now;
                }
            }
            List<Shot> toRemove = new List<Shot>();
            for (int i = 0; i < shots.Count; i ++)
            {
                int[] next = PointsHelper.NextShot(shots[i]);
                int[] prev = new int[] {shots[i].PosX,shots[i].PosY};
                int[] helpTab = null;
                if (!(prev[0] == 0 || prev[0] == 38 || prev[1] == 0 || prev[1] == 38))
                {
                    helpTab = shots[i].Fly(elements[next[0], next[1]], ref elements, ref shots, ref tanks, ref poitsInGame);
                    points.Add(new int[] {shots[i].PosX, shots[i].PosY});
                    points.Add(prev);
                    points.Add(next);
                }
                if (helpTab == null) 
                    toRemove.Add(shots[i]);               
            }
            for (int i = 0; i < toRemove.Count; i ++)
                shots.Remove(toRemove[i]);
            return points;
        }
    }
}
