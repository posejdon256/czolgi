﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProjectClasses.Helpers;

namespace IndividualProjectClasses.Objects
{
    public class Orzel : Element
    {
        public Orzel(short posX, short posY) : base(posX, posY)
        {
            Size = 3;
            ImagePath = BitmapFactory.bitmaps["orzel"];
        }
    }
}
