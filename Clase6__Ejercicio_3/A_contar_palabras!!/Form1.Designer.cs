namespace A_contar_palabras__
{
    partial class frm_principal
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
            this.btn_calcular = new System.Windows.Forms.Button();
            this.rtb_contenedor = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_calcular
            // 
            this.btn_calcular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_calcular.AutoSize = true;
            this.btn_calcular.Location = new System.Drawing.Point(406, 410);
            this.btn_calcular.MaximumSize = new System.Drawing.Size(75, 25);
            this.btn_calcular.MinimumSize = new System.Drawing.Size(75, 25);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 25);
            this.btn_calcular.TabIndex = 0;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // rtb_contenedor
            // 
            this.rtb_contenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_contenedor.Location = new System.Drawing.Point(-3, -2);
            this.rtb_contenedor.Name = "rtb_contenedor";
            this.rtb_contenedor.Size = new System.Drawing.Size(494, 394);
            this.rtb_contenedor.TabIndex = 1;
            this.rtb_contenedor.Text = "";
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 445);
            this.Controls.Add(this.rtb_contenedor);
            this.Controls.Add(this.btn_calcular);
            this.Name = "frm_principal";
            this.Text = "Contador de palabras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.RichTextBox rtb_contenedor;
    }
}
