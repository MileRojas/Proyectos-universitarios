namespace Activos
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcion1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoActToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codigoDeBarrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeActivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar Tipos de Activos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(278, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "Agregar Activos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(414, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 57);
            this.button3.TabIndex = 2;
            this.button3.Text = "Generar Activos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcion1ToolStripMenuItem,
            this.generarToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(729, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcion1ToolStripMenuItem
            // 
            this.opcion1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoActToolStripMenuItem,
            this.activoToolStripMenuItem});
            this.opcion1ToolStripMenuItem.Name = "opcion1ToolStripMenuItem";
            this.opcion1ToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.opcion1ToolStripMenuItem.Text = "Agregar";
            // 
            // tipoActToolStripMenuItem
            // 
            this.tipoActToolStripMenuItem.Name = "tipoActToolStripMenuItem";
            this.tipoActToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tipoActToolStripMenuItem.Text = "Tipo Activo";
            this.tipoActToolStripMenuItem.Click += new System.EventHandler(this.tipoActToolStripMenuItem_Click);
            // 
            // activoToolStripMenuItem
            // 
            this.activoToolStripMenuItem.Name = "activoToolStripMenuItem";
            this.activoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.activoToolStripMenuItem.Text = "Activo";
            this.activoToolStripMenuItem.Click += new System.EventHandler(this.activoToolStripMenuItem_Click);
            // 
            // generarToolStripMenuItem
            // 
            this.generarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codigoDeBarrasToolStripMenuItem});
            this.generarToolStripMenuItem.Name = "generarToolStripMenuItem";
            this.generarToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.generarToolStripMenuItem.Text = "Generar";
            // 
            // codigoDeBarrasToolStripMenuItem
            // 
            this.codigoDeBarrasToolStripMenuItem.Name = "codigoDeBarrasToolStripMenuItem";
            this.codigoDeBarrasToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.codigoDeBarrasToolStripMenuItem.Text = "Codigo de Barras";
            this.codigoDeBarrasToolStripMenuItem.Click += new System.EventHandler(this.codigoDeBarrasToolStripMenuItem_Click);
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
            this.tiposDeActivosToolStripMenuItem.Click += new System.EventHandler(this.tiposDeActivosToolStripMenuItem_Click);
            // 
            // acToolStripMenuItem
            // 
            this.acToolStripMenuItem.Name = "acToolStripMenuItem";
            this.acToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.acToolStripMenuItem.Text = "Activos";
            this.acToolStripMenuItem.Click += new System.EventHandler(this.acToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 337);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Activos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcion1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoActToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codigoDeBarrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeActivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acToolStripMenuItem;

    }
}

