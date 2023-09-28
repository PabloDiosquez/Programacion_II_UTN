namespace Login
{
    partial class frm_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbx_usuario_nombre = new System.Windows.Forms.TextBox();
            this.tbx_usuario_pass = new System.Windows.Forms.TextBox();
            this.lb_usuario_nombre = new System.Windows.Forms.Label();
            this.lb_usuario_pass = new System.Windows.Forms.Label();
            this.lb_Login = new System.Windows.Forms.Label();
            this.btn_loguear = new System.Windows.Forms.Button();
            this.btn_completar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_usuario_nombre
            // 
            this.tbx_usuario_nombre.Location = new System.Drawing.Point(144, 68);
            this.tbx_usuario_nombre.Name = "tbx_usuario_nombre";
            this.tbx_usuario_nombre.PlaceholderText = "Nombre de usuario";
            this.tbx_usuario_nombre.Size = new System.Drawing.Size(162, 23);
            this.tbx_usuario_nombre.TabIndex = 1;
            // 
            // tbx_usuario_pass
            // 
            this.tbx_usuario_pass.Location = new System.Drawing.Point(144, 121);
            this.tbx_usuario_pass.Name = "tbx_usuario_pass";
            this.tbx_usuario_pass.PlaceholderText = "Contraseña usuario";
            this.tbx_usuario_pass.Size = new System.Drawing.Size(162, 23);
            this.tbx_usuario_pass.TabIndex = 2;
            // 
            // lb_usuario_nombre
            // 
            this.lb_usuario_nombre.AutoSize = true;
            this.lb_usuario_nombre.Font = new System.Drawing.Font("Sitka Small", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_usuario_nombre.Location = new System.Drawing.Point(34, 68);
            this.lb_usuario_nombre.Name = "lb_usuario_nombre";
            this.lb_usuario_nombre.Size = new System.Drawing.Size(64, 19);
            this.lb_usuario_nombre.TabIndex = 5;
            this.lb_usuario_nombre.Text = "Usuario";
            // 
            // lb_usuario_pass
            // 
            this.lb_usuario_pass.AutoSize = true;
            this.lb_usuario_pass.Font = new System.Drawing.Font("Sitka Small", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_usuario_pass.Location = new System.Drawing.Point(34, 121);
            this.lb_usuario_pass.Name = "lb_usuario_pass";
            this.lb_usuario_pass.Size = new System.Drawing.Size(76, 19);
            this.lb_usuario_pass.TabIndex = 6;
            this.lb_usuario_pass.Text = "Password";
            // 
            // lb_Login
            // 
            this.lb_Login.AutoSize = true;
            this.lb_Login.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Login.Location = new System.Drawing.Point(107, 9);
            this.lb_Login.Name = "lb_Login";
            this.lb_Login.Size = new System.Drawing.Size(99, 40);
            this.lb_Login.TabIndex = 0;
            this.lb_Login.Text = "Login";
            // 
            // btn_loguear
            // 
            this.btn_loguear.BackColor = System.Drawing.Color.Silver;
            this.btn_loguear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_loguear.Font = new System.Drawing.Font("Sitka Small", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_loguear.Location = new System.Drawing.Point(34, 177);
            this.btn_loguear.Name = "btn_loguear";
            this.btn_loguear.Size = new System.Drawing.Size(76, 29);
            this.btn_loguear.TabIndex = 3;
            this.btn_loguear.Text = "Loguear";
            this.btn_loguear.UseVisualStyleBackColor = false;
            this.btn_loguear.Click += new System.EventHandler(this.btn_loguear_Click);
            // 
            // btn_completar
            // 
            this.btn_completar.Font = new System.Drawing.Font("Sitka Small", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_completar.Location = new System.Drawing.Point(238, 268);
            this.btn_completar.Name = "btn_completar";
            this.btn_completar.Size = new System.Drawing.Size(85, 23);
            this.btn_completar.TabIndex = 4;
            this.btn_completar.Text = "Completar ";
            this.btn_completar.UseVisualStyleBackColor = true;
            this.btn_completar.Click += new System.EventHandler(this.btn_completar_Click);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 312);
            this.Controls.Add(this.btn_completar);
            this.Controls.Add(this.btn_loguear);
            this.Controls.Add(this.lb_Login);
            this.Controls.Add(this.lb_usuario_pass);
            this.Controls.Add(this.lb_usuario_nombre);
            this.Controls.Add(this.tbx_usuario_pass);
            this.Controls.Add(this.tbx_usuario_nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_usuario_nombre;
        private System.Windows.Forms.TextBox tbx_usuario_pass;
        private System.Windows.Forms.Label lb_usuario_nombre;
        private System.Windows.Forms.Label lb_usuario_pass;
        private System.Windows.Forms.Label lb_Login;
        private System.Windows.Forms.Button btn_loguear;
        private System.Windows.Forms.Button btn_completar;
    }
}
