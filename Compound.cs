﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Kémia
{
    class Compound
    {
        public readonly string Name;
        public readonly string Sign;
        public readonly int Number;

        public Compound(string name, string sign, int number)
        {
            Name = name;
            Sign = sign;
            Number = number;
        }
    }
}
