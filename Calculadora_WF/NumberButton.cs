using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora_WF.Properties;

namespace Calculadora_WF
{
    public class NumberButton : Boton
    {
        private byte numero;
        public byte Numero { get { return numero; } set { } }

        public NumberButton(byte numer) : base(numer)
        {
            if (numer == 10)
            {
                this.numero = 0;
            }
            else
            {
                this.numero = numer;
            }

        }
        public NumberButton(byte numer, string caract) : base(numer, caract)
        {
            //this.numero = numer;
            //this.Name = $"button{numer}";
            //if (numero > 10)
            //{
            //    this.Image = (Icon)resources.GetObject("$this.Icon");
            //}

        }
    }
}
