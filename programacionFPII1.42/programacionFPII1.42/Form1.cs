namespace programacionFPII1._42
{
    public partial class Form1 : Form
    {
        private int x = 0;
        private int y = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDibuja_Click(object sender, EventArgs e)
        {
            // Obtenemos el objeto graphics por medio del handle de la ventana
            Graphics g = Graphics.FromHwnd(this.Handle);

            // Creamos una fuente 
            Font fuente = new Font("Times New Roman", 35);

            // Dibujamos un texto
            g.DrawString("En metodo", fuente, Brushes.Green, 50, 75);

            // tenemos que liberar los recurso no administrado
            // Si lo creamos directamente hacemos dispose
            // Si es una referencia a un objeto graphics ya existente  
            // mo hace falta dispose

            g.Dispose();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Obtenemos el objeto graphics
            Graphics g = e.Graphics;

            // Creamos una fuente
            Font fuente = new Font("Times New Roman", 35);

            // Dibujamos un texto
            g.DrawString("Hola a todos", fuente, Brushes.Red, x, y);
        }

        private void btnInvalidate_Click(object sender, EventArgs e)
        {
            x += 5;
            y += 17;

            Invalidate();
            //Invalidate((new Rectangle(0, 0, 100, 120));
        }
    }
}
