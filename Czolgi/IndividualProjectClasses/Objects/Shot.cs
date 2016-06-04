using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using IndividualProjectClasses.Helpers;

namespace IndividualProjectClasses.Objects
{
    public class Shot : Element
    {
        public int direction;
        //private MediaPlayer MediaPlayerShot = new MediaPlayer();
      
        public Shot(short posX, short posY, int _direction) : base(posX, posY)
        {
            Size = 1;
            direction = _direction;
            ImagePath = BitmapFactory.bitmaps["pocisk"];
        }
        #region public methods
        /// <summary>
        /// Obsługuje to co się dzieje z pociskiem kiedy trafi w cel
        /// </summary>
        public void Hit()
        { }

        public int[] Fly(Element elementonMyWay, ref Element[,] elements,ref List<Shot> shots, ref List<Czolg> tanks, ref int points)
        {
             //MediaPlayer MediaPlayerBlast = new MediaPlayer();
             //   MediaPlayerBlast.Open(new Uri(System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName +
              //      @"\Resources\" + "blast.mp3", UriKind.Relative));
            if (elementonMyWay == null)
            {
                int lastPx = PosX, lastPy = PosY;
                elements[PosX, PosY] = null;
                if (direction == 0)
                    PosX--;
                else if (direction == 1)
                    PosY--;
                else if (direction == 2)
                    PosX++;
                else
                    PosY++;
                elements[PosX, PosY] = this;
                return new int[] {lastPx,lastPy};
            }
                
            elements[PosX, PosY] = null;
            if (elementonMyWay.GetType().Name.Contains("NiezniszczalnyMur"))
                return null;
            if ((elementonMyWay.GetType().BaseType != null &&
                elementonMyWay.GetType().BaseType.ToString().Contains("Czolg")) || elementonMyWay.GetType().Name.Contains("Czolg"))
            {
                Czolg help = elementonMyWay as Czolg;
                if (elementonMyWay.GetType().Name.Contains("Czolg"))
                {
                    if (Math.Abs((help.intensibility - DateTime.Now).TotalMilliseconds) < 1500)
                        return null;
                    elements[elementonMyWay.PosX, elementonMyWay.PosY] = null;
                    help.PosX = 37;
                    help.PosY = 14;
                    help.intensibility = DateTime.Now;
                    elements[37, 14] = help;
                }
                else if (help.armor == 1)
                {
                    points += 100*help.difficulty;
                }
                help.armor--;
                if (help.armor == 0)
                {
                   // MediaPlayerBlast.Play();
                    tanks.Remove(elementonMyWay as Czolg);
                    elements[elementonMyWay.PosX, elementonMyWay.PosY] = null;
                }
              
                return null;
            }
            elements[elementonMyWay.PosX, elementonMyWay.PosY] = null;
            return null;
        }

        #endregion
    }
}
