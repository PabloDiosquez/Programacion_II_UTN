namespace Ejercicio_I01
{
    partial class Ingreso_Datos
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
            this.tbx_nombre = new System.Windows.Forms.TextBox();
            this.tbx_apellido = new System.Windows.Forms.TextBox();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.lb_apellido = new System.Windows.Forms.Label();
            this.btn_saludar = new System.Windows.Forms.Button();
            this.cb_materias = new System.Windows.Forms.ComboBox();
            this.lb_materia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbx_nombre
            // 
            this.tbx_nombre.Location = new System.Drawing.Point(12, 58);
            this.tbx_nombre.Name = "tbx_nombre";
            this.tbx_nombre.PlaceholderText = "Ingrese su nombre";
            this.tbx_nombre.Size = new System.Drawing.Size(181, 23);
            this.tbx_nombre.TabIndex = 0;
            // 
            // tbx_apellido
            // 
            this.tbx_apellido.Location = new System.Drawing.Point(209, 58);
            this.tbx_apellido.Name = "tbx_apellido";
            this.tbx_apellido.PlaceholderText = "Ingrese su apellido";
            this.tbx_apellido.Size = new System.Drawing.Size(181, 23);
            this.tbx_apellido.TabIndex = 1;
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_nombre.Location = new System.Drawing.Point(12, 40);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(53, 15);
            this.lb_nombre.TabIndex = 2;
            this.lb_nombre.Text = "Nombre";
            // 
            // lb_apellido
            // 
            this.lb_apellido.AutoSize = true;
            this.lb_apellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_apellido.Location = new System.Drawing.Point(209, 40);
            this.lb_apellido.Name = "lb_apellido";
            this.lb_apellido.Size = new System.Drawing.Size(52, 15);
            this.lb_apellido.TabIndex = 3;
            this.lb_apellido.Text = "Apellido";
            // 
            // btn_saludar
            // 
            this.btn_saludar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_saludar.Location = new System.Drawing.Point(280, 110);
            this.btn_saludar.Name = "btn_saludar";
            this.btn_saludar.Size = new System.Drawing.Size(110, 23);
            this.btn_saludar.TabIndex = 4;
            this.btn_saludar.Text = "Saludar";
            this.btn_saludar.UseVisualStyleBackColor = false;
            this.btn_saludar.Click += new System.EventHandler(this.btn_saludar_Click);
            // 
            // cb_materias
            // 
            this.cb_materias.FormattingEnabled = true;
            this.cb_materias.Location = new System.Drawing.Point(12, 111);
            this.cb_materias.Name = "cb_materias";
            this.cb_materias.Size = new System.Drawing.Size(181, 23);
            this.cb_materias.TabIndex = 5;
            this.cb_materias.Text = "Materias";
            // 
            // lb_materia
            // 
            this.lb_materia.AutoSize = true;
            this.lb_materia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_materia.Location = new System.Drawing.Point(13, 91);
            this.lb_materia.Name = "lb_materia";
            this.lb_materia.Size = new System.Drawing.Size(98, 15);
            this.lb_materia.TabIndex = 6;
            this.lb_materia.Text = "Materia Favorita";
            // 
            // Ingreso_Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(412, 153);
            this.Controls.Add(this.lb_materia);
            this.Controls.Add(this.cb_materias);
            this.Controls.Add(this.btn_saludar);
            this.Controls.Add(this.lb_apellido);
            this.Controls.Add(this.lb_nombre);
            this.Controls.Add(this.tbx_apellido);
            this.Controls.Add(this.tbx_nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ingreso_Datos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "¡Hola, Windows Forms!";
            this.Load += new System.EventHandler(this.Ingreso_Datos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_nombre;
        private System.Windows.Forms.TextBox tbx_apellido;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.Label lb_apellido;
        private System.Windows.Forms.Button btn_saludar;
        private System.Windows.Forms.ComboBox cb_materias;
        private System.Windows.Forms.Label lb_materia;
    }
}
