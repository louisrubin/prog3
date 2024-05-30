namespace Calculadora_WF
{
    public partial class Form1 : Form
    {
        private string listaMostrando = "";
        private double[] listaNumeros = new double[2];
        private DateTime[] listaTiempos = new DateTime[2];

        private char caracterOpera;
        private bool calcularTiempos = false;   // para que el Equals calcule tiempos

        private byte posActual = 0;     // para el ultimo btn +/-
        
        public Form1()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            listaMostrando += "1";
            textBox1.Text = listaMostrando;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listaMostrando += "2";
            textBox1.Text = listaMostrando;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listaMostrando += "3";
            textBox1.Text = listaMostrando;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listaMostrando += "4";
            textBox1.Text = listaMostrando;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listaMostrando += "5";
            textBox1.Text = listaMostrando;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listaMostrando += "6";
            textBox1.Text = listaMostrando;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listaMostrando += "7";
            textBox1.Text = listaMostrando;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listaMostrando += "8";
            textBox1.Text = listaMostrando;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listaMostrando += "9";
            textBox1.Text = listaMostrando;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            listaMostrando += "0";
            textBox1.Text = listaMostrando;
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
        private void button11_Click(object sender, EventArgs e)
        {

            if ( ! calcularTiempos)     // false;
            {
                calcularTiempos = true;
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                button11.BackColor = Color.DarkOrange;
                soloBotonTiempos();
                return;
            }
            calcularTiempos = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            button11.BackColor = Color.DimGray;

            listaMostrando = "";
            textBox1.Text = listaMostrando;
            allButtonsEnabled();

            //textBox1.Text = listaMostrando;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            listaMostrando = "";
            textBox1.Text = listaMostrando;
            allButtonsEnabled();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            listaMostrando = "";
            textBox1.Text = listaMostrando;
            allButtonsEnabled();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //      RETROCEDER
            if (listaMostrando.Length == 0)     // tiraba error por estar vacio
            {
                return;
            }

            string resultado = listaMostrando.Substring(0, listaMostrando.Length - 1);

            if (resultado.Equals("-"))      // si era num -5, quedaba el signo '-'
            {
                resultado = listaMostrando.Substring(0, resultado.Length - 1);
            }
            listaMostrando = resultado;
            textBox1.Text = listaMostrando;
        }
        private void button15_Click(object sender, EventArgs e)
        {
            
        }
        private void button16_Click(object sender, EventArgs e)
        {
            
        }
        private void button17_Click(object sender, EventArgs e)
        {

        }
        private void button18_Click(object sender, EventArgs e)
        {
            //      / / /

            if (listaMostrando.Length == 0)
            {
                listaMostrando += "0";      // cuando está vacio agrega el cero
            }

            listaNumeros[0] = double.Parse(listaMostrando);     // guardo el primer término de la operacion
            
            textBox1.Text = listaMostrando + "/";

            caracterOpera = '/';
            listaMostrando = "";

            posActual = 1;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //      X X X
            if (listaMostrando.Length == 0)
            {
                listaMostrando += "0";      // cuando está vacio agrega el cero
            }

            listaNumeros[0] = double.Parse(listaMostrando);     // guardo el primer término de la operacion
            listaMostrando += "x";
            textBox1.Text = listaMostrando;

            caracterOpera = 'x';
            listaMostrando = "";

            posActual = 1;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //      - - -
            if (listaMostrando.Length == 0)
            {
                listaMostrando += "0";      // cuando está vacio agrega el cero
            }

            listaNumeros[0] = double.Parse(listaMostrando);     // guardo el primer término de la operacion
            listaMostrando += "-";
            textBox1.Text = listaMostrando;

            caracterOpera = '-';
            listaMostrando = "";

            posActual = 1;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //      + + +
            if (listaMostrando.Length == 0)
            {
                listaMostrando += "0";      // cuando está vacio agrega el cero
            }

            listaNumeros[0] = double.Parse(listaMostrando);     // guardo el primer término de la operacion
            listaMostrando += "+";
            textBox1.Text = listaMostrando;

            caracterOpera = '+';
            listaMostrando = "";

            posActual = 1;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //      = = = 

            if (calcularTiempos)    // si calculando tiempos
            {
                //listaTiempos[0] = dateTimePicker1.Value;
                //listaTiempos[1] = dateTimePicker2.Value;
                TimeSpan dif = dateTimePicker2.Value - dateTimePicker1.Value;
                textBox1.Text = $"{dif.Days}d"; //, {dif.Hours}h, {dif.Minutes}m";
                return;
            }
            //
            // SI NO CALCULAMOS TIEMPOS SIGUE NORMAL
            //  
            if (listaMostrando == "")       // el 2do termino siempre arranca con 0 para evitar errores
            {
                listaMostrando += "0";
            }

            double resultado = listaNumeros[0];
            listaNumeros[1] = double.Parse(listaMostrando);

            switch (caracterOpera)
            {
                case 'x':
                    resultado *= listaNumeros[1];
                    break;


                case '-':
                    resultado -= listaNumeros[1];
                    break;


                case '+':
                    resultado += listaNumeros[1];
                    break;


                case '/':
                    resultado /= listaNumeros[1];

                    if (double.IsInfinity(resultado))       // si es infinito
                    {
                        listaMostrando = "";
                        textBox1.Text = "No div. por 0.";
                        posActual = 0;
                        soloBotonesLimpiar();
                        return;
                    } else if (double.IsNaN(resultado))     // si es NaN
                    {
                        listaMostrando = "";
                        textBox1.Text = listaMostrando;
                        posActual = 0;
                        //soloBotonesLimpiar();
                        return;
                    }
                    break;
            }

            resultado = Math.Round(resultado, 10);       // dejando solo x decimales
            listaNumeros[0] = resultado;    // resultado de la oper se posiciona 1er termino

            if (resultado == 0)
            {
                listaMostrando = "";
            }
            else
            {
                listaMostrando = resultado.ToString();
            }
            posActual = 0;
            textBox1.Text = listaMostrando;
        }
        private void button23_Click(object sender, EventArgs e)
        {
            //      , , ,
            if (listaMostrando.Length == 0)
            {
                listaMostrando += "0";      // cuando está vacio agrega el cero
            }
            listaMostrando += ",";
            textBox1.Text = listaMostrando;
        }
        private void button24_Click(object sender, EventArgs e)
        {
            //      +/-   +/-   +/-
            // cuando se presiona un boton de operacion se cambia 
            // el signo al numero del 2do termino

            if (listaMostrando.Length == 0)     // tiraba error por estar vacio
            {
                return;
            }
            listaNumeros[posActual] = double.Parse(listaMostrando);
            listaNumeros[posActual] *= (-1);

            listaMostrando = listaNumeros[posActual].ToString();
            textBox1.Text = listaNumeros[posActual].ToString();
        }
        private void button25_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // TEXTO BOX
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = "0";
            }
        }

        private void allButtonsEnabled()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            //button15.Enabled = true;
            //button16.Enabled = true;
            //button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
        }

        private void soloBotonesLimpiar()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            //
            button12.Enabled = true;
            button13.Enabled = true;
            //
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
            button23.Enabled = false;
            button24.Enabled = false;
        }

        private void soloBotonTiempos()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            //button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            //button22.Enabled = false;     // = = = activado
            button23.Enabled = false;
            button24.Enabled = false;
        }
    }
}
