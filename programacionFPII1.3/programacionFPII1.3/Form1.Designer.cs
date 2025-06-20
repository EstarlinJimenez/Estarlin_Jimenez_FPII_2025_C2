namespace programacionFPII1._3
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
            lblA = new Label();
            txtA = new TextBox();
            lblB = new Label();
            txtB = new TextBox();
            lblResultado = new Label();
            btnSuma = new Button();
            btnResta = new Button();
            btnDiv = new Button();
            btnMulti = new Button();
            SuspendLayout();
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(12, 19);
            lblA.Name = "lblA";
            lblA.Size = new Size(22, 20);
            lblA.TabIndex = 0;
            lblA.Text = "A:";
            // 
            // txtA
            // 
            txtA.Location = new Point(40, 12);
            txtA.Name = "txtA";
            txtA.Size = new Size(125, 27);
            txtA.TabIndex = 1;
            txtA.TextAlign = HorizontalAlignment.Right;
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(12, 62);
            lblB.Name = "lblB";
            lblB.Size = new Size(21, 20);
            lblB.TabIndex = 2;
            lblB.Text = "B:";
            // 
            // txtB
            // 
            txtB.Location = new Point(39, 55);
            txtB.Name = "txtB";
            txtB.Size = new Size(125, 27);
            txtB.TabIndex = 3;
            txtB.TextAlign = HorizontalAlignment.Right;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(115, 96);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(50, 20);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "label1";
            // 
            // btnSuma
            // 
            btnSuma.Location = new Point(194, 10);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(35, 29);
            btnSuma.TabIndex = 5;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // btnResta
            // 
            btnResta.Location = new Point(235, 10);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(35, 29);
            btnResta.TabIndex = 6;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btnResta_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(235, 55);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(35, 29);
            btnDiv.TabIndex = 8;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnMulti
            // 
            btnMulti.Location = new Point(194, 55);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(35, 29);
            btnMulti.TabIndex = 7;
            btnMulti.Text = "*";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 139);
            Controls.Add(btnDiv);
            Controls.Add(btnMulti);
            Controls.Add(btnResta);
            Controls.Add(btnSuma);
            Controls.Add(lblResultado);
            Controls.Add(txtB);
            Controls.Add(lblB);
            Controls.Add(txtA);
            Controls.Add(lblA);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblA;
        private TextBox txtA;
        private Label lblB;
        private TextBox txtB;
        private Label lblResultado;
        private Button btnSuma;
        private Button btnResta;
        private Button btnDiv;
        private Button btnMulti;
    }
}
