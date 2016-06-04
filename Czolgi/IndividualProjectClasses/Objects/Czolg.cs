using System;
using IndividualProjectClasses.Helpers;

namespace IndividualProjectClasses.Objects
{
    public class Czolg : Element
    {
        public int direction;
        public double speed;
        public double interval;
        public double armor;
        public DateTime lastShot;
        public DateTime lastMove;
        public DateTime intensibility;
        public int difficulty;
        public Czolg(short posX, short posY, int _direction) : base(posX, posY)
        {
            direction = _direction;
            Size = 3;
            ImagePath = BitmapFactory.bitmaps["czolg"];
            armor = 3;
            lastMove = DateTime.Now;
            speed = 0.5;
        }
        #region public methods

        public int[] MoveMe(Element elementOnMyWay, ref Element[,] elements)
        {
            int lastPx = PosX, lastPy = PosY;
            if (elementOnMyWay == null)
            {
                if (direction == 0)
                    PosX --;
                else if (direction == 1)
                    PosY --;
                else if (direction == 2)
                    PosX++;
                else
                    PosY ++;
                elements[lastPx, lastPy] = null;
                elements[PosX, PosY] = this;
                return new int[] {lastPx,lastPy};
            }
            direction = (direction + 1)%4;
            return null;
          
        }
        #endregion
        #region private methods

        private Shot Shot()
        {
            return null;
        }
        #endregion
    }
}
