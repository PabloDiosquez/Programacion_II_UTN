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
            this.txb_dni = new System.Windows.Forms.TextBox();
            this.txb_nombre = new System.Windows.Forms.TextBox();
            this.txb_partidos_jugados = new System.Windows.Forms.TextBox();
            this.txb_goles = new System.Windows.Forms.TextBox();
            this.btn_alta = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_dni
            // 
            this.txb_dni.Location = new System.Drawing.Point(47, 60);
            this.txb_dni.Name = "txb_dni";
            this.txb_dni.PlaceholderText = "DNI";
            this.txb_dni.Size = new System.Drawing.Size(332, 23);
            this.txb_dni.TabIndex = 0;
            // 
            // txb_nombre
            // 
            this.txb_nombre.Location = new System.Drawing.Point(47, 114);
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.PlaceholderText = "Nombre";
            this.txb_nombre.Size = new System.Drawing.Size(332, 23);
            this.txb_nombre.TabIndex = 1;
            // 
            // txb_partidos_jugados
            // 
            this.txb_partidos_jugados.Location = new System.Drawing.Point(47, 167);
            this.txb_partidos_jugados.Name = "txb_partidos_jugados";
            this.txb_partidos_jugados.PlaceholderText = "Partidos jugados en total ";
            this.txb_partidos_jugados.Size = new System.Drawing.Size(332, 23);
            this.txb_partidos_jugados.TabIndex = 3;
            // 
            // txb_goles
            // 
            this.txb_goles.Location = new System.Drawing.Point(47, 217);
            this.txb_goles.Name = "txb_goles";
            this.txb_goles.PlaceholderText = "Goles marcados";
            this.txb_goles.Size = new System.Drawing.Size(332, 23);
            this.txb_goles.TabIndex = 2;
            // 
            // btn_alta
            // 
            this.btn_alta.Location = new System.Drawing.Point(47, 263);
            this.btn_alta.Name = "btn_alta";
            this.btn_alta.Size = new System.Drawing.Size(137, 25);
            this.btn_alta.TabIndex = 5;
            this.btn_alta.Text = "Agregar a la lista";
            this.btn_alta.UseVisualStyleBackColor = true;
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(295, 263);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // Alta_jugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 340);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_alta);
            this.Controls.Add(this.txb_partidos_jugados);
            this.Controls.Add(this.txb_goles);
            this.Controls.Add(this.txb_nombre);
            this.Controls.Add(this.txb_dni);
            this.Name = "Alta_jugador";
            this.Text = "Alta Jugador";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Alta_jugador_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_dni;
        private System.Windows.Forms.TextBox txb_nombre;
        private System.Windows.Forms.TextBox txb_partidos_jugados;
        private System.Windows.Forms.TextBox txb_goles;
        private System.Windows.Forms.Button btn_alta;
        private System.Windows.Forms.Button btn_cancelar;
    }
}