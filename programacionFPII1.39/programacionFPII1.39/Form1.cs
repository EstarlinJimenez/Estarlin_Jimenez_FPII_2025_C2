namespace programacionFPII1._39
{
    public partial class Form1 : Form
    {
        private string ruta = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ruta = openFileDialog1.FileName;
                lblRuta.Text = ruta;
            }
        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = ruta;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void btnPausa_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }
    }
}
