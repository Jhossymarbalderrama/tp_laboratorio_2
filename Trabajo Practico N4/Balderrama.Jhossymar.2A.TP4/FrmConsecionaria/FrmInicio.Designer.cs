namespace FrmConsecionaria
{
    partial class FrmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consecionariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consecionariaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1122, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consecionariaToolStripMenuItem
            // 
            this.consecionariaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeVehiculosToolStripMenuItem});
            this.consecionariaToolStripMenuItem.Name = "consecionariaToolStripMenuItem";
            this.consecionariaToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.consecionariaToolStripMenuItem.Text = "Concesionaria";
            // 
            // listaDeVehiculosToolStripMenuItem
            // 
            this.listaDeVehiculosToolStripMenuItem.Name = "listaDeVehiculosToolStripMenuItem";
            this.listaDeVehiculosToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.listaDeVehiculosToolStripMenuItem.Text = "Lista de Vehiculos";
            this.listaDeVehiculosToolStripMenuItem.Click += new System.EventHandler(this.listaDeVehiculosToolStripMenuItem_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 588);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consecionariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeVehiculosToolStripMenuItem;
    }
}

