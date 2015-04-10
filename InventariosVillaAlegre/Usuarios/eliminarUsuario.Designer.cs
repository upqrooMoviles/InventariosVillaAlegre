namespace InventariosVillaAlegre
{
    partial class eliminarUsuario
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
            this.buscar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.tipo = new System.Windows.Forms.ComboBox();
            this.correo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buscar
            // 
            this.buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.Image = global::InventariosVillaAlegre.Properties.Resources._16__Searchnext_;
            this.buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buscar.Location = new System.Drawing.Point(369, 11);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(120, 35);
            this.buscar.TabIndex = 152;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // eliminar
            // 
            this.eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar.Image = global::InventariosVillaAlegre.Properties.Resources._16__User_delete_;
            this.eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eliminar.Location = new System.Drawing.Point(260, 264);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(134, 32);
            this.eliminar.TabIndex = 151;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Visible = false;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
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
            this.tipo.Location = new System.Drawing.Point(260, 140);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(264, 30);
            this.tipo.TabIndex = 147;
            // 
            // correo
            // 
            this.correo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.correo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.correo.Enabled = false;
            this.correo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correo.Location = new System.Drawing.Point(260, 191);
            this.correo.MaxLength = 45;
            this.correo.Name = "correo";
            this.correo.ShortcutsEnabled = false;
            this.correo.Size = new System.Drawing.Size(264, 31);
            this.correo.TabIndex = 146;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(47, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 22);
            this.label10.TabIndex = 145;
            this.label10.Text = "Correo Electronico:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(47, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 22);
            this.label11.TabIndex = 144;
            this.label11.Text = "Tipo de usuario:";
            // 
            // usuario
            // 
            this.usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.usuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(136, 15);
            this.usuario.MaxLength = 10;
            this.usuario.Name = "usuario";
            this.usuario.ShortcutsEnabled = false;
            this.usuario.Size = new System.Drawing.Size(213, 31);
            this.usuario.TabIndex = 142;
            this.usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usuario_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 22);
            this.label9.TabIndex = 141;
            this.label9.Text = "Usuario:";
            // 
            // nombre
            // 
            this.nombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombre.Enabled = false;
            this.nombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(260, 91);
            this.nombre.MaxLength = 45;
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(327, 31);
            this.nombre.TabIndex = 140;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 139;
            this.label1.Text = "Nombre:";
            // 
            // eliminarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InventariosVillaAlegre.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(629, 371);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "eliminarUsuario";
            this.Text = "eliminarUsuario";
            this.Load += new System.EventHandler(this.eliminarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.ComboBox tipo;
        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label1;
    }
}