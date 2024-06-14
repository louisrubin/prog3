namespace Parcial_2
{
    partial class Form1
    {
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
            this.btn_AbrirArchivo = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label_ruta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lab_palabras = new System.Windows.Forms.Label();
            this.lab_caracTotal = new System.Windows.Forms.Label();
            this.lab_caracSCEsp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_obtenerEstad = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AbrirArchivo
            // 
            this.btn_AbrirArchivo.BackColor = System.Drawing.Color.IndianRed;
            this.btn_AbrirArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AbrirArchivo.Location = new System.Drawing.Point(16, 33);
            this.btn_AbrirArchivo.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AbrirArchivo.Name = "btn_AbrirArchivo";
            this.btn_AbrirArchivo.Size = new System.Drawing.Size(141, 32);
            this.btn_AbrirArchivo.TabIndex = 0;
            this.btn_AbrirArchivo.Text = "Abrir Archivo";
            this.btn_AbrirArchivo.UseVisualStyleBackColor = false;
            this.btn_AbrirArchivo.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ruta: ";
            // 
            // label_ruta
            // 
            this.label_ruta.AutoSize = true;
            this.label_ruta.Location = new System.Drawing.Point(59, 9);
            this.label_ruta.Name = "label_ruta";
            this.label_ruta.Size = new System.Drawing.Size(12, 15);
            this.label_ruta.TabIndex = 3;
            this.label_ruta.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Palabras: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Caracteres Totales:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Caracteres sin contar espacios:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_palabras
            // 
            this.lab_palabras.AutoSize = true;
            this.lab_palabras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_palabras.Location = new System.Drawing.Point(292, 0);
            this.lab_palabras.Name = "lab_palabras";
            this.lab_palabras.Size = new System.Drawing.Size(284, 26);
            this.lab_palabras.TabIndex = 7;
            this.lab_palabras.Text = "-";
            this.lab_palabras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab_caracTotal
            // 
            this.lab_caracTotal.AutoSize = true;
            this.lab_caracTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_caracTotal.Location = new System.Drawing.Point(292, 26);
            this.lab_caracTotal.Name = "lab_caracTotal";
            this.lab_caracTotal.Size = new System.Drawing.Size(284, 26);
            this.lab_caracTotal.TabIndex = 8;
            this.lab_caracTotal.Text = "-";
            this.lab_caracTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab_caracSCEsp
            // 
            this.lab_caracSCEsp.AutoSize = true;
            this.lab_caracSCEsp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_caracSCEsp.Location = new System.Drawing.Point(292, 52);
            this.lab_caracSCEsp.Name = "lab_caracSCEsp";
            this.lab_caracSCEsp.Size = new System.Drawing.Size(284, 20);
            this.lab_caracSCEsp.TabIndex = 9;
            this.lab_caracSCEsp.Text = "-";
            this.lab_caracSCEsp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(19, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 251);
            this.panel1.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(579, 251);
            this.textBox1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lab_palabras, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lab_caracSCEsp, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lab_caracTotal, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 328);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(579, 72);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // btn_obtenerEstad
            // 
            this.btn_obtenerEstad.BackColor = System.Drawing.Color.Wheat;
            this.btn_obtenerEstad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_obtenerEstad.Location = new System.Drawing.Point(184, 33);
            this.btn_obtenerEstad.Name = "btn_obtenerEstad";
            this.btn_obtenerEstad.Size = new System.Drawing.Size(139, 32);
            this.btn_obtenerEstad.TabIndex = 12;
            this.btn_obtenerEstad.Text = "Obtener estadísticas";
            this.btn_obtenerEstad.UseVisualStyleBackColor = false;
            this.btn_obtenerEstad.Click += new System.EventHandler(this.btn_obtenerEstad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 407);
            this.Controls.Add(this.btn_obtenerEstad);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_ruta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AbrirArchivo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_AbrirArchivo;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label1;
        private Label label_ruta;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lab_palabras;
        private Label lab_caracTotal;
        private Label lab_caracSCEsp;
        private Panel panel1;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_obtenerEstad;
    }
}
