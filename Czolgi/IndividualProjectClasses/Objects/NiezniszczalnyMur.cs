using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectClasses.Objects
{
    public class NiezniszczalnyMur : Mur
    {
        public NiezniszczalnyMur(short _posX, short _posY) : base(_posX, _posY)
        {
            Size = 1;
        }
    }
}
