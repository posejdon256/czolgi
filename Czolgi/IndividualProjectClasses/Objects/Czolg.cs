using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectClasses.Objects
{
    public abstract class Czolg : Element
    {
        public Czolg(short posX, short posY) : base(posX, posY)
        {
            Size = 3;
        }
        #region public methods
        public void MoveMe()
        { }
        #endregion
        #region private methods

        private Shot Shot()
        {
            return null;
        }
        #endregion
    }
}
