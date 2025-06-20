namespace programacionFPII1._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            double costo = 0.0;
            string cotizacion = "";

            cotizacion = "Cotizacion de auto para " + txtNombre.Text;
            // Obtener costo inicial
            costo = Convert.ToDouble(txtCosto.Text);

            // Verificar seguros
            if(rbnBasico.Checked==true)
            {
                costo = costo + $500.0;
                cotizacion += "LLeva seguro basico \r\n";
            }
            if(rbnTeceros.Checked==true)
            {
                costo += 700.0;
                cotizacion += "LLeva seguro a terceros de $700 \r\n";
            }
            if(rbnTotal.Checked==true)
            {
                costo += 1000.0;
                cotizacion += "LLeva seguro total de 1000 \r\n";
            }

            // Verificar equipo

            if (chkAire.Checked == true)
            {
                costo += 500.0;
                cotizacion += "Con aire acondicionado de $500 \r\n";
            }
            if(chkAudio.Checked==true)
            {
                costo += 700.0;
                cotizacion += "Con sistema de audio de $700 \r\n";
            }

            // Mostramos total
            cotizacion += "El total a pagar es de " + costo.ToString();


            txtCotizacion.Text = cotizacion;
        }
    }
}
