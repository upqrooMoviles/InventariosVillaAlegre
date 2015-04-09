namespace InventariosVillaAlegre
{
    partial class olvidarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(olvidarContraseña));
            this.enviarcontraseña = new System.Windows.Forms.Button();
            this.mail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enviarcontraseña
            // 
            this.enviarcontraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enviarcontraseña.Image = global::InventariosVillaAlegre.Properties.Resources._16__At_;
            this.enviarcontraseña.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.enviarcontraseña.Location = new System.Drawing.Point(168, 175);
            this.enviarcontraseña.Name = "enviarcontraseña";
            this.enviarcontraseña.Size = new System.Drawing.Size(168, 49);
            this.enviarcontraseña.TabIndex = 127;
            this.enviarcontraseña.Text = "Enviar por correo";
            this.enviarcontraseña.UseVisualStyleBackColor = true;
            this.enviarcontraseña.Click += new System.EventHandler(this.enviarcontraseña_Click);
            // 
            // mail
            // 
            this.mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail.Location = new System.Drawing.Point(201, 124);
            this.mail.MaxLength = 45;
            this.mail.Name = "mail";
            this.mail.ShortcutsEnabled = false;
            this.mail.Size = new System.Drawing.Size(264, 31);
            this.mail.TabIndex = 126;
            this.mail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mail_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 22);
            this.label10.TabIndex = 125;
            this.label10.Text = "Correo Electronico:";
            // 
            // user
            // 
            this.user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.user.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(201, 72);
            this.user.MaxLength = 10;
            this.user.Name = "user";
            this.user.ShortcutsEnabled = false;
            this.user.Size = new System.Drawing.Size(264, 31);
            this.user.TabIndex = 129;
            this.user.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.user_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 22);
            this.label9.TabIndex = 128;
            this.label9.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 44);
            this.label1.TabIndex = 130;
            this.label1.Text = "Ingrese su usuario y coreo dado de alta\r\nen el sistema para enviar su contraseña." +
    "\r\n";
            // 
            // olvidarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InventariosVillaAlegre.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(493, 236);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.enviarcontraseña);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "olvidarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enviar contraseña por correo";
            this.Load += new System.EventHandler(this.olvidarContraseña_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enviarcontraseña;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;

    }
}