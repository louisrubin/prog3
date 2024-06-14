namespace Parcial_2
{
    public partial class Form1 : Form
    {
        int cantPalabras;
        int cantCaracConSpac;
        int cantCaracSinSpac;

        string rutaAbrir;

        string textoLeido;

        bool leerArchivo = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            leerArchivo = true;
            folderBrowserDialog1.ShowDialog();
            rutaAbrir = $@"{folderBrowserDialog1.SelectedPath}";
            label_ruta.Text = rutaAbrir;

            FileInfo fi = new FileInfo(rutaAbrir);

            if (fi.Exists)
            {
                textBox1.Text = "Archivo no encontrado.";
                return;
            }

            using (StreamReader reader = new StreamReader(folderBrowserDialog1.SelectedPath + @"\1984orwell.txt"))
            {
                //textoLeido = reader.ReadToEnd();
                textBox1.Text = reader.ReadToEnd();
            }

            lab_palabras.Text = "-";
            lab_caracTotal.Text = "-";
            lab_caracSCEsp.Text = "-";

        }
        private void btn_obtenerEstad_Click(object sender, EventArgs e)
        {
            obtenerEstadisticas();
        }

        private void obtenerEstadisticas()
        {
            textoLeido = textBox1.Text;     // lee desde el text box

            if (textBox1.Text.Length <= 0)
            {
                textBox1.Text = "No se ingreso texto.";
                return;
            }
            else
            {
                cantCaracConSpac = textoLeido.Length;
                cantPalabras = obtCantWord();

                lab_palabras.Text = cantPalabras.ToString();
                lab_caracTotal.Text = cantCaracConSpac.ToString();

                string textoSinEsp = textoLeido.Replace(" ", "");
                int cantCaracSinEsp = textoSinEsp.Length;

                lab_caracSCEsp.Text = cantCaracSinEsp.ToString();
            }
        }

        private int obtCantWord()
        {
            int cantWords = 0;
            for (int i = 0; i < textoLeido.Length; i++)
            {
                if (textoLeido[i] == ' ')
                {
                    cantWords++;
                }
            }
            return cantWords;
        }

    }
}
