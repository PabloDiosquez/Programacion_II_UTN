namespace Jugadores_UI
{
    partial class Alta_jugador
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
            this.txb_Nombre = new System.Windows.Forms.TextBox();
            this.txb_posicion = new System.Windows.Forms.TextBox();
            this.txb_camiseta = new System.Windows.Forms.TextBox();
            this.txb_edad = new System.Windows.Forms.TextBox();
            this.txb_nacionalidad = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_Nombre
            // 
            this.txb_Nombre.Location = new System.Drawing.Point(71, 53);
            this.txb_Nombre.Name = "txb_Nombre";
            this.txb_Nombre.PlaceholderText = "Nombre";
            this.txb_Nombre.Size = new System.Drawing.Size(248, 23);
            this.txb_Nombre.TabIndex = 0;
            // 
            // txb_posicion
            // 
            this.txb_posicion.Location = new System.Drawing.Point(71, 100);
            this.txb_posicion.Name = "txb_posicion";
            this.txb_posicion.PlaceholderText = "Posición";
            this.txb_posicion.Size = new System.Drawing.Size(248, 23);
            this.txb_posicion.TabIndex = 1;
            // 
            // txb_camiseta
            // 
            this.txb_camiseta.Location = new System.Drawing.Point(71, 144);
            this.txb_camiseta.Name = "txb_camiseta";
            this.txb_camiseta.PlaceholderText = "Camiseta";
            this.txb_camiseta.Size = new System.Drawing.Size(248, 23);
            this.txb_camiseta.TabIndex = 2;
            // 
            // txb_edad
            // 
            this.txb_edad.Location = new System.Drawing.Point(71, 189);
            this.txb_edad.Name = "txb_edad";
            this.txb_edad.PlaceholderText = "Edad";
            this.txb_edad.Size = new System.Drawing.Size(248, 23);
            this.txb_edad.TabIndex = 3;
            // 
            // txb_nacionalidad
            // 
            this.txb_nacionalidad.Location = new System.Drawing.Point(71, 232);
            this.txb_nacionalidad.Name = "txb_nacionalidad";
            this.txb_nacionalidad.PlaceholderText = "Nacionalidad";
            this.txb_nacionalidad.Size = new System.Drawing.Size(248, 23);
            this.txb_nacionalidad.TabIndex = 4;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(71, 287);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 5;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(244, 287);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // Alta_jugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 380);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txb_nacionalidad);
            this.Controls.Add(this.txb_edad);
            this.Controls.Add(this.txb_camiseta);
            this.Controls.Add(this.txb_posicion);
            this.Controls.Add(this.txb_Nombre);
            this.Name = "Alta_jugador";
            this.Text = "Alta jugador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_Nombre;
        private System.Windows.Forms.TextBox txb_posicion;
        private System.Windows.Forms.TextBox txb_camiseta;
        private System.Windows.Forms.TextBox txb_edad;
        private System.Windows.Forms.TextBox txb_nacionalidad;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}