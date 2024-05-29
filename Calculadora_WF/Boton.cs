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
    public class Boton : Button
    {
        private static byte tableIndexStat = 0;

        public Boton()
        {
            this.BackColor = Color.DimGray;
            this.ForeColor = Color.Black;
            this.Font = new System.Drawing.Font("Segoe UI", 18F, FontStyle.Bold);
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = FlatStyle.Flat;
            this.UseVisualStyleBackColor = false;

            this.TabIndex = ++tableIndexStat;     // indice tab

            this.Margin = new Padding(2);
            this.Dock = DockStyle.Fill;

        }
    }
}