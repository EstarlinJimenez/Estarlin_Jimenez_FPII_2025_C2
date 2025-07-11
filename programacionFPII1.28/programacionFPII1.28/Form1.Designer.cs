namespace programacionFPII1._28
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
            lblMensaje = new Label();
            btnFunte = new Button();
            fontDialog1 = new FontDialog();
            SuspendLayout();
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(47, 61);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(95, 20);
            lblMensaje.TabIndex = 0;
            lblMensaje.Text = "Hola a todos";
            // 
            // btnFunte
            // 
            btnFunte.Location = new Point(225, 52);
            btnFunte.Name = "btnFunte";
            btnFunte.Size = new Size(94, 29);
            btnFunte.TabIndex = 1;
            btnFunte.Text = "Fuente";
            btnFunte.UseVisualStyleBackColor = true;
            btnFunte.Click += btnFunte_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 395);
            Controls.Add(btnFunte);
            Controls.Add(lblMensaje);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensaje;
        private Button btnFunte;
        private FontDialog fontDialog1;
    }
}
