namespace Ejercicio_I02
{
    partial class frmCalculador
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
            this.lb_Kilometros = new System.Windows.Forms.Label();
            this.lb_Litros = new System.Windows.Forms.Label();
            this.tbx_Kilometros = new System.Windows.Forms.TextBox();
            this.tbx_Litros = new System.Windows.Forms.TextBox();
            this.rtb_Consumo = new System.Windows.Forms.RichTextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Kilometros
            // 
            this.lb_Kilometros.AutoSize = true;
            this.lb_Kilometros.Location = new System.Drawing.Point(12, 24);
            this.lb_Kilometros.Name = "lb_Kilometros";
            this.lb_Kilometros.Size = new System.Drawing.Size(64, 15);
            this.lb_Kilometros.TabIndex = 0;
            this.lb_Kilometros.Text = "Kilometros";
            // 
            // lb_Litros
            // 
            this.lb_Litros.AutoSize = true;
            this.lb_Litros.Location = new System.Drawing.Point(12, 90);
            this.lb_Litros.Name = "lb_Litros";
            this.lb_Litros.Size = new System.Drawing.Size(36, 15);
            this.lb_Litros.TabIndex = 1;
            this.lb_Litros.Text = "Litros";
            // 
            // tbx_Kilometros
            // 
            this.tbx_Kilometros.Location = new System.Drawing.Point(12, 51);
            this.tbx_Kilometros.Name = "tbx_Kilometros";
            this.tbx_Kilometros.Size = new System.Drawing.Size(158, 23);
            this.tbx_Kilometros.TabIndex = 2;
            // 
            // tbx_Litros
            // 
            this.tbx_Litros.Location = new System.Drawing.Point(12, 114);
            this.tbx_Litros.Name = "tbx_Litros";
            this.tbx_Litros.PlaceholderText = " ";
            this.tbx_Litros.Size = new System.Drawing.Size(158, 23);
            this.tbx_Litros.TabIndex = 3;
            // 
            // rtb_Consumo
            // 
            this.rtb_Consumo.Cursor = System.Windows.Forms.Cursors.No;
            this.rtb_Consumo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtb_Consumo.Location = new System.Drawing.Point(217, 24);
            this.rtb_Consumo.Name = "rtb_Consumo";
            this.rtb_Consumo.ReadOnly = true;
            this.rtb_Consumo.Size = new System.Drawing.Size(156, 144);
            this.rtb_Consumo.TabIndex = 4;
            this.rtb_Consumo.Text = "";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(12, 178);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 5;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // frmCalculador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 215);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.rtb_Consumo);
            this.Controls.Add(this.tbx_Litros);
            this.Controls.Add(this.tbx_Kilometros);
            this.Controls.Add(this.lb_Litros);
            this.Controls.Add(this.lb_Kilometros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Kilometros;
        private System.Windows.Forms.Label lb_Litros;
        private System.Windows.Forms.TextBox tbx_Kilometros;
        private System.Windows.Forms.TextBox tbx_Litros;
        private System.Windows.Forms.RichTextBox rtb_Consumo;
        private System.Windows.Forms.Button btn_Calcular;
    }
}
