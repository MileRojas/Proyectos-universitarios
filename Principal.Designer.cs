namespace Activos
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcion1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoActToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codigoDeBarrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeActivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soloUnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porGruposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 438);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(744, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcion1ToolStripMenuItem,
            this.generarToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcion1ToolStripMenuItem
            // 
            this.opcion1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoActToolStripMenuItem,
            this.activoToolStripMenuItem,
            this.personalToolStripMenuItem});
            this.opcion1ToolStripMenuItem.Name = "opcion1ToolStripMenuItem";
            this.opcion1ToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.opcion1ToolStripMenuItem.Text = "Agregar";
            // 
            // tipoActToolStripMenuItem
            // 
            this.tipoActToolStripMenuItem.Name = "tipoActToolStripMenuItem";
            this.tipoActToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.tipoActToolStripMenuItem.Text = "Tipo Activo";
            this.tipoActToolStripMenuItem.Click += new System.EventHandler(this.tipoActToolStripMenuItem_Click);
            // 
            // activoToolStripMenuItem
            // 
            this.activoToolStripMenuItem.Name = "activoToolStripMenuItem";
            this.activoToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.activoToolStripMenuItem.Text = "Activo";
            this.activoToolStripMenuItem.Click += new System.EventHandler(this.activoToolStripMenuItem_Click_1);
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.personalToolStripMenuItem.Text = "Personal";
            this.personalToolStripMenuItem.Click += new System.EventHandler(this.personalToolStripMenuItem_Click);
            // 
            // generarToolStripMenuItem
            // 
            this.generarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codigoDeBarrasToolStripMenuItem,
            this.activoToolStripMenuItem1,
            this.personalToolStripMenuItem1});
            this.generarToolStripMenuItem.Name = "generarToolStripMenuItem";
            this.generarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.generarToolStripMenuItem.Text = "Eliminar";
            this.generarToolStripMenuItem.Click += new System.EventHandler(this.generarToolStripMenuItem_Click);
            // 
            // codigoDeBarrasToolStripMenuItem
            // 
            this.codigoDeBarrasToolStripMenuItem.Name = "codigoDeBarrasToolStripMenuItem";
            this.codigoDeBarrasToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.codigoDeBarrasToolStripMenuItem.Text = "Tipo Activo";
            this.codigoDeBarrasToolStripMenuItem.Click += new System.EventHandler(this.codigoDeBarrasToolStripMenuItem_Click_1);
            // 
            // activoToolStripMenuItem1
            // 
            this.activoToolStripMenuItem1.Name = "activoToolStripMenuItem1";
            this.activoToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.activoToolStripMenuItem1.Text = "Activo";
            this.activoToolStripMenuItem1.Click += new System.EventHandler(this.activoToolStripMenuItem1_Click);
            // 
            // personalToolStripMenuItem1
            // 
            this.personalToolStripMenuItem1.Name = "personalToolStripMenuItem1";
            this.personalToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.personalToolStripMenuItem1.Text = "Personal";
            this.personalToolStripMenuItem1.Click += new System.EventHandler(this.personalToolStripMenuItem1_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiposDeActivosToolStripMenuItem,
            this.acToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // tiposDeActivosToolStripMenuItem
            // 
            this.tiposDeActivosToolStripMenuItem.Name = "tiposDeActivosToolStripMenuItem";
            this.tiposDeActivosToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.tiposDeActivosToolStripMenuItem.Text = "Tipos de Activos";
            this.tiposDeActivosToolStripMenuItem.Click += new System.EventHandler(this.tiposDeActivosToolStripMenuItem_Click_1);
            // 
            // acToolStripMenuItem
            // 
            this.acToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soloUnoToolStripMenuItem,
            this.porGruposToolStripMenuItem});
            this.acToolStripMenuItem.Name = "acToolStripMenuItem";
            this.acToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.acToolStripMenuItem.Text = "Activos";
            this.acToolStripMenuItem.Click += new System.EventHandler(this.acToolStripMenuItem_Click_1);
            // 
            // soloUnoToolStripMenuItem
            // 
            this.soloUnoToolStripMenuItem.Name = "soloUnoToolStripMenuItem";
            this.soloUnoToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.soloUnoToolStripMenuItem.Text = "Solo uno";
            this.soloUnoToolStripMenuItem.Click += new System.EventHandler(this.soloUnoToolStripMenuItem_Click);
            // 
            // porGruposToolStripMenuItem
            // 
            this.porGruposToolStripMenuItem.Name = "porGruposToolStripMenuItem";
            this.porGruposToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.porGruposToolStripMenuItem.Text = "Por Grupos";
            this.porGruposToolStripMenuItem.Click += new System.EventHandler(this.porGruposToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(744, 460);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip);
            this.IsMdiContainer = true;
            this.Name = "Principal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcion1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoActToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codigoDeBarrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeActivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem soloUnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porGruposToolStripMenuItem;
    }
}



