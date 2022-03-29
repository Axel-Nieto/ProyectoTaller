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
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(304, 461);
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
    }
}

