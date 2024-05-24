namespace Simon_Game
{
    public partial class Form1 : Form
    {
        List<int> secuencia = new List<int>();

        int indice = 0;

        public Form1()
        {
            InitializeComponent();

            disableAllColorButtons();

            Random ran = new Random();

            secuencia.Add(ran.Next(1, 5));
            secuencia.Add(ran.Next(1, 5));
            secuencia.Add(ran.Next(1, 5));

            //iniciarJuego();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Blue;
            timer2.Tag = button1;
            timer2.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;

            timer2.Tag = button2; // Almacenar una referencia al botón en el Tag del temporizador
            timer2.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Green;

            timer2.Tag = button3;
            timer2.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.DarkOrchid;

            timer2.Tag = button4;
            timer2.Start();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button5.Enabled = false;
            button5.BackColor = Color.Thistle;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // TIMER PARA MOSTRAR SECUENCUA DE COLORES A PRESIONAR
            if (indice >= secuencia.Count)
            {
                // Detener el Timer
                resetAllColorButtons();     // resetea los colores de los botones
                enableAllColorButtons();    // activa los botones
                timer1.Stop();
                return;
            }

            if (secuencia[indice] == 1)
            {
                button1.BackColor = Color.Blue;
                timer2.Tag = button1;
                timer2.Start(); 
            }
            if (secuencia[indice] == 2)
            {
                button2.BackColor = Color.Red;
                timer2.Tag = button2;
                timer2.Start();
            }
            if (secuencia[indice] == 3)
            {
                button3.BackColor = Color.Green;
                timer2.Tag = button3;
                timer2.Start();
            }
            if (secuencia[indice] == 4)
            {
                button4.BackColor = Color.DarkOrchid;
                timer2.Tag = button4;
                timer2.Start();
            }

            indice++;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            // timer para resetear color de un boton al hacer clic

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

            timer1.Start();
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
