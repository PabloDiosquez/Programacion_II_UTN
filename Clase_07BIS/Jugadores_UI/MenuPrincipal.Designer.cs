namespace Jugadores_UI
{
    partial class MenuPrincipal
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
            this.btn_agregar_jugador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_agregar_jugador
            // 
            this.btn_agregar_jugador.Location = new System.Drawing.Point(328, 339);
            this.btn_agregar_jugador.Name = "btn_agregar_jugador";
            this.btn_agregar_jugador.Size = new System.Drawing.Size(120, 25);
            this.btn_agregar_jugador.TabIndex = 0;
            this.btn_agregar_jugador.Text = "Agregar";
            this.btn_agregar_jugador.UseVisualStyleBackColor = true;
            this.btn_agregar_jugador.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 402);
            this.Controls.Add(this.btn_agregar_jugador);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_agregar_jugador;
    }
}
