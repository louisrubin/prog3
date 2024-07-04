using System;
using System.Collections.Generic;
using System.Globalization;
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
        public string Expresion { get; private set; }
        public double Resultado { get; private set; }
        public char Operacion {  get; private set; }

        public Calculo(string expresion, double result, char charOper)
        {
            this.Expresion = expresion;
            this.Resultado = result;
            this.Operacion = charOper;
        }

        public override string ToString()
        {
            return $"{Expresion} = {Resultado}";
        }
    }
}
