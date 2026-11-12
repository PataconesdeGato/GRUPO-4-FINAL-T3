namespace Estampida_Proyecto_____Final___Grupo4
{
    partial class frmOrdenCompra
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
            this.tabNueva = new System.Windows.Forms.TabPage();
            this.tabAnular = new System.Windows.Forms.TabPage();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.lblEntrega = new System.Windows.Forms.Label();
            this.dtpEntrega = new System.Windows.Forms.DateTimePicker();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.grpInsumos = new System.Windows.Forms.GroupBox();
            this.dgvInsumos = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblObligatorio = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.dgvOrdenes = new System.Windows.Forms.DataGridView();
            this.lblMensajeAnular = new System.Windows.Forms.Label();
            this.btnAnular = new System.Windows.Forms.Button();
            this.colIncluir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).BeginInit();
            this.tabPrincipal.SuspendLayout();
            this.tabNueva.SuspendLayout();
            this.tabAnular.SuspendLayout();
            this.grpDatos.SuspendLayout();
            this.grpInsumos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(12, 12);
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registrar orden de compra";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Location = new System.Drawing.Point(12, 48);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(976, 520);
            this.tabPrincipal.TabIndex = 1;
            // 
            // tabNueva
            // 
            this.tabNueva.Location = new System.Drawing.Point(4, 24);
            this.tabNueva.Name = "tabNueva";
            this.tabNueva.TabIndex = 2;
            this.tabNueva.Text = "Nueva orden";
            this.tabNueva.Padding = new System.Windows.Forms.Padding(3);
            this.tabNueva.UseVisualStyleBackColor = true;
            // 
            // tabAnular
            // 
            this.tabAnular.Location = new System.Drawing.Point(4, 24);
            this.tabAnular.Name = "tabAnular";
            this.tabAnular.TabIndex = 3;
            this.tabAnular.Text = "Anular orden";
            this.tabAnular.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnular.UseVisualStyleBackColor = true;
            // 
            // grpDatos
            // 
            this.grpDatos.Location = new System.Drawing.Point(10, 10);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(950, 70);
            this.grpDatos.TabIndex = 4;
            this.grpDatos.Text = "Datos de la orden";
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
            // lblProveedor
            // 
            this.lblProveedor.Location = new System.Drawing.Point(195, 32);
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.TabIndex = 7;
            this.lblProveedor.Text = "Proveedor *";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.Location = new System.Drawing.Point(270, 28);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(190, 23);
            this.cmbProveedor.TabIndex = 8;
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.FormattingEnabled = true;
            // 
            // lblEntrega
            // 
            this.lblEntrega.Location = new System.Drawing.Point(480, 32);
            this.lblEntrega.AutoSize = true;
            this.lblEntrega.Name = "lblEntrega";
            this.lblEntrega.TabIndex = 9;
            this.lblEntrega.Text = "Fecha estimada de entrega *";
            // 
            // dtpEntrega
            // 
            this.dtpEntrega.Location = new System.Drawing.Point(650, 28);
            this.dtpEntrega.Name = "dtpEntrega";
            this.dtpEntrega.Size = new System.Drawing.Size(115, 23);
            this.dtpEntrega.TabIndex = 10;
            this.dtpEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            // 
            // lblEstado
            // 
            this.lblEstado.Location = new System.Drawing.Point(785, 32);
            this.lblEstado.AutoSize = true;
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.TabIndex = 11;
            this.lblEstado.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(835, 28);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 23);
            this.txtEstado.TabIndex = 12;
            this.txtEstado.Text = "Emitida";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.BackColor = System.Drawing.SystemColors.Control;
            // 
            // grpInsumos
            // 
            this.grpInsumos.Location = new System.Drawing.Point(10, 90);
            this.grpInsumos.Name = "grpInsumos";
            this.grpInsumos.Size = new System.Drawing.Size(950, 300);
            this.grpInsumos.TabIndex = 13;
            this.grpInsumos.Text = "Insumos con stock igual o menor al mínimo";
            // 
            // dgvInsumos
            // 
            this.dgvInsumos.Location = new System.Drawing.Point(15, 25);
            this.dgvInsumos.Name = "dgvInsumos";
            this.dgvInsumos.Size = new System.Drawing.Size(920, 220);
            this.dgvInsumos.TabIndex = 14;
            this.dgvInsumos.AllowUserToAddRows = false;
            this.dgvInsumos.AllowUserToDeleteRows = false;
            this.dgvInsumos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInsumos.RowHeadersVisible = false;
            this.dgvInsumos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInsumos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIncluir,
            this.colInsumo,
            this.colUnidad,
            this.colStockActual,
            this.colStockMinimo,
            this.colCantidad,
            this.colPrecio,
            this.colImporte});
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(700, 262);
            this.lblTotal.AutoSize = true;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total de la orden (S/):";
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(840, 258);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(95, 23);
            this.txtTotal.TabIndex = 16;
            this.txtTotal.Text = "0.00";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.BackColor = System.Drawing.SystemColors.Control;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Location = new System.Drawing.Point(10, 405);
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.TabIndex = 17;
            this.lblMensaje.Text = "";
            this.lblMensaje.ForeColor = System.Drawing.Color.Firebrick;
            // 
            // lblObligatorio
            // 
            this.lblObligatorio.Location = new System.Drawing.Point(10, 448);
            this.lblObligatorio.AutoSize = true;
            this.lblObligatorio.Name = "lblObligatorio";
            this.lblObligatorio.TabIndex = 18;
            this.lblObligatorio.Text = "Campos obligatorios (*)";
            this.lblObligatorio.ForeColor = System.Drawing.SystemColors.GrayText;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(730, 438);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 34);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(840, 438);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(120, 34);
            this.btnConfirmar.TabIndex = 20;
            this.btnConfirmar.Text = "Confirmar orden";
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(155, 44, 31);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // dgvOrdenes
            // 
            this.dgvOrdenes.Location = new System.Drawing.Point(10, 10);
            this.dgvOrdenes.Name = "dgvOrdenes";
            this.dgvOrdenes.Size = new System.Drawing.Size(950, 370);
            this.dgvOrdenes.TabIndex = 21;
            this.dgvOrdenes.AllowUserToAddRows = false;
            this.dgvOrdenes.AllowUserToDeleteRows = false;
            this.dgvOrdenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrdenes.RowHeadersVisible = false;
            this.dgvOrdenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAnNro,
            this.colAnFecha,
            this.colAnProveedor,
            this.colAnTotal,
            this.colAnEstado});
            // 
            // lblMensajeAnular
            // 
            this.lblMensajeAnular.Location = new System.Drawing.Point(10, 395);
            this.lblMensajeAnular.AutoSize = true;
            this.lblMensajeAnular.Name = "lblMensajeAnular";
            this.lblMensajeAnular.TabIndex = 22;
            this.lblMensajeAnular.Text = "";
            this.lblMensajeAnular.ForeColor = System.Drawing.Color.Firebrick;
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(830, 390);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(130, 34);
            this.btnAnular.TabIndex = 23;
            this.btnAnular.Text = "Anular orden";
            this.btnAnular.BackColor = System.Drawing.Color.FromArgb(155, 44, 31);
            this.btnAnular.ForeColor = System.Drawing.Color.White;
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.UseVisualStyleBackColor = false;
            // 
            // colIncluir
            // 
            this.colIncluir.HeaderText = "Incluir";
            this.colIncluir.Name = "colIncluir";
            // 
            // colInsumo
            // 
            this.colInsumo.HeaderText = "Insumo";
            this.colInsumo.Name = "colInsumo";
            this.colInsumo.ReadOnly = true;
            // 
            // colUnidad
            // 
            this.colUnidad.HeaderText = "Unidad";
            this.colUnidad.Name = "colUnidad";
            this.colUnidad.ReadOnly = true;
            // 
            // colStockActual
            // 
            this.colStockActual.HeaderText = "Stock actual";
            this.colStockActual.Name = "colStockActual";
            this.colStockActual.ReadOnly = true;
            // 
            // colStockMinimo
            // 
            this.colStockMinimo.HeaderText = "Stock mínimo";
            this.colStockMinimo.Name = "colStockMinimo";
            this.colStockMinimo.ReadOnly = true;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad *";
            this.colCantidad.Name = "colCantidad";
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio unitario (S/) *";
            this.colPrecio.Name = "colPrecio";
            // 
            // colImporte
            // 
            this.colImporte.HeaderText = "Importe (S/)";
            this.colImporte.Name = "colImporte";
            this.colImporte.ReadOnly = true;
            // 
            // colAnNro
            // 
            this.colAnNro.HeaderText = "N° orden";
            this.colAnNro.Name = "colAnNro";
            this.colAnNro.ReadOnly = true;
            // 
            // colAnFecha
            // 
            this.colAnFecha.HeaderText = "Fecha";
            this.colAnFecha.Name = "colAnFecha";
            this.colAnFecha.ReadOnly = true;
            // 
            // colAnProveedor
            // 
            this.colAnProveedor.HeaderText = "Proveedor";
            this.colAnProveedor.Name = "colAnProveedor";
            this.colAnProveedor.ReadOnly = true;
            // 
            // colAnTotal
            // 
            this.colAnTotal.HeaderText = "Total (S/)";
            this.colAnTotal.Name = "colAnTotal";
            this.colAnTotal.ReadOnly = true;
            // 
            // colAnEstado
            // 
            this.colAnEstado.HeaderText = "Estado";
            this.colAnEstado.Name = "colAnEstado";
            this.colAnEstado.ReadOnly = true;
            // 
            // FrmOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 582);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tabPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmOrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar orden de compra";
            this.tabPrincipal.Controls.Add(this.tabNueva);
            this.tabPrincipal.Controls.Add(this.tabAnular);
            this.tabNueva.Controls.Add(this.grpDatos);
            this.grpDatos.Controls.Add(this.lblFecha);
            this.grpDatos.Controls.Add(this.dtpFecha);
            this.grpDatos.Controls.Add(this.lblProveedor);
            this.grpDatos.Controls.Add(this.cmbProveedor);
            this.grpDatos.Controls.Add(this.lblEntrega);
            this.grpDatos.Controls.Add(this.dtpEntrega);
            this.grpDatos.Controls.Add(this.lblEstado);
            this.grpDatos.Controls.Add(this.txtEstado);
            this.tabNueva.Controls.Add(this.grpInsumos);
            this.grpInsumos.Controls.Add(this.dgvInsumos);
            this.grpInsumos.Controls.Add(this.lblTotal);
            this.grpInsumos.Controls.Add(this.txtTotal);
            this.tabNueva.Controls.Add(this.lblMensaje);
            this.tabNueva.Controls.Add(this.lblObligatorio);
            this.tabNueva.Controls.Add(this.btnCancelar);
            this.tabNueva.Controls.Add(this.btnConfirmar);
            this.tabAnular.Controls.Add(this.dgvOrdenes);
            this.tabAnular.Controls.Add(this.lblMensajeAnular);
            this.tabAnular.Controls.Add(this.btnAnular);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).EndInit();
            this.tabPrincipal.ResumeLayout(false);
            this.tabNueva.ResumeLayout(false);
            this.tabAnular.ResumeLayout(false);
            this.grpDatos.ResumeLayout(false);
            this.grpInsumos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabNueva;
        private System.Windows.Forms.TabPage tabAnular;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label lblEntrega;
        private System.Windows.Forms.DateTimePicker dtpEntrega;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.GroupBox grpInsumos;
        private System.Windows.Forms.DataGridView dgvInsumos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblObligatorio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridView dgvOrdenes;
        private System.Windows.Forms.Label lblMensajeAnular;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIncluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnEstado;
    }
}