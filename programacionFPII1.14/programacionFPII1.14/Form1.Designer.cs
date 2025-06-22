namespace programacionFPII1._14
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
            chlbAlimentos = new CheckedListBox();
            txtNuevoAlimento = new TextBox();
            btnAdicionar = new Button();
            lblNombre = new Label();
            SuspendLayout();
            // 
            // chlbAlimentos
            // 
            chlbAlimentos.CheckOnClick = true;
            chlbAlimentos.FormattingEnabled = true;
            chlbAlimentos.Items.AddRange(new object[] { "Frijol", "Tomate" });
            chlbAlimentos.Location = new Point(12, 12);
            chlbAlimentos.Name = "chlbAlimentos";
            chlbAlimentos.Size = new Size(420, 136);
            chlbAlimentos.TabIndex = 0;
            chlbAlimentos.SelectedIndexChanged += chlbAlimentos_SelectedIndexChanged;
            // 
            // txtNuevoAlimento
            // 
            txtNuevoAlimento.Location = new Point(27, 229);
            txtNuevoAlimento.Name = "txtNuevoAlimento";
            txtNuevoAlimento.Size = new Size(125, 27);
            txtNuevoAlimento.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(192, 229);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(94, 29);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(27, 193);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(50, 20);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 387);
            Controls.Add(lblNombre);
            Controls.Add(btnAdicionar);
            Controls.Add(txtNuevoAlimento);
            Controls.Add(chlbAlimentos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox chlbAlimentos;
        private TextBox txtNuevoAlimento;
        private Button btnAdicionar;
        private Label lblNombre;
    }
}
