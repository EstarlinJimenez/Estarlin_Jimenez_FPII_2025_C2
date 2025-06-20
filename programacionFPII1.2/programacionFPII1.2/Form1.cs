namespace programacionFPII1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMensaje.text = "";
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = txtNombre.Text + " es el nombre, Hola!!!!";
        }
    }
}
