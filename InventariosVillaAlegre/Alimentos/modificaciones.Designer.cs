namespace InventariosVillaAlegre
{
    partial class modificaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modificaciones));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.claveP = new System.Windows.Forms.ComboBox();
            this.medidaP = new System.Windows.Forms.ComboBox();
            this.categoriaP = new System.Windows.Forms.ComboBox();
            this.existenciaP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nombreP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.modificarP = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tipoR = new System.Windows.Forms.ComboBox();
            this.claveR = new System.Windows.Forms.ComboBox();
            this.modificarR = new System.Windows.Forms.Button();
            this.tablaIngredientes = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.nombreR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.claveM = new System.Windows.Forms.ComboBox();
            this.modificarM = new System.Windows.Forms.Button();
            this.nombreM = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tablaMenu = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaIngredientes)).BeginInit();
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
            this.tabPage1.Controls.Add(this.medidaP);
            this.tabPage1.Controls.Add(this.categoriaP);
            this.tabPage1.Controls.Add(this.existenciaP);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.nombreP);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.modificarP);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1044, 512);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Productos";
            // 
            // claveP
            // 
            this.claveP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.claveP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.claveP.FormattingEnabled = true;
            this.claveP.Location = new System.Drawing.Point(516, 49);
            this.claveP.Name = "claveP";
            this.claveP.Size = new System.Drawing.Size(144, 25);
            this.claveP.TabIndex = 20;
            this.claveP.SelectedIndexChanged += new System.EventHandler(this.claveP_SelectedIndexChanged);
            // 
            // medidaP
            // 
            this.medidaP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.medidaP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.medidaP.Enabled = false;
            this.medidaP.FormattingEnabled = true;
            this.medidaP.Items.AddRange(new object[] {
            "GRAMOS",
            "KILOS",
            "LITROS",
            "MILIGRAMOS",
            "MILILITROS",
            "ONZAS",
            "PIEZAS"});
            this.medidaP.Location = new System.Drawing.Point(516, 260);
            this.medidaP.Name = "medidaP";
            this.medidaP.Size = new System.Drawing.Size(152, 25);
            this.medidaP.TabIndex = 19;
            // 
            // categoriaP
            // 
            this.categoriaP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoriaP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriaP.Enabled = false;
            this.categoriaP.FormattingEnabled = true;
            this.categoriaP.Items.AddRange(new object[] {
            "CARNES, PESCADOS Y HUEVOS",
            "CEREALES Y DERIVADOS, AZÚCAR Y DULCES",
            "FRUTAS",
            "GRASAS, ACEITE Y MANTEQUILLA",
            "LECHE Y DERIVADOS",
            "OTROS",
            "PATATAS, LEGUMBRES Y FRUTOS SECOS",
            "VERDURAS Y HORTALIZAS"});
            this.categoriaP.Location = new System.Drawing.Point(516, 194);
            this.categoriaP.Name = "categoriaP";
            this.categoriaP.Size = new System.Drawing.Size(306, 25);
            this.categoriaP.TabIndex = 18;
            // 
            // existenciaP
            // 
            this.existenciaP.Enabled = false;
            this.existenciaP.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.existenciaP.Location = new System.Drawing.Point(516, 330);
            this.existenciaP.MaxLength = 6;
            this.existenciaP.Name = "existenciaP";
            this.existenciaP.ShortcutsEnabled = false;
            this.existenciaP.Size = new System.Drawing.Size(152, 28);
            this.existenciaP.TabIndex = 15;
            this.existenciaP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.existenciaP_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label5.Location = new System.Drawing.Point(184, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(326, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Existencia actual del producto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label4.Location = new System.Drawing.Point(276, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Médida del producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label3.Location = new System.Drawing.Point(249, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Categoría del producto:";
            // 
            // nombreP
            // 
            this.nombreP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreP.Enabled = false;
            this.nombreP.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.nombreP.Location = new System.Drawing.Point(516, 120);
            this.nombreP.MaxLength = 45;
            this.nombreP.Name = "nombreP";
            this.nombreP.Size = new System.Drawing.Size(306, 28);
            this.nombreP.TabIndex = 9;
            this.nombreP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreP_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label2.Location = new System.Drawing.Point(269, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre del producto:";
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
            // modificarP
            // 
            this.modificarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modificarP.Enabled = false;
            this.modificarP.Image = global::InventariosVillaAlegre.Properties.Resources._16__Card_edit_;
            this.modificarP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.modificarP.Location = new System.Drawing.Point(440, 434);
            this.modificarP.Name = "modificarP";
            this.modificarP.Size = new System.Drawing.Size(165, 37);
            this.modificarP.TabIndex = 5;
            this.modificarP.Text = "Modificar producto";
            this.modificarP.UseVisualStyleBackColor = true;
            this.modificarP.Click += new System.EventHandler(this.modificarP_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::InventariosVillaAlegre.Properties.Resources.fondo;
            this.tabPage2.Controls.Add(this.tipoR);
            this.tabPage2.Controls.Add(this.claveR);
            this.tabPage2.Controls.Add(this.modificarR);
            this.tabPage2.Controls.Add(this.tablaIngredientes);
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
            this.tipoR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tipoR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoR.Enabled = false;
            this.tipoR.FormattingEnabled = true;
            this.tipoR.Items.AddRange(new object[] {
            "DESAYUNO",
            "COMIDA",
            "CENA",
            "GENERAL"});
            this.tipoR.Location = new System.Drawing.Point(252, 153);
            this.tipoR.Name = "tipoR";
            this.tipoR.Size = new System.Drawing.Size(182, 25);
            this.tipoR.TabIndex = 22;
            // 
            // claveR
            // 
            this.claveR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.claveR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.claveR.FormattingEnabled = true;
            this.claveR.Location = new System.Drawing.Point(252, 43);
            this.claveR.Name = "claveR";
            this.claveR.Size = new System.Drawing.Size(241, 25);
            this.claveR.TabIndex = 21;
            this.claveR.SelectedIndexChanged += new System.EventHandler(this.claveR_SelectedIndexChanged);
            // 
            // modificarR
            // 
            this.modificarR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modificarR.Enabled = false;
            this.modificarR.Image = global::InventariosVillaAlegre.Properties.Resources._16__Card_edit_;
            this.modificarR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.modificarR.Location = new System.Drawing.Point(229, 235);
            this.modificarR.Name = "modificarR";
            this.modificarR.Size = new System.Drawing.Size(165, 37);
            this.modificarR.TabIndex = 17;
            this.modificarR.Text = "Modificar receta";
            this.modificarR.UseVisualStyleBackColor = true;
            this.modificarR.Click += new System.EventHandler(this.modificarR_Click);
            // 
            // tablaIngredientes
            // 
            this.tablaIngredientes.AllowUserToAddRows = false;
            this.tablaIngredientes.AllowUserToDeleteRows = false;
            this.tablaIngredientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tablaIngredientes.BackgroundColor = System.Drawing.Color.White;
            this.tablaIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaIngredientes.Enabled = false;
            this.tablaIngredientes.Location = new System.Drawing.Point(614, 39);
            this.tablaIngredientes.Name = "tablaIngredientes";
            this.tablaIngredientes.Size = new System.Drawing.Size(400, 439);
            this.tablaIngredientes.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label8.Location = new System.Drawing.Point(54, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tipo de alimento:";
            // 
            // nombreR
            // 
            this.nombreR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreR.Enabled = false;
            this.nombreR.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.nombreR.Location = new System.Drawing.Point(252, 95);
            this.nombreR.MaxLength = 45;
            this.nombreR.Name = "nombreR";
            this.nombreR.Size = new System.Drawing.Size(306, 28);
            this.nombreR.TabIndex = 13;
            this.nombreR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreR_KeyPress);
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
            this.tabPage3.Controls.Add(this.modificarM);
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
            // claveM
            // 
            this.claveM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.claveM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.claveM.FormattingEnabled = true;
            this.claveM.Location = new System.Drawing.Point(475, 36);
            this.claveM.Name = "claveM";
            this.claveM.Size = new System.Drawing.Size(241, 25);
            this.claveM.TabIndex = 22;
            this.claveM.SelectedIndexChanged += new System.EventHandler(this.claveM_SelectedIndexChanged);
            // 
            // modificarM
            // 
            this.modificarM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modificarM.Enabled = false;
            this.modificarM.Image = global::InventariosVillaAlegre.Properties.Resources._16__Card_edit_;
            this.modificarM.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.modificarM.Location = new System.Drawing.Point(440, 412);
            this.modificarM.Name = "modificarM";
            this.modificarM.Size = new System.Drawing.Size(165, 37);
            this.modificarM.TabIndex = 18;
            this.modificarM.Text = "Modificar menú";
            this.modificarM.UseVisualStyleBackColor = true;
            this.modificarM.Click += new System.EventHandler(this.modificarM_Click);
            // 
            // nombreM
            // 
            this.nombreM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreM.Enabled = false;
            this.nombreM.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.nombreM.Location = new System.Drawing.Point(475, 107);
            this.nombreM.MaxLength = 45;
            this.nombreM.Name = "nombreM";
            this.nombreM.Size = new System.Drawing.Size(306, 28);
            this.nombreM.TabIndex = 13;
            this.nombreM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreM_KeyPress);
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
            this.tablaMenu.AllowUserToAddRows = false;
            this.tablaMenu.AllowUserToDeleteRows = false;
            this.tablaMenu.AllowUserToOrderColumns = true;
            this.tablaMenu.AllowUserToResizeColumns = false;
            this.tablaMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tablaMenu.BackgroundColor = System.Drawing.Color.White;
            this.tablaMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaMenu.Enabled = false;
            this.tablaMenu.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tablaMenu.Location = new System.Drawing.Point(6, 176);
            this.tablaMenu.Name = "tablaMenu";
            this.tablaMenu.Size = new System.Drawing.Size(1032, 160);
            this.tablaMenu.TabIndex = 5;
            // 
            // modificaciones
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
            this.Name = "modificaciones";
            this.Text = "modificaciones";
            this.Load += new System.EventHandler(this.modificaciones_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaIngredientes)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox existenciaP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombreP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button modificarP;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button modificarR;
        private System.Windows.Forms.DataGridView tablaIngredientes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nombreR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button modificarM;
        private System.Windows.Forms.TextBox nombreM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView tablaMenu;
        private System.Windows.Forms.ComboBox medidaP;
        private System.Windows.Forms.ComboBox categoriaP;
        private System.Windows.Forms.ComboBox claveP;
        private System.Windows.Forms.ComboBox claveR;
        private System.Windows.Forms.ComboBox tipoR;
        private System.Windows.Forms.ComboBox claveM;

    }
}