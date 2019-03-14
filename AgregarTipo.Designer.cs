namespace Activos
{
    partial class AgregarTipo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipoActivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcodTipoActivo = new System.Windows.Forms.MaskedTextBox();
            this.dgvTipoActivo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoActivo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Activo";
            // 
            // txtTipoActivo
            // 
            this.txtTipoActivo.Location = new System.Drawing.Point(116, 104);
            this.txtTipoActivo.Name = "txtTipoActivo";
            this.txtTipoActivo.Size = new System.Drawing.Size(100, 20);
            this.txtTipoActivo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cod Tipo Activo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcodTipoActivo
            // 
            this.txtcodTipoActivo.Location = new System.Drawing.Point(114, 69);
            this.txtcodTipoActivo.Mask = "00";
            this.txtcodTipoActivo.Name = "txtcodTipoActivo";
            this.txtcodTipoActivo.Size = new System.Drawing.Size(100, 20);
            this.txtcodTipoActivo.TabIndex = 5;
            // 
            // dgvTipoActivo
            // 
            this.dgvTipoActivo.AllowUserToAddRows = false;
            this.dgvTipoActivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoActivo.Location = new System.Drawing.Point(12, 170);
            this.dgvTipoActivo.Name = "dgvTipoActivo";
            this.dgvTipoActivo.Size = new System.Drawing.Size(341, 150);
            this.dgvTipoActivo.TabIndex = 6;
            // 
            // AgregarTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 346);
            this.Controls.Add(this.dgvTipoActivo);
            this.Controls.Add(this.txtcodTipoActivo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTipoActivo);
            this.Controls.Add(this.label1);
            this.Name = "AgregarTipo";
            this.Text = "AgregarTipo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoActivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTipoActivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txtcodTipoActivo;
        private System.Windows.Forms.DataGridView dgvTipoActivo;
    }
}