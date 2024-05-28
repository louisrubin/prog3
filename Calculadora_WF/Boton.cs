using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculadora_WF
{
    public abstract class Boton : Button
    {
        public Boton(string text)
        {
            this.Text = text;
            this.Size = new Size(80, 50);
            this.BackColor = Color.Gray;
            this.ForeColor = SystemColors.Window;
            this.Font = new Font("Calibri", 18F, FontStyle.Bold);
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = FlatStyle.Flat;
            this.Margin = new Padding(0);
            this.Name = $"button{text}";
            //this.TabIndex = 9;
            this.UseVisualStyleBackColor = false;
        }
    }
}
