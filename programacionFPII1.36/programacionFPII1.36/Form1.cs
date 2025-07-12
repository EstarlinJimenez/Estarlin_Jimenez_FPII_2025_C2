using System.Windows.Forms;

namespace programacionFPII1._36
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrirNotepad_Click(object sender, EventArgs e)
        {
            // Nos permitimos recibir eventos del notepad
            prcNotepad.EnableRaisingEvents = true;

            // Arrancamos el proceso
            prcNotepad.Start();

            lblEstado.Text = "Notepad Arrancado";
        }

        private void btnCerrarNotepad_Click(object sender, EventArgs e)
        {
            prcNotepad.Kill();


        }

        private void prcNotepad_Existed(object sender, EventArgs e)
        {
            // Este evento sucede cuando se cierra el proceso
            lblEstado.Text = "Notepad Cerrado";

            notifyIcon1.ShowBalloonTip(100, "Alerta", "Notepad Cerrado", ToolTipIcon.Info);

        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mostramos la forma
            this.Show();
        }

        private void esconderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Escondemos la forma
            this.Hide();
        }
    }
}
