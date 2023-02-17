namespace Atrapame_si_puedes
{
    partial class frm_calculador
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
            this.tbx_litros = new System.Windows.Forms.TextBox();
            this.tbx_kilometros = new System.Windows.Forms.TextBox();
            this.lbl_kilometros = new System.Windows.Forms.Label();
            this.lbl_litros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(12, 166);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(168, 36);
            this.btn_calcular.TabIndex = 0;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // rtb_contenedor
            // 
            this.rtb_contenedor.Location = new System.Drawing.Point(269, 12);
            this.rtb_contenedor.Name = "rtb_contenedor";
            this.rtb_contenedor.ReadOnly = true;
            this.rtb_contenedor.Size = new System.Drawing.Size(182, 180);
            this.rtb_contenedor.TabIndex = 1;
            this.rtb_contenedor.Text = "";
            // 
            // tbx_litros
            // 
            this.tbx_litros.Location = new System.Drawing.Point(15, 120);
            this.tbx_litros.Name = "tbx_litros";
            this.tbx_litros.Size = new System.Drawing.Size(165, 23);
            this.tbx_litros.TabIndex = 2;
            // 
            // tbx_kilometros
            // 
            this.tbx_kilometros.Location = new System.Drawing.Point(12, 54);
            this.tbx_kilometros.Name = "tbx_kilometros";
            this.tbx_kilometros.Size = new System.Drawing.Size(165, 23);
            this.tbx_kilometros.TabIndex = 3;
            // 
            // lbl_kilometros
            // 
            this.lbl_kilometros.AutoSize = true;
            this.lbl_kilometros.Location = new System.Drawing.Point(12, 25);
            this.lbl_kilometros.Name = "lbl_kilometros";
            this.lbl_kilometros.Size = new System.Drawing.Size(64, 15);
            this.lbl_kilometros.TabIndex = 4;
            this.lbl_kilometros.Text = "Kilómetros";
            // 
            // lbl_litros
            // 
            this.lbl_litros.AutoSize = true;
            this.lbl_litros.Location = new System.Drawing.Point(15, 89);
            this.lbl_litros.Name = "lbl_litros";
            this.lbl_litros.Size = new System.Drawing.Size(36, 15);
            this.lbl_litros.TabIndex = 5;
            this.lbl_litros.Text = "Litros";
            // 
            // frm_calculador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(463, 214);
            this.Controls.Add(this.lbl_litros);
            this.Controls.Add(this.lbl_kilometros);
            this.Controls.Add(this.tbx_kilometros);
            this.Controls.Add(this.tbx_litros);
            this.Controls.Add(this.rtb_contenedor);
            this.Controls.Add(this.btn_calcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(479, 253);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(479, 253);
            this.Name = "frm_calculador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.RichTextBox rtb_contenedor;
        private System.Windows.Forms.TextBox tbx_litros;
        private System.Windows.Forms.TextBox tbx_kilometros;
        private System.Windows.Forms.Label lbl_kilometros;
        private System.Windows.Forms.Label lbl_litros;
    }
}
