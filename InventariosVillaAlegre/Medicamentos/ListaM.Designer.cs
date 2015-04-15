namespace InventariosVillaAlegre.Medicamentos
{
    partial class ListaM
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
            this.enviar = new System.Windows.Forms.Button();
            this.archivo = new System.Windows.Forms.Button();
            this.medicamentos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.claveP = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // enviar
            // 
            this.enviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enviar.Image = global::InventariosVillaAlegre.Properties.Resources._16__At_;
            this.enviar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.enviar.Location = new System.Drawing.Point(716, 430);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(141, 37);
            this.enviar.TabIndex = 174;
            this.enviar.Text = "Enviar por correo";
            this.enviar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.enviar.UseVisualStyleBackColor = true;
            // 
            // archivo
            // 
            this.archivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.archivo.Image = global::InventariosVillaAlegre.Properties.Resources._16__Align_full_4_;
            this.archivo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.archivo.Location = new System.Drawing.Point(517, 430);
            this.archivo.Name = "archivo";
            this.archivo.Size = new System.Drawing.Size(139, 37);
            this.archivo.TabIndex = 173;
            this.archivo.Text = "Generar archivo";
            this.archivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.archivo.UseVisualStyleBackColor = true;
            // 
            // medicamentos
            // 
            this.medicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicamentos.Location = new System.Drawing.Point(12, 82);
            this.medicamentos.Name = "medicamentos";
            this.medicamentos.Size = new System.Drawing.Size(884, 330);
            this.medicamentos.TabIndex = 172;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 22);
            this.label5.TabIndex = 176;
            this.label5.Text = "Pertenencia: ";
            // 
            // claveP
            // 
            this.claveP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.claveP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.claveP.FormattingEnabled = true;
            this.claveP.Location = new System.Drawing.Point(173, 27);
            this.claveP.Name = "claveP";
            this.claveP.Size = new System.Drawing.Size(241, 21);
            this.claveP.TabIndex = 175;
            // 
            // ListaM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InventariosVillaAlegre.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(921, 489);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.claveP);
            this.Controls.Add(this.enviar);
            this.Controls.Add(this.archivo);
            this.Controls.Add(this.medicamentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaM";
            this.Text = "ListaM";
            ((System.ComponentModel.ISupportInitialize)(this.medicamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.Button archivo;
        private System.Windows.Forms.DataGridView medicamentos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox claveP;
    }
}