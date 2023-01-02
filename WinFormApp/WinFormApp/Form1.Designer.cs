namespace WinFormApp
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
            this.btnMostrarTexto = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMostrarTexto
            // 
            this.btnMostrarTexto.Location = new System.Drawing.Point(186, 227);
            this.btnMostrarTexto.Name = "btnMostrarTexto";
            this.btnMostrarTexto.Size = new System.Drawing.Size(188, 23);
            this.btnMostrarTexto.TabIndex = 0;
            this.btnMostrarTexto.Text = "Mostrar texto";
            this.btnMostrarTexto.UseVisualStyleBackColor = true;
            this.btnMostrarTexto.Click += new System.EventHandler(this.btnMostrarTexto_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTexto.Location = new System.Drawing.Point(202, 119);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(149, 25);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = "Texto de prueba";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 406);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.btnMostrarTexto);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarTexto;
        private System.Windows.Forms.Label lblTexto;
    }
}
