namespace programacionFPII1._39
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            btnCargar = new Button();
            btnReproducir = new Button();
            btnParar = new Button();
            btnPausa = new Button();
            lblRuta = new Label();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(21, 18);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(660, 413);
            axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(32, 437);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(94, 29);
            btnCargar.TabIndex = 1;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnReproducir
            // 
            btnReproducir.Location = new Point(132, 437);
            btnReproducir.Name = "btnReproducir";
            btnReproducir.Size = new Size(94, 29);
            btnReproducir.TabIndex = 2;
            btnReproducir.Text = "Reproducir";
            btnReproducir.UseVisualStyleBackColor = true;
            btnReproducir.Click += btnReproducir_Click;
            // 
            // btnParar
            // 
            btnParar.Location = new Point(232, 437);
            btnParar.Name = "btnParar";
            btnParar.Size = new Size(94, 29);
            btnParar.TabIndex = 3;
            btnParar.Text = "Parar";
            btnParar.UseVisualStyleBackColor = true;
            btnParar.Click += btnParar_Click;
            // 
            // btnPausa
            // 
            btnPausa.Location = new Point(332, 437);
            btnPausa.Name = "btnPausa";
            btnPausa.Size = new Size(94, 29);
            btnPausa.TabIndex = 4;
            btnPausa.Text = "Pausa";
            btnPausa.UseVisualStyleBackColor = true;
            btnPausa.Click += btnPausa_Click;
            // 
            // lblRuta
            // 
            lblRuta.AutoSize = true;
            lblRuta.Location = new Point(30, 472);
            lblRuta.Name = "lblRuta";
            lblRuta.Size = new Size(50, 20);
            lblRuta.TabIndex = 5;
            lblRuta.Text = "label1";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Todos |*.*";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 540);
            Controls.Add(lblRuta);
            Controls.Add(btnPausa);
            Controls.Add(btnParar);
            Controls.Add(btnReproducir);
            Controls.Add(btnCargar);
            Controls.Add(axWindowsMediaPlayer1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Button btnCargar;
        private Button btnReproducir;
        private Button btnParar;
        private Button btnPausa;
        private Label lblRuta;
        private OpenFileDialog openFileDialog1;
    }
}
