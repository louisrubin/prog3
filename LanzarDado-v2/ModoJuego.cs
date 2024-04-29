using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanzarDadoV2
{
    public class ModoJuego
    {
        private byte ID;
        private string name;
        private double porcentPierde;
        private double porcentGana;

        public static byte sigID = 0;

        public ModoJuego(string name, int porcentPierde, int porcentGana)
        {
            this.ID = ++sigID;
            this.name = name.ToUpper();
            this.porcentGana = (porcentGana );    // porc: 400 --> 4
            this.porcentPierde = (porcentPierde -1) * (-1);    // porcent: 200 --> -2
        }

        public double gano(double montoApost)
        {
            return montoApost * porcentGana;
        }
        public double perdio(double montoApost)
        {
            return montoApost * porcentPierde;
        }

        //public double getPorcentGana() { return porcentGana; }
        //public double getPorcentPierde() { return porcentPierde; }
        public double getPorcentGana(double montoApost) { return porcentGana * montoApost; }
        public double getPorcentPierde(double montoApost) { return (porcentPierde  * montoApost) * (-1); }
        public string getName() { return name; }
    }
}
