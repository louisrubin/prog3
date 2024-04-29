using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LanzarDadoV2
{
    public class Jugador
    {
        public int Id { get; private set; }
        private double saldoBilletera = 100;

        public byte dadoElegido;
        public ModoJuego modoElegido;
        public double montoApostado;

        public static int sigID = 0;

        public Jugador()
        {
            Id = ++sigID;
        }


        public double getBilletera() { return saldoBilletera; }
        public void setBilletera(double monto) { saldoBilletera += monto; }

        public bool tieneSaldo(double monto)
        {
            // verifica si tiene 
            if (saldoBilletera < monto && monto != 0) {
                return false;
            }
            else return true;
        }
        
    }

}
