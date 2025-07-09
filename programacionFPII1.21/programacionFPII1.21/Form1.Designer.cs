namespace programacionFPII1._21
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
            lstvAlimentos = new ListView();
            txtElemento = new TextBox();
            gbGrupos = new GroupBox();
            btnAdicionar = new Button();
            rbtCarnes = new RadioButton();
            rbtFrutas = new RadioButton();
            btnLimpiar = new Button();
            lblSelecionado = new Label();
            txtImagen = new TextBox();
            btnActualizar = new Button();
            btnBorrar = new Button();
            gbGrupos.SuspendLayout();
            SuspendLayout();
            // 
            // lstvAlimentos
            // 
            lstvAlimentos.Location = new Point(12, 12);
            lstvAlimentos.Name = "lstvAlimentos";
            lstvAlimentos.Size = new Size(481, 336);
            lstvAlimentos.TabIndex = 0;
            lstvAlimentos.UseCompatibleStateImageBehavior = false;
            lstvAlimentos.View = View.SmallIcon;
            lstvAlimentos.MouseClick += lstvAlimentos_Mouse;
            // 
            // txtElemento
            // 
            txtElemento.Location = new Point(12, 384);
            txtElemento.Name = "txtElemento";
            txtElemento.Size = new Size(125, 27);
            txtElemento.TabIndex = 1;
            // 
            // gbGrupos
            // 
            gbGrupos.Controls.Add(btnAdicionar);
            gbGrupos.Controls.Add(rbtCarnes);
            gbGrupos.Controls.Add(rbtFrutas);
            gbGrupos.Location = new Point(169, 354);
            gbGrupos.Name = "gbGrupos";
            gbGrupos.Size = new Size(250, 125);
            gbGrupos.TabIndex = 2;
            gbGrupos.TabStop = false;
            gbGrupos.Text = "Grupos";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(107, 26);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(94, 29);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // rbtCarnes
            // 
            rbtCarnes.AutoSize = true;
            rbtCarnes.Location = new Point(6, 54);
            rbtCarnes.Name = "rbtCarnes";
            rbtCarnes.Size = new Size(74, 24);
            rbtCarnes.TabIndex = 1;
            rbtCarnes.TabStop = true;
            rbtCarnes.Text = "Carnes";
            rbtCarnes.UseVisualStyleBackColor = true;
            // 
            // rbtFrutas
            // 
            rbtFrutas.AutoSize = true;
            rbtFrutas.Checked = true;
            rbtFrutas.Location = new Point(6, 26);
            rbtFrutas.Name = "rbtFrutas";
            rbtFrutas.Size = new Size(69, 24);
            rbtFrutas.TabIndex = 0;
            rbtFrutas.TabStop = true;
            rbtFrutas.Text = "Frutas";
            rbtFrutas.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(499, 67);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblSelecionado
            // 
            lblSelecionado.AutoSize = true;
            lblSelecionado.Location = new Point(499, 44);
            lblSelecionado.Name = "lblSelecionado";
            lblSelecionado.Size = new Size(50, 20);
            lblSelecionado.TabIndex = 4;
            lblSelecionado.Text = "label1";
            // 
            // txtImagen
            // 
            txtImagen.Location = new Point(12, 417);
            txtImagen.Name = "txtImagen";
            txtImagen.Size = new Size(125, 27);
            txtImagen.TabIndex = 5;
            txtImagen.Text = "0";
            txtImagen.TextAlign = HorizontalAlignment.Right;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(12, 450);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(499, 102);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(94, 29);
            btnBorrar.TabIndex = 7;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 559);
            Controls.Add(btnBorrar);
            Controls.Add(btnActualizar);
            Controls.Add(txtImagen);
            Controls.Add(lblSelecionado);
            Controls.Add(btnLimpiar);
            Controls.Add(gbGrupos);
            Controls.Add(txtElemento);
            Controls.Add(lstvAlimentos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbGrupos.ResumeLayout(false);
            gbGrupos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lstvAlimentos;
        private TextBox txtElemento;
        private GroupBox gbGrupos;
        private RadioButton rbtCarnes;
        private RadioButton rbtFrutas;
        private Button btnAdicionar;
        private Button btnLimpiar;
        private Label lblSelecionado;
        private TextBox txtImagen;
        private Button btnActualizar;
        private Button btnBorrar;
    }
}
