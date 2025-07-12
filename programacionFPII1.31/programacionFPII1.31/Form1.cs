namespace programacionFPII1._31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            monthCalendar1.BoldedDates = new DateTime[]
            {
                new DateTime(2025,10,25),
                new DateTime(2025,9,13),
                DateTime.Today.AddDays(13)
            };
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            DateTime inicio = monthCalendar1.SelectionStart;
            DateTime final = monthCalendar1.SelectionStart;

            lblInicio.Text = inicio.ToString();
            lblFinal.Text = final.ToString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblSeleccion.Text = monthCalendar1.SelectionStart.ToString();
        }
    }
}
