namespace Clase_7
{
    partial class Bienvenida
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
            this.lb_bienvenida = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_bienvenida
            // 
            this.lb_bienvenida.AutoSize = true;
            this.lb_bienvenida.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_bienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_bienvenida.Location = new System.Drawing.Point(41, 9);
            this.lb_bienvenida.Name = "lb_bienvenida";
            this.lb_bienvenida.Size = new System.Drawing.Size(378, 23);
            this.lb_bienvenida.TabIndex = 0;
            this.lb_bienvenida.Text = "Bienvenido! ¿Desea agregar algún jugador en el lista?";
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_agregar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_agregar.Location = new System.Drawing.Point(174, 66);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 1;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_mostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mostrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_mostrar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_mostrar.Location = new System.Drawing.Point(174, 121);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(75, 23);
            this.btn_mostrar.TabIndex = 2;
            this.btn_mostrar.Text = "Ver lista";
            this.btn_mostrar.UseVisualStyleBackColor = false;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cerrar.Location = new System.Drawing.Point(348, 184);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 3;
            this.btn_cerrar.Text = "Cerrar App";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            // 
            // Bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 219);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.lb_bienvenida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_bienvenida;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.Button btn_cerrar;
    }
}