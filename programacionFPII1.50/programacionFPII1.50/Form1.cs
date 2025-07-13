namespace programacionFPII1._50
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_DragDroF(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            txtContenidos.Text = "";
            // Obtenemos el arreglo con los archivos
            string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            string linea = "";

            lblArchivo.Text = archivos[0];

            // Leemos el archivo
            StreamReader lector = File.OpenText(archivos[0]);

            while((linea=lector.ReadLine()) !=null)
            {
                txtContenidos.Text += linea + "\r\n";
            }

            lector.Close();
        }
    }
}
