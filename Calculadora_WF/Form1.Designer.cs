namespace Calculadora_WF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        //private static byte nroBoton = 1;

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
            tableLayoutBotones = new TableLayoutPanel();
            button24 = new Boton();
            button19 = new Boton();
            button23 = new Boton();
            button13 = new Boton();
            button22 = new Boton();
            button18 = new Boton();
            button21 = new Boton();
            button6 = new Boton();
            button20 = new Boton();
            button17 = new Boton();
            button12 = new Boton();
            button16 = new Boton();
            button1 = new Boton();
            button15 = new Boton();
            button5 = new Boton();
            button2 = new Boton();
            button9 = new Boton();
            button4 = new Boton();
            button8 = new Boton();
            button3 = new Boton();
            button7 = new Boton();
            button10 = new Boton();
            button11 = new Boton();
            button14 = new Boton();
            button25 = new Boton();
            button26 = new Boton();
            textBox1 = new TextBox();
            tableLayoutPanelMitadArriba = new TableLayoutPanel();
            label_calculos = new Label();
            tableLayoutPanelHeader = new TableLayoutPanel();
            labelEstandar = new Label();
            tableLayoutPanelTimers = new TableLayoutPanel();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            tableLayoutPanelBasura = new TableLayoutPanel();
            panelTodoHistorial = new Panel();
            panelHistorialCalculos = new Panel();
            tableLayoutBotones.SuspendLayout();
            tableLayoutPanelMitadArriba.SuspendLayout();
            tableLayoutPanelHeader.SuspendLayout();
            tableLayoutPanelTimers.SuspendLayout();
            tableLayoutPanelBasura.SuspendLayout();
            panelTodoHistorial.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutBotones
            // 
            tableLayoutBotones.ColumnCount = 4;
            tableLayoutBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutBotones.Controls.Add(button24, 0, 5);
            tableLayoutBotones.Controls.Add(button19, 3, 2);
            tableLayoutBotones.Controls.Add(button23, 2, 5);
            tableLayoutBotones.Controls.Add(button13, 2, 0);
            tableLayoutBotones.Controls.Add(button22, 3, 5);
            tableLayoutBotones.Controls.Add(button18, 3, 1);
            tableLayoutBotones.Controls.Add(button21, 3, 4);
            tableLayoutBotones.Controls.Add(button6, 2, 3);
            tableLayoutBotones.Controls.Add(button20, 3, 3);
            tableLayoutBotones.Controls.Add(button17, 2, 1);
            tableLayoutBotones.Controls.Add(button12, 1, 0);
            tableLayoutBotones.Controls.Add(button16, 1, 1);
            tableLayoutBotones.Controls.Add(button1, 0, 4);
            tableLayoutBotones.Controls.Add(button15, 0, 1);
            tableLayoutBotones.Controls.Add(button5, 1, 3);
            tableLayoutBotones.Controls.Add(button2, 1, 4);
            tableLayoutBotones.Controls.Add(button9, 2, 2);
            tableLayoutBotones.Controls.Add(button4, 0, 3);
            tableLayoutBotones.Controls.Add(button8, 1, 2);
            tableLayoutBotones.Controls.Add(button3, 2, 4);
            tableLayoutBotones.Controls.Add(button7, 0, 2);
            tableLayoutBotones.Controls.Add(button10, 1, 5);
            tableLayoutBotones.Controls.Add(button11, 0, 0);
            tableLayoutBotones.Controls.Add(button14, 3, 0);
            tableLayoutBotones.Dock = DockStyle.Bottom;
            tableLayoutBotones.Location = new Point(0, 190);
            tableLayoutBotones.Name = "tableLayoutBotones";
            tableLayoutBotones.Padding = new Padding(2);
            tableLayoutBotones.RowCount = 6;
            tableLayoutBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutBotones.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutBotones.Size = new Size(344, 311);
            tableLayoutBotones.TabIndex = 0;
            // 
            // button24
            // 
            button24.BackColor = Color.DimGray;
            button24.Dock = DockStyle.Fill;
            button24.FlatStyle = FlatStyle.Flat;
            button24.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button24.ForeColor = Color.Black;
            button24.Image = Properties.Resources.plus_minus_icon;
            button24.Location = new Point(4, 259);
            button24.Margin = new Padding(2);
            button24.Name = "button24";
            button24.Size = new Size(81, 48);
            button24.TabIndex = 1;
            button24.UseVisualStyleBackColor = false;
            button24.Click += button24_Click;
            // 
            // button19
            // 
            button19.BackColor = Color.DimGray;
            button19.Dock = DockStyle.Fill;
            button19.FlatStyle = FlatStyle.Flat;
            button19.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button19.ForeColor = Color.Black;
            button19.Image = Properties.Resources.multiplication_icon2;
            button19.Location = new Point(259, 106);
            button19.Margin = new Padding(2);
            button19.Name = "button19";
            button19.Size = new Size(81, 47);
            button19.TabIndex = 2;
            button19.UseVisualStyleBackColor = false;
            button19.Click += button19_Click;
            // 
            // button23
            // 
            button23.BackColor = Color.DimGray;
            button23.Dock = DockStyle.Fill;
            button23.FlatStyle = FlatStyle.Flat;
            button23.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button23.ForeColor = Color.Black;
            button23.Location = new Point(174, 259);
            button23.Margin = new Padding(2);
            button23.Name = "button23";
            button23.Size = new Size(81, 48);
            button23.TabIndex = 3;
            button23.Text = ",";
            button23.UseVisualStyleBackColor = false;
            button23.Click += button23_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.DimGray;
            button13.Dock = DockStyle.Fill;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button13.ForeColor = Color.Black;
            button13.Location = new Point(174, 4);
            button13.Margin = new Padding(2);
            button13.Name = "button13";
            button13.Size = new Size(81, 47);
            button13.TabIndex = 4;
            button13.Text = "C";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button22
            // 
            button22.BackColor = Color.DarkCyan;
            button22.Dock = DockStyle.Fill;
            button22.FlatStyle = FlatStyle.Flat;
            button22.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button22.ForeColor = Color.Black;
            button22.Image = Properties.Resources.equal_symbol2;
            button22.Location = new Point(259, 259);
            button22.Margin = new Padding(2);
            button22.Name = "button22";
            button22.Size = new Size(81, 48);
            button22.TabIndex = 5;
            button22.UseVisualStyleBackColor = false;
            button22.Click += button22_Click;
            // 
            // button18
            // 
            button18.BackColor = Color.DimGray;
            button18.Dock = DockStyle.Fill;
            button18.FlatStyle = FlatStyle.Flat;
            button18.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button18.ForeColor = Color.Black;
            button18.Image = Properties.Resources.divide_icon;
            button18.Location = new Point(259, 55);
            button18.Margin = new Padding(2);
            button18.Name = "button18";
            button18.Size = new Size(81, 47);
            button18.TabIndex = 6;
            button18.UseVisualStyleBackColor = false;
            button18.Click += button18_Click;
            // 
            // button21
            // 
            button21.BackColor = Color.DimGray;
            button21.Dock = DockStyle.Fill;
            button21.FlatStyle = FlatStyle.Flat;
            button21.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button21.ForeColor = Color.Black;
            button21.Image = Properties.Resources.plus_sign2;
            button21.Location = new Point(259, 208);
            button21.Margin = new Padding(2);
            button21.Name = "button21";
            button21.Size = new Size(81, 47);
            button21.TabIndex = 7;
            button21.UseVisualStyleBackColor = false;
            button21.Click += button21_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DimGray;
            button6.Dock = DockStyle.Fill;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(174, 157);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(81, 47);
            button6.TabIndex = 8;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button20
            // 
            button20.BackColor = Color.DimGray;
            button20.Dock = DockStyle.Fill;
            button20.FlatStyle = FlatStyle.Flat;
            button20.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button20.ForeColor = Color.Black;
            button20.Image = Properties.Resources.substract_icon2;
            button20.Location = new Point(259, 157);
            button20.Margin = new Padding(2);
            button20.Name = "button20";
            button20.Size = new Size(81, 47);
            button20.TabIndex = 9;
            button20.UseVisualStyleBackColor = false;
            button20.Click += button20_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.DimGray;
            button17.Dock = DockStyle.Fill;
            button17.FlatStyle = FlatStyle.Flat;
            button17.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button17.ForeColor = Color.Black;
            button17.Image = Properties.Resources.math_raiz;
            button17.Location = new Point(174, 55);
            button17.Margin = new Padding(2);
            button17.Name = "button17";
            button17.Size = new Size(81, 47);
            button17.TabIndex = 10;
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.DimGray;
            button12.Dock = DockStyle.Fill;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button12.ForeColor = Color.Black;
            button12.Location = new Point(89, 4);
            button12.Margin = new Padding(2);
            button12.Name = "button12";
            button12.Size = new Size(81, 47);
            button12.TabIndex = 11;
            button12.Text = "CE";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.DimGray;
            button16.Dock = DockStyle.Fill;
            button16.FlatStyle = FlatStyle.Flat;
            button16.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button16.ForeColor = Color.Black;
            button16.Image = Properties.Resources.superscript_icon;
            button16.Location = new Point(89, 55);
            button16.Margin = new Padding(2);
            button16.Name = "button16";
            button16.Size = new Size(81, 47);
            button16.TabIndex = 12;
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.Dock = DockStyle.Fill;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(4, 208);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(81, 47);
            button1.TabIndex = 13;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.DimGray;
            button15.Dock = DockStyle.Fill;
            button15.FlatStyle = FlatStyle.Flat;
            button15.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button15.ForeColor = Color.Black;
            button15.Location = new Point(4, 55);
            button15.Margin = new Padding(2);
            button15.Name = "button15";
            button15.Size = new Size(81, 47);
            button15.TabIndex = 14;
            button15.Text = "1/x";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DimGray;
            button5.Dock = DockStyle.Fill;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(89, 157);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(81, 47);
            button5.TabIndex = 15;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DimGray;
            button2.Dock = DockStyle.Fill;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(89, 208);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(81, 47);
            button2.TabIndex = 16;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.DimGray;
            button9.Dock = DockStyle.Fill;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button9.ForeColor = Color.Black;
            button9.Location = new Point(174, 106);
            button9.Margin = new Padding(2);
            button9.Name = "button9";
            button9.Size = new Size(81, 47);
            button9.TabIndex = 17;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DimGray;
            button4.Dock = DockStyle.Fill;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(4, 157);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(81, 47);
            button4.TabIndex = 18;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.DimGray;
            button8.Dock = DockStyle.Fill;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button8.ForeColor = Color.Black;
            button8.Location = new Point(89, 106);
            button8.Margin = new Padding(2);
            button8.Name = "button8";
            button8.Size = new Size(81, 47);
            button8.TabIndex = 19;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DimGray;
            button3.Dock = DockStyle.Fill;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(174, 208);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(81, 47);
            button3.TabIndex = 20;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.DimGray;
            button7.Dock = DockStyle.Fill;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button7.ForeColor = Color.Black;
            button7.Location = new Point(4, 106);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(81, 47);
            button7.TabIndex = 21;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.DimGray;
            button10.Dock = DockStyle.Fill;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button10.ForeColor = Color.Black;
            button10.Location = new Point(89, 259);
            button10.Margin = new Padding(2);
            button10.Name = "button10";
            button10.Size = new Size(81, 48);
            button10.TabIndex = 22;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.DimGray;
            button11.Dock = DockStyle.Fill;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button11.ForeColor = Color.Black;
            button11.Image = Properties.Resources.timer_icon2;
            button11.Location = new Point(4, 4);
            button11.Margin = new Padding(2);
            button11.Name = "button11";
            button11.Size = new Size(81, 47);
            button11.TabIndex = 23;
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.DimGray;
            button14.Dock = DockStyle.Fill;
            button14.FlatStyle = FlatStyle.Flat;
            button14.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button14.ForeColor = Color.Black;
            button14.Image = Properties.Resources.backspace_outline_icon;
            button14.Location = new Point(259, 4);
            button14.Margin = new Padding(2);
            button14.Name = "button14";
            button14.Size = new Size(81, 47);
            button14.TabIndex = 24;
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // button25
            // 
            button25.BackColor = Color.DimGray;
            button25.Dock = DockStyle.Right;
            button25.FlatAppearance.BorderSize = 0;
            button25.FlatStyle = FlatStyle.Flat;
            button25.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button25.ForeColor = Color.Black;
            button25.Image = Properties.Resources.clock_icon_24;
            button25.Location = new Point(294, 2);
            button25.Margin = new Padding(2);
            button25.Name = "button25";
            button25.Size = new Size(40, 24);
            button25.TabIndex = 25;
            button25.UseVisualStyleBackColor = false;
            button25.Click += button25_Click;
            // 
            // button26
            // 
            button26.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button26.BackColor = Color.FromArgb(75, 75, 75);
            button26.FlatStyle = FlatStyle.Flat;
            button26.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button26.ForeColor = Color.Black;
            button26.Image = Properties.Resources.trash_24px;
            button26.Location = new Point(294, 5);
            button26.Margin = new Padding(2, 5, 10, 2);
            button26.Name = "button26";
            button26.Size = new Size(40, 33);
            button26.TabIndex = 52;
            button26.UseVisualStyleBackColor = false;
            button26.Click += button26_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(64, 64, 64);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Bottom;
            textBox1.Font = new Font("Segoe UI", 35F, FontStyle.Bold);
            textBox1.ForeColor = SystemColors.Control;
            textBox1.Location = new Point(12, 111);
            textBox1.Margin = new Padding(12, 3, 12, 12);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(320, 63);
            textBox1.TabIndex = 0;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // tableLayoutPanelMitadArriba
            // 
            tableLayoutPanelMitadArriba.ColumnCount = 1;
            tableLayoutPanelMitadArriba.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMitadArriba.Controls.Add(textBox1, 0, 3);
            tableLayoutPanelMitadArriba.Controls.Add(label_calculos, 0, 2);
            tableLayoutPanelMitadArriba.Controls.Add(tableLayoutPanelHeader, 0, 0);
            tableLayoutPanelMitadArriba.Controls.Add(tableLayoutPanelTimers, 0, 1);
            tableLayoutPanelMitadArriba.Dock = DockStyle.Top;
            tableLayoutPanelMitadArriba.Location = new Point(0, 0);
            tableLayoutPanelMitadArriba.Name = "tableLayoutPanelMitadArriba";
            tableLayoutPanelMitadArriba.RowCount = 4;
            tableLayoutPanelMitadArriba.RowStyles.Add(new RowStyle(SizeType.Percent, 20.781496F));
            tableLayoutPanelMitadArriba.RowStyles.Add(new RowStyle(SizeType.Percent, 20.3667431F));
            tableLayoutPanelMitadArriba.RowStyles.Add(new RowStyle(SizeType.Percent, 13.5713511F));
            tableLayoutPanelMitadArriba.RowStyles.Add(new RowStyle(SizeType.Percent, 45.28041F));
            tableLayoutPanelMitadArriba.Size = new Size(344, 186);
            tableLayoutPanelMitadArriba.TabIndex = 1;
            // 
            // label_calculos
            // 
            label_calculos.AutoSize = true;
            label_calculos.Dock = DockStyle.Fill;
            label_calculos.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_calculos.ForeColor = SystemColors.ControlDark;
            label_calculos.Location = new Point(2, 75);
            label_calculos.Margin = new Padding(2, 0, 2, 0);
            label_calculos.Name = "label_calculos";
            label_calculos.Size = new Size(340, 25);
            label_calculos.TabIndex = 3;
            label_calculos.TextAlign = ContentAlignment.BottomRight;
            // 
            // tableLayoutPanelHeader
            // 
            tableLayoutPanelHeader.ColumnCount = 2;
            tableLayoutPanelHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelHeader.Controls.Add(labelEstandar, 0, 0);
            tableLayoutPanelHeader.Controls.Add(button25, 1, 0);
            tableLayoutPanelHeader.Dock = DockStyle.Top;
            tableLayoutPanelHeader.Location = new Point(3, 3);
            tableLayoutPanelHeader.Margin = new Padding(3, 3, 5, 3);
            tableLayoutPanelHeader.Name = "tableLayoutPanelHeader";
            tableLayoutPanelHeader.RowCount = 1;
            tableLayoutPanelHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelHeader.Size = new Size(336, 28);
            tableLayoutPanelHeader.TabIndex = 1;
            // 
            // labelEstandar
            // 
            labelEstandar.Anchor = AnchorStyles.Left;
            labelEstandar.AutoSize = true;
            labelEstandar.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            labelEstandar.ForeColor = SystemColors.Control;
            labelEstandar.Location = new Point(3, 0);
            labelEstandar.Name = "labelEstandar";
            labelEstandar.Size = new Size(94, 28);
            labelEstandar.TabIndex = 0;
            labelEstandar.Text = "Estándar";
            // 
            // tableLayoutPanelTimers
            // 
            tableLayoutPanelTimers.ColumnCount = 2;
            tableLayoutPanelTimers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelTimers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelTimers.Controls.Add(dateTimePicker1, 0, 0);
            tableLayoutPanelTimers.Controls.Add(dateTimePicker2, 1, 0);
            tableLayoutPanelTimers.Dock = DockStyle.Top;
            tableLayoutPanelTimers.Location = new Point(3, 41);
            tableLayoutPanelTimers.Name = "tableLayoutPanelTimers";
            tableLayoutPanelTimers.RowCount = 1;
            tableLayoutPanelTimers.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelTimers.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelTimers.Size = new Size(338, 27);
            tableLayoutPanelTimers.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Dock = DockStyle.Fill;
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(3, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(163, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Dock = DockStyle.Fill;
            dateTimePicker2.Enabled = false;
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(172, 3);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(163, 23);
            dateTimePicker2.TabIndex = 1;
            // 
            // tableLayoutPanelBasura
            // 
            tableLayoutPanelBasura.ColumnCount = 1;
            tableLayoutPanelBasura.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelBasura.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelBasura.Controls.Add(button26, 0, 0);
            tableLayoutPanelBasura.Dock = DockStyle.Bottom;
            tableLayoutPanelBasura.Location = new Point(0, 271);
            tableLayoutPanelBasura.Name = "tableLayoutPanelBasura";
            tableLayoutPanelBasura.RowCount = 1;
            tableLayoutPanelBasura.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelBasura.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelBasura.Size = new Size(344, 40);
            tableLayoutPanelBasura.TabIndex = 1;
            // 
            // panelTodoHistorial
            // 
            panelTodoHistorial.Controls.Add(panelHistorialCalculos);
            panelTodoHistorial.Controls.Add(tableLayoutPanelBasura);
            panelTodoHistorial.Dock = DockStyle.Top;
            panelTodoHistorial.Location = new Point(0, 186);
            panelTodoHistorial.Name = "panelTodoHistorial";
            panelTodoHistorial.Size = new Size(344, 311);
            panelTodoHistorial.TabIndex = 2;
            panelTodoHistorial.Visible = false;
            // 
            // panelHistorialCalculos
            // 
            panelHistorialCalculos.AutoScroll = true;
            panelHistorialCalculos.BackColor = Color.FromArgb(64, 64, 64);
            panelHistorialCalculos.Dock = DockStyle.Top;
            panelHistorialCalculos.Location = new Point(0, 0);
            panelHistorialCalculos.Name = "panelHistorialCalculos";
            panelHistorialCalculos.Size = new Size(344, 268);
            panelHistorialCalculos.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(344, 501);
            Controls.Add(panelTodoHistorial);
            Controls.Add(tableLayoutPanelMitadArriba);
            Controls.Add(tableLayoutBotones);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(460, 640);
            MinimumSize = new Size(360, 540);
            Name = "Form1";
            Text = "Calculadora";
            tableLayoutBotones.ResumeLayout(false);
            tableLayoutPanelMitadArriba.ResumeLayout(false);
            tableLayoutPanelMitadArriba.PerformLayout();
            tableLayoutPanelHeader.ResumeLayout(false);
            tableLayoutPanelHeader.PerformLayout();
            tableLayoutPanelTimers.ResumeLayout(false);
            tableLayoutPanelBasura.ResumeLayout(false);
            panelTodoHistorial.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutBotones;
        private Boton button24;
        private Boton button19;
        private Boton button23;
        private Boton button13;
        private Boton button22;
        private Boton button18;
        private Boton button21;
        private Boton button6;
        private Boton button20;
        private Boton button17;
        private Boton button12;
        private Boton button16;
        private Boton button1;
        private Boton button15;
        private Boton button5;
        private Boton button2;
        private Boton button9;
        private Boton button4;
        private Boton button8;
        private Boton button3;
        private Boton button7;
        private Boton button10;
        private Boton button11;
        private Boton button14;
        private TableLayoutPanel tableLayoutPanelMitadArriba;
        private TableLayoutPanel tableLayoutPanelHeader;
        private TableLayoutPanel tableLayoutPanelTimers;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label labelEstandar;
        private Label label_calculos;
        private TableLayoutPanel tableLayoutPanelBasura;
        private Boton button25;
        private Boton button26;
        private Panel panelTodoHistorial;
        private Panel panelHistorialCalculos;
        private TextBox textBox1;
    }
}
