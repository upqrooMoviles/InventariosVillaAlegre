namespace InventariosVillaAlegre
{
    partial class medicamentos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(medicamentos));
            this.contenedor = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.Panel();
            this.modificarR = new System.Windows.Forms.Button();
            this.buscarM = new System.Windows.Forms.Button();
            this.agregarM = new System.Windows.Forms.Button();
            this.eliminarM = new System.Windows.Forms.Button();
            this.actualizarM = new System.Windows.Forms.Button();
            this.eliminarR = new System.Windows.Forms.Button();
            this.agregarR = new System.Windows.Forms.Button();
            this.listaM = new System.Windows.Forms.Button();
            this.fichaR = new System.Windows.Forms.Button();
            this.listaR = new System.Windows.Forms.Button();
            this.baner = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.hora = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menu.SuspendLayout();
            this.baner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.Color.Transparent;
            this.contenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contenedor.Location = new System.Drawing.Point(226, 127);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(921, 489);
            this.contenedor.TabIndex = 9;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menu.Controls.Add(this.modificarR);
            this.menu.Controls.Add(this.buscarM);
            this.menu.Controls.Add(this.agregarM);
            this.menu.Controls.Add(this.eliminarM);
            this.menu.Controls.Add(this.actualizarM);
            this.menu.Controls.Add(this.eliminarR);
            this.menu.Controls.Add(this.agregarR);
            this.menu.Controls.Add(this.listaM);
            this.menu.Controls.Add(this.fichaR);
            this.menu.Controls.Add(this.listaR);
            this.menu.Location = new System.Drawing.Point(1, 127);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(219, 486);
            this.menu.TabIndex = 8;
            // 
            // modificarR
            // 
            this.modificarR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modificarR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarR.Image = global::InventariosVillaAlegre.Properties.Resources._16__User_edit_;
            this.modificarR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.modificarR.Location = new System.Drawing.Point(-1, 233);
            this.modificarR.Name = "modificarR";
            this.modificarR.Size = new System.Drawing.Size(219, 40);
            this.modificarR.TabIndex = 9;
            this.modificarR.Text = "Modificar residente";
            this.modificarR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modificarR.UseVisualStyleBackColor = true;
            this.modificarR.Visible = false;
            this.modificarR.Click += new System.EventHandler(this.modificarR_Click);
            // 
            // buscarM
            // 
            this.buscarM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarM.Image = global::InventariosVillaAlegre.Properties.Resources._16__Searchnext_;
            this.buscarM.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buscarM.Location = new System.Drawing.Point(-1, 49);
            this.buscarM.Name = "buscarM";
            this.buscarM.Size = new System.Drawing.Size(219, 40);
            this.buscarM.TabIndex = 8;
            this.buscarM.Text = "Buscar medicamento";
            this.buscarM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarM.UseVisualStyleBackColor = true;
            this.buscarM.Click += new System.EventHandler(this.buscarM_Click);
            // 
            // agregarM
            // 
            this.agregarM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarM.Image = global::InventariosVillaAlegre.Properties.Resources._16__Quarantine_;
            this.agregarM.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.agregarM.Location = new System.Drawing.Point(-1, 325);
            this.agregarM.Name = "agregarM";
            this.agregarM.Size = new System.Drawing.Size(219, 40);
            this.agregarM.TabIndex = 1;
            this.agregarM.Text = "Agregar medicamento";
            this.agregarM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarM.UseVisualStyleBackColor = true;
            this.agregarM.Visible = false;
            this.agregarM.Click += new System.EventHandler(this.agregarM_Click);
            // 
            // eliminarM
            // 
            this.eliminarM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminarM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarM.Image = global::InventariosVillaAlegre.Properties.Resources._16__Card_delete_;
            this.eliminarM.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eliminarM.Location = new System.Drawing.Point(-1, 417);
            this.eliminarM.Name = "eliminarM";
            this.eliminarM.Size = new System.Drawing.Size(219, 40);
            this.eliminarM.TabIndex = 7;
            this.eliminarM.Text = "Eliminar medicamento";
            this.eliminarM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminarM.UseVisualStyleBackColor = true;
            this.eliminarM.Visible = false;
            this.eliminarM.Click += new System.EventHandler(this.eliminarM_Click);
            // 
            // actualizarM
            // 
            this.actualizarM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.actualizarM.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizarM.Image = global::InventariosVillaAlegre.Properties.Resources._16__Contents_;
            this.actualizarM.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.actualizarM.Location = new System.Drawing.Point(-1, 187);
            this.actualizarM.Name = "actualizarM";
            this.actualizarM.Size = new System.Drawing.Size(219, 40);
            this.actualizarM.TabIndex = 6;
            this.actualizarM.Text = "Actualizar medicamento\r\n";
            this.actualizarM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.actualizarM.UseVisualStyleBackColor = true;
            this.actualizarM.Visible = false;
            this.actualizarM.Click += new System.EventHandler(this.actualizarM_Click);
            // 
            // eliminarR
            // 
            this.eliminarR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminarR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarR.Image = global::InventariosVillaAlegre.Properties.Resources._16__User_delete_;
            this.eliminarR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eliminarR.Location = new System.Drawing.Point(-1, 371);
            this.eliminarR.Name = "eliminarR";
            this.eliminarR.Size = new System.Drawing.Size(219, 40);
            this.eliminarR.TabIndex = 5;
            this.eliminarR.Text = "Eliminar residente";
            this.eliminarR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminarR.UseVisualStyleBackColor = true;
            this.eliminarR.Visible = false;
            this.eliminarR.Click += new System.EventHandler(this.eliminarR_Click);
            // 
            // agregarR
            // 
            this.agregarR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarR.Image = global::InventariosVillaAlegre.Properties.Resources._16__User_add_;
            this.agregarR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.agregarR.Location = new System.Drawing.Point(-1, 279);
            this.agregarR.Name = "agregarR";
            this.agregarR.Size = new System.Drawing.Size(219, 40);
            this.agregarR.TabIndex = 4;
            this.agregarR.Text = "Agregar residente";
            this.agregarR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarR.UseVisualStyleBackColor = true;
            this.agregarR.Visible = false;
            this.agregarR.Click += new System.EventHandler(this.agregarR_Click);
            // 
            // listaM
            // 
            this.listaM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listaM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaM.Image = global::InventariosVillaAlegre.Properties.Resources._16__View_normal_;
            this.listaM.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.listaM.Location = new System.Drawing.Point(-1, 141);
            this.listaM.Name = "listaM";
            this.listaM.Size = new System.Drawing.Size(219, 40);
            this.listaM.TabIndex = 3;
            this.listaM.Text = "Lista de medicamentos";
            this.listaM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listaM.UseVisualStyleBackColor = true;
            this.listaM.Click += new System.EventHandler(this.listaM_Click);
            // 
            // fichaR
            // 
            this.fichaR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fichaR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fichaR.Image = global::InventariosVillaAlegre.Properties.Resources._16__Idcard_;
            this.fichaR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fichaR.Location = new System.Drawing.Point(-1, 3);
            this.fichaR.Name = "fichaR";
            this.fichaR.Size = new System.Drawing.Size(219, 40);
            this.fichaR.TabIndex = 2;
            this.fichaR.Text = "Ficha de residente";
            this.fichaR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fichaR.UseVisualStyleBackColor = true;
            this.fichaR.Click += new System.EventHandler(this.fichaR_Click_1);
            // 
            // listaR
            // 
            this.listaR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listaR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaR.Image = global::InventariosVillaAlegre.Properties.Resources._16__Goto_line_;
            this.listaR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.listaR.Location = new System.Drawing.Point(-1, 95);
            this.listaR.Name = "listaR";
            this.listaR.Size = new System.Drawing.Size(219, 40);
            this.listaR.TabIndex = 0;
            this.listaR.Text = "Lista de residentes";
            this.listaR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listaR.UseVisualStyleBackColor = true;
            this.listaR.Click += new System.EventHandler(this.listaR_Click);
            // 
            // baner
            // 
            this.baner.BackColor = System.Drawing.Color.Transparent;
            this.baner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.baner.Controls.Add(this.panel1);
            this.baner.Controls.Add(this.pictureBox3);
            this.baner.Controls.Add(this.pictureBox2);
            this.baner.Controls.Add(this.hora);
            this.baner.Controls.Add(this.fecha);
            this.baner.Controls.Add(this.label3);
            this.baner.Controls.Add(this.label2);
            this.baner.Controls.Add(this.user);
            this.baner.Controls.Add(this.label1);
            this.baner.Location = new System.Drawing.Point(1, 1);
            this.baner.Name = "baner";
            this.baner.Size = new System.Drawing.Size(1146, 120);
            this.baner.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(279, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 401);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::InventariosVillaAlegre.Properties.Resources.medicamentos;
            this.pictureBox3.Location = new System.Drawing.Point(397, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 116);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::InventariosVillaAlegre.Properties.Resources.logo_villa_alegre_21;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(388, 117);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.BackColor = System.Drawing.Color.Transparent;
            this.hora.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora.Location = new System.Drawing.Point(976, 91);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(47, 21);
            this.hora.TabIndex = 17;
            this.hora.Text = "Hora";
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.BackColor = System.Drawing.Color.Transparent;
            this.fecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Location = new System.Drawing.Point(976, 53);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(59, 21);
            this.fecha.TabIndex = 16;
            this.fecha.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(896, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Hora:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(896, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Fecha:";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.BackColor = System.Drawing.Color.Transparent;
            this.user.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(976, 12);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(66, 21);
            this.user.TabIndex = 13;
            this.user.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(896, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Usuario: ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // medicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InventariosVillaAlegre.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(1148, 617);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.baner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "medicamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario Medicamentos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.medicamentos_FormClosed);
            this.menu.ResumeLayout(false);
            this.baner.ResumeLayout(false);
            this.baner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Panel baner;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buscarM;
        private System.Windows.Forms.Button agregarM;
        private System.Windows.Forms.Button eliminarM;
        private System.Windows.Forms.Button actualizarM;
        private System.Windows.Forms.Button eliminarR;
        private System.Windows.Forms.Button agregarR;
        private System.Windows.Forms.Button listaM;
        private System.Windows.Forms.Button fichaR;
        private System.Windows.Forms.Button listaR;
        private System.Windows.Forms.Button modificarR;
    }
}