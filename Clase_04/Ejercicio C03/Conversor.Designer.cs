namespace Ejercicio_C03
{
    partial class Conversor
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
            this.lb_decimal_binario = new System.Windows.Forms.Label();
            this.lb_binario_decimal = new System.Windows.Forms.Label();
            this.tbx_decimal_a_binario = new System.Windows.Forms.TextBox();
            this.tbx_binario_a_decimal = new System.Windows.Forms.TextBox();
            this.tbx_resultado_decimal_a_binario = new System.Windows.Forms.TextBox();
            this.txb_resultado_binario_a_decimal = new System.Windows.Forms.TextBox();
            this.btn_decimal_a_binario = new System.Windows.Forms.Button();
            this.btn_binario_a_decimal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_decimal_binario
            // 
            this.lb_decimal_binario.AutoSize = true;
            this.lb_decimal_binario.Font = new System.Drawing.Font("Sitka Heading", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_decimal_binario.Location = new System.Drawing.Point(12, 14);
            this.lb_decimal_binario.Name = "lb_decimal_binario";
            this.lb_decimal_binario.Size = new System.Drawing.Size(131, 19);
            this.lb_decimal_binario.TabIndex = 0;
            this.lb_decimal_binario.Text = "De Decimal a Binario";
            // 
            // lb_binario_decimal
            // 
            this.lb_binario_decimal.AutoSize = true;
            this.lb_binario_decimal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_binario_decimal.Location = new System.Drawing.Point(1, 47);
            this.lb_binario_decimal.Name = "lb_binario_decimal";
            this.lb_binario_decimal.Size = new System.Drawing.Size(142, 13);
            this.lb_binario_decimal.TabIndex = 1;
            this.lb_binario_decimal.Text = "De Binario a Decimal";
            // 
            // tbx_decimal_a_binario
            // 
            this.tbx_decimal_a_binario.Location = new System.Drawing.Point(149, 14);
            this.tbx_decimal_a_binario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_decimal_a_binario.Name = "tbx_decimal_a_binario";
            this.tbx_decimal_a_binario.Size = new System.Drawing.Size(122, 21);
            this.tbx_decimal_a_binario.TabIndex = 2;
            // 
            // tbx_binario_a_decimal
            // 
            this.tbx_binario_a_decimal.Location = new System.Drawing.Point(149, 45);
            this.tbx_binario_a_decimal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_binario_a_decimal.Name = "tbx_binario_a_decimal";
            this.tbx_binario_a_decimal.Size = new System.Drawing.Size(122, 21);
            this.tbx_binario_a_decimal.TabIndex = 3;
            // 
            // tbx_resultado_decimal_a_binario
            // 
            this.tbx_resultado_decimal_a_binario.Location = new System.Drawing.Point(380, 13);
            this.tbx_resultado_decimal_a_binario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_resultado_decimal_a_binario.Name = "tbx_resultado_decimal_a_binario";
            this.tbx_resultado_decimal_a_binario.Size = new System.Drawing.Size(122, 21);
            this.tbx_resultado_decimal_a_binario.TabIndex = 4;
            // 
            // txb_resultado_binario_a_decimal
            // 
            this.txb_resultado_binario_a_decimal.Location = new System.Drawing.Point(380, 44);
            this.txb_resultado_binario_a_decimal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_resultado_binario_a_decimal.Name = "txb_resultado_binario_a_decimal";
            this.txb_resultado_binario_a_decimal.Size = new System.Drawing.Size(122, 21);
            this.txb_resultado_binario_a_decimal.TabIndex = 5;
            // 
            // btn_decimal_a_binario
            // 
            this.btn_decimal_a_binario.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_decimal_a_binario.Location = new System.Drawing.Point(285, 13);
            this.btn_decimal_a_binario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_decimal_a_binario.Name = "btn_decimal_a_binario";
            this.btn_decimal_a_binario.Size = new System.Drawing.Size(75, 27);
            this.btn_decimal_a_binario.TabIndex = 6;
            this.btn_decimal_a_binario.Text = "=>";
            this.btn_decimal_a_binario.UseVisualStyleBackColor = true;
            this.btn_decimal_a_binario.Click += new System.EventHandler(this.btn_decimal_a_binario_Click);
            // 
            // btn_binario_a_decimal
            // 
            this.btn_binario_a_decimal.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_binario_a_decimal.Location = new System.Drawing.Point(285, 44);
            this.btn_binario_a_decimal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_binario_a_decimal.Name = "btn_binario_a_decimal";
            this.btn_binario_a_decimal.Size = new System.Drawing.Size(75, 25);
            this.btn_binario_a_decimal.TabIndex = 7;
            this.btn_binario_a_decimal.Text = "=>";
            this.btn_binario_a_decimal.UseVisualStyleBackColor = true;
            this.btn_binario_a_decimal.Click += new System.EventHandler(this.btn_binario_a_decimal_Click);
            // 
            // Conversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 80);
            this.Controls.Add(this.btn_binario_a_decimal);
            this.Controls.Add(this.btn_decimal_a_binario);
            this.Controls.Add(this.txb_resultado_binario_a_decimal);
            this.Controls.Add(this.tbx_resultado_decimal_a_binario);
            this.Controls.Add(this.tbx_binario_a_decimal);
            this.Controls.Add(this.tbx_decimal_a_binario);
            this.Controls.Add(this.lb_binario_decimal);
            this.Controls.Add(this.lb_decimal_binario);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Conversor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor Numérico ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_decimal_binario;
        private System.Windows.Forms.Label lb_binario_decimal;
        private System.Windows.Forms.TextBox tbx_decimal_a_binario;
        private System.Windows.Forms.TextBox tbx_binario_a_decimal;
        private System.Windows.Forms.TextBox tbx_resultado_decimal_a_binario;
        private System.Windows.Forms.TextBox txb_resultado_binario_a_decimal;
        private System.Windows.Forms.Button btn_decimal_a_binario;
        private System.Windows.Forms.Button btn_binario_a_decimal;
    }
}
