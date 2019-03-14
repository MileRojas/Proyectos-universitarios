namespace Activos
{
    partial class ActivosGrupos
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
            this.dgvActivos = new System.Windows.Forms.DataGridView();
            this.cbTipoActivo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbResponsable = new System.Windows.Forms.ComboBox();
            this.PBFoto = new System.Windows.Forms.PictureBox();
            this.cmbUbicacion = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtRutaFoto = new System.Windows.Forms.TextBox();
            this.lblFotografia = new System.Windows.Forms.Label();
            this.btnFoto = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbResponsable2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvActivos
            // 
            this.dgvActivos.AllowUserToAddRows = false;
            this.dgvActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivos.Location = new System.Drawing.Point(15, 157);
            this.dgvActivos.Name = "dgvActivos";
            this.dgvActivos.Size = new System.Drawing.Size(698, 109);
            this.dgvActivos.TabIndex = 0;
            this.dgvActivos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActivos_CellClick);
            // 
            // cbTipoActivo
            // 
            this.cbTipoActivo.Enabled = false;
            this.cbTipoActivo.FormattingEnabled = true;
            this.cbTipoActivo.Location = new System.Drawing.Point(166, 69);
            this.cbTipoActivo.Name = "cbTipoActivo";
            this.cbTipoActivo.Size = new System.Drawing.Size(121, 21);
            this.cbTipoActivo.TabIndex = 1;
            this.cbTipoActivo.SelectedIndexChanged += new System.EventHandler(this.cbTipoActivo_SelectedIndexChanged);
            this.cbTipoActivo.SelectedValueChanged += new System.EventHandler(this.cbTipoActivo_SelectedValueChanged);
            this.cbTipoActivo.TextChanged += new System.EventHandler(this.cbTipoActivo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione un Tipo de Activo";
            // 
            // cmbResponsable
            // 
            this.cmbResponsable.FormattingEnabled = true;
            this.cmbResponsable.Location = new System.Drawing.Point(157, 451);
            this.cmbResponsable.Name = "cmbResponsable";
            this.cmbResponsable.Size = new System.Drawing.Size(184, 21);
            this.cmbResponsable.TabIndex = 53;
            // 
            // PBFoto
            // 
            this.PBFoto.Location = new System.Drawing.Point(371, 321);
            this.PBFoto.Name = "PBFoto";
            this.PBFoto.Size = new System.Drawing.Size(248, 152);
            this.PBFoto.TabIndex = 52;
            this.PBFoto.TabStop = false;
            // 
            // cmbUbicacion
            // 
            this.cmbUbicacion.FormattingEnabled = true;
            this.cmbUbicacion.Items.AddRange(new object[] {
            "1-100",
            "2-100",
            "3-100",
            "4-100",
            "9-100"});
            this.cmbUbicacion.Location = new System.Drawing.Point(157, 405);
            this.cmbUbicacion.Name = "cmbUbicacion";
            this.cmbUbicacion.Size = new System.Drawing.Size(184, 21);
            this.cmbUbicacion.TabIndex = 51;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(157, 534);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(184, 20);
            this.txtValor.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 541);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Valor Compra";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(157, 488);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(187, 20);
            this.dtpFecha.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 494);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Fecha Compra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Responsable";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Ubicacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nombre";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(157, 332);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(184, 67);
            this.txtDescripcion.TabIndex = 40;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(157, 287);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(184, 20);
            this.txtNombre.TabIndex = 38;
            // 
            // txtRutaFoto
            // 
            this.txtRutaFoto.Location = new System.Drawing.Point(384, 523);
            this.txtRutaFoto.Name = "txtRutaFoto";
            this.txtRutaFoto.Size = new System.Drawing.Size(100, 20);
            this.txtRutaFoto.TabIndex = 56;
            // 
            // lblFotografia
            // 
            this.lblFotografia.AutoSize = true;
            this.lblFotografia.Location = new System.Drawing.Point(490, 530);
            this.lblFotografia.Name = "lblFotografia";
            this.lblFotografia.Size = new System.Drawing.Size(35, 13);
            this.lblFotografia.TabIndex = 57;
            this.lblFotografia.Text = "label8";
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(384, 488);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(75, 23);
            this.btnFoto.TabIndex = 58;
            this.btnFoto.Text = "Nueva Foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(344, 568);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 59;
            this.btnGuardar.Text = "Actualizar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 13);
            this.label8.TabIndex = 61;
            this.label8.Text = "Seleccione que grupo mostrar";
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Items.AddRange(new object[] {
            "Personal",
            "Tipo Activo"});
            this.cmbGrupo.Location = new System.Drawing.Point(166, 26);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(121, 21);
            this.cmbGrupo.TabIndex = 60;
            this.cmbGrupo.TextChanged += new System.EventHandler(this.cmbGrupo_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 13);
            this.label9.TabIndex = 63;
            this.label9.Text = "Seleccione un Responsable";
            // 
            // cmbResponsable2
            // 
            this.cmbResponsable2.Enabled = false;
            this.cmbResponsable2.FormattingEnabled = true;
            this.cmbResponsable2.Location = new System.Drawing.Point(166, 113);
            this.cmbResponsable2.Name = "cmbResponsable2";
            this.cmbResponsable2.Size = new System.Drawing.Size(121, 21);
            this.cmbResponsable2.TabIndex = 62;
            this.cmbResponsable2.TextChanged += new System.EventHandler(this.cmbResponsable2_TextChanged);
            // 
            // ActivosGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 621);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbResponsable2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbGrupo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.lblFotografia);
            this.Controls.Add(this.txtRutaFoto);
            this.Controls.Add(this.cmbResponsable);
            this.Controls.Add(this.PBFoto);
            this.Controls.Add(this.cmbUbicacion);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTipoActivo);
            this.Controls.Add(this.dgvActivos);
            this.Name = "ActivosGrupos";
            this.Text = "ActivosGrupos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvActivos;
        private System.Windows.Forms.ComboBox cbTipoActivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbResponsable;
        private System.Windows.Forms.PictureBox PBFoto;
        private System.Windows.Forms.ComboBox cmbUbicacion;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtRutaFoto;
        private System.Windows.Forms.Label lblFotografia;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbResponsable2;
    }
}