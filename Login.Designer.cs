namespace ProyectoTaller
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TextboxUsuario = new System.Windows.Forms.TextBox();
            this.FakeflixLogo = new System.Windows.Forms.PictureBox();
            this.TextboxPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FakeflixLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // TextboxUsuario
            // 
            this.TextboxUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextboxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxUsuario.ForeColor = System.Drawing.Color.DarkGray;
            this.TextboxUsuario.Location = new System.Drawing.Point(39, 117);
            this.TextboxUsuario.Name = "TextboxUsuario";
            this.TextboxUsuario.Size = new System.Drawing.Size(220, 22);
            this.TextboxUsuario.TabIndex = 0;
            this.TextboxUsuario.Text = "Nombre de usuario";
            this.TextboxUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FakeflixLogo
            // 
            this.FakeflixLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.FakeflixLogo.Image = global::ProyectoTaller.Properties.Resources.Fakeflix_logo;
            this.FakeflixLogo.Location = new System.Drawing.Point(9, 12);
            this.FakeflixLogo.Name = "FakeflixLogo";
            this.FakeflixLogo.Size = new System.Drawing.Size(280, 53);
            this.FakeflixLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FakeflixLogo.TabIndex = 1;
            this.FakeflixLogo.TabStop = false;
            // 
            // TextboxPassword
            // 
            this.TextboxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextboxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.TextboxPassword.Location = new System.Drawing.Point(39, 167);
            this.TextboxPassword.Name = "TextboxPassword";
            this.TextboxPassword.Size = new System.Drawing.Size(220, 22);
            this.TextboxPassword.TabIndex = 2;
            this.TextboxPassword.Text = "Contraseña";
            this.TextboxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextboxPassword.UseSystemPasswordChar = true;
            this.TextboxPassword.TextChanged += new System.EventHandler(this.TextboxPassword_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(9)))), ((int)(((byte)(19)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(105, 257);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "INGRESAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(304, 332);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextboxPassword);
            this.Controls.Add(this.FakeflixLogo);
            this.Controls.Add(this.TextboxUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.FakeflixLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextboxUsuario;
        private System.Windows.Forms.PictureBox FakeflixLogo;
        private System.Windows.Forms.TextBox TextboxPassword;
        private System.Windows.Forms.Button button1;
    }
}

