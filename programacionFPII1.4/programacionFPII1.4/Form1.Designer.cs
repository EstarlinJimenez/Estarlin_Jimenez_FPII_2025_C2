namespace programacionFPII1._4
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
            chkMonitor = new CheckBox();
            chkTeclado = new CheckBox();
            chkMouse = new CheckBox();
            lblMensaje = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // chkMonitor
            // 
            chkMonitor.AutoSize = true;
            chkMonitor.Location = new Point(35, 94);
            chkMonitor.Name = "chkMonitor";
            chkMonitor.Size = new Size(120, 24);
            chkMonitor.TabIndex = 0;
            chkMonitor.Text = "Monitor S250";
            chkMonitor.UseVisualStyleBackColor = true;
            chkMonitor.CheckedChanged += chkMonitor_CheckedChanged;
            // 
            // chkTeclado
            // 
            chkTeclado.AutoSize = true;
            chkTeclado.Location = new Point(35, 124);
            chkTeclado.Name = "chkTeclado";
            chkTeclado.Size = new Size(111, 24);
            chkTeclado.TabIndex = 1;
            chkTeclado.Text = "Teclado S15";
            chkTeclado.UseVisualStyleBackColor = true;
            // 
            // chkMouse
            // 
            chkMouse.AutoSize = true;
            chkMouse.Location = new Point(35, 154);
            chkMouse.Name = "chkMouse";
            chkMouse.Size = new Size(102, 24);
            chkMouse.TabIndex = 2;
            chkMouse.Text = "Mause S20";
            chkMouse.UseVisualStyleBackColor = true;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(35, 199);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(50, 20);
            lblMensaje.TabIndex = 3;
            lblMensaje.Text = "label1";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(272, 91);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 397);
            Controls.Add(btnCalcular);
            Controls.Add(lblMensaje);
            Controls.Add(chkMouse);
            Controls.Add(chkTeclado);
            Controls.Add(chkMonitor);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkMonitor;
        private CheckBox chkTeclado;
        private CheckBox chkMouse;
        private Label lblMensaje;
        private Button btnCalcular;
    }
}
