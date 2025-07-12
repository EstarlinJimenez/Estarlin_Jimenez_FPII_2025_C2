namespace programacionFPII1._32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Aqui va el codigo para abrir y leer el archivo

                lblAbrir.Text = openFileDialog1.FileName;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                // Aqui va el codigo para salvar

                lblSalvar.Text = saveFileDialog1.FileName;
                  
            }
        }
    }
}
