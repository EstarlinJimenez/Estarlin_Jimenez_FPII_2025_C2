namespace programacionFPII1._11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            txtA = new TextBox();
            cmnuTxtA = new ContextMenuStrip(components);
            borrarToolStripMenuItem = new ToolStripMenuItem();
            aleatorioToolStripMenuItem = new ToolStripMenuItem();
            txtB = new TextBox();
            lblResultado = new Label();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            operacionesToolStripMenuItem = new ToolStripMenuItem();
            sumaToolStripMenuItem = new ToolStripMenuItem();
            restaToolStripMenuItem = new ToolStripMenuItem();
            multiToolStripMenuItem = new ToolStripMenuItem();
            divToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            habilitarToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            tstOperaciones = new ToolStrip();
            tstbSuma = new ToolStripButton();
            tstbResta = new ToolStripButton();
            tstbMulti = new ToolStripButton();
            tstbDiv = new ToolStripButton();
            stsInformacion = new StatusStrip();
            slblValores = new ToolStripStatusLabel();
            slblOperacion = new ToolStripStatusLabel();
            slblResultado = new ToolStripStatusLabel();
            cmnuTxtA.SuspendLayout();
            menuStrip2.SuspendLayout();
            tstOperaciones.SuspendLayout();
            stsInformacion.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 28);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(397, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // txtA
            // 
            txtA.ContextMenuStrip = cmnuTxtA;
            txtA.Location = new Point(30, 85);
            txtA.Name = "txtA";
            txtA.Size = new Size(125, 27);
            txtA.TabIndex = 2;
            txtA.TextAlign = HorizontalAlignment.Right;
            // 
            // cmnuTxtA
            // 
            cmnuTxtA.ImageScalingSize = new Size(20, 20);
            cmnuTxtA.Items.AddRange(new ToolStripItem[] { borrarToolStripMenuItem, aleatorioToolStripMenuItem });
            cmnuTxtA.Name = "contextMenuStrip1";
            cmnuTxtA.Size = new Size(141, 52);
            // 
            // borrarToolStripMenuItem
            // 
            borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            borrarToolStripMenuItem.Size = new Size(140, 24);
            borrarToolStripMenuItem.Text = "Borrar";
            borrarToolStripMenuItem.Click += borrarToolStripMenuItem_Click;
            // 
            // aleatorioToolStripMenuItem
            // 
            aleatorioToolStripMenuItem.Name = "aleatorioToolStripMenuItem";
            aleatorioToolStripMenuItem.Size = new Size(140, 24);
            aleatorioToolStripMenuItem.Text = "Aleatorio";
            aleatorioToolStripMenuItem.Click += aleatorioToolStripMenuItem_Click;
            // 
            // txtB
            // 
            txtB.Location = new Point(30, 118);
            txtB.Name = "txtB";
            txtB.Size = new Size(125, 27);
            txtB.TabIndex = 3;
            txtB.TextAlign = HorizontalAlignment.Right;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(193, 92);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(50, 20);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "label1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.AutoToolTip = true;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(121, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.ToolTipText = "Quitar la aplicacion";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // operacionesToolStripMenuItem
            // 
            operacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sumaToolStripMenuItem, restaToolStripMenuItem, multiToolStripMenuItem, divToolStripMenuItem, toolStripSeparator1, habilitarToolStripMenuItem });
            operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            operacionesToolStripMenuItem.Size = new Size(106, 24);
            operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // sumaToolStripMenuItem
            // 
            sumaToolStripMenuItem.Name = "sumaToolStripMenuItem";
            sumaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            sumaToolStripMenuItem.Size = new Size(179, 26);
            sumaToolStripMenuItem.Text = "Suma";
            sumaToolStripMenuItem.Click += sumaToolStripMenuItem_Click;
            // 
            // restaToolStripMenuItem
            // 
            restaToolStripMenuItem.Name = "restaToolStripMenuItem";
            restaToolStripMenuItem.Size = new Size(179, 26);
            restaToolStripMenuItem.Text = "Resta";
            restaToolStripMenuItem.Click += restaToolStripMenuItem_Click;
            // 
            // multiToolStripMenuItem
            // 
            multiToolStripMenuItem.Name = "multiToolStripMenuItem";
            multiToolStripMenuItem.Size = new Size(179, 26);
            multiToolStripMenuItem.Text = "Multi";
            multiToolStripMenuItem.Click += multiToolStripMenuItem_Click;
            // 
            // divToolStripMenuItem
            // 
            divToolStripMenuItem.Name = "divToolStripMenuItem";
            divToolStripMenuItem.Size = new Size(179, 26);
            divToolStripMenuItem.Text = "Div";
            divToolStripMenuItem.Click += divToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(176, 6);
            // 
            // habilitarToolStripMenuItem
            // 
            habilitarToolStripMenuItem.Checked = true;
            habilitarToolStripMenuItem.CheckOnClick = true;
            habilitarToolStripMenuItem.CheckState = CheckState.Checked;
            habilitarToolStripMenuItem.Name = "habilitarToolStripMenuItem";
            habilitarToolStripMenuItem.Size = new Size(179, 26);
            habilitarToolStripMenuItem.Text = "Habilitar";
            habilitarToolStripMenuItem.CheckedChanged += habilitarToolStripMenuItem_CheckedChanged;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(65, 24);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(170, 26);
            acercaDeToolStripMenuItem.Text = "Acerca de....";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, operacionesToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(397, 28);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // tstOperaciones
            // 
            tstOperaciones.ImageScalingSize = new Size(20, 20);
            tstOperaciones.Items.AddRange(new ToolStripItem[] { tstbSuma, tstbResta, tstbMulti, tstbDiv });
            tstOperaciones.Location = new Point(0, 52);
            tstOperaciones.Name = "tstOperaciones";
            tstOperaciones.Size = new Size(397, 27);
            tstOperaciones.TabIndex = 5;
            tstOperaciones.Text = "toolStrip1";
            // 
            // tstbSuma
            // 
            tstbSuma.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tstbSuma.Image = (Image)resources.GetObject("tstbSuma.Image");
            tstbSuma.ImageTransparentColor = Color.Magenta;
            tstbSuma.Name = "tstbSuma";
            tstbSuma.Size = new Size(29, 24);
            tstbSuma.Text = "Suma";
            tstbSuma.Click += sumaToolStripMenuItem_Click;
            // 
            // tstbResta
            // 
            tstbResta.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tstbResta.Image = (Image)resources.GetObject("tstbResta.Image");
            tstbResta.ImageTransparentColor = Color.Magenta;
            tstbResta.Name = "tstbResta";
            tstbResta.Size = new Size(29, 24);
            tstbResta.Text = "Resta";
            tstbResta.Click += restaToolStripMenuItem_Click;
            // 
            // tstbMulti
            // 
            tstbMulti.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tstbMulti.Image = (Image)resources.GetObject("tstbMulti.Image");
            tstbMulti.ImageTransparentColor = Color.Magenta;
            tstbMulti.Name = "tstbMulti";
            tstbMulti.Size = new Size(29, 24);
            tstbMulti.Text = "Multi";
            tstbMulti.Click += multiToolStripMenuItem_Click;
            // 
            // tstbDiv
            // 
            tstbDiv.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tstbDiv.Image = (Image)resources.GetObject("tstbDiv.Image");
            tstbDiv.ImageTransparentColor = Color.Magenta;
            tstbDiv.Name = "tstbDiv";
            tstbDiv.Size = new Size(29, 24);
            tstbDiv.Text = "Div";
            tstbDiv.Click += divToolStripMenuItem_Click;
            // 
            // stsInformacion
            // 
            stsInformacion.ImageScalingSize = new Size(20, 20);
            stsInformacion.Items.AddRange(new ToolStripItem[] { slblValores, slblOperacion, slblResultado });
            stsInformacion.Location = new Point(0, 314);
            stsInformacion.Name = "stsInformacion";
            stsInformacion.Size = new Size(397, 30);
            stsInformacion.TabIndex = 6;
            stsInformacion.Text = "statusStrip1";
            // 
            // slblValores
            // 
            slblValores.AutoSize = false;
            slblValores.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            slblValores.BorderStyle = Border3DStyle.Sunken;
            slblValores.Name = "slblValores";
            slblValores.Size = new Size(100, 24);
            slblValores.Text = "A=0, B=0";
            // 
            // slblOperacion
            // 
            slblOperacion.AutoSize = false;
            slblOperacion.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            slblOperacion.BorderStyle = Border3DStyle.Bump;
            slblOperacion.Name = "slblOperacion";
            slblOperacion.Size = new Size(90, 24);
            slblOperacion.Text = "Sin seleccionar";
            // 
            // slblResultado
            // 
            slblResultado.AutoSize = false;
            slblResultado.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            slblResultado.BorderStyle = Border3DStyle.Raised;
            slblResultado.Name = "slblResultado";
            slblResultado.Size = new Size(50, 24);
            slblResultado.Text = "R=0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 344);
            Controls.Add(stsInformacion);
            Controls.Add(tstOperaciones);
            Controls.Add(lblResultado);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            cmnuTxtA.ResumeLayout(false);
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            tstOperaciones.ResumeLayout(false);
            tstOperaciones.PerformLayout();
            stsInformacion.ResumeLayout(false);
            stsInformacion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private TextBox txtA;
        private TextBox txtB;
        private Label lblResultado;
        private ContextMenuStrip cmnuTxtA;
        private ToolStripMenuItem borrarToolStripMenuItem;
        private ToolStripMenuItem aleatorioToolStripMenuItem;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem operacionesToolStripMenuItem;
        private ToolStripMenuItem sumaToolStripMenuItem;
        private ToolStripMenuItem restaToolStripMenuItem;
        private ToolStripMenuItem multiToolStripMenuItem;
        private ToolStripMenuItem divToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem habilitarToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private MenuStrip menuStrip2;
        private ToolStrip tstOperaciones;
        private ToolStripButton tstbSuma;
        private ToolStripButton tstbResta;
        private ToolStripButton tstbMulti;
        private ToolStripButton tstbDiv;
        private StatusStrip stsInformacion;
        private ToolStripStatusLabel slblValores;
        private ToolStripStatusLabel slblOperacion;
        private ToolStripStatusLabel slblResultado;
    }
}
