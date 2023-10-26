namespace FormPrincipal
{
    partial class frm_Principal
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
            this.rtx_Imprimir = new System.Windows.Forms.RichTextBox();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtx_Imprimir
            // 
            this.rtx_Imprimir.Location = new System.Drawing.Point(31, 28);
            this.rtx_Imprimir.Name = "rtx_Imprimir";
            this.rtx_Imprimir.ReadOnly = true;
            this.rtx_Imprimir.Size = new System.Drawing.Size(228, 194);
            this.rtx_Imprimir.TabIndex = 0;
            this.rtx_Imprimir.Text = "";
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.Location = new System.Drawing.Point(184, 249);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(75, 23);
            this.btn_Imprimir.TabIndex = 1;
            this.btn_Imprimir.Text = "Imprimir";
            this.btn_Imprimir.UseVisualStyleBackColor = true;
            this.btn_Imprimir.Click += new System.EventHandler(this.btn_Imprimir_Click);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 283);
            this.Controls.Add(this.btn_Imprimir);
            this.Controls.Add(this.rtx_Imprimir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Interfaz Imprimible";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtx_Imprimir;
        private System.Windows.Forms.Button btn_Imprimir;
    }
}
