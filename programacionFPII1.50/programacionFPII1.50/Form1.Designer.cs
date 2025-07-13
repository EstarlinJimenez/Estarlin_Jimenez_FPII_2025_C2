namespace programacionFPII1._50
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
            lblArchivo = new Label();
            txtContenidos = new TextBox();
            SuspendLayout();
            // 
            // lblArchivo
            // 
            lblArchivo.AutoSize = true;
            lblArchivo.Location = new Point(12, 9);
            lblArchivo.Name = "lblArchivo";
            lblArchivo.Size = new Size(50, 20);
            lblArchivo.TabIndex = 0;
            lblArchivo.Text = "label1";
            // 
            // txtContenidos
            // 
            txtContenidos.AllowDrop = true;
            txtContenidos.Location = new Point(12, 32);
            txtContenidos.Multiline = true;
            txtContenidos.Name = "txtContenidos";
            txtContenidos.ScrollBars = ScrollBars.Both;
            txtContenidos.Size = new Size(386, 341);
            txtContenidos.TabIndex = 1;
            txtContenidos.DragDrop += textBox1_DragDroF;
            txtContenidos.DragEnter += txtContenidos_DragEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 385);
            Controls.Add(txtContenidos);
            Controls.Add(lblArchivo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblArchivo;
        private TextBox txtContenidos;
    }
}
