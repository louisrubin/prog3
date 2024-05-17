using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_1
{
    public class Usuario
    {
        private string name, apellido, direccion, telefono;
        public string Name { get { return name; } }
        public string Apellido { get { return apellido; } }

        public Usuario(string name, string apell, string direc, string tel)
        {
            this.name = name;
            this.apellido = apell;
            this.direccion = direc;
            this.telefono = tel;
        }

        public override string ToString()
        {
            return $"Nombre: {name}, Apellido: {apellido}, Dirección: {direccion}, Teléfono: {telefono}";
        }

    }
}
