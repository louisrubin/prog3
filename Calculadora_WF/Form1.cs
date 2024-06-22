using System.Diagnostics;

namespace Calculadora_WF
{
    //
    //  github: https://github.com/louisrubin/prog3/tree/main/Calculadora_WF
    //

    public partial class Form1 : Form
    {

        private string listaMostrando = "";                 // el numero que se está ingresando
        private double[] listaNumeros = new double[2];          // 2 numeros para la operacion
        private DateTime[] listaTiempos = new DateTime[2];
        private List<Calculo> listCalculos = new List<Calculo>();   // lista de todos los calculos

        private char caracterOpera = ' ';
        private bool calcularTiempos = false;   // para que el Equals calcule tiempos

        private byte posActual = 0;     // para el ultimo btn +/-
        private bool volverPosCero = true;      // permitir asignar el primer carac luego de operac, algo asi

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!volverPosCero) listaMostrando = "";

            resetTextBox();     // reinicia el string de numeros ingresados

            volverPosCero = true;
            listaMostrando += "1";
            textBox1.Text = listaMostrando;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!volverPosCero) listaMostrando = "";

            resetTextBox();     // reinicia el string de numeros ingresados

            volverPosCero = true;
            listaMostrando += "2";
            textBox1.Text = listaMostrando;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!volverPosCero) listaMostrando = "";

            resetTextBox();     // reinicia el string de numeros ingresados

            volverPosCero = true;
            listaMostrando += "3";
            textBox1.Text = listaMostrando;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!volverPosCero) listaMostrando = "";

            resetTextBox();     // reinicia el string de numeros ingresados

            volverPosCero = true;
            listaMostrando += "4";
            textBox1.Text = listaMostrando;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!volverPosCero) listaMostrando = "";

            resetTextBox();     // reinicia el string de numeros ingresados

            volverPosCero = true;
            listaMostrando += "5";
            textBox1.Text = listaMostrando;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!volverPosCero) listaMostrando = "";

            resetTextBox();     // reinicia el string de numeros ingresados

            volverPosCero = true;
            listaMostrando += "6";
            textBox1.Text = listaMostrando;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!volverPosCero) listaMostrando = "";

            resetTextBox();     // reinicia el string de numeros ingresados

            volverPosCero = true;
            listaMostrando += "7";
            textBox1.Text = listaMostrando;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!volverPosCero) listaMostrando = "";

            resetTextBox();     // reinicia el string de numeros ingresados

            volverPosCero = true;
            listaMostrando += "8";
            textBox1.Text = listaMostrando;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!volverPosCero) listaMostrando = "";

            resetTextBox();     // reinicia el string de numeros ingresados

            volverPosCero = true;
            listaMostrando += "9";
            textBox1.Text = listaMostrando;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (!volverPosCero) listaMostrando = "";

            resetTextBox();     // reinicia el string de numeros ingresados

            volverPosCero = true;
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
            //      TIEMPOS   TIEMPOS   TIEMPOS
            if (!calcularTiempos)     // false;
            {
                calcularTiempos = true;
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                button11.BackColor = Color.DarkOrange;
                soloBotonTiempos();
                //textBox1.Text = "";
                //label2.Text = "";
                return;
            }
            calcularTiempos = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            button11.BackColor = Color.DimGray;

            listaMostrando = "";
            textBox1.Text = "";
            allButtonsEnabled();

            label_calculos.Text = "";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            //      CE   CE   CE
            if (!volverPosCero) label_calculos.Text = "";
            listaMostrando = "";
            textBox1.Text = listaMostrando;
            allButtonsEnabled();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //      C   C   C
            volverPosCero = true;
            listaMostrando = "";
            listaNumeros[0] = 0;    // limpias los 2 términos = 0
            listaNumeros[1] = 0;
            posActual = 0;          // vuelve al 1er término de la operac

            caracterOpera = ' ';        // limpia el caracter de operacion
            label_calculos.Text = "";

            textBox1.Text = listaMostrando;
            allButtonsEnabled();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //      <--   <--   <--
            if (listaMostrando.Length == 0)     // tiraba error por estar vacio
            {
                return;
            }

            volverPosCero = true;
            string resultado = listaMostrando.Substring(0, listaMostrando.Length - 1);

            if (resultado.Equals("-"))      // si era num -5, quedaba el signo '-'
            {
                listaMostrando = "";
            }
            listaMostrando = resultado;
            textBox1.Text = listaMostrando;
        }
        private void button15_Click(object sender, EventArgs e)
        {
            //      1/x   1/x   1/x
            if (listaMostrando.Length == 0)
            {
                listaMostrando = "0";
            }
            string text_operac;
            listaNumeros[0] = 1;
            //listaNumeros[1] = double.Parse(listaMostrando);   // NO

            double resultado = listaNumeros[0] / double.Parse(listaMostrando);
            generarStringOperac('/', out text_operac, listaMostrando);      // metodo genera string
            label_calculos.Text = text_operac;
            if (divisionHasError(resultado)) return;        // hubo error en la division

            resultado = Math.Round(resultado, 9);       // dejando solo x decimales
            listaNumeros[0] = resultado;    // resultado de la oper se posiciona 1er termino

            listCalculos.Add(new Calculo(text_operac, resultado));      // se agrega a la lista

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
            volverPosCero = false;

        }
        private void button16_Click(object sender, EventArgs e)
        {
            //      x^2   x^2   x^2
            if (listaMostrando.Length == 0)
            {
                return;
            }
            string text_operac = "";

            listaNumeros[0] = double.Parse(listaMostrando);
            double resultado = Math.Round(Math.Pow(listaNumeros[0], 2), 9); // potenciacion, 9 decimales


            listaMostrando = resultado.ToString();
            text_operac = $"({listaNumeros[0]}) ^ 2 =";

            listCalculos.Add(new Calculo(text_operac, resultado));

            label_calculos.Text = text_operac;
            textBox1.Text = listaMostrando;
            posActual = 0;
            volverPosCero = false;
        }
        private void button17_Click(object sender, EventArgs e)
        {
            //    Raiz   Raiz   Raiz 
            if (listaMostrando.Length == 0)
            {
                return;
            }
            string text_operac = "";

            listaNumeros[0] = double.Parse(listaMostrando);
            double resultado = Math.Round(Math.Sqrt(listaNumeros[0]), 9); // raiz cuadrada con 9 decimales

            listaMostrando = resultado.ToString();
            text_operac = $"√({listaNumeros[0]}) =";
            label_calculos.Text = text_operac;

            listCalculos.Add(new Calculo(text_operac, resultado));

            if (double.IsNaN(resultado))     // si es NaN
            {
                textBox1.Text = "NaN";
                soloBotonesLimpiar();
                return;            // SI hubo error
            }

            textBox1.Text = listaMostrando;
            posActual = 0;
            volverPosCero = false;
        }
        private void button18_Click(object sender, EventArgs e)
        {
            //      / / /

            if (listaMostrando.Length == 0) // arrancar el program tirar error pq está vacío
            {
                listaMostrando += "0";      // cuando está vacio agrega el cero
            }

            //if (caracterOpera == '/')       // si ya se asignó una operacion antes
            //{
            //    posActual = 1;              // cambia a la posic 1 del array para qe el metodo pueda funcionar
            //    restultadoOperacion();      // hace esa operacion
            //}

            listaNumeros[0] = double.Parse(listaMostrando);     // guardo el primer término de la operacion
            label_calculos.Text = listaMostrando + " / ";

            caracterOpera = '/';
            //listaMostrando = "";
            //textBox1.Text = "";

            posActual = 1;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //      X X X
            if (listaMostrando.Length == 0)
            {
                listaMostrando += "0";      // cuando está vacio agrega el cero
            }

            //if (caracterOpera == 'x')
            //{
            //    posActual = 1;
            //    restultadoOperacion();      // hace esa operacion
            //}

            textBox1.Text = listaMostrando;
            listaNumeros[0] = double.Parse(listaMostrando);     // guardo el primer término de la operacion
            label_calculos.Text = listaMostrando + " x ";

            caracterOpera = 'x';
            //listaMostrando = "";
            //textBox1.Text = "";

            posActual = 1;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //      - - -
            if (listaMostrando.Length == 0)
            {
                listaMostrando += "0";
            }

            //if (caracterOpera == '-')
            //{
            //    posActual = 1;
            //    restultadoOperacion();
            //}

            listaNumeros[0] = double.Parse(listaMostrando);     // guardo el primer término de la operacion
            label_calculos.Text = listaMostrando + " - ";

            caracterOpera = '-';
            //listaMostrando = "";
            //textBox1.Text = "";

            posActual = 1;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //      + + +
            if (listaMostrando.Length == 0) // arrancar el program tirar error pq está vacío
            {
                listaMostrando += "0";      // cuando está vacio agrega el cero
            }

            //if (caracterOpera == '+')   // si ya se asignó una operacion antes
            //{
            //    posActual = 1;      // cambia a la posic 1 del array para qe el metodo pueda funcionar
            //    restultadoOperacion();      // hace esa operacion 
            //}

            listaNumeros[0] = double.Parse(listaMostrando);     // guardo el primer término de la operacion
            label_calculos.Text = listaMostrando + " + ";

            caracterOpera = '+';

            posActual = 1;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //      = = = 
            restultadoOperacion();  // tuve que mover el código a un metodo
                                    // para usarlo en otros botones tmb
        }
        private void button23_Click(object sender, EventArgs e)
        {
            //      , , ,
            if (listaMostrando.Length == 0)
            {
                listaMostrando += "0";      // cuando está vacio agrega el cero
            }

            if (listaMostrando.Contains(','))
            {
                //listaMostrando = ""; 
                return;     // si ya contiene una coma no hace nada
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
            //volverPosCero = true;     // NO
        }
        private void button25_Click(object sender, EventArgs e)
        {
            //      HISTORIAL 
            tableLayoutPanelResul T_L_P_Resul_actual;

            if (!panelTodoHistorial.Visible)
            {
                button25.BackColor = Color.Thistle;
                panelTodoHistorial.Visible = true;

                if (listCalculos.Count == 0)
                {
                    // MENSAJE 'no hay historial todavía.'
                    T_L_P_Resul_actual = new tableLayoutPanelResul("No hay historial todavía.");

                    panelHistorialCalculos.Controls.Add(T_L_P_Resul_actual);
                }
                else
                {
                    foreach (var calculo in listCalculos)
                    {
                        T_L_P_Resul_actual = new tableLayoutPanelResul(calculo.Expresion, calculo.Resultado);
                        T_L_P_Resul_actual.click_personalizado += TableLayoutPanelResul_CustomClick;
                        panelHistorialCalculos.Controls.Add(T_L_P_Resul_actual);
                    }
                }
                return;
            }
            panelHistorialCalculos.Controls.Clear();    // LIMPIA TODO AL CERRAR

            button25.BackColor = Color.DimGray;
            panelTodoHistorial.Visible = false;
        }
        private void TableLayoutPanelResul_CustomClick(object sender, CustomEventArgs customArgs)
        {
            //   EVENT CLIC SOBRE CALCULO EN HISTORIAL <CustomEventArgs>
            listaMostrando = customArgs.Resultado;
            textBox1.Text = customArgs.Resultado;
            label_calculos.Text = customArgs.Operacion;

            panelTodoHistorial.Visible = false;     // cierra el panel
        }

        private void button26_Click(object sender, EventArgs e)
        {
            // CLEAR HISTORIAL
            listCalculos.Clear();

            panelHistorialCalculos.AutoScrollPosition = new Point(0, 0);    // Resetear la posición de scroll

            panelHistorialCalculos.Controls.Clear();    // LIMPIA TODO
            // MENSAJE 'no hay historial todavía.'
            panelHistorialCalculos.Controls.Add(new tableLayoutPanelResul("No hay historial todavía."));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // TEXTO BOX
            // 
            if (listaMostrando.Length == 0)
            {
                textBox1.Text = "0";
            }
        }

        private void restultadoOperacion()
        {
            if (calcularTiempos)    // si calculando tiempos
            {
                TimeSpan dif = dateTimePicker2.Value - dateTimePicker1.Value;
                label_calculos.Text = "";
                textBox1.Text = $"{dif.Days}d";
                return;
            }
            //
            // SI NO CALCULAMOS TIEMPOS SIGUE NORMAL
            // 

            if (listaMostrando == "")       // el 2do termino siempre arranca con 0 para evitar errores
            {
                listaMostrando += "0";
            }

            listaNumeros[posActual] = double.Parse(listaMostrando);  // hasta no presionar otra tecla de oper, sigue en posic=0;
            double resultado = listaNumeros[0];

            string text_operac = "";        // string que se mostrará en label 2

            switch (caracterOpera)
            {
                case 'x':
                    generarStringOperac('x', out text_operac);      // metodo genera string

                    label_calculos.Text = text_operac; ;
                    resultado *= listaNumeros[1];
                    break;


                case '-':
                    generarStringOperac('-', out text_operac);      // metodo genera string

                    label_calculos.Text = text_operac; ;
                    resultado -= listaNumeros[1];
                    break;


                case '+':
                    generarStringOperac('+', out text_operac);      // metodo genera string

                    label_calculos.Text = text_operac; ;
                    resultado += listaNumeros[1];
                    break;


                case '/':
                    generarStringOperac('/', out text_operac);      // metodo genera string

                    label_calculos.Text = text_operac;

                    resultado /= listaNumeros[1];

                    if (divisionHasError(resultado)) return;        // hubo error en la division

                    break;
            }

            resultado = Math.Round(resultado, 9);       // dejando solo x decimales
            listaNumeros[0] = resultado;    // resultado de la oper se posiciona 1er termino

            listCalculos.Add(new Calculo(text_operac, resultado));

            if (resultado == 0)
            {
                listaMostrando = "";
            }
            else
            {
                listaMostrando = resultado.ToString();      
            }
            posActual = 0;
            textBox1.Text = listaMostrando;         // se muestra resultado en pantalla
            volverPosCero = false;
            
        }
        
        private void resetTextBox()
        {
            // si luego de ingresar un 'x', '+', '-', '/'
            // se resetee y muestre el num ingresado

            if (listaMostrando != "")       // al limpiar todo con 'CE' o 'C' queda un string vacio
            {
                if (listaNumeros[0] == double.Parse(listaMostrando))
                {
                    listaMostrando = "";        // limpia el string de numeros ingresados
                }
            }
        }

        private bool divisionHasError(double resultado)
        {
            if (double.IsInfinity(resultado))       // si es infinito
            {
                listaMostrando = "";
                textBox1.Text = "No div. por 0.";
                posActual = 0;
                label_calculos.Text = "";
                soloBotonesLimpiar();
                button12.Focus();   // seleccionaba todo el texto del textbox y nqv
                return true;            // SI hubo error
            }
            else if (double.IsNaN(resultado))     // si es NaN
            {
                listaMostrando = "";
                textBox1.Text = "Entrada inválida.";
                textBox1.Text = listaMostrando;
                posActual = 0;
                label_calculos.Text = "";
                soloBotonesLimpiar();
                return true;            // SI hubo error
            }
            return false;       // NO hubo errores
        }

        private void generarStringOperac(char caract, out string variable, string numExtra = null)
        {
            // genera el string de cada opera. ej: '(-85) + 10 ='
            string stringReturn = "";
            double segundoNum = listaNumeros[1];

            // este if es para el boton 1/x el cual esperaba siempre la posicion 2 del array, en este caso queda vacío
            if (numExtra != null) segundoNum = double.Parse(numExtra);

            if (listaNumeros[0] < 0) stringReturn += $"({listaNumeros[0]})";
            else stringReturn += $"{listaNumeros[0]}";

            stringReturn += $" {caract} ";

            if (segundoNum < 0) stringReturn += $"({segundoNum}) =";
            else stringReturn += $"{segundoNum} =";

            variable = stringReturn;
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
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            button25.Enabled = true;
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
            button25.Enabled = false;
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
            button25.Enabled = false;
        }

    }
}
