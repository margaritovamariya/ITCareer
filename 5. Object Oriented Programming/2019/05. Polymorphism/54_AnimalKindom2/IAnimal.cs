﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54_AnimalKindom2
{
    interface IAnimal:IMakeNoise,IMakeTrick
    {
        void Perform();
    }
}