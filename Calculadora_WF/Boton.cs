using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculadora_WF
{
    public abstract class Boton : Button
    {
        private static byte tableIndexStat = 0;

        public Boton(ref byte number)
        {
            if (number == 10)
            {
                this.Name = $"button{0}";
                this.Text = "0";
            }
            else
            {
                this.Name = $"button{number}";
                this.Text = number.ToString();
            }
            //this.Text = number.ToString();
            //this.Name = $"button{number.ToString()}";
            this.BackColor = Color.DimGray;
            this.ForeColor = Color.Black;
            this.Font = new System.Drawing.Font("Segoe UI", 18F, FontStyle.Bold);
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = FlatStyle.Flat;

            this.TabIndex = ++tableIndexStat;     // indice tab

            this.UseVisualStyleBackColor = false;

            this.Size = new Size(80, 50);           // tamaño actual
            this.MaximumSize = new Size(90, 60);    // tamaño maximo
            this.MinimumSize = new Size(80, 50);    // tamaño minimo
            this.Margin = new Padding(0);

            number++;

        }
        public Boton(ref byte number, string text)
        {
            /*
             *      BOTONES NO NUMERICOS
             */
            this.Text = text;
            this.Name = $"button{number}";
            this.BackColor = Color.DimGray;
            this.ForeColor = Color.Black;
            this.Font = new System.Drawing.Font("Segoe UI", 18F, FontStyle.Bold);
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = FlatStyle.Flat;

            this.TabIndex = ++tableIndexStat;     // indice tab

            this.UseVisualStyleBackColor = false;

            this.Size = new Size(80, 50);           // tamaño actual
            this.MaximumSize = new Size(90, 60);    // tamaño maximo
            this.MinimumSize = new Size(80, 50);    // tamaño minimo
            this.Margin = new Padding(0);

            number++;

        }
    }
}
