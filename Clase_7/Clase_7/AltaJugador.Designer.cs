namespace Clase_7
{
    partial class AltaJugador
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
            this.lb_apellido = new System.Windows.Forms.Label();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.lb_posicion = new System.Windows.Forms.Label();
            this.lb_camiseta = new System.Windows.Forms.Label();
            this.lb_equipo = new System.Windows.Forms.Label();
            this.tbx_apellido = new System.Windows.Forms.TextBox();
            this.tbx_nombre = new System.Windows.Forms.TextBox();
            this.tbx_equipo = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.nud_camiseta = new System.Windows.Forms.NumericUpDown();
            this.cbx_posicion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_camiseta)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_apellido
            // 
            this.lb_apellido.AutoSize = true;
            this.lb_apellido.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_apellido.Location = new System.Drawing.Point(40, 50);
            this.lb_apellido.Name = "lb_apellido";
            this.lb_apellido.Size = new System.Drawing.Size(51, 15);
            this.lb_apellido.TabIndex = 0;
            this.lb_apellido.Text = "Apellido";
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_nombre.Location = new System.Drawing.Point(40, 90);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(51, 15);
            this.lb_nombre.TabIndex = 1;
            this.lb_nombre.Text = "Nombre";
            // 
            // lb_posicion
            // 
            this.lb_posicion.AutoSize = true;
            this.lb_posicion.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_posicion.Location = new System.Drawing.Point(39, 134);
            this.lb_posicion.Name = "lb_posicion";
            this.lb_posicion.Size = new System.Drawing.Size(52, 15);
            this.lb_posicion.TabIndex = 2;
            this.lb_posicion.Text = "Posición";
            // 
            // lb_camiseta
            // 
            this.lb_camiseta.AutoSize = true;
            this.lb_camiseta.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_camiseta.Location = new System.Drawing.Point(39, 177);
            this.lb_camiseta.Name = "lb_camiseta";
            this.lb_camiseta.Size = new System.Drawing.Size(117, 15);
            this.lb_camiseta.TabIndex = 3;
            this.lb_camiseta.Text = "Número de camiseta";
            // 
            // lb_equipo
            // 
            this.lb_equipo.AutoSize = true;
            this.lb_equipo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_equipo.Location = new System.Drawing.Point(39, 217);
            this.lb_equipo.Name = "lb_equipo";
            this.lb_equipo.Size = new System.Drawing.Size(44, 15);
            this.lb_equipo.TabIndex = 4;
            this.lb_equipo.Text = "Equipo";
            // 
            // tbx_apellido
            // 
            this.tbx_apellido.Location = new System.Drawing.Point(167, 47);
            this.tbx_apellido.Name = "tbx_apellido";
            this.tbx_apellido.PlaceholderText = "Apellido";
            this.tbx_apellido.Size = new System.Drawing.Size(135, 23);
            this.tbx_apellido.TabIndex = 5;
            // 
            // tbx_nombre
            // 
            this.tbx_nombre.Location = new System.Drawing.Point(167, 90);
            this.tbx_nombre.Name = "tbx_nombre";
            this.tbx_nombre.PlaceholderText = "Nombre";
            this.tbx_nombre.Size = new System.Drawing.Size(135, 23);
            this.tbx_nombre.TabIndex = 6;
            // 
            // tbx_equipo
            // 
            this.tbx_equipo.Location = new System.Drawing.Point(167, 217);
            this.tbx_equipo.Name = "tbx_equipo";
            this.tbx_equipo.PlaceholderText = "Equipo";
            this.tbx_equipo.Size = new System.Drawing.Size(135, 23);
            this.tbx_equipo.TabIndex = 9;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_agregar.Location = new System.Drawing.Point(40, 267);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 10;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancelar.Location = new System.Drawing.Point(256, 333);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 11;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // nud_camiseta
            // 
            this.nud_camiseta.Location = new System.Drawing.Point(167, 177);
            this.nud_camiseta.Name = "nud_camiseta";
            this.nud_camiseta.Size = new System.Drawing.Size(59, 23);
            this.nud_camiseta.TabIndex = 12;
            // 
            // cbx_posicion
            // 
            this.cbx_posicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_posicion.FormattingEnabled = true;
            this.cbx_posicion.Location = new System.Drawing.Point(167, 134);
            this.cbx_posicion.Name = "cbx_posicion";
            this.cbx_posicion.Size = new System.Drawing.Size(121, 23);
            this.cbx_posicion.TabIndex = 13;
            // 
            // AltaJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 368);
            this.Controls.Add(this.cbx_posicion);
            this.Controls.Add(this.nud_camiseta);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.tbx_equipo);
            this.Controls.Add(this.tbx_nombre);
            this.Controls.Add(this.tbx_apellido);
            this.Controls.Add(this.lb_equipo);
            this.Controls.Add(this.lb_camiseta);
            this.Controls.Add(this.lb_posicion);
            this.Controls.Add(this.lb_nombre);
            this.Controls.Add(this.lb_apellido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AltaJugador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de alta para jugadores";
            this.Load += new System.EventHandler(this.AltaJugador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_camiseta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_apellido;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.Label lb_posicion;
        private System.Windows.Forms.Label lb_camiseta;
        private System.Windows.Forms.Label lb_equipo;
        private System.Windows.Forms.TextBox tbx_apellido;
        private System.Windows.Forms.TextBox tbx_nombre;
        private System.Windows.Forms.TextBox tbx_equipo;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.NumericUpDown nud_camiseta;
        private System.Windows.Forms.ComboBox cbx_posicion;
    }
}