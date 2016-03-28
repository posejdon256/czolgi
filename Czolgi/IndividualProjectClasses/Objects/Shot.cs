using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectClasses.Objects
{
    class Shot : Element
    {
        public Shot(short posX, short posY) : base(posX, posY)
        {
            Size = 1;
        }
        #region public methods
        /// <summary>
        /// Obsługuje to co się dzieje z pociskiem kiedy trafi w cel
        /// </summary>
        public void Hit()
        { }

        #endregion
    }
}
