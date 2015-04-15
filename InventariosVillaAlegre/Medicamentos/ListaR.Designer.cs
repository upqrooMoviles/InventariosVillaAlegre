namespace InventariosVillaAlegre.Medicamentos
{
    partial class ListaR
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
            ((System.ComponentModel.ISupportInitialize)(this.medicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // enviar
            // 
            this.enviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enviar.Image = global::InventariosVillaAlegre.Properties.Resources._16__At_;
            this.enviar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.enviar.Location = new System.Drawing.Point(719, 430);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(141, 37);
            this.enviar.TabIndex = 177;
            this.enviar.Text = "Enviar por correo";
            this.enviar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.enviar.UseVisualStyleBackColor = true;
            // 
            // archivo
            // 
            this.archivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.archivo.Image = global::InventariosVillaAlegre.Properties.Resources._16__Align_full_4_;
            this.archivo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.archivo.Location = new System.Drawing.Point(520, 430);
            this.archivo.Name = "archivo";
            this.archivo.Size = new System.Drawing.Size(139, 37);
            this.archivo.TabIndex = 176;
            this.archivo.Text = "Generar archivo";
            this.archivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.archivo.UseVisualStyleBackColor = true;
            // 
            // medicamentos
            // 
            this.medicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicamentos.Location = new System.Drawing.Point(12, 35);
            this.medicamentos.Name = "medicamentos";
            this.medicamentos.Size = new System.Drawing.Size(884, 374);
            this.medicamentos.TabIndex = 175;
            // 
            // ListaR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InventariosVillaAlegre.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(921, 489);
            this.Controls.Add(this.enviar);
            this.Controls.Add(this.archivo);
            this.Controls.Add(this.medicamentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaR";
            this.Text = "ListaR";
            ((System.ComponentModel.ISupportInitialize)(this.medicamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.Button archivo;
        private System.Windows.Forms.DataGridView medicamentos;
    }
}