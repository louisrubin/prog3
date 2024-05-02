using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanzarDado_V2
{
    internal class Dado
    {
        Random rand = new Random();

        public byte getNumero { 
            get { return (byte) rand.Next(1, 7) ; } 

            private set { }     // private
        } 
    }
}
