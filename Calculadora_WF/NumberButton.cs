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

        public NumberButton(ref byte number) : base(ref number)
        {
            if (number == 10)
            {
                this.numero = 0;
            }
            else
            {
                this.numero = number;
            }

        }
        public NumberButton(ref byte numer, string caract) : base(ref numer, caract)
        {
            //this.numero = numer;
            //this.Name = $"button{numer}";
            //if (numero > 10)
            //{
            //    this.Image = (Icon)resources.GetObject("$this.Icon");
            //}
            //button25.Image = Properties.Resources.backspace_outline_icon;
            //button25.Image = Properties.Resources.math_raiz;
            //button25.Image = Properties.Resources.plus_minus_icon;
            //button25.Image = Properties.Resources.pi_filled_icon;
            //button25.Image = Properties.Resources.superscript_icon;

        }
    }
}
