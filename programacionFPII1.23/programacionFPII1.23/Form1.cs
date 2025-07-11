namespace programacionFPII1._23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Today;
            string formato = "MMM ddd yy d, hh-> mm ";

            lblFecha.Text = fecha.ToString(formato);
        }
    }
}
