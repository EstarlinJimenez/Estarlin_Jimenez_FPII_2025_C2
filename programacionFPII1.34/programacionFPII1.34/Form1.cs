namespace programacionFPII1._34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIr2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void btnIr1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btnRegresa1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }
    }
}
