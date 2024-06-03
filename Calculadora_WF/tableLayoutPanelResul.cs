using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_WF
{
    public class tableLayoutPanelResul : TableLayoutPanel
    {
        // 
        // table Layout Panel Results
        // 

        /*
         * // 
            // tableLayoutPanelResults
            // 
            tableLayoutPanelResults.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelResults.Dock = DockStyle.Top;
            tableLayoutPanelResults.Location = new Point(0, 0);
            tableLayoutPanelResults.Margin = new Padding(3, 3, 3, 15);
            tableLayoutPanelResults.Name = "tableLayoutPanelResults";
            tableLayoutPanelResults.Padding = new Padding(0, 0, 7, 0);
            tableLayoutPanelResults.RowCount = 1;
            tableLayoutPanelResults.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelResults.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanelResults.Size = new Size(344, 69);
            tableLayoutPanelResults.TabIndex = 0;
         // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(331, 23);
            label3.TabIndex = 0;
            label3.Text = "32 + 10 =";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Right;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(300, 23);
            label4.Name = "label4";
            label4.Size = new Size(34, 46);
            label4.TabIndex = 1;
            label4.Text = "42";
            label4.TextAlign = ContentAlignment.MiddleRight;
         */

        Label labelOperacion;
        Label labelResultado;

        public tableLayoutPanelResul(string stringOperac, string resultado)
        {
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

            //this.Location = new Point(0, 0);
            //this.Name = "tableLayoutPanelResults";
            //this.RowCount = 1;
        }
    }

    class LabelOperacion : Label
    {
        // LABEL DEFINIDO PARA EL OPERACION --> '32 + 10 ='
        public LabelOperacion(string operacion)
        {
            this.AutoSize = true;
            this.Dock = DockStyle.Fill;
            this.Font = new Font("Segoe UI", 10F);
            this.ForeColor = SystemColors.ControlDark;
            this.Size = new Size(331, 23);
            this.Text = operacion;
            this.TextAlign = ContentAlignment.MiddleRight;
            //this.TabIndex = 0;
            //this.Location = new Point(3, 0);
            //this.Name = "label3";
        }
    }
    class LabelResultado : Label
    {
        // LABEL DEFINIDO QUE IMPRIME SOLO EL RESULTADO --> '42'
        public LabelResultado(string resultado)
        {
            this.AutoSize = true;
            this.Dock = DockStyle.Right;
            this.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.ForeColor = SystemColors.Control;
            this.Size = new Size(34, 46);
            this.Text = resultado;
            this.TextAlign = ContentAlignment.MiddleRight;
            //this.Location = new Point(300, 23);
            //this.Name = "label4";
            //this.TabIndex = 1;
        }
    }
}
