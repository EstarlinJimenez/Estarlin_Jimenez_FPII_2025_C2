namespace programacionFPII1._30
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
            mtxtDato = new MaskedTextBox();
            btnMostrar = new Button();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // mtxtDato
            // 
            mtxtDato.Location = new Point(12, 12);
            mtxtDato.Mask = "00/00/LL";
            mtxtDato.Name = "mtxtDato";
            mtxtDato.Size = new Size(125, 27);
            mtxtDato.TabIndex = 0;
            mtxtDato.ValidatingType = typeof(DateTime);
            mtxtDato.MaskInputRejected += mtxtDato_MaskInputRejected;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(221, 10);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(94, 29);
            btnMostrar.TabIndex = 1;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(22, 79);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(50, 20);
            lblMensaje.TabIndex = 2;
            lblMensaje.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 346);
            Controls.Add(lblMensaje);
            Controls.Add(btnMostrar);
            Controls.Add(mtxtDato);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mtxtDato;
        private Button btnMostrar;
        private Label lblMensaje;
    }
}
