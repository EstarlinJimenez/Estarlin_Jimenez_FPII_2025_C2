namespace programacionFPII1._36
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
            components = new System.ComponentModel.Container();
            lblEstado = new Label();
            btnAbrirNotepad = new Button();
            btnCerrarNotepad = new Button();
            prcNotepad = new System.Diagnostics.Process();
            contextMenuStrip1 = new ContextMenuStrip(components);
            mostrarToolStripMenuItem = new ToolStripMenuItem();
            esconderToolStripMenuItem = new ToolStripMenuItem();
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(68, 113);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(79, 20);
            lblEstado.TabIndex = 0;
            lblEstado.Text = "Esperando";
            // 
            // btnAbrirNotepad
            // 
            btnAbrirNotepad.Location = new Point(203, 91);
            btnAbrirNotepad.Name = "btnAbrirNotepad";
            btnAbrirNotepad.Size = new Size(126, 29);
            btnAbrirNotepad.TabIndex = 1;
            btnAbrirNotepad.Text = "Abrir Notepad";
            btnAbrirNotepad.UseVisualStyleBackColor = true;
            btnAbrirNotepad.Click += btnAbrirNotepad_Click;
            // 
            // btnCerrarNotepad
            // 
            btnCerrarNotepad.Location = new Point(203, 126);
            btnCerrarNotepad.Name = "btnCerrarNotepad";
            btnCerrarNotepad.Size = new Size(126, 29);
            btnCerrarNotepad.TabIndex = 2;
            btnCerrarNotepad.Text = "Cerrar Notepad";
            btnCerrarNotepad.UseVisualStyleBackColor = true;
            btnCerrarNotepad.Click += btnCerrarNotepad_Click;
            // 
            // prcNotepad
            // 
            prcNotepad.StartInfo.Domain = "";
            prcNotepad.StartInfo.FileName = "notepad.exe";
            prcNotepad.StartInfo.LoadUserProfile = false;
            prcNotepad.StartInfo.Password = null;
            prcNotepad.StartInfo.StandardErrorEncoding = null;
            prcNotepad.StartInfo.StandardInputEncoding = null;
            prcNotepad.StartInfo.StandardOutputEncoding = null;
            prcNotepad.StartInfo.UseCredentialsForNetworkingOnly = false;
            prcNotepad.StartInfo.UserName = "";
            prcNotepad.StartInfo.WorkingDirectory = "C:\\Users\\estar\\OneDrive\\Documentos";
            prcNotepad.SynchronizingObject = this;
            prcNotepad.Exited += prcNotepad_Existed;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { mostrarToolStripMenuItem, esconderToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(139, 52);
            // 
            // mostrarToolStripMenuItem
            // 
            mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            mostrarToolStripMenuItem.Size = new Size(138, 24);
            mostrarToolStripMenuItem.Text = "Mostrar";
            mostrarToolStripMenuItem.Click += mostrarToolStripMenuItem_Click;
            // 
            // esconderToolStripMenuItem
            // 
            esconderToolStripMenuItem.Name = "esconderToolStripMenuItem";
            esconderToolStripMenuItem.Size = new Size(138, 24);
            esconderToolStripMenuItem.Text = "Esconder";
            esconderToolStripMenuItem.Click += esconderToolStripMenuItem_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Text = "Abre Aplicaciones";
            notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 410);
            Controls.Add(btnCerrarNotepad);
            Controls.Add(btnAbrirNotepad);
            Controls.Add(lblEstado);
            Name = "Form1";
            Text = "Form1";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEstado;
        private Button btnAbrirNotepad;
        private Button btnCerrarNotepad;
        private System.Diagnostics.Process prcNotepad;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem mostrarToolStripMenuItem;
        private ToolStripMenuItem esconderToolStripMenuItem;
        private NotifyIcon notifyIcon1;
    }
}
