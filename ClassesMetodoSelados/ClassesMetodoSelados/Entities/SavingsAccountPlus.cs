﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMetodoSelados.Entities
{
    class SavingsAccountPlus : Account
    {

        sealed public override int ReturnTest()
        {
            return base.ReturnTest();
        }
    }
}
