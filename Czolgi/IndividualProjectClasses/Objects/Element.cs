using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace IndividualProjectClasses.Objects
{
    public abstract class Element
    {
        #region private fields

        internal Int16 Size { get; set; }
        public Int16 PosX { get; set; }
        public Int16 PosY { get; set; }
        public BitmapImage ImagePath { get; set; }

        #endregion

        public Element(Int16 posX, Int16 posY)
        {
            PosX = posX;
            PosY = posY;
        }
        #region public methods

        public void ImHit()
        { }

        #endregion
    }
}
