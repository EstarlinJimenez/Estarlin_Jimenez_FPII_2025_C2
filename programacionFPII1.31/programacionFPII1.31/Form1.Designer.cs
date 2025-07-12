namespace programacionFPII1._31
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
            monthCalendar1 = new MonthCalendar();
            btnFecha = new Button();
            lblInicio = new Label();
            lblFinal = new Label();
            lblSeleccion = new Label();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.FirstDayOfWeek = Day.Sunday;
            monthCalendar1.Location = new Point(18, 18);
            monthCalendar1.MaxSelectionCount = 30;
            monthCalendar1.MonthlyBoldedDates = new DateTime[]
    {
    new DateTime(2025, 10, 25, 0, 0, 0, 0)
    };
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // btnFecha
            // 
            btnFecha.Location = new Point(321, 26);
            btnFecha.Name = "btnFecha";
            btnFecha.Size = new Size(162, 29);
            btnFecha.TabIndex = 4;
            btnFecha.Text = "Seleccionar Fechas";
            btnFecha.UseVisualStyleBackColor = true;
            btnFecha.Click += btnFecha_Click;
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.Location = new Point(29, 265);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(50, 20);
            lblInicio.TabIndex = 5;
            lblInicio.Text = "label1";
            // 
            // lblFinal
            // 
            lblFinal.AutoSize = true;
            lblFinal.Location = new Point(34, 319);
            lblFinal.Name = "lblFinal";
            lblFinal.Size = new Size(50, 20);
            lblFinal.TabIndex = 6;
            lblFinal.Text = "label1";
            // 
            // lblSeleccion
            // 
            lblSeleccion.AutoSize = true;
            lblSeleccion.Location = new Point(39, 371);
            lblSeleccion.Name = "lblSeleccion";
            lblSeleccion.Size = new Size(50, 20);
            lblSeleccion.TabIndex = 7;
            lblSeleccion.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 669);
            Controls.Add(lblSeleccion);
            Controls.Add(lblFinal);
            Controls.Add(lblInicio);
            Controls.Add(btnFecha);
            Controls.Add(monthCalendar1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Button btnFecha;
        private Label lblInicio;
        private Label lblFinal;
        private Label lblSeleccion;
    }
}
