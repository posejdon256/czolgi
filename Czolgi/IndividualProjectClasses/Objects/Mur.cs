using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectClasses.Objects
{
    public class Mur : Element
    {
        public Mur(Int16 _posX, Int16 _posY):base(_posX,_posY)
        {
            Size = 1;
        }
    }
}
