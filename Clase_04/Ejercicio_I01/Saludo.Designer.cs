namespace Ejercicio_I01
{
    partial class Saludo
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
            this.lb_saludo = new System.Windows.Forms.Label();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_saludo
            // 
            this.lb_saludo.AutoSize = true;
            this.lb_saludo.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_saludo.Location = new System.Drawing.Point(12, 34);
            this.lb_saludo.Name = "lb_saludo";
            this.lb_saludo.Size = new System.Drawing.Size(219, 25);
            this.lb_saludo.TabIndex = 0;
            this.lb_saludo.Text = "¡Hola, Windows Forms!";
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_nombre.Location = new System.Drawing.Point(12, 79);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(0, 21);
            this.lb_nombre.TabIndex = 1;
            // 
            // Saludo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 164);
            this.Controls.Add(this.lb_nombre);
            this.Controls.Add(this.lb_saludo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Saludo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saludo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Saludo_FormClosing);
            this.Load += new System.EventHandler(this.Saludo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_saludo;
        private System.Windows.Forms.Label lb_nombre;
    }
}