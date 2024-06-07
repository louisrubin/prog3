using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_WF
{
    // clase calculo donde almacena su expresion y su resultado
    // y despues mostrarlos más facil en otro lado
    public class Calculo
    {
        public string Expresion { get; set; }
        public double Resultado { get; set; }

        public Calculo(string expresion, double result)
        {
            this.Expresion = expresion;
            this.Resultado = result;
        }

        public override string ToString()
        {
            return $"{Expresion} = {Resultado}";
        }
    }
}
