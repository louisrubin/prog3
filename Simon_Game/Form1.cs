namespace Simon_Game
{
    public partial class Form1 : Form
    {
        List<byte> secuenJuego = new List<byte>();        // secuencia del juego a pulsar
        List<byte> secuenActual = new List<byte>();       // secuencia presionado por el jugador
        Random ran = new Random();

        public static byte nivelActual = 0;

        byte indiceActual = 0;

        public Form1()
        {
            InitializeComponent();

            disableAllColorButtons();

            secuenJuego.Add( (byte)ran.Next(1, 5));
            secuenJuego.Add( (byte)ran.Next(1, 5));
        }

        private void iniciarRonda()
        {
            indiceActual = 0;
            label1.Text = $"Nivel: {++nivelActual}";
            secuenActual.Clear();               // limpia los colores presionados antes
            secuenJuego.Add((byte)ran.Next(1, 5));

            if ( (nivelActual+1)%3 == 0)
            {
                double aumentoVelocid = timer1.Interval * 0.95;     // aumenta un 5% cada 3 niveles
                timer1.Interval = (int) aumentoVelocid;
            }

            // BOTON 5: cambia color y lo desactiva
            button5.Enabled = false;
            button5.BackColor = Color.Thistle;

            timer1.Start();     // TIMER IMPRIMIR SECUENCIA
        }
        private void button5_Click(object sender, EventArgs e)
        {
            // BOTON INICIAR JUEGO
            iniciarRonda();

            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            secuenActual.Add(button1.CodigoColor);      // codigo del boton
            button1.prenderBoton();
            timer2.Tag = button1;

            timer2.Start();

            verifBotonPresionado();
        }

        private void verifBotonPresionado()
        {
            if (secuenActual[indiceActual] == secuenJuego[indiceActual])
            {
                if (secuenActual.Count >= secuenJuego.Count)
                {
                    button5.Enabled = true;
                    disableAllColorButtons();
                    button5.Text = "Continuar";
                    button5.BackColor = Color.HotPink;      // boton 5 no es de clase 'Boton'
                    return;
                }
            }
                    // SI ERRA EN UN COLOR TERMINA EL JUEGO
            else
            {
                button5.Text = "FIN";
                MessageBox.Show("Fin del juego.");
                disableAllColorButtons();
                return;
            }
            indiceActual++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            secuenActual.Add(button2.CodigoColor);
            button2.prenderBoton();

            timer2.Tag = button2; // Almacenar una referencia al botón en el Tag del temporizador
            timer2.Start();

            verifBotonPresionado();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            secuenActual.Add(button3.CodigoColor);
            button3.prenderBoton();

            timer2.Tag = button3;
            timer2.Start();

            verifBotonPresionado();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            secuenActual.Add(button4.CodigoColor);
            button4.prenderBoton();

            timer2.Tag = button4;
            timer2.Start();

            verifBotonPresionado();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // TIMER PARA MOSTRAR SECUENCUA DE COLORES A PRESIONAR
            if (indiceActual >= secuenJuego.Count)
            {
                // Detener el Timer
                resetAllColorButtons();     // resetea los colores de los botones
                enableAllColorButtons();    // activa los botones
                timer1.Stop();
                indiceActual = 0;   // al terminar el timer reinicia el indice
                return;
            }

            // verifica el codigo insertado en la lista para enviar el boton que corresponde
            if (secuenJuego[indiceActual] == 1)
            {
                button1.prenderBoton();
                timer2.Tag = button1;
                timer2.Start(); 
            }
            if (secuenJuego[indiceActual] == 2)
            {
                button2.prenderBoton();
                timer2.Tag = button2;
                timer2.Start();
            }
            if (secuenJuego[indiceActual] == 3)
            {
                button3.prenderBoton();
                timer2.Tag = button3;
                timer2.Start();
            }
            if (secuenJuego[indiceActual] == 4)
            {
                button4.prenderBoton();
                timer2.Tag = button4;
                timer2.Start();
            }

            indiceActual++;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            // timer para resetear color de un boton al hacer clic
            timer2.Stop();

            Boton button = (Boton)timer2.Tag;     // unboxing del boton que hizo clic
            button.apagarBoton();       // apaga cada boton

        }

        private void resetAllColorButtons()    // activar todos los botones de colores
        {
            button1.apagarBoton();
            button2.apagarBoton();
            button3.apagarBoton();
            button4.apagarBoton();
        }
        private void disableAllColorButtons()   // metodo para desactivar todos los botones de colores
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void enableAllColorButtons()    // activar todos los botones de colores
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }

    }
}
