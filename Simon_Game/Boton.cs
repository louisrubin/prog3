using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;     // de acá implementando clase Button

namespace Simon_Game
{
    public class Boton : Button
    {
        private byte codigoColor;
        private static byte sigCodColor = 0;
        private Color colorPrendido;
        private Color colorApagado;

        public Color ColorPrendido { get { return colorPrendido; } set { colorPrendido = value; } }
        public Color ColorApagado { get { return colorApagado; } set { colorApagado = value; } }

        public Boton(Color colorParam)
        {
            this.codigoColor = ++sigCodColor;

            this.colorPrendido = colorParam;

            this.Name = $"button{codigoColor}";
            this.BackColor = (Color) colorParam;
            this.FlatAppearance.BorderColor = Color.White;
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = FlatStyle.Flat;
            this.Text = "\r\n";
            this.UseVisualStyleBackColor = false;
        }

    }
}
