using System.CodeDom.Compiler;

namespace programacionFPII1._49
{
    public partial class Form1 : Form
    {
        private int y = 50;
        private int conteo = 0;
        private EventHandler handlerComun_Click;
        private object Contols;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Creamos la instancia del boton
            Button temp = new Button();

            // Colocamos las propiedades
            temp.Height = 23;
            temp.Width = 200;
            temp.Location = new Point(50, y);
            y += 25;
            temp.Name = "btnBotton" + conteo.ToString();
            temp.Text = "Boton #" + conteo.ToString();
            conteo++;

            // Adicionamos el handler
            temp.Click += new EventHandler(HandlerComun_Click);

            // Adicionamos el boton a la forma
            Controls.Add(temp);


        }
        private void HandlerComun_Click(object sender, EventArgs e)
        {
            Console.Beep(((Button)sender).Location.Y * 10, 100);
        }
    }
}
