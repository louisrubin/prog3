using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_WF
{
    //public delegate void onClick(object? sender, EventArgs e);

    public class tableLayoutPanelResul : TableLayoutPanel
    {
        // 
        // table Layout Panel Results
        // 
        Label labelOperacion;
        Label labelResultado;

        public string Operacion { get { return labelOperacion.Text; } }
        public string Resultado { get { return labelResultado.Text; } }

        public tableLayoutPanelResul(string stringOperac, double resultado)
        {
            // CTOR 1
            labelOperacion = new LabelOperacion(stringOperac);
            labelResultado = new LabelResultado(resultado);

            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            this.Controls.Add(labelOperacion, 0, 0);
            this.Controls.Add(labelResultado, 0, 1);
            this.Dock = DockStyle.Top;
            this.Margin = new Padding(3, 3, 3, 15);
            this.Padding = new Padding(0, 0, 7, 0);
            this.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            this.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
            this.Size = new Size(344, 69);

            this.Click += results_Click;
        }
        
        public tableLayoutPanelResul(string stringOperac)
        {
            // CTOR 2
            labelOperacion = new LabelOperacion(stringOperac);

            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            this.Controls.Add(labelOperacion, 0, 0);
            this.Dock = DockStyle.Top;
            this.Margin = new Padding(3, 3, 3, 15);
            this.Padding = new Padding(0, 0, 7, 0);
            this.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            this.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
            this.Size = new Size(344, 69);
        }
        public void results_Click(object? sender, EventArgs e)
        {
            //Form1.TexTBoxPrincipal.Text = this.Resultado;
        }
    }

    class LabelOperacion : Label
    {
        // LABEL DEFINIDO PARA LA EXPRESION --> '32 + 10 ='
        public LabelOperacion(string operacion)
        {
            this.AutoSize = true;
            this.Dock = DockStyle.Fill;
            this.Font = new Font("Segoe UI", 10F);
            this.ForeColor = SystemColors.ControlDark;
            this.Size = new Size(331, 23);
            this.Text = operacion;
            this.TextAlign = ContentAlignment.MiddleRight;
        }
    }
    class LabelResultado : Label
    {
        // LABEL DEFINIDO QUE IMPRIME EL RESULTADO --> '42'
        public LabelResultado(double resultado)
        {
            this.AutoSize = true;
            this.Dock = DockStyle.Right;
            this.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.ForeColor = SystemColors.Control;
            this.Size = new Size(34, 46);
            this.Text = resultado.ToString();
        }
    }
}
