using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_WF
{
    public class NumberButton : Boton
    {
        private byte numero;
        public byte Numero { get { return numero; } set { } }

        public NumberButton(byte numer) : base(numer.ToString())
        {
            this.numero = numer;
            //this.Name = $"button{numer}";

        }
    }
}
