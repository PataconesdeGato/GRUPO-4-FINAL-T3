namespace Estampida_Proyecto_____Final___Grupo4
{
    partial class frmIngresoInsumos
    {
        private System.ComponentModel.IContainer components = null;

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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabNuevo = new System.Windows.Forms.TabPage();
            this.tabAnular = new System.Windows.Forms.TabPage();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblOrden = new System.Windows.Forms.Label();
            this.cmbOrden = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.lblFactura = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.grpVerificacion = new System.Windows.Forms.GroupBox();
            this.dgvVerificacion = new System.Windows.Forms.DataGridView();
            this.lblNota = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblObligatorio = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.dgvIngresos = new System.Windows.Forms.DataGridView();
            this.lblMensajeAnular = new System.Windows.Forms.Label();
            this.btnAnular = new System.Windows.Forms.Button();
            this.colInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecibida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVerificacion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colMotivo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colAnNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresos)).BeginInit();
            this.tabPrincipal.SuspendLayout();
            this.tabNuevo.SuspendLayout();
            this.tabAnular.SuspendLayout();
            this.grpDatos.SuspendLayout();
            this.grpVerificacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(12, 12);
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registrar ingreso de insumos";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Location = new System.Drawing.Point(12, 48);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(976, 560);
            this.tabPrincipal.TabIndex = 1;
            // 
            // tabNuevo
            // 
            this.tabNuevo.Location = new System.Drawing.Point(4, 24);
            this.tabNuevo.Name = "tabNuevo";
            this.tabNuevo.TabIndex = 2;
            this.tabNuevo.Text = "Nuevo ingreso";
            this.tabNuevo.Padding = new System.Windows.Forms.Padding(3);
            this.tabNuevo.UseVisualStyleBackColor = true;
            // 
            // tabAnular
            // 
            this.tabAnular.Location = new System.Drawing.Point(4, 24);
            this.tabAnular.Name = "tabAnular";
            this.tabAnular.TabIndex = 3;
            this.tabAnular.Text = "Anular ingreso";
            this.tabAnular.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnular.UseVisualStyleBackColor = true;
            // 
            // grpDatos
            // 
            this.grpDatos.Location = new System.Drawing.Point(10, 10);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(950, 100);
            this.grpDatos.TabIndex = 4;
            this.grpDatos.Text = "Datos del ingreso";
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(15, 32);
            this.lblFecha.AutoSize = true;
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha *";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(60, 28);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(115, 23);
            this.dtpFecha.TabIndex = 6;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            // 
            // lblOrden
            // 
            this.lblOrden.Location = new System.Drawing.Point(215, 32);
            this.lblOrden.AutoSize = true;
            this.lblOrden.Name = "lblOrden";
            this.lblOrden.TabIndex = 7;
            this.lblOrden.Text = "Orden de compra *";
            // 
            // cmbOrden
            // 
            this.cmbOrden.Location = new System.Drawing.Point(335, 28);
            this.cmbOrden.Name = "cmbOrden";
            this.cmbOrden.Size = new System.Drawing.Size(150, 23);
            this.cmbOrden.TabIndex = 8;
            this.cmbOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrden.FormattingEnabled = true;
            // 
            // lblProveedor
            // 
            this.lblProveedor.Location = new System.Drawing.Point(525, 32);
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.TabIndex = 9;
            this.lblProveedor.Text = "Proveedor";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(595, 28);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(230, 23);
            this.txtProveedor.TabIndex = 10;
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.BackColor = System.Drawing.SystemColors.Control;
            // 
            // lblFactura
            // 
            this.lblFactura.Location = new System.Drawing.Point(15, 66);
            this.lblFactura.AutoSize = true;
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.TabIndex = 11;
            this.lblFactura.Text = "N° de factura o guía *";
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(150, 62);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(160, 23);
            this.txtFactura.TabIndex = 12;
            // 
            // grpVerificacion
            // 
            this.grpVerificacion.Location = new System.Drawing.Point(10, 120);
            this.grpVerificacion.Name = "grpVerificacion";
            this.grpVerificacion.Size = new System.Drawing.Size(950, 285);
            this.grpVerificacion.TabIndex = 13;
            this.grpVerificacion.Text = "Verificación de insumos recibidos";
            // 
            // dgvVerificacion
            // 
            this.dgvVerificacion.Location = new System.Drawing.Point(15, 25);
            this.dgvVerificacion.Name = "dgvVerificacion";
            this.dgvVerificacion.Size = new System.Drawing.Size(920, 205);
            this.dgvVerificacion.TabIndex = 14;
            this.dgvVerificacion.AllowUserToAddRows = false;
            this.dgvVerificacion.AllowUserToDeleteRows = false;
            this.dgvVerificacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVerificacion.RowHeadersVisible = false;
            this.dgvVerificacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVerificacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInsumo,
            this.colPedida,
            this.colRecibida,
            this.colPeso,
            this.colVerificacion,
            this.colMotivo});
            // 
            // lblNota
            // 
            this.lblNota.Location = new System.Drawing.Point(15, 245);
            this.lblNota.AutoSize = true;
            this.lblNota.Name = "lblNota";
            this.lblNota.TabIndex = 15;
            this.lblNota.Text = "Cada insumo rechazado genera una incidencia. El stock aumenta solo con lo aceptado.";
            this.lblNota.ForeColor = System.Drawing.SystemColors.GrayText;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Location = new System.Drawing.Point(10, 415);
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.TabIndex = 16;
            this.lblMensaje.Text = "";
            this.lblMensaje.ForeColor = System.Drawing.Color.Firebrick;
            // 
            // lblObligatorio
            // 
            this.lblObligatorio.Location = new System.Drawing.Point(10, 488);
            this.lblObligatorio.AutoSize = true;
            this.lblObligatorio.Name = "lblObligatorio";
            this.lblObligatorio.TabIndex = 17;
            this.lblObligatorio.Text = "Campos obligatorios (*)";
            this.lblObligatorio.ForeColor = System.Drawing.SystemColors.GrayText;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(730, 478);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 34);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(840, 478);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(120, 34);
            this.btnConfirmar.TabIndex = 19;
            this.btnConfirmar.Text = "Confirmar ingreso";
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(155, 44, 31);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // dgvIngresos
            // 
            this.dgvIngresos.Location = new System.Drawing.Point(10, 10);
            this.dgvIngresos.Name = "dgvIngresos";
            this.dgvIngresos.Size = new System.Drawing.Size(950, 410);
            this.dgvIngresos.TabIndex = 20;
            this.dgvIngresos.AllowUserToAddRows = false;
            this.dgvIngresos.AllowUserToDeleteRows = false;
            this.dgvIngresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIngresos.RowHeadersVisible = false;
            this.dgvIngresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIngresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAnNro,
            this.colAnFecha,
            this.colAnOrden,
            this.colAnProveedor,
            this.colAnFactura,
            this.colAnEstado});
            // 
            // lblMensajeAnular
            // 
            this.lblMensajeAnular.Location = new System.Drawing.Point(10, 435);
            this.lblMensajeAnular.AutoSize = true;
            this.lblMensajeAnular.Name = "lblMensajeAnular";
            this.lblMensajeAnular.TabIndex = 21;
            this.lblMensajeAnular.Text = "";
            this.lblMensajeAnular.ForeColor = System.Drawing.Color.Firebrick;
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(820, 430);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(140, 34);
            this.btnAnular.TabIndex = 22;
            this.btnAnular.Text = "Anular ingreso";
            this.btnAnular.BackColor = System.Drawing.Color.FromArgb(155, 44, 31);
            this.btnAnular.ForeColor = System.Drawing.Color.White;
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.UseVisualStyleBackColor = false;
            // 
            // colInsumo
            // 
            this.colInsumo.HeaderText = "Insumo";
            this.colInsumo.Name = "colInsumo";
            this.colInsumo.ReadOnly = true;
            // 
            // colPedida
            // 
            this.colPedida.HeaderText = "Cantidad pedida";
            this.colPedida.Name = "colPedida";
            this.colPedida.ReadOnly = true;
            // 
            // colRecibida
            // 
            this.colRecibida.HeaderText = "Cantidad recibida *";
            this.colRecibida.Name = "colRecibida";
            // 
            // colPeso
            // 
            this.colPeso.HeaderText = "Peso (kg) *";
            this.colPeso.Name = "colPeso";
            // 
            // colVerificacion
            // 
            this.colVerificacion.HeaderText = "Verificación *";
            this.colVerificacion.Name = "colVerificacion";
            this.colVerificacion.Items.AddRange(new object[] { "Aceptado", "Rechazado" });
            // 
            // colMotivo
            // 
            this.colMotivo.HeaderText = "Motivo de rechazo";
            this.colMotivo.Name = "colMotivo";
            this.colMotivo.Items.AddRange(new object[] { "Calidad", "Peso" });
            // 
            // colAnNro
            // 
            this.colAnNro.HeaderText = "N° ingreso";
            this.colAnNro.Name = "colAnNro";
            this.colAnNro.ReadOnly = true;
            // 
            // colAnFecha
            // 
            this.colAnFecha.HeaderText = "Fecha";
            this.colAnFecha.Name = "colAnFecha";
            this.colAnFecha.ReadOnly = true;
            // 
            // colAnOrden
            // 
            this.colAnOrden.HeaderText = "Orden de compra";
            this.colAnOrden.Name = "colAnOrden";
            this.colAnOrden.ReadOnly = true;
            // 
            // colAnProveedor
            // 
            this.colAnProveedor.HeaderText = "Proveedor";
            this.colAnProveedor.Name = "colAnProveedor";
            this.colAnProveedor.ReadOnly = true;
            // 
            // colAnFactura
            // 
            this.colAnFactura.HeaderText = "Factura o guía";
            this.colAnFactura.Name = "colAnFactura";
            this.colAnFactura.ReadOnly = true;
            // 
            // colAnEstado
            // 
            this.colAnEstado.HeaderText = "Estado";
            this.colAnEstado.Name = "colAnEstado";
            this.colAnEstado.ReadOnly = true;
            // 
            // FrmIngresoInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 622);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tabPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmIngresoInsumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar ingreso de insumos";
            this.tabPrincipal.Controls.Add(this.tabNuevo);
            this.tabPrincipal.Controls.Add(this.tabAnular);
            this.tabNuevo.Controls.Add(this.grpDatos);
            this.grpDatos.Controls.Add(this.lblFecha);
            this.grpDatos.Controls.Add(this.dtpFecha);
            this.grpDatos.Controls.Add(this.lblOrden);
            this.grpDatos.Controls.Add(this.cmbOrden);
            this.grpDatos.Controls.Add(this.lblProveedor);
            this.grpDatos.Controls.Add(this.txtProveedor);
            this.grpDatos.Controls.Add(this.lblFactura);
            this.grpDatos.Controls.Add(this.txtFactura);
            this.tabNuevo.Controls.Add(this.grpVerificacion);
            this.grpVerificacion.Controls.Add(this.dgvVerificacion);
            this.grpVerificacion.Controls.Add(this.lblNota);
            this.tabNuevo.Controls.Add(this.lblMensaje);
            this.tabNuevo.Controls.Add(this.lblObligatorio);
            this.tabNuevo.Controls.Add(this.btnCancelar);
            this.tabNuevo.Controls.Add(this.btnConfirmar);
            this.tabAnular.Controls.Add(this.dgvIngresos);
            this.tabAnular.Controls.Add(this.lblMensajeAnular);
            this.tabAnular.Controls.Add(this.btnAnular);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresos)).EndInit();
            this.tabPrincipal.ResumeLayout(false);
            this.tabNuevo.ResumeLayout(false);
            this.tabAnular.ResumeLayout(false);
            this.grpDatos.ResumeLayout(false);
            this.grpVerificacion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabNuevo;
        private System.Windows.Forms.TabPage tabAnular;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblOrden;
        private System.Windows.Forms.ComboBox cmbOrden;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.GroupBox grpVerificacion;
        private System.Windows.Forms.DataGridView dgvVerificacion;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblObligatorio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridView dgvIngresos;
        private System.Windows.Forms.Label lblMensajeAnular;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecibida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeso;
        private System.Windows.Forms.DataGridViewComboBoxColumn colVerificacion;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMotivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnEstado;
    }
}