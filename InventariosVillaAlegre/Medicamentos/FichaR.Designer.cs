namespace InventariosVillaAlegre.Medicamentos
{
    partial class FichaR
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
            this.nick = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.observaciones = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.padecimientos = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.protocolo = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contacto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.TextBox();
            this.medicamentos = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.enviar = new System.Windows.Forms.Button();
            this.archivo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // nick
            // 
            this.nick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nick.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nick.FormattingEnabled = true;
            this.nick.Location = new System.Drawing.Point(153, 12);
            this.nick.Name = "nick";
            this.nick.Size = new System.Drawing.Size(241, 21);
            this.nick.TabIndex = 152;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 22);
            this.label1.TabIndex = 151;
            this.label1.Text = "Nick personal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(581, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 22);
            this.label5.TabIndex = 166;
            this.label5.Text = "Observaciones:";
            // 
            // observaciones
            // 
            this.observaciones.Location = new System.Drawing.Point(585, 124);
            this.observaciones.Name = "observaciones";
            this.observaciones.ReadOnly = true;
            this.observaciones.Size = new System.Drawing.Size(327, 67);
            this.observaciones.TabIndex = 165;
            this.observaciones.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 22);
            this.label4.TabIndex = 164;
            this.label4.Text = "Padecimientos:";
            // 
            // padecimientos
            // 
            this.padecimientos.Location = new System.Drawing.Point(266, 173);
            this.padecimientos.Name = "padecimientos";
            this.padecimientos.ReadOnly = true;
            this.padecimientos.Size = new System.Drawing.Size(309, 64);
            this.padecimientos.TabIndex = 163;
            this.padecimientos.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 22);
            this.label3.TabIndex = 162;
            this.label3.Text = "Protocolo de emergencia:";
            // 
            // protocolo
            // 
            this.protocolo.Location = new System.Drawing.Point(266, 103);
            this.protocolo.Name = "protocolo";
            this.protocolo.ReadOnly = true;
            this.protocolo.Size = new System.Drawing.Size(309, 64);
            this.protocolo.TabIndex = 161;
            this.protocolo.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 22);
            this.label2.TabIndex = 160;
            this.label2.Text = "Fecha de nacimiento:";
            // 
            // contacto
            // 
            this.contacto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.contacto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contacto.Location = new System.Drawing.Point(624, 52);
            this.contacto.MaxLength = 45;
            this.contacto.Name = "contacto";
            this.contacto.ReadOnly = true;
            this.contacto.ShortcutsEnabled = false;
            this.contacto.Size = new System.Drawing.Size(285, 31);
            this.contacto.TabIndex = 158;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(366, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(252, 22);
            this.label10.TabIndex = 157;
            this.label10.Text = "Contacto de emergencia:";
            // 
            // nombre
            // 
            this.nombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(504, 12);
            this.nombre.MaxLength = 45;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Size = new System.Drawing.Size(405, 31);
            this.nombre.TabIndex = 154;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(406, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 22);
            this.label6.TabIndex = 153;
            this.label6.Text = "Nombre:";
            // 
            // fecha
            // 
            this.fecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.fecha.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Location = new System.Drawing.Point(224, 52);
            this.fecha.MaxLength = 10;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.ShortcutsEnabled = false;
            this.fecha.Size = new System.Drawing.Size(141, 31);
            this.fecha.TabIndex = 167;
            // 
            // medicamentos
            // 
            this.medicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicamentos.Location = new System.Drawing.Point(17, 256);
            this.medicamentos.Name = "medicamentos";
            this.medicamentos.Size = new System.Drawing.Size(884, 150);
            this.medicamentos.TabIndex = 168;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 22);
            this.label7.TabIndex = 169;
            this.label7.Text = "Medicamentos:";
            // 
            // enviar
            // 
            this.enviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enviar.Image = global::InventariosVillaAlegre.Properties.Resources._16__At_;
            this.enviar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.enviar.Location = new System.Drawing.Point(760, 427);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(141, 37);
            this.enviar.TabIndex = 171;
            this.enviar.Text = "Enviar por correo";
            this.enviar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.enviar.UseVisualStyleBackColor = true;
            // 
            // archivo
            // 
            this.archivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.archivo.Image = global::InventariosVillaAlegre.Properties.Resources._16__Align_full_4_;
            this.archivo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.archivo.Location = new System.Drawing.Point(565, 427);
            this.archivo.Name = "archivo";
            this.archivo.Size = new System.Drawing.Size(139, 37);
            this.archivo.TabIndex = 170;
            this.archivo.Text = "Generar archivo";
            this.archivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.archivo.UseVisualStyleBackColor = true;
            // 
            // FichaR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InventariosVillaAlegre.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(921, 489);
            this.Controls.Add(this.enviar);
            this.Controls.Add(this.archivo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.medicamentos);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.observaciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.padecimientos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.protocolo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contacto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nick);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FichaR";
            this.Text = "FichaR";
            ((System.ComponentModel.ISupportInitialize)(this.medicamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox nick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox observaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox padecimientos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox protocolo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox contacto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fecha;
        private System.Windows.Forms.DataGridView medicamentos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.Button archivo;
    }
}