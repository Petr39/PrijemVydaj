﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IPenize
    {
        string [] VytvorVydajZaklad();
        void Vydaj();
        DateTime Datum();

        void VypisData();



    }
}
