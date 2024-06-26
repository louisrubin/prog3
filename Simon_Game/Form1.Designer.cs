﻿namespace Simon_Game
{
    partial class Form1
    {

        private Boton button1;              // cambie el tipo de clase 'Button' --> 'Boton'
        private Boton button2;
        private Boton button3;
        private Boton button4;
        private Button button5;                         // 'Button' ya que no necesito almacenar sus datos
        private BindingSource bindingSource1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Label label1;                       // mostrador de nivel

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            components = new System.ComponentModel.Container();


            button1 = new Boton(Color.Blue, SystemColors.ActiveCaption, "button1");
            button2 = new Boton(Color.Red, Color.RosyBrown, "button2");
            button3 = new Boton(Color.Green, Color.DarkSeaGreen, "button3");
            button4 = new Boton(Color.DarkOrchid, Color.Plum, "button4");

            bindingSource1 = new BindingSource(components);
            timer1 = new System.Windows.Forms.Timer(components);
            button5 = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();


            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Size = new Size(215, 185);
            //button1.TabIndex = 0;
            button1.Click += button1_Click;

            // 
            // button2
            // 
            button2.Location = new Point(403, 12);
            button2.Size = new Size(215, 180);
            //button2.TabIndex = 2;
            button2.Click += button2_Click;

            // 
            // button3
            // 
            button3.Location = new Point(12, 292);
            button3.Size = new Size(215, 185);
            //button3.TabIndex = 2;
            button3.Click += button3_Click;

            // 
            // button4
            // 
            button4.Location = new Point(403, 292);
            button4.Size = new Size(215, 185);
            //button4.TabIndex = 3;
            button4.Click += button4_Click;

            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // button5
            // 
            button5.BackColor = Color.HotPink;
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderColor = Color.White;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(257, 228);
            button5.Name = "button5";
            button5.Size = new Size(125, 40);
            button5.TabIndex = 4;
            button5.Text = "Empezar";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // timer2
            // 
            timer2.Interval = 550;
            timer2.Tick += timer2_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(297, 280);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 5;
            label1.Text = "Nivel: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(630, 489);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Simon Game";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

    }

    #endregion

    // :D
}
