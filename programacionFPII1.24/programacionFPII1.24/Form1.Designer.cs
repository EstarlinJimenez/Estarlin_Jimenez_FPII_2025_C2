namespace programacionFPII1._24
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
            dateTimePicker1 = new DateTimePicker();
            lblFecha = new Label();
            btnCalcular = new Button();
            txtDias = new TextBox();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Location = new Point(51, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(132, 63);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(50, 20);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "label1";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(207, 112);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtDias
            // 
            txtDias.Location = new Point(51, 113);
            txtDias.Name = "txtDias";
            txtDias.Size = new Size(125, 27);
            txtDias.TabIndex = 3;
            txtDias.Text = "0";
            txtDias.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 416);
            Controls.Add(txtDias);
            Controls.Add(btnCalcular);
            Controls.Add(lblFecha);
            Controls.Add(dateTimePicker1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label lblFecha;
        private Button btnCalcular;
        private TextBox txtDias;
    }
}
