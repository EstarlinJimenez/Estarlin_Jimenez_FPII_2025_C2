namespace claseFPII
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
            btnSaludo = new Button();
            label1 = new Label();
            btmDespedida = new Button();
            SuspendLayout();
            // 
            // btnSaludo
            // 
            btnSaludo.Location = new Point(234, 43);
            btnSaludo.Name = "btnSaludo";
            btnSaludo.Size = new Size(94, 29);
            btnSaludo.TabIndex = 0;
            btnSaludo.Text = "Saludo!";
            btnSaludo.UseVisualStyleBackColor = true;
            btnSaludo.Click += btnSaludo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 47);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 1;
            label1.Text = " label1";
            // 
            // btmDespedida
            // 
            btmDespedida.Location = new Point(234, 98);
            btmDespedida.Name = "btmDespedida";
            btmDespedida.Size = new Size(94, 29);
            btmDespedida.TabIndex = 2;
            btmDespedida.Text = "Despedida";
            btmDespedida.UseVisualStyleBackColor = true;
            btmDespedida.Click += btmDespedida_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 342);
            Controls.Add(btmDespedida);
            Controls.Add(label1);
            Controls.Add(btnSaludo);
            Name = "Form1";
            Text = "Programa 01";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaludo;
        private Label label1;
        private Button btmDespedida;
    }
}
