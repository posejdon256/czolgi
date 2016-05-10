using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProjectClasses.Objects;
using IndividualProjectClasses.Objects.Enemy;

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
                case "pg1":
                    return new PowerUp(x,y,1);
                case "pg2":
                    return new PowerUp(x, y, 2);
                case "pg3":
                    return new PowerUp(x, y, 3);
                case "pg4":
                    return new PowerUp(x, y, 4);
            }
            if (name[0] == 'c')
                return GetTank(name, x, y);
            return null;
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
