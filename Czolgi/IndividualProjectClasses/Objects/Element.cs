using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectClasses.Objects
{
    public class Element
    {
        #region private fields

        internal Int16 Size { get; set; }
        private Int16 PosX { get; set; }
        private Int16 PosY { get; set; }

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
