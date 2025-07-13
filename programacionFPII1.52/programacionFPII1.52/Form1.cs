namespace programacionFPII1._52
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Clipboard.ContainsText())
                txtDos.Text = Clipboard.GetText();
            if (Clipboard.ContainsImage())
                pictureBox1.Image = Clipboard.GetImage();
            if (Clipboard.ContainsData(DataFormats.Rtf))
                rtbUno.Rtf = (string)Clipboard.GetData(DataFormats.Rtf);
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtUno.Text);
            //Clipboard.SetImagen(pictureBox1.Image);
            //Clipboard.SetData(DataFormats.Rtf, rbtUno.Rtf);

        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }
    }
}
