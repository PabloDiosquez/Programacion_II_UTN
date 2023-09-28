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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 171);
            this.Controls.Add(this.btn_mensaje);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_mensaje;
    }
}
