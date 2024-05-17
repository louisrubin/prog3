using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_1
{
    public class Correo
    {
        private string asunto, cuerpo;
        private Usuario remitente, destinatario;

        public Correo(Usuario remit, Usuario dest, string asunt, string body)
        {
            this.remitente = remit;
            this.destinatario = dest;
            this.asunto = asunt;
            this.cuerpo = body;
        }

        public override string ToString()
        {
            return $"\t[Remitente: {remitente.Name}, {remitente.Apellido}\n\tDestinatario: {destinatario.Name}, {destinatario.Apellido}" +
                $"\n\tAsunto: {asunto}, Cuerpo: {cuerpo}]";
        }
    }
}
