namespace InventariosVillaAlegre
{
    partial class principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principal));
            this.label1 = new System.Windows.Forms.Label();
            this.alimentos = new System.Windows.Forms.PictureBox();
            this.medicamentos = new System.Windows.Forms.PictureBox();
            this.usuarios = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.alimentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 32.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elige una opción: ";
            // 
            // alimentos
            // 
            this.alimentos.BackColor = System.Drawing.Color.Transparent;
            this.alimentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alimentos.Image = global::InventariosVillaAlegre.Properties.Resources.alimentos;
            this.alimentos.Location = new System.Drawing.Point(22, 95);
            this.alimentos.Name = "alimentos";
            this.alimentos.Size = new System.Drawing.Size(230, 230);
            this.alimentos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alimentos.TabIndex = 1;
            this.alimentos.TabStop = false;
            this.toolTip1.SetToolTip(this.alimentos, "Inventario Alimentos");
            this.alimentos.Click += new System.EventHandler(this.alimentos_Click);
            // 
            // medicamentos
            // 
            this.medicamentos.BackColor = System.Drawing.Color.Transparent;
            this.medicamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.medicamentos.Image = global::InventariosVillaAlegre.Properties.Resources.medicamentos;
            this.medicamentos.Location = new System.Drawing.Point(286, 96);
            this.medicamentos.Name = "medicamentos";
            this.medicamentos.Size = new System.Drawing.Size(230, 230);
            this.medicamentos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.medicamentos.TabIndex = 2;
            this.medicamentos.TabStop = false;
            this.toolTip1.SetToolTip(this.medicamentos, "Inventario de Medicamentos");
            this.medicamentos.Click += new System.EventHandler(this.medicamentos_Click);
            // 
            // usuarios
            // 
            this.usuarios.BackColor = System.Drawing.Color.Transparent;
            this.usuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usuarios.Image = global::InventariosVillaAlegre.Properties.Resources.usuarios;
            this.usuarios.Location = new System.Drawing.Point(550, 95);
            this.usuarios.Name = "usuarios";
            this.usuarios.Size = new System.Drawing.Size(230, 230);
            this.usuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.usuarios.TabIndex = 3;
            this.usuarios.TabStop = false;
            this.toolTip1.SetToolTip(this.usuarios, "Agregar Usuarios");
            this.usuarios.Click += new System.EventHandler(this.usuarios_Click);
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InventariosVillaAlegre.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(803, 368);
            this.Controls.Add(this.usuarios);
            this.Controls.Add(this.medicamentos);
            this.Controls.Add(this.alimentos);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de inventario - Villa Alegre";
            ((System.ComponentModel.ISupportInitialize)(this.alimentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox alimentos;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox medicamentos;
        private System.Windows.Forms.PictureBox usuarios;
    }
}

