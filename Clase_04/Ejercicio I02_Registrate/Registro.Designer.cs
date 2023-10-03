namespace Ejercicio_I02_Registrate
{
    partial class Registro
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
            this.gbx_nombre_direccion_edad = new System.Windows.Forms.GroupBox();
            this.nud_edad = new System.Windows.Forms.NumericUpDown();
            this.lb_edad = new System.Windows.Forms.Label();
            this.tbx_direccion = new System.Windows.Forms.TextBox();
            this.lb_direccion = new System.Windows.Forms.Label();
            this.lb_apellido = new System.Windows.Forms.Label();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.tbx_apellido = new System.Windows.Forms.TextBox();
            this.tbx_nombre = new System.Windows.Forms.TextBox();
            this.gbx_genero = new System.Windows.Forms.GroupBox();
            this.rbt_no_binario = new System.Windows.Forms.RadioButton();
            this.rbt_femenino = new System.Windows.Forms.RadioButton();
            this.rbt_masculino = new System.Windows.Forms.RadioButton();
            this.gbx_cursos = new System.Windows.Forms.GroupBox();
            this.cbx_javascript = new System.Windows.Forms.CheckBox();
            this.cbx_python = new System.Windows.Forms.CheckBox();
            this.cbx_csharp = new System.Windows.Forms.CheckBox();
            this.lbx_pais = new System.Windows.Forms.ListBox();
            this.lb_pais = new System.Windows.Forms.Label();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.gbx_nombre_direccion_edad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_edad)).BeginInit();
            this.gbx_genero.SuspendLayout();
            this.gbx_cursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_nombre_direccion_edad
            // 
            this.gbx_nombre_direccion_edad.Controls.Add(this.nud_edad);
            this.gbx_nombre_direccion_edad.Controls.Add(this.lb_edad);
            this.gbx_nombre_direccion_edad.Controls.Add(this.tbx_direccion);
            this.gbx_nombre_direccion_edad.Controls.Add(this.lb_direccion);
            this.gbx_nombre_direccion_edad.Controls.Add(this.lb_apellido);
            this.gbx_nombre_direccion_edad.Controls.Add(this.lb_nombre);
            this.gbx_nombre_direccion_edad.Controls.Add(this.tbx_apellido);
            this.gbx_nombre_direccion_edad.Controls.Add(this.tbx_nombre);
            this.gbx_nombre_direccion_edad.Location = new System.Drawing.Point(12, 12);
            this.gbx_nombre_direccion_edad.Name = "gbx_nombre_direccion_edad";
            this.gbx_nombre_direccion_edad.Size = new System.Drawing.Size(232, 199);
            this.gbx_nombre_direccion_edad.TabIndex = 0;
            this.gbx_nombre_direccion_edad.TabStop = false;
            this.gbx_nombre_direccion_edad.Text = "Detalles del ingresante";
            // 
            // nud_edad
            // 
            this.nud_edad.Location = new System.Drawing.Point(84, 165);
            this.nud_edad.Name = "nud_edad";
            this.nud_edad.Size = new System.Drawing.Size(120, 23);
            this.nud_edad.TabIndex = 7;
            // 
            // lb_edad
            // 
            this.lb_edad.AutoSize = true;
            this.lb_edad.Location = new System.Drawing.Point(13, 165);
            this.lb_edad.Name = "lb_edad";
            this.lb_edad.Size = new System.Drawing.Size(33, 15);
            this.lb_edad.TabIndex = 6;
            this.lb_edad.Text = "Edad";
            // 
            // tbx_direccion
            // 
            this.tbx_direccion.Location = new System.Drawing.Point(84, 121);
            this.tbx_direccion.Name = "tbx_direccion";
            this.tbx_direccion.PlaceholderText = "Dirección";
            this.tbx_direccion.Size = new System.Drawing.Size(124, 23);
            this.tbx_direccion.TabIndex = 5;
            // 
            // lb_direccion
            // 
            this.lb_direccion.AutoSize = true;
            this.lb_direccion.Location = new System.Drawing.Point(13, 121);
            this.lb_direccion.Name = "lb_direccion";
            this.lb_direccion.Size = new System.Drawing.Size(57, 15);
            this.lb_direccion.TabIndex = 4;
            this.lb_direccion.Text = "Dirección";
            // 
            // lb_apellido
            // 
            this.lb_apellido.AutoSize = true;
            this.lb_apellido.Location = new System.Drawing.Point(13, 82);
            this.lb_apellido.Name = "lb_apellido";
            this.lb_apellido.Size = new System.Drawing.Size(51, 15);
            this.lb_apellido.TabIndex = 3;
            this.lb_apellido.Text = "Apellido";
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Location = new System.Drawing.Point(13, 39);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(51, 15);
            this.lb_nombre.TabIndex = 2;
            this.lb_nombre.Text = "Nombre";
            // 
            // tbx_apellido
            // 
            this.tbx_apellido.Location = new System.Drawing.Point(84, 82);
            this.tbx_apellido.Name = "tbx_apellido";
            this.tbx_apellido.PlaceholderText = "Apellido";
            this.tbx_apellido.Size = new System.Drawing.Size(124, 23);
            this.tbx_apellido.TabIndex = 1;
            // 
            // tbx_nombre
            // 
            this.tbx_nombre.Location = new System.Drawing.Point(84, 39);
            this.tbx_nombre.Name = "tbx_nombre";
            this.tbx_nombre.PlaceholderText = "Nombre";
            this.tbx_nombre.Size = new System.Drawing.Size(124, 23);
            this.tbx_nombre.TabIndex = 0;
            // 
            // gbx_genero
            // 
            this.gbx_genero.Controls.Add(this.rbt_no_binario);
            this.gbx_genero.Controls.Add(this.rbt_femenino);
            this.gbx_genero.Controls.Add(this.rbt_masculino);
            this.gbx_genero.Location = new System.Drawing.Point(275, 12);
            this.gbx_genero.Name = "gbx_genero";
            this.gbx_genero.Size = new System.Drawing.Size(164, 143);
            this.gbx_genero.TabIndex = 1;
            this.gbx_genero.TabStop = false;
            this.gbx_genero.Text = "Género";
            // 
            // rbt_no_binario
            // 
            this.rbt_no_binario.AutoSize = true;
            this.rbt_no_binario.Location = new System.Drawing.Point(19, 117);
            this.rbt_no_binario.Name = "rbt_no_binario";
            this.rbt_no_binario.Size = new System.Drawing.Size(81, 19);
            this.rbt_no_binario.TabIndex = 2;
            this.rbt_no_binario.TabStop = true;
            this.rbt_no_binario.Text = "No Binario";
            this.rbt_no_binario.UseVisualStyleBackColor = true;
            // 
            // rbt_femenino
            // 
            this.rbt_femenino.AutoSize = true;
            this.rbt_femenino.Location = new System.Drawing.Point(19, 78);
            this.rbt_femenino.Name = "rbt_femenino";
            this.rbt_femenino.Size = new System.Drawing.Size(78, 19);
            this.rbt_femenino.TabIndex = 1;
            this.rbt_femenino.TabStop = true;
            this.rbt_femenino.Text = "Femenino";
            this.rbt_femenino.UseVisualStyleBackColor = true;
            // 
            // rbt_masculino
            // 
            this.rbt_masculino.AutoSize = true;
            this.rbt_masculino.Location = new System.Drawing.Point(19, 37);
            this.rbt_masculino.Name = "rbt_masculino";
            this.rbt_masculino.Size = new System.Drawing.Size(80, 19);
            this.rbt_masculino.TabIndex = 0;
            this.rbt_masculino.TabStop = true;
            this.rbt_masculino.Text = "Masculino";
            this.rbt_masculino.UseVisualStyleBackColor = true;
            // 
            // gbx_cursos
            // 
            this.gbx_cursos.Controls.Add(this.cbx_javascript);
            this.gbx_cursos.Controls.Add(this.cbx_python);
            this.gbx_cursos.Controls.Add(this.cbx_csharp);
            this.gbx_cursos.Location = new System.Drawing.Point(272, 177);
            this.gbx_cursos.Name = "gbx_cursos";
            this.gbx_cursos.Size = new System.Drawing.Size(167, 171);
            this.gbx_cursos.TabIndex = 2;
            this.gbx_cursos.TabStop = false;
            this.gbx_cursos.Text = "Cursos";
            // 
            // cbx_javascript
            // 
            this.cbx_javascript.AutoSize = true;
            this.cbx_javascript.Location = new System.Drawing.Point(19, 117);
            this.cbx_javascript.Name = "cbx_javascript";
            this.cbx_javascript.Size = new System.Drawing.Size(77, 19);
            this.cbx_javascript.TabIndex = 2;
            this.cbx_javascript.Text = "Javascript";
            this.cbx_javascript.UseVisualStyleBackColor = true;
            // 
            // cbx_python
            // 
            this.cbx_python.AutoSize = true;
            this.cbx_python.Location = new System.Drawing.Point(19, 76);
            this.cbx_python.Name = "cbx_python";
            this.cbx_python.Size = new System.Drawing.Size(64, 19);
            this.cbx_python.TabIndex = 1;
            this.cbx_python.Text = "Python";
            this.cbx_python.UseVisualStyleBackColor = true;
            // 
            // cbx_csharp
            // 
            this.cbx_csharp.AutoSize = true;
            this.cbx_csharp.Location = new System.Drawing.Point(19, 34);
            this.cbx_csharp.Name = "cbx_csharp";
            this.cbx_csharp.Size = new System.Drawing.Size(41, 19);
            this.cbx_csharp.TabIndex = 0;
            this.cbx_csharp.Text = "C#";
            this.cbx_csharp.UseVisualStyleBackColor = true;
            // 
            // lbx_pais
            // 
            this.lbx_pais.FormattingEnabled = true;
            this.lbx_pais.ItemHeight = 15;
            this.lbx_pais.Location = new System.Drawing.Point(12, 253);
            this.lbx_pais.Name = "lbx_pais";
            this.lbx_pais.Size = new System.Drawing.Size(229, 109);
            this.lbx_pais.TabIndex = 3;
            // 
            // lb_pais
            // 
            this.lb_pais.AutoSize = true;
            this.lb_pais.Location = new System.Drawing.Point(12, 225);
            this.lb_pais.Name = "lb_pais";
            this.lb_pais.Size = new System.Drawing.Size(28, 15);
            this.lb_pais.TabIndex = 4;
            this.lb_pais.Text = "País";
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Location = new System.Drawing.Point(349, 368);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(90, 24);
            this.btn_ingresar.TabIndex = 5;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 408);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.lb_pais);
            this.Controls.Add(this.lbx_pais);
            this.Controls.Add(this.gbx_cursos);
            this.Controls.Add(this.gbx_genero);
            this.Controls.Add(this.gbx_nombre_direccion_edad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.gbx_nombre_direccion_edad.ResumeLayout(false);
            this.gbx_nombre_direccion_edad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_edad)).EndInit();
            this.gbx_genero.ResumeLayout(false);
            this.gbx_genero.PerformLayout();
            this.gbx_cursos.ResumeLayout(false);
            this.gbx_cursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_nombre_direccion_edad;
        private System.Windows.Forms.GroupBox gbx_genero;
        private System.Windows.Forms.GroupBox gbx_cursos;
        private System.Windows.Forms.ListBox lbx_pais;
        private System.Windows.Forms.Label lb_pais;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Label lb_apellido;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.TextBox tbx_apellido;
        private System.Windows.Forms.TextBox tbx_nombre;
        private System.Windows.Forms.TextBox tbx_direccion;
        private System.Windows.Forms.Label lb_direccion;
        private System.Windows.Forms.Label lb_edad;
        private System.Windows.Forms.NumericUpDown nud_edad;
        private System.Windows.Forms.RadioButton rbt_no_binario;
        private System.Windows.Forms.RadioButton rbt_femenino;
        private System.Windows.Forms.RadioButton rbt_masculino;
        private System.Windows.Forms.CheckBox cbx_javascript;
        private System.Windows.Forms.CheckBox cbx_python;
        private System.Windows.Forms.CheckBox cbx_csharp;
    }
}
