namespace programacionFPII1._2
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblMensaje = new Label();
            btnSaludo = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 41);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(85, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 1;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(29, 86);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(50, 20);
            lblMensaje.TabIndex = 2;
            lblMensaje.Text = "label1";
            // 
            // btnSaludo
            // 
            btnSaludo.Location = new Point(235, 40);
            btnSaludo.Name = "btnSaludo";
            btnSaludo.Size = new Size(94, 29);
            btnSaludo.TabIndex = 3;
            btnSaludo.Text = "Saludo";
            btnSaludo.UseVisualStyleBackColor = true;
            btnSaludo.Click += btnSaludo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 135);
            Controls.Add(btnSaludo);
            Controls.Add(lblMensaje);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblMensaje;
        private Button btnSaludo;
    }
}
