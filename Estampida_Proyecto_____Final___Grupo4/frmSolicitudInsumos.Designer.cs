namespace Estampida_Proyecto_____Final___Grupo4
{
    partial class frmSolicitudInsumos
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
            this.lblSolicitante = new System.Windows.Forms.Label();
            this.txtSolicitante = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.grpInsumo = new System.Windows.Forms.GroupBox();
            this.lblInsumo = new System.Windows.Forms.Label();
            this.cmbInsumo = new System.Windows.Forms.ComboBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grpDetalle = new System.Windows.Forms.GroupBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblObligatorio = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.lblMensajeAnular = new System.Windows.Forms.Label();
            this.btnAnular = new System.Windows.Forms.Button();
            this.colNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnSolicitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.tabPrincipal.SuspendLayout();
            this.tabNuevo.SuspendLayout();
            this.tabAnular.SuspendLayout();
            this.grpDatos.SuspendLayout();
            this.grpInsumo.SuspendLayout();
            this.grpDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(12, 12);
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registrar pedido de insumos";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Location = new System.Drawing.Point(12, 48);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(976, 570);
            this.tabPrincipal.TabIndex = 1;
            // 
            // tabNuevo
            // 
            this.tabNuevo.Location = new System.Drawing.Point(4, 24);
            this.tabNuevo.Name = "tabNuevo";
            this.tabNuevo.TabIndex = 2;
            this.tabNuevo.Text = "Nuevo pedido";
            this.tabNuevo.Padding = new System.Windows.Forms.Padding(3);
            this.tabNuevo.UseVisualStyleBackColor = true;
            // 
            // tabAnular
            // 
            this.tabAnular.Location = new System.Drawing.Point(4, 24);
            this.tabAnular.Name = "tabAnular";
            this.tabAnular.TabIndex = 3;
            this.tabAnular.Text = "Anular pedido";
            this.tabAnular.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnular.UseVisualStyleBackColor = true;
            // 
            // grpDatos
            // 
            this.grpDatos.Location = new System.Drawing.Point(10, 10);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(950, 70);
            this.grpDatos.TabIndex = 4;
            this.grpDatos.Text = "Datos del pedido";
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
            this.dtpFecha.Size = new System.Drawing.Size(130, 23);
            this.dtpFecha.TabIndex = 6;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            // 
            // lblSolicitante
            // 
            this.lblSolicitante.Location = new System.Drawing.Point(230, 32);
            this.lblSolicitante.AutoSize = true;
            this.lblSolicitante.Name = "lblSolicitante";
            this.lblSolicitante.TabIndex = 7;
            this.lblSolicitante.Text = "Jefe de cocina solicitante";
            // 
            // txtSolicitante
            // 
            this.txtSolicitante.Location = new System.Drawing.Point(390, 28);
            this.txtSolicitante.Name = "txtSolicitante";
            this.txtSolicitante.Size = new System.Drawing.Size(190, 23);
            this.txtSolicitante.TabIndex = 8;
            this.txtSolicitante.ReadOnly = true;
            this.txtSolicitante.BackColor = System.Drawing.SystemColors.Control;
            // 
            // lblEstado
            // 
            this.lblEstado.Location = new System.Drawing.Point(620, 32);
            this.lblEstado.AutoSize = true;
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(670, 28);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(120, 23);
            this.txtEstado.TabIndex = 10;
            this.txtEstado.Text = "Pendiente";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.BackColor = System.Drawing.SystemColors.Control;
            // 
            // grpInsumo
            // 
            this.grpInsumo.Location = new System.Drawing.Point(10, 90);
            this.grpInsumo.Name = "grpInsumo";
            this.grpInsumo.Size = new System.Drawing.Size(950, 75);
            this.grpInsumo.TabIndex = 11;
            this.grpInsumo.Text = "Agregar insumo";
            // 
            // lblInsumo
            // 
            this.lblInsumo.Location = new System.Drawing.Point(15, 34);
            this.lblInsumo.AutoSize = true;
            this.lblInsumo.Name = "lblInsumo";
            this.lblInsumo.TabIndex = 12;
            this.lblInsumo.Text = "Insumo *";
            // 
            // cmbInsumo
            // 
            this.cmbInsumo.Location = new System.Drawing.Point(75, 30);
            this.cmbInsumo.Name = "cmbInsumo";
            this.cmbInsumo.Size = new System.Drawing.Size(200, 23);
            this.cmbInsumo.TabIndex = 13;
            this.cmbInsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInsumo.FormattingEnabled = true;
            // 
            // lblStock
            // 
            this.lblStock.Location = new System.Drawing.Point(295, 34);
            this.lblStock.AutoSize = true;
            this.lblStock.Name = "lblStock";
            this.lblStock.TabIndex = 14;
            this.lblStock.Text = "Stock disponible";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(395, 30);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(80, 23);
            this.txtStock.TabIndex = 15;
            this.txtStock.ReadOnly = true;
            this.txtStock.BackColor = System.Drawing.SystemColors.Control;
            // 
            // lblCantidad
            // 
            this.lblCantidad.Location = new System.Drawing.Point(495, 34);
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.TabIndex = 16;
            this.lblCantidad.Text = "Cantidad solicitada *";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(630, 30);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(80, 23);
            this.txtCantidad.TabIndex = 17;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(760, 27);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(160, 30);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar insumo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // grpDetalle
            // 
            this.grpDetalle.Location = new System.Drawing.Point(10, 175);
            this.grpDetalle.Name = "grpDetalle";
            this.grpDetalle.Size = new System.Drawing.Size(950, 290);
            this.grpDetalle.TabIndex = 19;
            this.grpDetalle.Text = "Detalle del pedido";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.Location = new System.Drawing.Point(15, 25);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.Size = new System.Drawing.Size(920, 215);
            this.dgvDetalle.TabIndex = 20;
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNro,
            this.colInsumo,
            this.colUnidad,
            this.colStock,
            this.colCantidad});
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(15, 248);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(130, 30);
            this.btnQuitar.TabIndex = 21;
            this.btnQuitar.Text = "Quitar insumo";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Location = new System.Drawing.Point(10, 478);
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.TabIndex = 22;
            this.lblMensaje.Text = "";
            this.lblMensaje.ForeColor = System.Drawing.Color.Firebrick;
            // 
            // lblObligatorio
            // 
            this.lblObligatorio.Location = new System.Drawing.Point(10, 508);
            this.lblObligatorio.AutoSize = true;
            this.lblObligatorio.Name = "lblObligatorio";
            this.lblObligatorio.TabIndex = 23;
            this.lblObligatorio.Text = "Campos obligatorios (*)";
            this.lblObligatorio.ForeColor = System.Drawing.SystemColors.GrayText;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(730, 498);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 34);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(840, 498);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(120, 34);
            this.btnConfirmar.TabIndex = 25;
            this.btnConfirmar.Text = "Confirmar pedido";
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(155, 44, 31);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.Location = new System.Drawing.Point(10, 10);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(950, 430);
            this.dgvPedidos.TabIndex = 26;
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAnNro,
            this.colAnFecha,
            this.colAnSolicitante,
            this.colAnEstado});
            // 
            // lblMensajeAnular
            // 
            this.lblMensajeAnular.Location = new System.Drawing.Point(10, 455);
            this.lblMensajeAnular.AutoSize = true;
            this.lblMensajeAnular.Name = "lblMensajeAnular";
            this.lblMensajeAnular.TabIndex = 27;
            this.lblMensajeAnular.Text = "";
            this.lblMensajeAnular.ForeColor = System.Drawing.Color.Firebrick;
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(830, 450);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(130, 34);
            this.btnAnular.TabIndex = 28;
            this.btnAnular.Text = "Anular pedido";
            this.btnAnular.BackColor = System.Drawing.Color.FromArgb(155, 44, 31);
            this.btnAnular.ForeColor = System.Drawing.Color.White;
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.UseVisualStyleBackColor = false;
            // 
            // colNro
            // 
            this.colNro.HeaderText = "N°";
            this.colNro.Name = "colNro";
            this.colNro.ReadOnly = true;
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
            // colStock
            // 
            this.colStock.HeaderText = "Stock disponible";
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad solicitada";
            this.colCantidad.Name = "colCantidad";
            // 
            // colAnNro
            // 
            this.colAnNro.HeaderText = "N° pedido";
            this.colAnNro.Name = "colAnNro";
            this.colAnNro.ReadOnly = true;
            // 
            // colAnFecha
            // 
            this.colAnFecha.HeaderText = "Fecha";
            this.colAnFecha.Name = "colAnFecha";
            this.colAnFecha.ReadOnly = true;
            // 
            // colAnSolicitante
            // 
            this.colAnSolicitante.HeaderText = "Jefe de cocina";
            this.colAnSolicitante.Name = "colAnSolicitante";
            this.colAnSolicitante.ReadOnly = true;
            // 
            // colAnEstado
            // 
            this.colAnEstado.HeaderText = "Estado";
            this.colAnEstado.Name = "colAnEstado";
            this.colAnEstado.ReadOnly = true;
            // 
            // FrmSolicitudInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 632);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tabPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmSolicitudInsumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar pedido de insumos";
            this.tabPrincipal.Controls.Add(this.tabNuevo);
            this.tabPrincipal.Controls.Add(this.tabAnular);
            this.tabNuevo.Controls.Add(this.grpDatos);
            this.grpDatos.Controls.Add(this.lblFecha);
            this.grpDatos.Controls.Add(this.dtpFecha);
            this.grpDatos.Controls.Add(this.lblSolicitante);
            this.grpDatos.Controls.Add(this.txtSolicitante);
            this.grpDatos.Controls.Add(this.lblEstado);
            this.grpDatos.Controls.Add(this.txtEstado);
            this.tabNuevo.Controls.Add(this.grpInsumo);
            this.grpInsumo.Controls.Add(this.lblInsumo);
            this.grpInsumo.Controls.Add(this.cmbInsumo);
            this.grpInsumo.Controls.Add(this.lblStock);
            this.grpInsumo.Controls.Add(this.txtStock);
            this.grpInsumo.Controls.Add(this.lblCantidad);
            this.grpInsumo.Controls.Add(this.txtCantidad);
            this.grpInsumo.Controls.Add(this.btnAgregar);
            this.tabNuevo.Controls.Add(this.grpDetalle);
            this.grpDetalle.Controls.Add(this.dgvDetalle);
            this.grpDetalle.Controls.Add(this.btnQuitar);
            this.tabNuevo.Controls.Add(this.lblMensaje);
            this.tabNuevo.Controls.Add(this.lblObligatorio);
            this.tabNuevo.Controls.Add(this.btnCancelar);
            this.tabNuevo.Controls.Add(this.btnConfirmar);
            this.tabAnular.Controls.Add(this.dgvPedidos);
            this.tabAnular.Controls.Add(this.lblMensajeAnular);
            this.tabAnular.Controls.Add(this.btnAnular);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.tabPrincipal.ResumeLayout(false);
            this.tabNuevo.ResumeLayout(false);
            this.tabAnular.ResumeLayout(false);
            this.grpDatos.ResumeLayout(false);
            this.grpInsumo.ResumeLayout(false);
            this.grpDetalle.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblSolicitante;
        private System.Windows.Forms.TextBox txtSolicitante;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.GroupBox grpInsumo;
        private System.Windows.Forms.Label lblInsumo;
        private System.Windows.Forms.ComboBox cmbInsumo;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox grpDetalle;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblObligatorio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Label lblMensajeAnular;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnSolicitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnEstado;
    }
}