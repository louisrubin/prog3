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
            label_TamTotal1.Font = new Font("Segoe UI", 10F);
            label_TamTotal1.Location = new Point(398, 502);
            label_TamTotal1.Name = "label_TamTotal1";
            label_TamTotal1.Size = new Size(92, 19);
            label_TamTotal1.TabIndex = 4;
            label_TamTotal1.Text = "Tamaño Total:";
            label_TamTotal1.Visible = false;
            // 
            // label_TamTotal2
            // 
            label_TamTotal2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label_TamTotal2.AutoSize = true;
            label_TamTotal2.Font = new Font("Segoe UI", 12F);
            label_TamTotal2.Location = new Point(496, 500);
            label_TamTotal2.Name = "label_TamTotal2";
            label_TamTotal2.Size = new Size(76, 21);
            label_TamTotal2.TabIndex = 5;
            label_TamTotal2.Text = "32,09 MB";
            label_TamTotal2.TextAlign = ContentAlignment.MiddleRight;
            label_TamTotal2.Visible = false;
            // 
            // label_cantArchivos1
            // 
            label_cantArchivos1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label_cantArchivos1.AutoSize = true;
            label_cantArchivos1.Font = new Font("Segoe UI", 10F);
            label_cantArchivos1.Location = new Point(398, 472);
            label_cantArchivos1.Name = "label_cantArchivos1";
            label_cantArchivos1.Size = new Size(100, 19);
            label_cantArchivos1.TabIndex = 6;
            label_cantArchivos1.Text = "Cant. Archivos:";
            label_cantArchivos1.Visible = false;
            // 
            // label_cantArchivos2
            // 
            label_cantArchivos2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label_cantArchivos2.Font = new Font("Segoe UI", 12F);
            label_cantArchivos2.Location = new Point(515, 468);
            label_cantArchivos2.Name = "label_cantArchivos2";
            label_cantArchivos2.Size = new Size(48, 23);
            label_cantArchivos2.TabIndex = 0;
            label_cantArchivos2.Text = "18";
            label_cantArchivos2.TextAlign = ContentAlignment.TopRight;
            label_cantArchivos2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 536);
            Controls.Add(label_cantArchivos2);
            Controls.Add(label_cantArchivos1);
            Controls.Add(label_TamTotal2);
            Controls.Add(label_TamTotal1);
            Controls.Add(buttonBuscarCarpeta);
            Controls.Add(textBoxRuta);
            Controls.Add(labelRuta);
            Controls.Add(panelTextBox);
            MaximizeBox = false;
            MaximumSize = new Size(600, 700);
            MinimumSize = new Size(459, 542);
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
    }
}
