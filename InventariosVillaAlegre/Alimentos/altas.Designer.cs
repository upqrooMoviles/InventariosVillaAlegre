namespace InventariosVillaAlegre
{
    partial class altas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(altas));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.medidaP = new System.Windows.Forms.ComboBox();
            this.categoriaP = new System.Windows.Forms.ComboBox();
            this.existenciaP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nombreP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.claveP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.altaP = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.finalizarR = new System.Windows.Forms.Button();
            this.cantidadingrediente = new System.Windows.Forms.TextBox();
            this.labelMedida = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxIngredientes = new System.Windows.Forms.ComboBox();
            this.añadiringrediente = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.altaR = new System.Windows.Forms.Button();
            this.tipoR = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nombreR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.claveR = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.altaM = new System.Windows.Forms.Button();
            this.nombreM = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.claveM = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.menuSemanal = new System.Windows.Forms.DataGridView();
            this.listaIngredientes = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuSemanal)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1052, 542);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImage = global::InventariosVillaAlegre.Properties.Resources.fondo;
            this.tabPage1.Controls.Add(this.medidaP);
            this.tabPage1.Controls.Add(this.categoriaP);
            this.tabPage1.Controls.Add(this.existenciaP);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.nombreP);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.claveP);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.altaP);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1044, 512);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Productos";
            // 
            // medidaP
            // 
            this.medidaP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.medidaP.FormattingEnabled = true;
            this.medidaP.Items.AddRange(new object[] {
            "GRAMOS",
            "KILOS",
            "LITROS",
            "MILIGRAMOS",
            "MILILITROS",
            "ONZAS",
            "PIEZAS"});
            this.medidaP.Location = new System.Drawing.Point(516, 255);
            this.medidaP.Name = "medidaP";
            this.medidaP.Size = new System.Drawing.Size(152, 25);
            this.medidaP.TabIndex = 17;
            // 
            // categoriaP
            // 
            this.categoriaP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.categoriaP.Location = new System.Drawing.Point(516, 189);
            this.categoriaP.Name = "categoriaP";
            this.categoriaP.Size = new System.Drawing.Size(306, 25);
            this.categoriaP.TabIndex = 16;
            // 
            // existenciaP
            // 
            this.existenciaP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.existenciaP.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.existenciaP.Location = new System.Drawing.Point(516, 330);
            this.existenciaP.MaxLength = 6;
            this.existenciaP.Name = "existenciaP";
            this.existenciaP.ShortcutsEnabled = false;
            this.existenciaP.Size = new System.Drawing.Size(89, 28);
            this.existenciaP.TabIndex = 15;
            this.existenciaP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.existencia_KeyPress);
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
            this.nombreP.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.nombreP.Location = new System.Drawing.Point(516, 120);
            this.nombreP.MaxLength = 45;
            this.nombreP.Name = "nombreP";
            this.nombreP.Size = new System.Drawing.Size(306, 28);
            this.nombreP.TabIndex = 9;
            this.nombreP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombe_KeyPress);
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
            // claveP
            // 
            this.claveP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.claveP.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.claveP.Location = new System.Drawing.Point(516, 50);
            this.claveP.MaxLength = 10;
            this.claveP.Name = "claveP";
            this.claveP.ShortcutsEnabled = false;
            this.claveP.Size = new System.Drawing.Size(152, 28);
            this.claveP.TabIndex = 7;
            this.claveP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clave_KeyPress);
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
            // altaP
            // 
            this.altaP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.altaP.Image = global::InventariosVillaAlegre.Properties.Resources._16__Contents_;
            this.altaP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.altaP.Location = new System.Drawing.Point(440, 434);
            this.altaP.Name = "altaP";
            this.altaP.Size = new System.Drawing.Size(154, 35);
            this.altaP.TabIndex = 5;
            this.altaP.Text = "Alta de producto";
            this.altaP.UseVisualStyleBackColor = true;
            this.altaP.Click += new System.EventHandler(this.altaP_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::InventariosVillaAlegre.Properties.Resources.fondo;
            this.tabPage2.Controls.Add(this.listaIngredientes);
            this.tabPage2.Controls.Add(this.finalizarR);
            this.tabPage2.Controls.Add(this.cantidadingrediente);
            this.tabPage2.Controls.Add(this.labelMedida);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.comboBoxIngredientes);
            this.tabPage2.Controls.Add(this.añadiringrediente);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.altaR);
            this.tabPage2.Controls.Add(this.tipoR);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.nombreR);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.claveR);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1044, 512);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Recetas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // finalizarR
            // 
            this.finalizarR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finalizarR.Image = global::InventariosVillaAlegre.Properties.Resources._16__Address_book_;
            this.finalizarR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.finalizarR.Location = new System.Drawing.Point(363, 220);
            this.finalizarR.Name = "finalizarR";
            this.finalizarR.Size = new System.Drawing.Size(165, 37);
            this.finalizarR.TabIndex = 26;
            this.finalizarR.Text = "Finalizar Receta";
            this.finalizarR.UseVisualStyleBackColor = true;
            this.finalizarR.Visible = false;
            this.finalizarR.Click += new System.EventHandler(this.finalizarR_Click);
            // 
            // cantidadingrediente
            // 
            this.cantidadingrediente.Enabled = false;
            this.cantidadingrediente.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.cantidadingrediente.Location = new System.Drawing.Point(773, 49);
            this.cantidadingrediente.MaxLength = 6;
            this.cantidadingrediente.Name = "cantidadingrediente";
            this.cantidadingrediente.ShortcutsEnabled = false;
            this.cantidadingrediente.Size = new System.Drawing.Size(93, 28);
            this.cantidadingrediente.TabIndex = 24;
            this.cantidadingrediente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidadingrediente_KeyPress);
            // 
            // labelMedida
            // 
            this.labelMedida.AutoSize = true;
            this.labelMedida.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.labelMedida.Location = new System.Drawing.Point(898, 53);
            this.labelMedida.Name = "labelMedida";
            this.labelMedida.Size = new System.Drawing.Size(0, 24);
            this.labelMedida.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label13.Location = new System.Drawing.Point(769, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 24);
            this.label13.TabIndex = 22;
            this.label13.Text = "Cantidad:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label12.Location = new System.Drawing.Point(597, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 24);
            this.label12.TabIndex = 21;
            this.label12.Text = "Ingrediente:";
            // 
            // comboBoxIngredientes
            // 
            this.comboBoxIngredientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxIngredientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIngredientes.Enabled = false;
            this.comboBoxIngredientes.FormattingEnabled = true;
            this.comboBoxIngredientes.Items.AddRange(new object[] {
            "Desayuno",
            "Comida",
            "Cena",
            "General"});
            this.comboBoxIngredientes.Location = new System.Drawing.Point(601, 53);
            this.comboBoxIngredientes.Name = "comboBoxIngredientes";
            this.comboBoxIngredientes.Size = new System.Drawing.Size(150, 25);
            this.comboBoxIngredientes.TabIndex = 20;
            this.comboBoxIngredientes.SelectedIndexChanged += new System.EventHandler(this.comboBoxIngredientes_SelectedIndexChanged);
            // 
            // añadiringrediente
            // 
            this.añadiringrediente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.añadiringrediente.Enabled = false;
            this.añadiringrediente.Image = global::InventariosVillaAlegre.Properties.Resources._16__Plus_favorites_;
            this.añadiringrediente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.añadiringrediente.Location = new System.Drawing.Point(715, 109);
            this.añadiringrediente.Name = "añadiringrediente";
            this.añadiringrediente.Size = new System.Drawing.Size(165, 37);
            this.añadiringrediente.TabIndex = 19;
            this.añadiringrediente.Text = "Añadir ingrediente";
            this.añadiringrediente.UseVisualStyleBackColor = true;
            this.añadiringrediente.Click += new System.EventHandler(this.añadiringrediente_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label11.Location = new System.Drawing.Point(597, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(222, 24);
            this.label11.TabIndex = 18;
            this.label11.Text = "Lista de Ingredientes:";
            // 
            // altaR
            // 
            this.altaR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.altaR.Enabled = false;
            this.altaR.Image = global::InventariosVillaAlegre.Properties.Resources._16__Contents_;
            this.altaR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.altaR.Location = new System.Drawing.Point(166, 220);
            this.altaR.Name = "altaR";
            this.altaR.Size = new System.Drawing.Size(165, 37);
            this.altaR.TabIndex = 17;
            this.altaR.Text = "Alta de receta";
            this.altaR.UseVisualStyleBackColor = true;
            this.altaR.Click += new System.EventHandler(this.altaR_Click);
            // 
            // tipoR
            // 
            this.tipoR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tipoR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoR.FormattingEnabled = true;
            this.tipoR.Items.AddRange(new object[] {
            "DESAYUNO",
            "COMIDA",
            "CENA",
            "GENERAL"});
            this.tipoR.Location = new System.Drawing.Point(252, 153);
            this.tipoR.Name = "tipoR";
            this.tipoR.Size = new System.Drawing.Size(182, 25);
            this.tipoR.TabIndex = 15;
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
            // claveR
            // 
            this.claveR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.claveR.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.claveR.Location = new System.Drawing.Point(252, 39);
            this.claveR.MaxLength = 15;
            this.claveR.Name = "claveR";
            this.claveR.ShortcutsEnabled = false;
            this.claveR.Size = new System.Drawing.Size(194, 28);
            this.claveR.TabIndex = 11;
            this.claveR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.claveR_KeyPress);
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
            this.tabPage3.Controls.Add(this.altaM);
            this.tabPage3.Controls.Add(this.nombreM);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.claveM);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.menuSemanal);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1044, 512);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Menús";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // altaM
            // 
            this.altaM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.altaM.Image = global::InventariosVillaAlegre.Properties.Resources._16__Contents_;
            this.altaM.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.altaM.Location = new System.Drawing.Point(541, 454);
            this.altaM.Name = "altaM";
            this.altaM.Size = new System.Drawing.Size(165, 37);
            this.altaM.TabIndex = 18;
            this.altaM.Text = "Alta de menú";
            this.altaM.UseVisualStyleBackColor = true;
            this.altaM.Click += new System.EventHandler(this.altaM_Click);
            // 
            // nombreM
            // 
            this.nombreM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreM.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.nombreM.Location = new System.Drawing.Point(475, 107);
            this.nombreM.MaxLength = 45;
            this.nombreM.Name = "nombreM";
            this.nombreM.Size = new System.Drawing.Size(337, 28);
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
            // claveM
            // 
            this.claveM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.claveM.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.claveM.Location = new System.Drawing.Point(475, 37);
            this.claveM.MaxLength = 20;
            this.claveM.Name = "claveM";
            this.claveM.Size = new System.Drawing.Size(220, 28);
            this.claveM.TabIndex = 11;
            this.claveM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.claveM_KeyPress);
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
            // menuSemanal
            // 
            this.menuSemanal.AllowUserToAddRows = false;
            this.menuSemanal.AllowUserToDeleteRows = false;
            this.menuSemanal.AllowUserToOrderColumns = true;
            this.menuSemanal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.menuSemanal.BackgroundColor = System.Drawing.Color.White;
            this.menuSemanal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuSemanal.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuSemanal.Location = new System.Drawing.Point(164, 173);
            this.menuSemanal.Name = "menuSemanal";
            this.menuSemanal.Size = new System.Drawing.Size(704, 275);
            this.menuSemanal.TabIndex = 5;
            // 
            // listaIngredientes
            // 
            this.listaIngredientes.Enabled = false;
            this.listaIngredientes.Location = new System.Drawing.Point(601, 227);
            this.listaIngredientes.Name = "listaIngredientes";
            this.listaIngredientes.Size = new System.Drawing.Size(297, 273);
            this.listaIngredientes.TabIndex = 27;
            this.listaIngredientes.Text = "";
            // 
            // altas
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
            this.Name = "altas";
            this.Text = "altas";
            this.Load += new System.EventHandler(this.altas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuSemanal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button altaP;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox existenciaP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombreP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox claveP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button altaR;
        private System.Windows.Forms.ComboBox tipoR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nombreR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox claveR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView menuSemanal;
        private System.Windows.Forms.Button altaM;
        private System.Windows.Forms.TextBox nombreM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox claveM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox medidaP;
        private System.Windows.Forms.ComboBox categoriaP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox cantidadingrediente;
        private System.Windows.Forms.Label labelMedida;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxIngredientes;
        private System.Windows.Forms.Button añadiringrediente;
        private System.Windows.Forms.Button finalizarR;
        private System.Windows.Forms.RichTextBox listaIngredientes;
    }
}