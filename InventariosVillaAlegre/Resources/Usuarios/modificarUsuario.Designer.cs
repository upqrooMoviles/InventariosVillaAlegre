namespace InventariosVillaAlegre
{
    partial class modificarUsuario
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
            this.modificar = new System.Windows.Forms.Button();
            this.contraseñaconfirmacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.tipo = new System.Windows.Forms.ComboBox();
            this.correo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modificar
            // 
            this.modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modificar.Enabled = false;
            this.modificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificar.Image = global::InventariosVillaAlegre.Properties.Resources._16__User_edit_;
            this.modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.modificar.Location = new System.Drawing.Point(314, 317);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(144, 32);
            this.modificar.TabIndex = 137;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Visible = false;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // contraseñaconfirmacion
            // 
            this.contraseñaconfirmacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contraseñaconfirmacion.Enabled = false;
            this.contraseñaconfirmacion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseñaconfirmacion.Location = new System.Drawing.Point(229, 178);
            this.contraseñaconfirmacion.MaxLength = 12;
            this.contraseñaconfirmacion.Name = "contraseñaconfirmacion";
            this.contraseñaconfirmacion.PasswordChar = '*';
            this.contraseñaconfirmacion.ShortcutsEnabled = false;
            this.contraseñaconfirmacion.Size = new System.Drawing.Size(264, 31);
            this.contraseñaconfirmacion.TabIndex = 136;
            this.contraseñaconfirmacion.TextChanged += new System.EventHandler(this.contraseñaconfirmacion_TextChanged);
            this.contraseñaconfirmacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contraseñaconfirmacion_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 22);
            this.label4.TabIndex = 135;
            this.label4.Text = "Repetir Contraseña:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // contraseña
            // 
            this.contraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contraseña.Enabled = false;
            this.contraseña.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña.Location = new System.Drawing.Point(229, 130);
            this.contraseña.MaxLength = 12;
            this.contraseña.Name = "contraseña";
            this.contraseña.PasswordChar = '*';
            this.contraseña.ShortcutsEnabled = false;
            this.contraseña.Size = new System.Drawing.Size(264, 31);
            this.contraseña.TabIndex = 134;
            this.contraseña.TextChanged += new System.EventHandler(this.contraseña_TextChanged);
            this.contraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contraseña_KeyPress);
            // 
            // tipo
            // 
            this.tipo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipo.Enabled = false;
            this.tipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tipo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo.FormattingEnabled = true;
            this.tipo.Items.AddRange(new object[] {
            "General",
            "AdminAlimentos",
            "AdminMedicamentos",
            "BasicoAlimentos",
            "BasicoMedicamentos"});
            this.tipo.Location = new System.Drawing.Point(229, 224);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(264, 30);
            this.tipo.TabIndex = 133;
            this.tipo.SelectedIndexChanged += new System.EventHandler(this.tipo_SelectedIndexChanged);
            // 
            // correo
            // 
            this.correo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.correo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.correo.Enabled = false;
            this.correo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correo.Location = new System.Drawing.Point(229, 270);
            this.correo.MaxLength = 45;
            this.correo.Name = "correo";
            this.correo.ShortcutsEnabled = false;
            this.correo.Size = new System.Drawing.Size(264, 31);
            this.correo.TabIndex = 132;
            this.correo.TextChanged += new System.EventHandler(this.correo_TextChanged);
            this.correo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.correo_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 22);
            this.label10.TabIndex = 131;
            this.label10.Text = "Correo Electronico:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 227);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 22);
            this.label11.TabIndex = 130;
            this.label11.Text = "Tipo de usuario:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 22);
            this.label8.TabIndex = 129;
            this.label8.Text = "Contraseña:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // usuario
            // 
            this.usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.usuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(105, 5);
            this.usuario.MaxLength = 10;
            this.usuario.Name = "usuario";
            this.usuario.ShortcutsEnabled = false;
            this.usuario.Size = new System.Drawing.Size(213, 31);
            this.usuario.TabIndex = 128;
            this.usuario.TextChanged += new System.EventHandler(this.usuario_TextChanged);
            this.usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usuario_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 22);
            this.label9.TabIndex = 127;
            this.label9.Text = "Usuario:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // nombre
            // 
            this.nombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombre.Enabled = false;
            this.nombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(229, 81);
            this.nombre.MaxLength = 45;
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(327, 31);
            this.nombre.TabIndex = 126;
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            this.nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 125;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buscar
            // 
            this.buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.Image = global::InventariosVillaAlegre.Properties.Resources._16__Searchnext_;
            this.buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buscar.Location = new System.Drawing.Point(338, 1);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(120, 35);
            this.buscar.TabIndex = 138;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // modificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InventariosVillaAlegre.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(629, 371);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.contraseñaconfirmacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.contraseña);
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
            this.Name = "modificarUsuario";
            this.Text = "modificarUsuario";
            this.Load += new System.EventHandler(this.modificarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.TextBox contraseñaconfirmacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.ComboBox tipo;
        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buscar;
    }
}