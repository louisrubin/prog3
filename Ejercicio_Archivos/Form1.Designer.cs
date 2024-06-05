namespace Ejercicio_Archivos
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
            panelTextBox = new Panel();
            textBox_InfoCarpeta = new TextBox();
            labelRuta = new Label();
            textBoxRuta = new TextBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            buttonBuscarCarpeta = new Button();
            label_TamTotal1 = new Label();
            label_TamTotal2 = new Label();
            label_cantArchivos1 = new Label();
            label_cantArchivos2 = new Label();
            button_generarTxt = new Button();
            button_leer = new Button();
            label_creado = new Label();
            button_serializar = new Button();
            button_deserializar = new Button();
            button_limpiar = new Button();
            panelTextBox.SuspendLayout();
            SuspendLayout();
            // 
            // panelTextBox
            // 
            panelTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelTextBox.BackColor = SystemColors.AppWorkspace;
            panelTextBox.Controls.Add(textBox_InfoCarpeta);
            panelTextBox.Location = new Point(12, 76);
            panelTextBox.Name = "panelTextBox";
            panelTextBox.Size = new Size(560, 371);
            panelTextBox.TabIndex = 0;
            // 
            // textBox_InfoCarpeta
            // 
            textBox_InfoCarpeta.Dock = DockStyle.Fill;
            textBox_InfoCarpeta.Location = new Point(0, 0);
            textBox_InfoCarpeta.Multiline = true;
            textBox_InfoCarpeta.Name = "textBox_InfoCarpeta";
            textBox_InfoCarpeta.ReadOnly = true;
            textBox_InfoCarpeta.ScrollBars = ScrollBars.Vertical;
            textBox_InfoCarpeta.Size = new Size(560, 371);
            textBox_InfoCarpeta.TabIndex = 0;
            // 
            // labelRuta
            // 
            labelRuta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelRuta.AutoSize = true;
            labelRuta.Font = new Font("Segoe UI", 12F);
            labelRuta.Location = new Point(12, 23);
            labelRuta.Name = "labelRuta";
            labelRuta.Size = new Size(45, 21);
            labelRuta.TabIndex = 1;
            labelRuta.Text = "Ruta:";
            // 
            // textBoxRuta
            // 
            textBoxRuta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxRuta.Location = new Point(63, 23);
            textBoxRuta.Name = "textBoxRuta";
            textBoxRuta.ReadOnly = true;
            textBoxRuta.Size = new Size(466, 23);
            textBoxRuta.TabIndex = 2;
            // 
            // buttonBuscarCarpeta
            // 
            buttonBuscarCarpeta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonBuscarCarpeta.BackColor = Color.Orange;
            buttonBuscarCarpeta.Location = new Point(12, 481);
            buttonBuscarCarpeta.MaximumSize = new Size(125, 40);
            buttonBuscarCarpeta.Name = "buttonBuscarCarpeta";
            buttonBuscarCarpeta.Size = new Size(117, 40);
            buttonBuscarCarpeta.TabIndex = 3;
            buttonBuscarCarpeta.Text = "Buscar Carpeta";
            buttonBuscarCarpeta.UseVisualStyleBackColor = false;
            buttonBuscarCarpeta.Click += buttonBuscarCarpeta_Click;
            // 
            // label_TamTotal1
            // 
            label_TamTotal1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label_TamTotal1.AutoSize = true;
            label_TamTotal1.Font = new Font("Segoe UI", 9F);
            label_TamTotal1.Location = new Point(411, 452);
            label_TamTotal1.Name = "label_TamTotal1";
            label_TamTotal1.Size = new Size(80, 15);
            label_TamTotal1.TabIndex = 4;
            label_TamTotal1.Text = "Tamaño Total:";
            label_TamTotal1.Visible = false;
            // 
            // label_TamTotal2
            // 
            label_TamTotal2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label_TamTotal2.AutoSize = true;
            label_TamTotal2.Font = new Font("Segoe UI", 10F);
            label_TamTotal2.Location = new Point(497, 449);
            label_TamTotal2.Name = "label_TamTotal2";
            label_TamTotal2.Size = new Size(69, 19);
            label_TamTotal2.TabIndex = 5;
            label_TamTotal2.Text = "32,09 MB";
            label_TamTotal2.TextAlign = ContentAlignment.MiddleRight;
            label_TamTotal2.Visible = false;
            // 
            // label_cantArchivos1
            // 
            label_cantArchivos1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label_cantArchivos1.AutoSize = true;
            label_cantArchivos1.Font = new Font("Segoe UI", 9F);
            label_cantArchivos1.Location = new Point(283, 452);
            label_cantArchivos1.Name = "label_cantArchivos1";
            label_cantArchivos1.Size = new Size(87, 15);
            label_cantArchivos1.TabIndex = 6;
            label_cantArchivos1.Text = "Cant. Archivos:";
            label_cantArchivos1.Visible = false;
            // 
            // label_cantArchivos2
            // 
            label_cantArchivos2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label_cantArchivos2.Font = new Font("Segoe UI", 10F);
            label_cantArchivos2.Location = new Point(376, 448);
            label_cantArchivos2.Name = "label_cantArchivos2";
            label_cantArchivos2.Size = new Size(29, 19);
            label_cantArchivos2.TabIndex = 0;
            label_cantArchivos2.Text = "18";
            label_cantArchivos2.TextAlign = ContentAlignment.TopRight;
            label_cantArchivos2.Visible = false;
            // 
            // button_generarTxt
            // 
            button_generarTxt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_generarTxt.BackColor = SystemColors.ControlDark;
            button_generarTxt.Enabled = false;
            button_generarTxt.Location = new Point(145, 486);
            button_generarTxt.Name = "button_generarTxt";
            button_generarTxt.Size = new Size(90, 31);
            button_generarTxt.TabIndex = 7;
            button_generarTxt.Text = "Generar txt";
            button_generarTxt.UseVisualStyleBackColor = false;
            button_generarTxt.Click += button_generarTxt_Click;
            // 
            // button_leer
            // 
            button_leer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_leer.BackColor = SystemColors.ControlDark;
            button_leer.Location = new Point(252, 486);
            button_leer.Name = "button_leer";
            button_leer.Size = new Size(90, 31);
            button_leer.TabIndex = 8;
            button_leer.Text = "Leer Archivo";
            button_leer.UseVisualStyleBackColor = false;
            button_leer.Click += button_leer_Click;
            // 
            // label_creado
            // 
            label_creado.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_creado.AutoSize = true;
            label_creado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label_creado.ForeColor = Color.Green;
            label_creado.Location = new Point(12, 450);
            label_creado.Name = "label_creado";
            label_creado.Size = new Size(180, 15);
            label_creado.TabIndex = 9;
            label_creado.Text = "Archivo Creado Correctamente";
            label_creado.Visible = false;
            // 
            // button_serializar
            // 
            button_serializar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_serializar.Location = new Point(416, 490);
            button_serializar.Name = "button_serializar";
            button_serializar.Size = new Size(75, 23);
            button_serializar.TabIndex = 10;
            button_serializar.Text = "Serializar";
            button_serializar.UseVisualStyleBackColor = true;
            button_serializar.Click += button_serializar_Click;
            // 
            // button_deserializar
            // 
            button_deserializar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_deserializar.Location = new Point(497, 490);
            button_deserializar.Name = "button_deserializar";
            button_deserializar.Size = new Size(75, 23);
            button_deserializar.TabIndex = 11;
            button_deserializar.Text = "Deserializar";
            button_deserializar.UseVisualStyleBackColor = true;
            button_deserializar.Click += button_deserializar_Click;
            // 
            // button_limpiar
            // 
            button_limpiar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_limpiar.Location = new Point(517, 52);
            button_limpiar.Name = "button_limpiar";
            button_limpiar.Size = new Size(55, 23);
            button_limpiar.TabIndex = 12;
            button_limpiar.Text = "Limpiar";
            button_limpiar.UseVisualStyleBackColor = true;
            button_limpiar.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 536);
            Controls.Add(button_limpiar);
            Controls.Add(button_deserializar);
            Controls.Add(button_serializar);
            Controls.Add(label_creado);
            Controls.Add(button_leer);
            Controls.Add(button_generarTxt);
            Controls.Add(label_cantArchivos2);
            Controls.Add(label_cantArchivos1);
            Controls.Add(label_TamTotal2);
            Controls.Add(label_TamTotal1);
            Controls.Add(buttonBuscarCarpeta);
            Controls.Add(textBoxRuta);
            Controls.Add(labelRuta);
            Controls.Add(panelTextBox);
            MaximizeBox = false;
            MaximumSize = new Size(700, 800);
            MinimumSize = new Size(600, 575);
            Name = "Form1";
            Text = "Ejercicio Archivos - RUBIN";
            panelTextBox.ResumeLayout(false);
            panelTextBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTextBox;
        private Label labelRuta;
        private TextBox textBoxRuta;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button buttonBuscarCarpeta;
        private Label label_TamTotal1;
        private Label label_TamTotal2;
        private TextBox textBox_InfoCarpeta;
        private Label label_cantArchivos1;
        private Label label_cantArchivos2;
        private Button button_generarTxt;
        private Button button_leer;
        private Label label_creado;
        private Button button_serializar;
        private Button button_deserializar;
        private Button button_limpiar;
    }
}
