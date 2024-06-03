using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_WF
{
    // clase calculo donde almacena su expresion y su resultado
    // y despues mostrarlos más facil en otro lado
    public class Calculo
    {
        public string expresion { get; set; }
        public double resultado { get; set; }

        public Calculo(string expresion, double result)
        {
            this.expresion = expresion;
            this.resultado = result;
        }

        public override string ToString()
        {
            return $"{expresion} = {resultado}";
        }
    }
}
