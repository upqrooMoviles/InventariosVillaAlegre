namespace InventariosVillaAlegre
{
    partial class bajas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bajas));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tablaProducto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.eliminarP = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tipoR = new System.Windows.Forms.TextBox();
            this.eliminarR = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.nombreR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.eliminarM = new System.Windows.Forms.Button();
            this.nombreM = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tablaMenu = new System.Windows.Forms.DataGridView();
            this.claveP = new System.Windows.Forms.ComboBox();
            this.ingredientesR = new System.Windows.Forms.RichTextBox();
            this.claveR = new System.Windows.Forms.ComboBox();
            this.claveM = new System.Windows.Forms.ComboBox();
            this.dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desayuno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProducto)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(2, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1052, 542);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImage = global::InventariosVillaAlegre.Properties.Resources.fondo;
            this.tabPage1.Controls.Add(this.claveP);
            this.tabPage1.Controls.Add(this.tablaProducto);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.eliminarP);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1044, 512);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Productos";
            // 
            // tablaProducto
            // 
            this.tablaProducto.AllowUserToAddRows = false;
            this.tablaProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tablaProducto.BackgroundColor = System.Drawing.Color.White;
            this.tablaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clave,
            this.categoria,
            this.producto,
            this.medida,
            this.existencia});
            this.tablaProducto.Location = new System.Drawing.Point(149, 136);
            this.tablaProducto.Name = "tablaProducto";
            this.tablaProducto.ReadOnly = true;
            this.tablaProducto.Size = new System.Drawing.Size(743, 96);
            this.tablaProducto.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label1.Location = new System.Drawing.Point(291, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Clave del producto:";
            // 
            // eliminarP
            // 
            this.eliminarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminarP.Enabled = false;
            this.eliminarP.Image = global::InventariosVillaAlegre.Properties.Resources._16__Minus_over_;
            this.eliminarP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eliminarP.Location = new System.Drawing.Point(440, 345);
            this.eliminarP.Name = "eliminarP";
            this.eliminarP.Size = new System.Drawing.Size(181, 37);
            this.eliminarP.TabIndex = 5;
            this.eliminarP.Text = "Eliminar de producto";
            this.eliminarP.UseVisualStyleBackColor = true;
            this.eliminarP.Click += new System.EventHandler(this.eliminarP_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::InventariosVillaAlegre.Properties.Resources.fondo;
            this.tabPage2.Controls.Add(this.claveR);
            this.tabPage2.Controls.Add(this.ingredientesR);
            this.tabPage2.Controls.Add(this.tipoR);
            this.tabPage2.Controls.Add(this.eliminarR);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.nombreR);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1044, 512);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Recetas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tipoR
            // 
            this.tipoR.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.tipoR.Location = new System.Drawing.Point(252, 151);
            this.tipoR.Name = "tipoR";
            this.tipoR.ReadOnly = true;
            this.tipoR.Size = new System.Drawing.Size(306, 28);
            this.tipoR.TabIndex = 18;
            // 
            // eliminarR
            // 
            this.eliminarR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminarR.Enabled = false;
            this.eliminarR.Image = global::InventariosVillaAlegre.Properties.Resources._16__Minus_over_;
            this.eliminarR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eliminarR.Location = new System.Drawing.Point(229, 235);
            this.eliminarR.Name = "eliminarR";
            this.eliminarR.Size = new System.Drawing.Size(179, 37);
            this.eliminarR.TabIndex = 17;
            this.eliminarR.Text = "Eliminar receta";
            this.eliminarR.UseVisualStyleBackColor = true;
            this.eliminarR.Click += new System.EventHandler(this.eliminarR_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label8.Location = new System.Drawing.Point(54, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tipo de alimento:";
            // 
            // nombreR
            // 
            this.nombreR.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.nombreR.Location = new System.Drawing.Point(252, 95);
            this.nombreR.Name = "nombreR";
            this.nombreR.ReadOnly = true;
            this.nombreR.Size = new System.Drawing.Size(306, 28);
            this.nombreR.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label6.Location = new System.Drawing.Point(5, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nombre de la receta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label7.Location = new System.Drawing.Point(27, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Clave de la receta:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::InventariosVillaAlegre.Properties.Resources.fondo;
            this.tabPage3.Controls.Add(this.claveM);
            this.tabPage3.Controls.Add(this.eliminarM);
            this.tabPage3.Controls.Add(this.nombreM);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.tablaMenu);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1044, 512);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Menús";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // eliminarM
            // 
            this.eliminarM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminarM.Enabled = false;
            this.eliminarM.Image = global::InventariosVillaAlegre.Properties.Resources._16__Minus_over_;
            this.eliminarM.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eliminarM.Location = new System.Drawing.Point(440, 412);
            this.eliminarM.Name = "eliminarM";
            this.eliminarM.Size = new System.Drawing.Size(150, 37);
            this.eliminarM.TabIndex = 18;
            this.eliminarM.Text = "Eliminar menú";
            this.eliminarM.UseVisualStyleBackColor = true;
            this.eliminarM.Click += new System.EventHandler(this.eliminarM_Click);
            // 
            // nombreM
            // 
            this.nombreM.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.nombreM.Location = new System.Drawing.Point(475, 107);
            this.nombreM.Name = "nombreM";
            this.nombreM.ReadOnly = true;
            this.nombreM.Size = new System.Drawing.Size(306, 28);
            this.nombreM.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label9.Location = new System.Drawing.Point(263, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(206, 24);
            this.label9.TabIndex = 12;
            this.label9.Text = "Nombre del menú:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label10.Location = new System.Drawing.Point(285, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 24);
            this.label10.TabIndex = 10;
            this.label10.Text = "Clave del menú:";
            // 
            // tablaMenu
            // 
            this.tablaMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tablaMenu.BackgroundColor = System.Drawing.Color.White;
            this.tablaMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dia,
            this.desayuno,
            this.comida,
            this.cena});
            this.tablaMenu.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tablaMenu.Location = new System.Drawing.Point(221, 176);
            this.tablaMenu.Name = "tablaMenu";
            this.tablaMenu.ReadOnly = true;
            this.tablaMenu.Size = new System.Drawing.Size(674, 217);
            this.tablaMenu.TabIndex = 5;
            // 
            // claveP
            // 
            this.claveP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.claveP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.claveP.FormattingEnabled = true;
            this.claveP.Location = new System.Drawing.Point(516, 54);
            this.claveP.Name = "claveP";
            this.claveP.Size = new System.Drawing.Size(144, 25);
            this.claveP.TabIndex = 9;
            this.claveP.SelectedIndexChanged += new System.EventHandler(this.claveP_SelectedIndexChanged);
            // 
            // ingredientesR
            // 
            this.ingredientesR.Enabled = false;
            this.ingredientesR.Location = new System.Drawing.Point(684, 95);
            this.ingredientesR.Name = "ingredientesR";
            this.ingredientesR.ReadOnly = true;
            this.ingredientesR.Size = new System.Drawing.Size(313, 362);
            this.ingredientesR.TabIndex = 19;
            this.ingredientesR.Text = "";
            // 
            // claveR
            // 
            this.claveR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.claveR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.claveR.FormattingEnabled = true;
            this.claveR.Location = new System.Drawing.Point(252, 43);
            this.claveR.Name = "claveR";
            this.claveR.Size = new System.Drawing.Size(215, 25);
            this.claveR.TabIndex = 20;
            this.claveR.SelectedIndexChanged += new System.EventHandler(this.claveR_SelectedIndexChanged);
            // 
            // claveM
            // 
            this.claveM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.claveM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.claveM.FormattingEnabled = true;
            this.claveM.Location = new System.Drawing.Point(475, 41);
            this.claveM.Name = "claveM";
            this.claveM.Size = new System.Drawing.Size(286, 25);
            this.claveM.TabIndex = 19;
            this.claveM.SelectedIndexChanged += new System.EventHandler(this.claveM_SelectedIndexChanged);
            // 
            // dia
            // 
            this.dia.HeaderText = "DIA";
            this.dia.Name = "dia";
            this.dia.ReadOnly = true;
            this.dia.Width = 55;
            // 
            // desayuno
            // 
            this.desayuno.HeaderText = "DESAYUNO";
            this.desayuno.Name = "desayuno";
            this.desayuno.ReadOnly = true;
            this.desayuno.Width = 101;
            // 
            // comida
            // 
            this.comida.HeaderText = "COMIDA";
            this.comida.Name = "comida";
            this.comida.ReadOnly = true;
            this.comida.Width = 88;
            // 
            // cena
            // 
            this.cena.HeaderText = "CENA";
            this.cena.Name = "cena";
            this.cena.ReadOnly = true;
            this.cena.Width = 70;
            // 
            // clave
            // 
            this.clave.HeaderText = "CLAVE";
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            this.clave.Width = 75;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "CATEGORIA";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Width = 107;
            // 
            // producto
            // 
            this.producto.HeaderText = "PRODUCTO";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            this.producto.Width = 105;
            // 
            // medida
            // 
            this.medida.HeaderText = "MEDIDA";
            this.medida.Name = "medida";
            this.medida.ReadOnly = true;
            this.medida.Width = 83;
            // 
            // existencia
            // 
            this.existencia.HeaderText = "EXISTENCIA";
            this.existencia.Name = "existencia";
            this.existencia.ReadOnly = true;
            this.existencia.Width = 102;
            // 
            // bajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InventariosVillaAlegre.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(1056, 550);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "bajas";
            this.Text = "bajas";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProducto)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button eliminarP;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button eliminarR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nombreR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button eliminarM;
        private System.Windows.Forms.TextBox nombreM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView tablaMenu;
        private System.Windows.Forms.DataGridView tablaProducto;
        private System.Windows.Forms.TextBox tipoR;
        private System.Windows.Forms.ComboBox claveP;
        private System.Windows.Forms.ComboBox claveR;
        private System.Windows.Forms.RichTextBox ingredientesR;
        private System.Windows.Forms.ComboBox claveM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn desayuno;
        private System.Windows.Forms.DataGridViewTextBoxColumn comida;
        private System.Windows.Forms.DataGridViewTextBoxColumn cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn existencia;
    }
}