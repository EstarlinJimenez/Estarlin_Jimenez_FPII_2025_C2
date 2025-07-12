namespace programacionFPII1._34
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
            label1 = new Label();
            btnIr1 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            btnRegresa1 = new Button();
            label3 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            btnHome = new Button();
            btnIr2 = new Button();
            label2 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 51);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 0;
            label1.Text = "Hola estas en casa";
            // 
            // btnIr1
            // 
            btnIr1.Location = new Point(313, 367);
            btnIr1.Name = "btnIr1";
            btnIr1.Size = new Size(94, 29);
            btnIr1.TabIndex = 1;
            btnIr1.Text = "Ir a 1";
            btnIr1.UseVisualStyleBackColor = true;
            btnIr1.Click += btnIr1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(btnIr2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(419, 409);
            panel1.TabIndex = 2;
            panel1.Visible = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnRegresa1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(radioButton1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(419, 409);
            panel2.TabIndex = 4;
            panel2.Visible = false;
            // 
            // btnRegresa1
            // 
            btnRegresa1.Location = new Point(12, 368);
            btnRegresa1.Name = "btnRegresa1";
            btnRegresa1.Size = new Size(94, 29);
            btnRegresa1.TabIndex = 3;
            btnRegresa1.Text = "Regresa 1";
            btnRegresa1.UseVisualStyleBackColor = true;
            btnRegresa1.Click += btnRegresa1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(193, 122);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 2;
            label3.Text = "Panel 2";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(46, 90);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(117, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(43, 45);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(12, 368);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(94, 29);
            btnHome.TabIndex = 3;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnIr2
            // 
            btnIr2.Location = new Point(313, 368);
            btnIr2.Name = "btnIr2";
            btnIr2.Size = new Size(94, 29);
            btnIr2.TabIndex = 2;
            btnIr2.Text = "Ir a 2";
            btnIr2.UseVisualStyleBackColor = true;
            btnIr2.Click += btnIr2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 56);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Panel 1";
            // 
            // button1
            // 
            button1.Location = new Point(46, 51);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 409);
            Controls.Add(panel1);
            Controls.Add(btnIr1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnIr1;
        private Panel panel1;
        private Button btnHome;
        private Button btnIr2;
        private Label label2;
        private Button button1;
        private Panel panel2;
        private Label label3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button btnRegresa1;
    }
}
