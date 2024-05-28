namespace Calculadora_WF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private static byte nroBoton = 0;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

            button1 = new NumberButton(++nroBoton);
            button2 = new NumberButton(++nroBoton);
            button3 = new NumberButton(++nroBoton);
            button4 = new NumberButton(++nroBoton);
            button5 = new NumberButton(++nroBoton);
            button6 = new NumberButton(++nroBoton);
            button7 = new NumberButton(++nroBoton);
            button8 = new NumberButton(++nroBoton);
            button9 = new NumberButton(++nroBoton);
            button10 = new NumberButton(++nroBoton);
            button11 = new NumberButton(++nroBoton, "%");
            button12 = new NumberButton(++nroBoton, "CE");
            button13 = new NumberButton(++nroBoton, "C");
            button14 = new NumberButton(++nroBoton, "<-");
            button15 = new NumberButton(++nroBoton, "1.x");
            button16 = new NumberButton(++nroBoton, "x^2");
            button17 = new NumberButton(++nroBoton, "2R/x");
            button18 = new NumberButton(++nroBoton, "/");
            button19 = new NumberButton(++nroBoton, "x");
            button20 = new NumberButton(++nroBoton, "-");
            button21 = new NumberButton(++nroBoton, "+");
            button22 = new NumberButton(++nroBoton, "=");
            button23 = new NumberButton(++nroBoton, ",");
            button24 = new NumberButton(++nroBoton, "+/-");
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(3, 395);
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(89, 395);
            // 
            // button3
            // 
            button3.Location = new Point(175, 395);
            // 
            // button4
            // 
            button4.Location = new Point(3, 342);
            // 
            // button5
            // 
            button5.Location = new Point(89, 342);
            // 
            // button6
            // 
            button6.Location = new Point(175, 342);
            // 
            // button7
            // 
            button7.Location = new Point(3, 289);
            // 
            // button8
            // 
            button8.Location = new Point(89, 289);
            // 
            // button9
            // 
            button9.Location = new Point(175, 289);
            // 
            // button10
            // 
            button10.Location = new Point(89, 448);
            button10.Click += button10_Click_1;
            // 
            // button11
            // 
            button11.Location = new Point(3, 162);
            // 
            // button12
            // 
            button12.Location = new Point(89, 162);
            // 
            // button13
            // 
            button13.Location = new Point(176, 162);
            // 
            // button14
            // 
            button14.Location = new Point(257, 162);
            // 
            // button15
            // 
            button15.Location = new Point(8, 227);
            // 
            // button16
            // 
            button16.Location = new Point(94, 229);
            // 
            // button17
            // 
            button17.Location = new Point(180, 229);
            // 
            // button18
            // 
            button18.Location = new Point(261, 227);
            // 
            // button19
            // 
            button19.Location = new Point(261, 289);
            // 
            // button20
            // 
            button20.Location = new Point(261, 342);
            // 
            // button21
            // 
            button21.Location = new Point(261, 395);
            // 
            // button22
            // 
            button22.Location = new Point(261, 448);
            // 
            // button23
            // 
            button23.Location = new Point(175, 448);
            // 
            // button24
            // 
            button24.Location = new Point(3, 448);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(344, 501);
            Controls.Add(button24);
            Controls.Add(button23);
            Controls.Add(button22);
            Controls.Add(button21);
            Controls.Add(button20);
            Controls.Add(button19);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(460, 640);
            MinimumSize = new Size(360, 540);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
        }

        #endregion

        private NumberButton button1;
        private NumberButton button2;
        private NumberButton button3;
        private NumberButton button4;
        private NumberButton button5;
        private NumberButton button6;
        private NumberButton button7;
        private NumberButton button8;
        private NumberButton button9;
        private NumberButton button10;
        private NumberButton button11;
        private NumberButton button12;
        private NumberButton button13;
        private NumberButton button14;
        private NumberButton button15;
        private NumberButton button16;
        private NumberButton button17;
        private NumberButton button18;
        private NumberButton button19;
        private NumberButton button20;
        private NumberButton button21;
        private NumberButton button22;
        private NumberButton button23;
        private NumberButton button24;
    }
}
