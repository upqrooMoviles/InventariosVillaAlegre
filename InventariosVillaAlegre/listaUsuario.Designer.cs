namespace InventariosVillaAlegre
{
    partial class listaUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usuarios = new System.Windows.Forms.DataGridView();
            this.enviar = new System.Windows.Forms.Button();
            this.archivo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarios
            // 
            this.usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.usuarios.BackgroundColor = System.Drawing.Color.White;
            this.usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarios.Enabled = false;
            this.usuarios.EnableHeadersVisualStyles = false;
            this.usuarios.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usuarios.Location = new System.Drawing.Point(12, 24);
            this.usuarios.Name = "usuarios";
            this.usuarios.Size = new System.Drawing.Size(570, 286);
            this.usuarios.TabIndex = 5;
            // 
            // enviar
            // 
            this.enviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enviar.Image = global::InventariosVillaAlegre.Properties.Resources._16__At_;
            this.enviar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.enviar.Location = new System.Drawing.Point(416, 322);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(141, 37);
            this.enviar.TabIndex = 46;
            this.enviar.Text = "Enviar por correo";
            this.enviar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.enviar.UseVisualStyleBackColor = true;
            this.enviar.Click += new System.EventHandler(this.enviar_Click);
            // 
            // archivo
            // 
            this.archivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.archivo.Image = global::InventariosVillaAlegre.Properties.Resources._16__Align_full_4_;
            this.archivo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.archivo.Location = new System.Drawing.Point(221, 322);
            this.archivo.Name = "archivo";
            this.archivo.Size = new System.Drawing.Size(139, 37);
            this.archivo.TabIndex = 45;
            this.archivo.Text = "Generar archivo";
            this.archivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.archivo.UseVisualStyleBackColor = true;
            this.archivo.Click += new System.EventHandler(this.archivo_Click);
            // 
            // listaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InventariosVillaAlegre.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(629, 371);
            this.Controls.Add(this.enviar);
            this.Controls.Add(this.archivo);
            this.Controls.Add(this.usuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "listaUsuario";
            this.Text = "listaUsuario";
            this.Load += new System.EventHandler(this.listaUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView usuarios;
        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.Button archivo;
    }
}