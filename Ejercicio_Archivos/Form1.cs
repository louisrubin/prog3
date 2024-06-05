using System.Text.Json;
using System.Text.Json.Serialization;

namespace Ejercicio_Archivos
{
    public partial class Form1 : Form
    {
        List<Musica> listaMusica = new List<Musica>();
        string aSerializar;

        private string path_txt = @$"C:\Users\{Environment.UserName}\Desktop\reporte_Txt.txt";
        int cantArchivos = 0;
        double totalSizeMBs = 0;
        string nombre_carpeta;

        public Form1()
        {
            InitializeComponent();
            listaMusica.Add(new Musica()
            {
                Nombre = "Look On",
                Artista = "John Frusciante",
                Album = "Inside Of Emptiness"
            });
            listaMusica.Add(new Musica("I Miss You", "blink-182", "Blink-182"));
            listaMusica.Add(new Musica("Stairway to Heaven", "Led Zeppelin", "Led Zeppelin IV"));
        }

        private void buttonBuscarCarpeta_Click(object sender, EventArgs e)
        {
            label_creado.Visible = false;

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            string path = folderBrowserDialog.SelectedPath;

            textBoxRuta.Text = path;
            if (path != "")
            {
                textBox_InfoCarpeta.Text = GetFiles(path);
                return;
            }

            textBox_InfoCarpeta.Text = "Ruta no válida.";
        }

        public string GetFiles(string path)
        {
            string info = "";
            long totalSizeBytes = 0;
            cantArchivos = 0;

            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo[] archEncontrados = directoryInfo.GetFiles("*.*", SearchOption.TopDirectoryOnly);
            nombre_carpeta = directoryInfo.FullName;

            if (archEncontrados.Length <= 1)
            {
                textBox_InfoCarpeta.Text = "Directorio vacío.";
                return "";
            }

            foreach (FileInfo file in archEncontrados)
            {
                totalSizeBytes += file.Length;
            }

            foreach (var item in archEncontrados)
            {
                if (item.Extension.Equals(".ini"))
                {
                    continue;
                }
                cantArchivos++;
                long fileSize = item.Length;
                double sizeFile = (double)fileSize / 1024;
                double fileSizeRelative = (double)fileSize / totalSizeBytes * 100;

                info += $"Nombre: {item.Name}, Tamaño: {Math.Round(sizeFile, 1)} KB, Tamaño Relativo: {Math.Round(fileSizeRelative, 1)}% {Environment.NewLine}";
            }

            totalSizeMBs = Math.Round((totalSizeBytes / (1024.0 * 1024.0)), 2);
            label_TamTotal2.Text = $"{totalSizeMBs} MB";
            label_TamTotal2.Visible = true;
            label_TamTotal1.Visible = true;
            textBox_InfoCarpeta.Text = info;
            label_cantArchivos1.Visible = true;
            label_cantArchivos2.Visible = true;
            label_cantArchivos2.Text = cantArchivos.ToString();

            button_generarTxt.Enabled = true;
            button_generarTxt.BackColor = SystemColors.MenuHighlight;

            return info;
        }

        private void button_generarTxt_Click(object sender, EventArgs e)
        {
            // abro o creo el archivo 
            if (!File.Exists(path_txt))   // si el archivo no existia dice que se creó
            {                               // si ya existia no hace nada
                label_creado.Visible = true;
            }

            FileInfo fileActual = new FileInfo(path_txt);
            FileStream fileStream = fileActual.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite);


            using (StreamWriter escritor = new StreamWriter(fileStream))
            {
                escritor.WriteLine("Carpeta: " + nombre_carpeta + escritor.NewLine);
                escritor.Write(textBox_InfoCarpeta.Text);
                escritor.Write('\n');
                escritor.WriteLine($"Total archivos: {cantArchivos}");
                escritor.WriteLine($"Tamaño total: {totalSizeMBs} MB {escritor.NewLine}");
            }

            fileStream.Close();
        }

        private void button_leer_Click(object sender, EventArgs e)
        {
            label_creado.Visible = false;
            textBox_InfoCarpeta.Text = "";      // limpia el text box

            FileInfo fileActual = new FileInfo(path_txt);   // abro el archivo

            if (!fileActual.Exists)       // si el archivo no existe
            {
                textBox_InfoCarpeta.Text = "El archivo no existe.";
                return;
            }

            FileStream fileStream = fileActual.Open(FileMode.Open, FileAccess.Read);
            string lectura;     // aca se guarda la linea leída del txt

            using (StreamReader lector = new StreamReader(fileStream))
            {
                while ((lectura = lector.ReadLine()) != null)
                {
                    textBox_InfoCarpeta.Text += lectura;            // vuelvo la lectura en el text box
                    textBox_InfoCarpeta.Text += Environment.NewLine;
                }
            }

            fileStream.Close();
        }

        private void button_serializar_Click(object sender, EventArgs e)
        {
            if (listaMusica.Count == 0)
            {
                textBox_InfoCarpeta.Text = "Lista de música limpia.";
                return;
            }

            var opciones = new JsonSerializerOptions { WriteIndented = true };

            aSerializar = JsonSerializer.Serialize(listaMusica, opciones);
            textBox_InfoCarpeta.Text = aSerializar;
            button_generarTxt.Enabled = true;
            listaMusica.Clear();

            label_cantArchivos1.Visible = false;
            label_cantArchivos2.Visible = false;

            label_TamTotal1.Visible = false;
            label_TamTotal2.Visible = false;
        }

        private void button_deserializar_Click(object sender, EventArgs e)
        {
            textBox_InfoCarpeta.Text = "";
            if (aSerializar == null)
            {
                textBox_InfoCarpeta.Text = "Primero hay que Serializar.";
                return;
            }

            listaMusica = JsonSerializer.Deserialize<List<Musica>>(aSerializar);

            foreach (var item in listaMusica)
            {
                textBox_InfoCarpeta.Text += item.ToString() + Environment.NewLine;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxRuta.Text = "";
            textBox_InfoCarpeta.Text = "";

            label_cantArchivos1.Visible = false;
            label_cantArchivos2.Visible = false;

            label_TamTotal1.Visible = false;
            label_TamTotal2.Visible = false;

            label_creado.Visible = false;

            button_generarTxt.Enabled = false;
            button_generarTxt.BackColor = SystemColors.ControlDark;
        }
    }
}
