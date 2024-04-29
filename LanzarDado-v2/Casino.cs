using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanzarDadoV2
{
    static class Casino
    {
        private static double pozo = 1000;

        public static void setApuesta(double monto)
        {
            pozo += monto;
        }
        public static double getPozo() { return pozo; }
        public static bool getPozoConSaldo(double monto) { return pozo > monto; }  // verif si el pozo tiene saldo dispon
    }
}
