using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;
using IndividualProjectClasses.Helpers;
using IndividualProjectClasses.Objects;

namespace Czolgi.Controllers
{
    internal static class EnemyTankController
    {
        internal static int enemyTanksNumber = 0;
        private static List<Czolg> enemyTanksList = new List<Czolg>(); 
        internal static void AddEnemyTank(ref Element[,] elements, ref List<Czolg> tanks, int level)
        {
            if(enemyTanksNumber == 14)
                return;
            Random rand = new Random(DateTime.Now.Second);
            int x = rand.Next(0, 38);
            int y = rand.Next(0, 38);
            while (elements[x, y] != null)
            {
                x = rand.Next(0, 38);
                y = rand.Next(0, 38);
            }
            enemyTanksList[enemyTanksNumber].PosX = (short)x;
            enemyTanksList[enemyTanksNumber].PosY = (short)y;
            enemyTanksList[enemyTanksNumber].lastMove=DateTime.Now;
            enemyTanksList[enemyTanksNumber].lastShot=DateTime.Now;
            tanks.Add(enemyTanksList[enemyTanksNumber]);
            elements[x, y] = enemyTanksList[enemyTanksNumber];
            enemyTanksNumber++;
        }

        internal static void FillTanks(int levelNumber)
        {
            enemyTanksList = new List<Czolg>();
            if (levelNumber == 0)
            {
                enemyTanksList.Add(Factory.Get("cst",0,0) as Czolg);
                enemyTanksList.Add(Factory.Get("cnl", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("cSb", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("csr", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("cst", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("cnl", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("cnr", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("cSb", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("csb", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("cnt", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("cnl", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("cSt", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("csr", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("csr", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("cnb", 0, 0) as Czolg);
            }
            if (levelNumber == 1)
            {
                enemyTanksList.Add(Factory.Get("cnt", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("cSl", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("cZb", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("cnr", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("cnt", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("cSl", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("cSr", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("cZb", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("cnb", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("cSt", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("cSl", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("cZt", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("cnr", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("cSr", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("cZb", 0, 0) as Czolg);
            }
            if (levelNumber == 2)
            {
                enemyTanksList.Add(Factory.Get("cSt", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("cZl", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("cNb", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("cSr", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("cSt", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("cZl", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("cZr", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("cNb", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("cSb", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("cZt", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("cZl", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("cNt", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("cSr", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("cZr", 0, 0) as Czolg);
                enemyTanksList.Add(Factory.Get("cNb", 0, 0) as Czolg);
            }
        }
    }
}
