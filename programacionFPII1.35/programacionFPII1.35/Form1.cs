namespace programacionFPII1._35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionaNodo_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add(txtNodo.Text);
            txtNodo.Text = "";
        }

        private void btnAdicionaElemento_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Nodes.Add(txtElemento.Text);
            txtElemento.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }

        private void btnEliminanodo_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Remove(treeView1.SelectedNode);
        }
    }
}
