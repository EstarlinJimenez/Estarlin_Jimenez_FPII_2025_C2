namespace programacionFPII1._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            txtA.Text = "0";
            txtB.Text = "0";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);

            double r = a + b;

            lblResultado.Text = r.ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);

            double r = a - b;

            lblResultado.Text = r.ToString();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);

            double r = a * b;

            lblResultado.Text = r.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);

            double r = a / b;

            lblResultado.Text = r.ToString();
        }
    }
}
