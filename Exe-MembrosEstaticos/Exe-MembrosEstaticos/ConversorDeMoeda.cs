using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_MembrosEstaticos
{
    class ConversorDeMoeda
    {
        public static double CotacaoDolar;
        public static double Real;
        public static double Iof = 6;


        public static double ConverteMoeda()
        {
            return ((Real * CotacaoDolar) + (Iof * ((Real * CotacaoDolar)) / 100));
        }

    }
}
