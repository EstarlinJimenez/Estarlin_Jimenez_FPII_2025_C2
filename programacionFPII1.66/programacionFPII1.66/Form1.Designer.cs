namespace programacionFPII1._66
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
            btnMostrar = new Button();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(248, 52);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(94, 29);
            btnMostrar.TabIndex = 0;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(36, 61);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(50, 20);
            lblMensaje.TabIndex = 1;
            lblMensaje.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 351);
            Controls.Add(lblMensaje);
            Controls.Add(btnMostrar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMostrar;
        private Label lblMensaje;
    }
}
