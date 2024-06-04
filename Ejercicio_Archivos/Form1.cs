namespace Ejercicio_Archivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBuscarCarpeta_Click(object sender, EventArgs e)
        {
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
            double totalSizeMBs = 0;

            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo[] archEncontrados = directoryInfo.GetFiles("*.*", SearchOption.TopDirectoryOnly);

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
                long fileSize = item.Length ;
                double sizeFile = (double)fileSize / 1024;
                double fileSizeRelative = (double)fileSize / totalSizeBytes * 100;

                info += $"Nombre: {item.Name}, Tamaño: {Math.Round(sizeFile,1)} KB, Tamaño Relativo: {Math.Round(fileSizeRelative, 1)}% {Environment.NewLine}";
            }

            totalSizeMBs = Math.Round((totalSizeBytes / (1024.0 * 1024.0)), 2);
            label_TamTotal2.Text = $"{totalSizeMBs} MB";
            label_TamTotal2.Visible = true;
            label_TamTotal1.Visible = true;
            textBox_InfoCarpeta.Text = info;
            label_cantArchivos1.Visible = true;
            label_cantArchivos2.Visible = true;
            label_cantArchivos2.Text = (archEncontrados.Length -1).ToString();

            return info;
        }
    }
}
