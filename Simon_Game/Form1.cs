namespace Simon_Game
{
    public partial class Form1 : Form
    {
        List<int> secuenJuego = new List<int>();        // secuencia del juego a pulsar
        List<int> secuenActual = new List<int>();       // secuencia presionado por el jugador
        Random ran = new Random();

        public static byte nivelActual = 0;

        int indiceActual = 0;

        public Form1()
        {
            InitializeComponent();

            disableAllColorButtons();

            secuenJuego.Add(ran.Next(1, 5));
            secuenJuego.Add(ran.Next(1, 5));
        }

        private void iniciarRonda()
        {
            if ( (nivelActual+1)%3 == 0)
            {
                double aumentoVelocid = timer1.Interval * 0.95;     // aumenta un 5% cada 3 niveles
                timer1.Interval = (int) aumentoVelocid;
            }

            label1.Text = $"Nivel: {++nivelActual}";
            indiceActual = 0;
            secuenActual.Clear();               // limpia los colores presionados antes
            secuenJuego.Add(ran.Next(1, 5));

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
            secuenActual.Add(1);
            button1.BackColor = Color.Blue;
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
                    button5.BackColor = Color.HotPink;
                    return;
                }
            }
                    // SI ERRA EN UN COLOR TERMINA EL JUEGO
            else
            {
                MessageBox.Show("Fin del juego.");
                disableAllColorButtons();
                return;
            }
            indiceActual++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            secuenActual.Add(2);
            button2.BackColor = Color.Red;

            timer2.Tag = button2; // Almacenar una referencia al botón en el Tag del temporizador
            timer2.Start();

            verifBotonPresionado();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            secuenActual.Add(3);
            button3.BackColor = Color.Green;

            timer2.Tag = button3;
            timer2.Start();

            verifBotonPresionado();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            secuenActual.Add(4);
            button4.BackColor = Color.DarkOrchid;

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

            if (secuenJuego[indiceActual] == 1)
            {
                button1.BackColor = Color.Blue;
                timer2.Tag = button1;
                timer2.Start(); 
            }
            if (secuenJuego[indiceActual] == 2)
            {
                button2.BackColor = Color.Red;
                timer2.Tag = button2;
                timer2.Start();
            }
            if (secuenJuego[indiceActual] == 3)
            {
                button3.BackColor = Color.Green;
                timer2.Tag = button3;
                timer2.Start();
            }
            if (secuenJuego[indiceActual] == 4)
            {
                button4.BackColor = Color.DarkOrchid;
                timer2.Tag = button4;
                timer2.Start();
            }

            indiceActual++;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            // timer para resetear color de un boton al hacer clic
            //timer1.Stop();
            timer2.Stop();

            Button button = (Button)timer2.Tag;     // unboxing del boton que hizo clic

            if (button == button1)
            {
                button.BackColor = SystemColors.ActiveCaption;
            }
            if (button == button2)
            {
                button.BackColor = Color.RosyBrown;
            }
            if (button == button3)
            {
                button.BackColor = Color.DarkSeaGreen;
            }
            if (button == button4)
            {
                button.BackColor = Color.Plum;
            }

            //timer1.Start();
        }

        private void resetAllColorButtons()    // activar todos los botones de colores
        {
            button1.BackColor = SystemColors.ActiveCaption;
            button2.BackColor = Color.RosyBrown;
            button3.BackColor = Color.DarkSeaGreen;
            button4.BackColor = Color.Plum;
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
