using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProjectClasses.Objects;
using IndividualProjectClasses.Objects.Enemy;
using IndividualProjectClasses.Objects.PowerUps;

namespace IndividualProjectClasses.Helpers
{
    static public class Factory
    {
        public static Element Get(string name, short x, short y)
        {
            switch (name)
            {
                case "M":
                    return new NiezniszczalnyMur(x,y);
                case "m":
                    return new Mur(x,y);
                case "O":
                    return new Orzel(x, y);
            }
            if (name[0] == 'c')
                return GetTank(name, x, y);
            if (name[0] == 'p')
                return GetPowerUp(name, x, y);
            return null;
        }

        private static Element GetPowerUp(string name, short x, short y)
        {
            switch (name[2])
            {
                case '1':
                    return new Granat(x, y, 0);
                case '2':
                    return new Ochrona(x, y, 0);
                case '3':
                    return new Zamrozenie(x, y, 0);
                case '4':
                    return new Zycie(x, y, 0);
            }
            return new Czolg(x, y, 0);
        }

        private static Element GetTank(string name, short x, short y)
        {
            switch (name[1])
            {
                case 'N':
                    return new Niszczyciel(x,y,Direction(name[2]));
                case 'n':
                    return new Normalny(x, y, Direction(name[2]));
                case 'S':
                    return new Silny(x, y, Direction(name[2]));
                case 's':
                    return new Slaby(x, y, Direction(name[2]));
                case 'Z':
                    return new Zaglada(x, y, Direction(name[2]));
                case 'c':
                    return new Czolg(x, y, Direction(name[2]));
            }
            return  new Czolg(x,y,Direction(name[2]));
        }
        private static int Direction(char k)
        {
            switch (k)
            {
                case 'l':
                    return 0;
                case 't':
                    return 1;
                case 'r':
                    return 2;
                case 'b':
                    return 3;
            }
            return 0;
        }
    }
}
