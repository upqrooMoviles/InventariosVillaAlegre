namespace InventariosVillaAlegre
{
    partial class reportesCorreo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reportesCorreo));
            this.rutaarchivo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mensaje = new System.Windows.Forms.TextBox();
            this.asuntoenviar = new System.Windows.Forms.TextBox();
            this.correoenviar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enviar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rutaarchivo
            // 
            this.rutaarchivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rutaarchivo.Location = new System.Drawing.Point(104, 178);
            this.rutaarchivo.Name = "rutaarchivo";
            this.rutaarchivo.ReadOnly = true;
            this.rutaarchivo.Size = new System.Drawing.Size(296, 31);
            this.rutaarchivo.TabIndex = 89;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(7, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 22);
            this.label4.TabIndex = 88;
            this.label4.Text = "Archivo:";
            // 
            // mensaje
            // 
            this.mensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mensaje.Location = new System.Drawing.Point(104, 225);
            this.mensaje.MaxLength = 150;
            this.mensaje.Multiline = true;
            this.mensaje.Name = "mensaje";
            this.mensaje.Size = new System.Drawing.Size(296, 111);
            this.mensaje.TabIndex = 86;
            // 
            // asuntoenviar
            // 
            this.asuntoenviar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.asuntoenviar.Location = new System.Drawing.Point(104, 134);
            this.asuntoenviar.MaxLength = 45;
            this.asuntoenviar.Name = "asuntoenviar";
            this.asuntoenviar.Size = new System.Drawing.Size(296, 31);
            this.asuntoenviar.TabIndex = 85;
            // 
            // correoenviar
            // 
            this.correoenviar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.correoenviar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.correoenviar.Location = new System.Drawing.Point(104, 91);
            this.correoenviar.MaxLength = 45;
            this.correoenviar.Name = "correoenviar";
            this.correoenviar.Size = new System.Drawing.Size(296, 31);
            this.correoenviar.TabIndex = 84;
            this.correoenviar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.correoenviar_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(7, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 83;
            this.label3.Text = "Mensaje:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(7, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 82;
            this.label2.Text = "Asunto:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::InventariosVillaAlegre.Properties.Resources.logo_villa_alegre_21;
            this.pictureBox1.Location = new System.Drawing.Point(90, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(7, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 80;
            this.label1.Text = "Para:";
            // 
            // enviar
            // 
            this.enviar.Image = global::InventariosVillaAlegre.Properties.Resources._16__At_;
            this.enviar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.enviar.Location = new System.Drawing.Point(260, 342);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(106, 40);
            this.enviar.TabIndex = 90;
            this.enviar.Text = "Enviar";
            this.enviar.UseVisualStyleBackColor = true;
            this.enviar.Click += new System.EventHandler(this.enviar_Click);
            // 
            // reportesCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InventariosVillaAlegre.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(406, 394);
            this.Controls.Add(this.enviar);
            this.Controls.Add(this.rutaarchivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mensaje);
            this.Controls.Add(this.asuntoenviar);
            this.Controls.Add(this.correoenviar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "reportesCorreo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enviar reporte por correo";
            this.Load += new System.EventHandler(this.reportesCorreo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rutaarchivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mensaje;
        private System.Windows.Forms.TextBox asuntoenviar;
        private System.Windows.Forms.TextBox correoenviar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enviar;
    }
}