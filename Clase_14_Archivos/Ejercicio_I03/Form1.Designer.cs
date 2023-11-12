namespace Ejercicio_I03
{
    partial class frm_Notepad
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mstrip_archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrip_abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrip_guardar = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrip_guardar_como = new System.Windows.Forms.ToolStripMenuItem();
            this.sStrip = new System.Windows.Forms.StatusStrip();
            this.tsStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.rtb_notepad = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.sStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstrip_archivo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(689, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mstrip_archivo
            // 
            this.mstrip_archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstrip_abrir,
            this.mstrip_guardar,
            this.mstrip_guardar_como});
            this.mstrip_archivo.Name = "mstrip_archivo";
            this.mstrip_archivo.Size = new System.Drawing.Size(60, 20);
            this.mstrip_archivo.Text = "Archivo";
            // 
            // mstrip_abrir
            // 
            this.mstrip_abrir.Name = "mstrip_abrir";
            this.mstrip_abrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mstrip_abrir.Size = new System.Drawing.Size(269, 22);
            this.mstrip_abrir.Text = "Abrir";
            this.mstrip_abrir.Click += new System.EventHandler(this.mstrip_abrir_Click);
            // 
            // mstrip_guardar
            // 
            this.mstrip_guardar.Name = "mstrip_guardar";
            this.mstrip_guardar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mstrip_guardar.Size = new System.Drawing.Size(269, 22);
            this.mstrip_guardar.Text = "Guardar";
            this.mstrip_guardar.Click += new System.EventHandler(this.mstrip_guardar_Click);
            // 
            // mstrip_guardar_como
            // 
            this.mstrip_guardar_como.Name = "mstrip_guardar_como";
            this.mstrip_guardar_como.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.mstrip_guardar_como.Size = new System.Drawing.Size(269, 22);
            this.mstrip_guardar_como.Text = "Guardar como...";
            this.mstrip_guardar_como.Click += new System.EventHandler(this.mstrip_guardar_como_Click);
            // 
            // sStrip
            // 
            this.sStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatusLabel});
            this.sStrip.Location = new System.Drawing.Point(0, 536);
            this.sStrip.Name = "sStrip";
            this.sStrip.Size = new System.Drawing.Size(689, 22);
            this.sStrip.TabIndex = 1;
            this.sStrip.Text = "statusStrip1";
            // 
            // tsStatusLabel
            // 
            this.tsStatusLabel.Name = "tsStatusLabel";
            this.tsStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // rtb_notepad
            // 
            this.rtb_notepad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_notepad.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtb_notepad.Location = new System.Drawing.Point(0, 24);
            this.rtb_notepad.Name = "rtb_notepad";
            this.rtb_notepad.Size = new System.Drawing.Size(689, 512);
            this.rtb_notepad.TabIndex = 2;
            this.rtb_notepad.Text = "";
            // 
            // frm_Notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 558);
            this.Controls.Add(this.rtb_notepad);
            this.Controls.Add(this.sStrip);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Notepad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notepad";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.sStrip.ResumeLayout(false);
            this.sStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mstrip_archivo;
        private System.Windows.Forms.ToolStripMenuItem mstrip_abrir;
        private System.Windows.Forms.ToolStripMenuItem mstrip_guardar;
        private System.Windows.Forms.ToolStripMenuItem mstrip_guardar_como;
        private System.Windows.Forms.StatusStrip sStrip;
        private System.Windows.Forms.RichTextBox rtb_notepad;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusLabel;
    }
}
