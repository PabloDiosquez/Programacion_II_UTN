namespace WinFormsApp
{
    partial class Form1
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
            this.btn_mensaje = new System.Windows.Forms.Button();
            this.tbx_usuario = new System.Windows.Forms.TextBox();
            this.lb_usuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_mensaje
            // 
            this.btn_mensaje.BackColor = System.Drawing.SystemColors.Control;
            this.btn_mensaje.Location = new System.Drawing.Point(57, 119);
            this.btn_mensaje.Name = "btn_mensaje";
            this.btn_mensaje.Size = new System.Drawing.Size(75, 23);
            this.btn_mensaje.TabIndex = 0;
            this.btn_mensaje.Text = "Mensaje";
            this.btn_mensaje.UseVisualStyleBackColor = false;
            this.btn_mensaje.Click += new System.EventHandler(this.btn_mensaje_Click);
            // 
            // tbx_usuario
            // 
            this.tbx_usuario.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbx_usuario.ForeColor = System.Drawing.Color.Gray;
            this.tbx_usuario.Location = new System.Drawing.Point(65, 37);
            this.tbx_usuario.Name = "tbx_usuario";
            this.tbx_usuario.PlaceholderText = "Nombre de Usuario";
            this.tbx_usuario.Size = new System.Drawing.Size(125, 23);
            this.tbx_usuario.TabIndex = 1;
            // 
            // lb_usuario
            // 
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_usuario.Location = new System.Drawing.Point(12, 37);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(49, 15);
            this.lb_usuario.TabIndex = 2;
            this.lb_usuario.Text = "Usuario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 177);
            this.Controls.Add(this.lb_usuario);
            this.Controls.Add(this.tbx_usuario);
            this.Controls.Add(this.btn_mensaje);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_mensaje;
        private System.Windows.Forms.TextBox tbx_usuario;
        private System.Windows.Forms.Label lb_usuario;
    }
}
