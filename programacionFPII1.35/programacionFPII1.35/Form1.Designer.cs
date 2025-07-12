namespace programacionFPII1._35
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            treeView1 = new TreeView();
            txtNodo = new TextBox();
            txtElemento = new TextBox();
            btnAdicionaNodo = new Button();
            btnAdicionaElemento = new Button();
            btnLimpiar = new Button();
            btnEliminanodo = new Button();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 12);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(151, 296);
            treeView1.TabIndex = 0;
            // 
            // txtNodo
            // 
            txtNodo.Location = new Point(194, 12);
            txtNodo.Name = "txtNodo";
            txtNodo.Size = new Size(125, 27);
            txtNodo.TabIndex = 1;
            // 
            // txtElemento
            // 
            txtElemento.Location = new Point(194, 45);
            txtElemento.Name = "txtElemento";
            txtElemento.Size = new Size(125, 27);
            txtElemento.TabIndex = 2;
            // 
            // btnAdicionaNodo
            // 
            btnAdicionaNodo.Location = new Point(325, 12);
            btnAdicionaNodo.Name = "btnAdicionaNodo";
            btnAdicionaNodo.Size = new Size(155, 29);
            btnAdicionaNodo.TabIndex = 3;
            btnAdicionaNodo.Text = "Adiciona Nodo";
            btnAdicionaNodo.UseVisualStyleBackColor = true;
            btnAdicionaNodo.Click += btnAdicionaNodo_Click;
            // 
            // btnAdicionaElemento
            // 
            btnAdicionaElemento.Location = new Point(325, 43);
            btnAdicionaElemento.Name = "btnAdicionaElemento";
            btnAdicionaElemento.Size = new Size(155, 29);
            btnAdicionaElemento.TabIndex = 4;
            btnAdicionaElemento.Text = "Adiciona Elemento";
            btnAdicionaElemento.UseVisualStyleBackColor = true;
            btnAdicionaElemento.Click += btnAdicionaElemento_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(325, 78);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(155, 29);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpia Arbol";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminanodo
            // 
            btnEliminanodo.Location = new Point(325, 113);
            btnEliminanodo.Name = "btnEliminanodo";
            btnEliminanodo.Size = new Size(155, 29);
            btnEliminanodo.TabIndex = 6;
            btnEliminanodo.Text = "Elimina nodo";
            btnEliminanodo.UseVisualStyleBackColor = true;
            btnEliminanodo.Click += btnEliminanodo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 387);
            Controls.Add(btnEliminanodo);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAdicionaElemento);
            Controls.Add(btnAdicionaNodo);
            Controls.Add(txtElemento);
            Controls.Add(txtNodo);
            Controls.Add(treeView1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private TextBox txtNodo;
        private TextBox txtElemento;
        private Button btnAdicionaNodo;
        private Button btnAdicionaElemento;
        private Button btnLimpiar;
        private Button btnEliminanodo;
    }
}
