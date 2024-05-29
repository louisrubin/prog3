namespace Calculadora_WF
{
    public partial class Form1 : Form
    {
        private string listOperac = "";
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listOperac += "1";
            textBox1.Text = listOperac;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listOperac += "2";
            textBox1.Text = listOperac;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listOperac += "3";
            textBox1.Text = listOperac;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listOperac += "4";
            textBox1.Text = listOperac;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listOperac += "5";
            textBox1.Text = listOperac;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listOperac += "6";
            textBox1.Text = listOperac;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listOperac += "7";
            textBox1.Text = listOperac;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listOperac += "8";
            textBox1.Text = listOperac;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listOperac += "9";
            textBox1.Text = listOperac;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            listOperac += "0";
            textBox1.Text = listOperac;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                // Establecer el tamaño deseado (por ejemplo, 800x600)
                //this.WindowState = FormWindowState.Normal;
                this.Size = new Size(360, 540);
                //this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                //                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            listOperac += "+";
            textBox1.Text = listOperac;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            listOperac += "-";
            textBox1.Text = listOperac;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            listOperac += "x";
            textBox1.Text = listOperac;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            listOperac += "/";
            textBox1.Text = listOperac;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            listOperac += ",";
            textBox1.Text = listOperac;
        }

        
    }
}
