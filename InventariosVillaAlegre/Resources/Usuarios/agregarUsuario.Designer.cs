namespace InventariosVillaAlegre
{
    partial class agregarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregarUsuario));
            this.contraseña = new System.Windows.Forms.TextBox();
            this.guardar = new System.Windows.Forms.Button();
            this.tipo = new System.Windows.Forms.ComboBox();
            this.correo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contraseñaconfirmacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.agregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contraseña
            // 
            this.contraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contraseña.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña.Location = new System.Drawing.Point(218, 119);
            this.contraseña.MaxLength = 12;
            this.contraseña.Name = "contraseña";
            this.contraseña.PasswordChar = '*';
            this.contraseña.ShortcutsEnabled = false;
            this.contraseña.Size = new System.Drawing.Size(264, 31);
            this.contraseña.TabIndex = 121;
            this.contraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contraseña_KeyPress);
            // 
            // guardar
            // 
            this.guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardar.FlatAppearance.BorderSize = 0;
            this.guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardar.Location = new System.Drawing.Point(934, 438);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(55, 55);
            this.guardar.TabIndex = 118;
            this.guardar.UseVisualStyleBackColor = true;
            // 
            // tipo
            // 
            this.tipo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tipo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo.FormattingEnabled = true;
            this.tipo.Items.AddRange(new object[] {
            "General",
            "AdminAlimentos",
            "AdminMedicamentos",
            "BasicoAlimentos",
            "BasicoMedicamentos"});
            this.tipo.Location = new System.Drawing.Point(218, 214);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(264, 30);
            this.tipo.TabIndex = 117;
            // 
            // correo
            // 
            this.correo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.correo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.correo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correo.Location = new System.Drawing.Point(218, 260);
            this.correo.MaxLength = 45;
            this.correo.Name = "correo";
            this.correo.ShortcutsEnabled = false;
            this.correo.Size = new System.Drawing.Size(264, 31);
            this.correo.TabIndex = 114;
            this.correo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.correo_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 22);
            this.label10.TabIndex = 113;
            this.label10.Text = "Correo Electronico:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 22);
            this.label11.TabIndex = 112;
            this.label11.Text = "Tipo de usuario:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 22);
            this.label8.TabIndex = 111;
            this.label8.Text = "Contraseña:";
            // 
            // usuario
            // 
            this.usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.usuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(218, 68);
            this.usuario.MaxLength = 10;
            this.usuario.Name = "usuario";
            this.usuario.ShortcutsEnabled = false;
            this.usuario.Size = new System.Drawing.Size(264, 31);
            this.usuario.TabIndex = 110;
            this.usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usuario_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 22);
            this.label9.TabIndex = 109;
            this.label9.Text = "Usuario:";
            // 
            // nombre
            // 
            this.nombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(218, 21);
            this.nombre.MaxLength = 45;
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(327, 31);
            this.nombre.TabIndex = 103;
            this.nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 102;
            this.label1.Text = "Nombre:";
            // 
            // contraseñaconfirmacion
            // 
            this.contraseñaconfirmacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contraseñaconfirmacion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseñaconfirmacion.Location = new System.Drawing.Point(218, 168);
            this.contraseñaconfirmacion.MaxLength = 12;
            this.contraseñaconfirmacion.Name = "contraseñaconfirmacion";
            this.contraseñaconfirmacion.PasswordChar = '*';
            this.contraseñaconfirmacion.ShortcutsEnabled = false;
            this.contraseñaconfirmacion.Size = new System.Drawing.Size(264, 31);
            this.contraseñaconfirmacion.TabIndex = 123;
            this.contraseñaconfirmacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contraseñaconfirmacion_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 22);
            this.label4.TabIndex = 122;
            this.label4.Text = "Repetir Contraseña:";
            // 
            // agregar
            // 
            this.agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar.Image = global::InventariosVillaAlegre.Properties.Resources._16__User_add_1;
            this.agregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.agregar.Location = new System.Drawing.Point(248, 310);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(168, 49);
            this.agregar.TabIndex = 124;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // agregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InventariosVillaAlegre.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(629, 371);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.contraseñaconfirmacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "agregarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Usuario";
            this.Load += new System.EventHandler(this.agregarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.ComboBox tipo;
        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contraseñaconfirmacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button agregar;
    }
}