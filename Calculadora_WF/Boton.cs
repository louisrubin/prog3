using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculadora_WF
{
    public abstract class Boton : Button
    {
        //private static byte tableIndexStat = 0;
        public Boton(string text)
        {
            this.Text = text;
            this.Name = $"button{text}";
            this.BackColor = Color.DimGray;
            this.ForeColor = SystemColors.Control;
            this.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = FlatStyle.Flat;

            //this.TabIndex = tableIndexStat;     // indice tab

            this.UseVisualStyleBackColor = false;

            this.Size = new Size(80, 50);           // tamaño actual
            this.MaximumSize = new Size(90, 60);    // tamaño maximo
            this.MinimumSize = new Size(80, 50);    // tamaño minimo
            this.Margin = new Padding(0);

            //tableIndexStat++;   // static +1

        }
    }
}
