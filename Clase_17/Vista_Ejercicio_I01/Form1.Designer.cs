namespace Vista_Ejercicio_I01
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
            this.tbx_Nombre = new System.Windows.Forms.TextBox();
            this.tbx_Apellido = new System.Windows.Forms.TextBox();
            this.lbx_Personas = new System.Windows.Forms.ListBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Leer = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.nud_Id = new System.Windows.Forms.NumericUpDown();
            this.lb_Id = new System.Windows.Forms.Label();
            this.lb_Nombre = new System.Windows.Forms.Label();
            this.lb_Apellido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Id)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_Nombre
            // 
            this.tbx_Nombre.Location = new System.Drawing.Point(106, 57);
            this.tbx_Nombre.Name = "tbx_Nombre";
            this.tbx_Nombre.Size = new System.Drawing.Size(143, 23);
            this.tbx_Nombre.TabIndex = 0;
            // 
            // tbx_Apellido
            // 
            this.tbx_Apellido.Location = new System.Drawing.Point(106, 102);
            this.tbx_Apellido.Name = "tbx_Apellido";
            this.tbx_Apellido.Size = new System.Drawing.Size(143, 23);
            this.tbx_Apellido.TabIndex = 1;
            // 
            // lbx_Personas
            // 
            this.lbx_Personas.FormattingEnabled = true;
            this.lbx_Personas.ItemHeight = 15;
            this.lbx_Personas.Location = new System.Drawing.Point(279, 12);
            this.lbx_Personas.Name = "lbx_Personas";
            this.lbx_Personas.Size = new System.Drawing.Size(285, 304);
            this.lbx_Personas.TabIndex = 2;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(21, 147);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(99, 23);
            this.btn_Guardar.TabIndex = 3;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Leer
            // 
            this.btn_Leer.Location = new System.Drawing.Point(21, 195);
            this.btn_Leer.Name = "btn_Leer";
            this.btn_Leer.Size = new System.Drawing.Size(99, 23);
            this.btn_Leer.TabIndex = 4;
            this.btn_Leer.Text = "Actualizar";
            this.btn_Leer.UseVisualStyleBackColor = true;
            this.btn_Leer.Click += new System.EventHandler(this.btn_Leer_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(150, 147);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(99, 23);
            this.btn_Modificar.TabIndex = 5;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(150, 195);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(99, 23);
            this.btn_Eliminar.TabIndex = 6;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // nud_Id
            // 
            this.nud_Id.Location = new System.Drawing.Point(106, 12);
            this.nud_Id.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_Id.Name = "nud_Id";
            this.nud_Id.Size = new System.Drawing.Size(56, 23);
            this.nud_Id.TabIndex = 7;
            // 
            // lb_Id
            // 
            this.lb_Id.AutoSize = true;
            this.lb_Id.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Id.Location = new System.Drawing.Point(21, 12);
            this.lb_Id.Name = "lb_Id";
            this.lb_Id.Size = new System.Drawing.Size(22, 20);
            this.lb_Id.TabIndex = 8;
            this.lb_Id.Text = "Id";
            // 
            // lb_Nombre
            // 
            this.lb_Nombre.AutoSize = true;
            this.lb_Nombre.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Nombre.Location = new System.Drawing.Point(21, 56);
            this.lb_Nombre.Name = "lb_Nombre";
            this.lb_Nombre.Size = new System.Drawing.Size(66, 20);
            this.lb_Nombre.TabIndex = 9;
            this.lb_Nombre.Text = "Nombre";
            // 
            // lb_Apellido
            // 
            this.lb_Apellido.AutoSize = true;
            this.lb_Apellido.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Apellido.Location = new System.Drawing.Point(21, 102);
            this.lb_Apellido.Name = "lb_Apellido";
            this.lb_Apellido.Size = new System.Drawing.Size(66, 20);
            this.lb_Apellido.TabIndex = 10;
            this.lb_Apellido.Text = "Apellido";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(583, 331);
            this.Controls.Add(this.lb_Apellido);
            this.Controls.Add(this.lb_Nombre);
            this.Controls.Add(this.lb_Id);
            this.Controls.Add(this.nud_Id);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Leer);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.lbx_Personas);
            this.Controls.Add(this.tbx_Apellido);
            this.Controls.Add(this.tbx_Nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Personas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_Nombre;
        private System.Windows.Forms.TextBox tbx_Apellido;
        private System.Windows.Forms.ListBox lbx_Personas;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Leer;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.NumericUpDown nud_Id;
        private System.Windows.Forms.Label lb_Id;
        private System.Windows.Forms.Label lb_Nombre;
        private System.Windows.Forms.Label lb_Apellido;
    }
}
