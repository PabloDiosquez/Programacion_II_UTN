namespace EjercicioI04_Form
{
    partial class frm_Volador
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
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.rtb_voladores = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(201, 207);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(75, 23);
            this.btn_mostrar.TabIndex = 0;
            this.btn_mostrar.Text = "Mostrar";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // rtb_voladores
            // 
            this.rtb_voladores.Location = new System.Drawing.Point(21, 12);
            this.rtb_voladores.Name = "rtb_voladores";
            this.rtb_voladores.ReadOnly = true;
            this.rtb_voladores.Size = new System.Drawing.Size(255, 189);
            this.rtb_voladores.TabIndex = 1;
            this.rtb_voladores.Text = "";
            // 
            // frm_Volador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 244);
            this.Controls.Add(this.rtb_voladores);
            this.Controls.Add(this.btn_mostrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Volador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Voladores ✈";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.RichTextBox rtb_voladores;
    }
}
