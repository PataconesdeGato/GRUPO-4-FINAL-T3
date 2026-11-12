namespace Estampida_Proyecto_____Final___Grupo4
{
    partial class frmAjusteInventario
    {
        /// <summary>
        /// Variable requerida por el diseñador.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpAjuste = new System.Windows.Forms.GroupBox();
            this.lblReporteTitulo = new System.Windows.Forms.Label();
            this.cboReporte = new System.Windows.Forms.ComboBox();
            this.lblDecisionTitulo = new System.Windows.Forms.Label();
            this.lblDecisionValor = new System.Windows.Forms.Label();
            this.lblInsumoTitulo = new System.Windows.Forms.Label();
            this.cboInsumo = new System.Windows.Forms.ComboBox();
            this.lblStockActualTitulo = new System.Windows.Forms.Label();
            this.lblStockActualValor = new System.Windows.Forms.Label();
            this.lblCantidadTitulo = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblStockResultanteTitulo = new System.Windows.Forms.Label();
            this.lblStockResultanteValor = new System.Windows.Forms.Label();
            this.lblMotivoTitulo = new System.Windows.Forms.Label();
            this.cboMotivo = new System.Windows.Forms.ComboBox();
            this.lblResponsableTitulo = new System.Windows.Forms.Label();
            this.lblResponsableValor = new System.Windows.Forms.Label();
            this.lblObservacionTitulo = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.btnRegistrarAjuste = new System.Windows.Forms.Button();
            this.grpFiltro = new System.Windows.Forms.GroupBox();
            this.lblDesdeTitulo = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHastaTitulo = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblInsumoFiltroTitulo = new System.Windows.Forms.Label();
            this.cboInsumoFiltro = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.grpAjustes = new System.Windows.Forms.GroupBox();
            this.dgvAjustes = new System.Windows.Forms.DataGridView();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMotivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutorizadoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAnularAjuste = new System.Windows.Forms.Button();
            this.btnNuevoAjuste = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.ssEstado = new System.Windows.Forms.StatusStrip();
            this.tsslListo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpAjuste.SuspendLayout();
            this.grpFiltro.SuspendLayout();
            this.grpAjustes.SuspendLayout();
            this.SuspendLayout();

            // grpAjuste
            this.grpAjuste.Controls.Add(this.lblReporteTitulo);
            this.grpAjuste.Controls.Add(this.cboReporte);
            this.grpAjuste.Controls.Add(this.lblDecisionTitulo);
            this.grpAjuste.Controls.Add(this.lblDecisionValor);
            this.grpAjuste.Controls.Add(this.lblInsumoTitulo);
            this.grpAjuste.Controls.Add(this.cboInsumo);
            this.grpAjuste.Controls.Add(this.lblStockActualTitulo);
            this.grpAjuste.Controls.Add(this.lblStockActualValor);
            this.grpAjuste.Controls.Add(this.lblCantidadTitulo);
            this.grpAjuste.Controls.Add(this.nudCantidad);
            this.grpAjuste.Controls.Add(this.lblStockResultanteTitulo);
            this.grpAjuste.Controls.Add(this.lblStockResultanteValor);
            this.grpAjuste.Controls.Add(this.lblMotivoTitulo);
            this.grpAjuste.Controls.Add(this.cboMotivo);
            this.grpAjuste.Controls.Add(this.lblResponsableTitulo);
            this.grpAjuste.Controls.Add(this.lblResponsableValor);
            this.grpAjuste.Controls.Add(this.lblObservacionTitulo);
            this.grpAjuste.Controls.Add(this.txtObservacion);
            this.grpAjuste.Controls.Add(this.btnRegistrarAjuste);
            this.grpAjuste.Location = new System.Drawing.Point(12, 12);
            this.grpAjuste.Name = "grpAjuste";
            this.grpAjuste.Size = new System.Drawing.Size(976, 230);
            this.grpAjuste.TabStop = false;
            this.grpAjuste.Text = "Registrar ajuste de inventario";

            // lblReporteTitulo
            this.lblReporteTitulo.AutoSize = true;
            this.lblReporteTitulo.Location = new System.Drawing.Point(14, 30);
            this.lblReporteTitulo.Name = "lblReporteTitulo";
            this.lblReporteTitulo.Text = "Reporte de diferencias:";

            // cboReporte
            this.cboReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReporte.FormattingEnabled = true;
            this.cboReporte.Location = new System.Drawing.Point(150, 27);
            this.cboReporte.Name = "cboReporte";
            this.cboReporte.Size = new System.Drawing.Size(300, 23);
            this.cboReporte.SelectedIndexChanged += new System.EventHandler(this.cboReporte_SelectedIndexChanged);

            // lblDecisionTitulo
            this.lblDecisionTitulo.AutoSize = true;
            this.lblDecisionTitulo.Location = new System.Drawing.Point(470, 30);
            this.lblDecisionTitulo.Name = "lblDecisionTitulo";
            this.lblDecisionTitulo.Text = "Decisión del Administrador:";

            // lblDecisionValor
            this.lblDecisionValor.AutoSize = true;
            this.lblDecisionValor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDecisionValor.ForeColor = System.Drawing.Color.FromArgb(16, 124, 16);
            this.lblDecisionValor.Location = new System.Drawing.Point(640, 30);
            this.lblDecisionValor.Name = "lblDecisionValor";
            this.lblDecisionValor.Text = "Autorizado";

            // lblInsumoTitulo
            this.lblInsumoTitulo.AutoSize = true;
            this.lblInsumoTitulo.Location = new System.Drawing.Point(14, 64);
            this.lblInsumoTitulo.Name = "lblInsumoTitulo";
            this.lblInsumoTitulo.Text = "Insumo:";

            // cboInsumo
            this.cboInsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInsumo.FormattingEnabled = true;
            this.cboInsumo.Location = new System.Drawing.Point(150, 61);
            this.cboInsumo.Name = "cboInsumo";
            this.cboInsumo.Size = new System.Drawing.Size(300, 23);
            this.cboInsumo.SelectedIndexChanged += new System.EventHandler(this.cboInsumo_SelectedIndexChanged);

            // lblStockActualTitulo
            this.lblStockActualTitulo.AutoSize = true;
            this.lblStockActualTitulo.Location = new System.Drawing.Point(470, 64);
            this.lblStockActualTitulo.Name = "lblStockActualTitulo";
            this.lblStockActualTitulo.Text = "Stock actual:";

            // lblStockActualValor
            this.lblStockActualValor.AutoSize = true;
            this.lblStockActualValor.Location = new System.Drawing.Point(560, 64);
            this.lblStockActualValor.Name = "lblStockActualValor";
            this.lblStockActualValor.Text = "0";

            // lblCantidadTitulo
            this.lblCantidadTitulo.AutoSize = true;
            this.lblCantidadTitulo.Location = new System.Drawing.Point(14, 98);
            this.lblCantidadTitulo.Name = "lblCantidadTitulo";
            this.lblCantidadTitulo.Text = "Cantidad (+ / -):";

            // nudCantidad (positivo suma al stock, negativo lo resta)
            this.nudCantidad.Location = new System.Drawing.Point(150, 95);
            this.nudCantidad.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            this.nudCantidad.Minimum = new decimal(new int[] { 9999, 0, 0, -2147483648 });
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(100, 23);
            this.nudCantidad.ValueChanged += new System.EventHandler(this.nudCantidad_ValueChanged);

            // lblStockResultanteTitulo
            this.lblStockResultanteTitulo.AutoSize = true;
            this.lblStockResultanteTitulo.Location = new System.Drawing.Point(270, 98);
            this.lblStockResultanteTitulo.Name = "lblStockResultanteTitulo";
            this.lblStockResultanteTitulo.Text = "Stock resultante:";

            // lblStockResultanteValor
            this.lblStockResultanteValor.AutoSize = true;
            this.lblStockResultanteValor.Location = new System.Drawing.Point(370, 98);
            this.lblStockResultanteValor.Name = "lblStockResultanteValor";
            this.lblStockResultanteValor.Text = "0";

            // lblMotivoTitulo
            this.lblMotivoTitulo.AutoSize = true;
            this.lblMotivoTitulo.Location = new System.Drawing.Point(14, 132);
            this.lblMotivoTitulo.Name = "lblMotivoTitulo";
            this.lblMotivoTitulo.Text = "Motivo:";

            // cboMotivo
            this.cboMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMotivo.FormattingEnabled = true;
            this.cboMotivo.Location = new System.Drawing.Point(150, 129);
            this.cboMotivo.Name = "cboMotivo";
            this.cboMotivo.Size = new System.Drawing.Size(300, 23);

            // lblResponsableTitulo
            this.lblResponsableTitulo.AutoSize = true;
            this.lblResponsableTitulo.Location = new System.Drawing.Point(470, 132);
            this.lblResponsableTitulo.Name = "lblResponsableTitulo";
            this.lblResponsableTitulo.Text = "Responsable:";

            // lblResponsableValor
            this.lblResponsableValor.AutoSize = true;
            this.lblResponsableValor.Location = new System.Drawing.Point(560, 132);
            this.lblResponsableValor.Name = "lblResponsableValor";
            this.lblResponsableValor.Text = "Jorge Medina Flores";

            // lblObservacionTitulo
            this.lblObservacionTitulo.AutoSize = true;
            this.lblObservacionTitulo.Location = new System.Drawing.Point(14, 166);
            this.lblObservacionTitulo.Name = "lblObservacionTitulo";
            this.lblObservacionTitulo.Text = "Observación:";

            // txtObservacion
            this.txtObservacion.Location = new System.Drawing.Point(150, 163);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(806, 23);

            // btnRegistrarAjuste
            this.btnRegistrarAjuste.Location = new System.Drawing.Point(816, 192);
            this.btnRegistrarAjuste.Name = "btnRegistrarAjuste";
            this.btnRegistrarAjuste.Size = new System.Drawing.Size(140, 28);
            this.btnRegistrarAjuste.Text = "Registrar ajuste";
            this.btnRegistrarAjuste.UseVisualStyleBackColor = true;
            this.btnRegistrarAjuste.Click += new System.EventHandler(this.btnRegistrarAjuste_Click);

            // grpFiltro
            this.grpFiltro.Controls.Add(this.lblDesdeTitulo);
            this.grpFiltro.Controls.Add(this.dtpDesde);
            this.grpFiltro.Controls.Add(this.lblHastaTitulo);
            this.grpFiltro.Controls.Add(this.dtpHasta);
            this.grpFiltro.Controls.Add(this.lblInsumoFiltroTitulo);
            this.grpFiltro.Controls.Add(this.cboInsumoFiltro);
            this.grpFiltro.Controls.Add(this.btnConsultar);
            this.grpFiltro.Controls.Add(this.btnLimpiarFiltro);
            this.grpFiltro.Location = new System.Drawing.Point(12, 250);
            this.grpFiltro.Name = "grpFiltro";
            this.grpFiltro.Size = new System.Drawing.Size(976, 64);
            this.grpFiltro.TabStop = false;
            this.grpFiltro.Text = "Consultar ajustes";

            // lblDesdeTitulo
            this.lblDesdeTitulo.AutoSize = true;
            this.lblDesdeTitulo.Location = new System.Drawing.Point(14, 28);
            this.lblDesdeTitulo.Name = "lblDesdeTitulo";
            this.lblDesdeTitulo.Text = "Desde:";

            // dtpDesde
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(62, 24);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(140, 23);

            // lblHastaTitulo
            this.lblHastaTitulo.AutoSize = true;
            this.lblHastaTitulo.Location = new System.Drawing.Point(220, 28);
            this.lblHastaTitulo.Name = "lblHastaTitulo";
            this.lblHastaTitulo.Text = "Hasta:";

            // dtpHasta
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(268, 24);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(140, 23);

            // lblInsumoFiltroTitulo
            this.lblInsumoFiltroTitulo.AutoSize = true;
            this.lblInsumoFiltroTitulo.Location = new System.Drawing.Point(430, 28);
            this.lblInsumoFiltroTitulo.Name = "lblInsumoFiltroTitulo";
            this.lblInsumoFiltroTitulo.Text = "Insumo:";

            // cboInsumoFiltro
            this.cboInsumoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInsumoFiltro.FormattingEnabled = true;
            this.cboInsumoFiltro.Location = new System.Drawing.Point(480, 25);
            this.cboInsumoFiltro.Name = "cboInsumoFiltro";
            this.cboInsumoFiltro.Size = new System.Drawing.Size(240, 23);

            // btnConsultar
            this.btnConsultar.Location = new System.Drawing.Point(740, 22);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(110, 28);
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);

            // btnLimpiarFiltro
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(860, 22);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiarFiltro.Text = "Limpiar";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltro.Click += new System.EventHandler(this.btnLimpiarFiltro_Click);

            // grpAjustes
            this.grpAjustes.Controls.Add(this.dgvAjustes);
            this.grpAjustes.Location = new System.Drawing.Point(12, 326);
            this.grpAjustes.Name = "grpAjustes";
            this.grpAjustes.Size = new System.Drawing.Size(976, 300);
            this.grpAjustes.TabStop = false;
            this.grpAjustes.Text = "Ajustes registrados";

            // dgvAjustes
            this.dgvAjustes.AllowUserToAddRows = false;
            this.dgvAjustes.AllowUserToDeleteRows = false;
            this.dgvAjustes.AllowUserToResizeRows = false;
            this.dgvAjustes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAjustes.BackgroundColor = System.Drawing.Color.White;
            this.dgvAjustes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvAjustes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAjustes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFecha,
            this.colInsumo,
            this.colCantidad,
            this.colMotivo,
            this.colAutorizadoPor,
            this.colEstado});
            this.dgvAjustes.Location = new System.Drawing.Point(14, 26);
            this.dgvAjustes.MultiSelect = false;
            this.dgvAjustes.Name = "dgvAjustes";
            this.dgvAjustes.ReadOnly = true;
            this.dgvAjustes.RowHeadersVisible = false;
            this.dgvAjustes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAjustes.Size = new System.Drawing.Size(946, 262);

            // colFecha
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;

            // colInsumo
            this.colInsumo.HeaderText = "Insumo";
            this.colInsumo.Name = "colInsumo";
            this.colInsumo.ReadOnly = true;

            // colCantidad
            this.colCantidad.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;

            // colMotivo
            this.colMotivo.HeaderText = "Motivo";
            this.colMotivo.Name = "colMotivo";
            this.colMotivo.ReadOnly = true;

            // colAutorizadoPor
            this.colAutorizadoPor.HeaderText = "Autorizado por";
            this.colAutorizadoPor.Name = "colAutorizadoPor";
            this.colAutorizadoPor.ReadOnly = true;

            // colEstado
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;

            // btnAnularAjuste
            this.btnAnularAjuste.Location = new System.Drawing.Point(14, 636);
            this.btnAnularAjuste.Name = "btnAnularAjuste";
            this.btnAnularAjuste.Size = new System.Drawing.Size(150, 28);
            this.btnAnularAjuste.Text = "Anular ajuste";
            this.btnAnularAjuste.UseVisualStyleBackColor = true;
            this.btnAnularAjuste.Click += new System.EventHandler(this.btnAnularAjuste_Click);

            // btnNuevoAjuste
            this.btnNuevoAjuste.Location = new System.Drawing.Point(172, 636);
            this.btnNuevoAjuste.Name = "btnNuevoAjuste";
            this.btnNuevoAjuste.Size = new System.Drawing.Size(130, 28);
            this.btnNuevoAjuste.Text = "Nuevo ajuste";
            this.btnNuevoAjuste.UseVisualStyleBackColor = true;
            this.btnNuevoAjuste.Click += new System.EventHandler(this.btnNuevoAjuste_Click);

            // btnCerrar
            this.btnCerrar.Location = new System.Drawing.Point(876, 636);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(110, 28);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);

            // ssEstado
            this.ssEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslListo,
            this.tsslUsuario});
            this.ssEstado.Location = new System.Drawing.Point(0, 678);
            this.ssEstado.Name = "ssEstado";
            this.ssEstado.Size = new System.Drawing.Size(1000, 22);

            // tsslListo
            this.tsslListo.Name = "tsslListo";
            this.tsslListo.Spring = true;
            this.tsslListo.Text = "Listo";
            this.tsslListo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // tsslUsuario
            this.tsslUsuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsslUsuario.Name = "tsslUsuario";
            this.tsslUsuario.Text = "Usuario: Jefe de Almacén · 12/11/2026";

            // frmAjusteInventario
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.ssEstado);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnNuevoAjuste);
            this.Controls.Add(this.btnAnularAjuste);
            this.Controls.Add(this.grpAjustes);
            this.Controls.Add(this.grpFiltro);
            this.Controls.Add(this.grpAjuste);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmAjusteInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajustes de inventario – La Estampida";
            this.Load += new System.EventHandler(this.frmAjusteInventario_Load);
            this.grpAjuste.ResumeLayout(false);
            this.grpAjuste.PerformLayout();
            this.grpFiltro.ResumeLayout(false);
            this.grpFiltro.PerformLayout();
            this.grpAjustes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAjustes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpAjuste;
        private System.Windows.Forms.Label lblReporteTitulo;
        private System.Windows.Forms.ComboBox cboReporte;
        private System.Windows.Forms.Label lblDecisionTitulo;
        private System.Windows.Forms.Label lblDecisionValor;
        private System.Windows.Forms.Label lblInsumoTitulo;
        private System.Windows.Forms.ComboBox cboInsumo;
        private System.Windows.Forms.Label lblStockActualTitulo;
        private System.Windows.Forms.Label lblStockActualValor;
        private System.Windows.Forms.Label lblCantidadTitulo;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblStockResultanteTitulo;
        private System.Windows.Forms.Label lblStockResultanteValor;
        private System.Windows.Forms.Label lblMotivoTitulo;
        private System.Windows.Forms.ComboBox cboMotivo;
        private System.Windows.Forms.Label lblResponsableTitulo;
        private System.Windows.Forms.Label lblResponsableValor;
        private System.Windows.Forms.Label lblObservacionTitulo;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Button btnRegistrarAjuste;
        private System.Windows.Forms.GroupBox grpFiltro;
        private System.Windows.Forms.Label lblDesdeTitulo;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHastaTitulo;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblInsumoFiltroTitulo;
        private System.Windows.Forms.ComboBox cboInsumoFiltro;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnLimpiarFiltro;
        private System.Windows.Forms.GroupBox grpAjustes;
        private System.Windows.Forms.DataGridView dgvAjustes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMotivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutorizadoPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.Button btnAnularAjuste;
        private System.Windows.Forms.Button btnNuevoAjuste;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.StatusStrip ssEstado;
        private System.Windows.Forms.ToolStripStatusLabel tsslListo;
        private System.Windows.Forms.ToolStripStatusLabel tsslUsuario;
    }
}
