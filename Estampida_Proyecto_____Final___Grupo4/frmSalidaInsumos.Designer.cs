namespace Estampida_Proyecto_____Final___Grupo4
{
    partial class frmSalidaInsumos
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
            this.grpPendientes = new System.Windows.Forms.GroupBox();
            this.dgvPendientes = new System.Windows.Forms.DataGridView();
            this.grpDetalle = new System.Windows.Forms.GroupBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.lblPedido = new System.Windows.Forms.Label();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.lblAlerta = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.lblObligatorio = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.colNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSolicitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSolicitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEntregada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.grpPendientes.SuspendLayout();
            this.grpDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(12, 12);
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registrar salida de insumos";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            // 
            // grpPendientes
            // 
            this.grpPendientes.Location = new System.Drawing.Point(12, 48);
            this.grpPendientes.Name = "grpPendientes";
            this.grpPendientes.Size = new System.Drawing.Size(976, 175);
            this.grpPendientes.TabIndex = 1;
            this.grpPendientes.Text = "Pedidos de insumos pendientes";
            // 
            // dgvPendientes
            // 
            this.dgvPendientes.Location = new System.Drawing.Point(15, 25);
            this.dgvPendientes.Name = "dgvPendientes";
            this.dgvPendientes.Size = new System.Drawing.Size(945, 135);
            this.dgvPendientes.TabIndex = 2;
            this.dgvPendientes.AllowUserToAddRows = false;
            this.dgvPendientes.AllowUserToDeleteRows = false;
            this.dgvPendientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPendientes.RowHeadersVisible = false;
            this.dgvPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNro,
            this.colFecha,
            this.colSolicitante,
            this.colEstado});
            // 
            // grpDetalle
            // 
            this.grpDetalle.Location = new System.Drawing.Point(12, 233);
            this.grpDetalle.Name = "grpDetalle";
            this.grpDetalle.Size = new System.Drawing.Size(976, 345);
            this.grpDetalle.TabIndex = 3;
            this.grpDetalle.Text = "Detalle del pedido";
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(15, 32);
            this.lblFecha.AutoSize = true;
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(55, 28);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 23);
            this.txtFecha.TabIndex = 5;
            this.txtFecha.ReadOnly = true;
            this.txtFecha.BackColor = System.Drawing.SystemColors.Control;
            // 
            // lblHora
            // 
            this.lblHora.Location = new System.Drawing.Point(185, 32);
            this.lblHora.AutoSize = true;
            this.lblHora.Name = "lblHora";
            this.lblHora.TabIndex = 6;
            this.lblHora.Text = "Hora";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(225, 28);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(80, 23);
            this.txtHora.TabIndex = 7;
            this.txtHora.ReadOnly = true;
            this.txtHora.BackColor = System.Drawing.SystemColors.Control;
            // 
            // lblPedido
            // 
            this.lblPedido.Location = new System.Drawing.Point(335, 32);
            this.lblPedido.AutoSize = true;
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.TabIndex = 8;
            this.lblPedido.Text = "Pedido asociado";
            // 
            // txtPedido
            // 
            this.txtPedido.Location = new System.Drawing.Point(435, 28);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(90, 23);
            this.txtPedido.TabIndex = 9;
            this.txtPedido.ReadOnly = true;
            this.txtPedido.BackColor = System.Drawing.SystemColors.Control;
            // 
            // lblResponsable
            // 
            this.lblResponsable.Location = new System.Drawing.Point(560, 32);
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.TabIndex = 10;
            this.lblResponsable.Text = "Responsable";
            // 
            // txtResponsable
            // 
            this.txtResponsable.Location = new System.Drawing.Point(645, 28);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(200, 23);
            this.txtResponsable.TabIndex = 11;
            this.txtResponsable.ReadOnly = true;
            this.txtResponsable.BackColor = System.Drawing.SystemColors.Control;
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.Location = new System.Drawing.Point(15, 65);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.Size = new System.Drawing.Size(945, 200);
            this.dgvDetalle.TabIndex = 12;
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInsumo,
            this.colUnidad,
            this.colSolicitado,
            this.colStock,
            this.colEntregada,
            this.colEstadoStock});
            // 
            // lblAlerta
            // 
            this.lblAlerta.Location = new System.Drawing.Point(15, 278);
            this.lblAlerta.AutoSize = true;
            this.lblAlerta.Name = "lblAlerta";
            this.lblAlerta.TabIndex = 13;
            this.lblAlerta.Text = "Alerta de desabastecimiento: insumo, cantidad solicitada y cantidad disponible.";
            this.lblAlerta.ForeColor = System.Drawing.Color.Firebrick;
            this.lblAlerta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            // 
            // lblNota
            // 
            this.lblNota.Location = new System.Drawing.Point(15, 310);
            this.lblNota.AutoSize = true;
            this.lblNota.Name = "lblNota";
            this.lblNota.TabIndex = 14;
            this.lblNota.Text = "Al registrar la salida se descuenta el stock, se genera la nota de insumos y el pedido pasa a Atendido.";
            this.lblNota.ForeColor = System.Drawing.SystemColors.GrayText;
            // 
            // lblObligatorio
            // 
            this.lblObligatorio.Location = new System.Drawing.Point(12, 600);
            this.lblObligatorio.AutoSize = true;
            this.lblObligatorio.Name = "lblObligatorio";
            this.lblObligatorio.TabIndex = 15;
            this.lblObligatorio.Text = "Campos obligatorios (*)";
            this.lblObligatorio.ForeColor = System.Drawing.SystemColors.GrayText;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(762, 592);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 34);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(872, 592);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(116, 34);
            this.btnRegistrar.TabIndex = 17;
            this.btnRegistrar.Text = "Registrar salida";
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(155, 44, 31);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // colNro
            // 
            this.colNro.HeaderText = "N° pedido";
            this.colNro.Name = "colNro";
            this.colNro.ReadOnly = true;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colSolicitante
            // 
            this.colSolicitante.HeaderText = "Jefe de cocina";
            this.colSolicitante.Name = "colSolicitante";
            this.colSolicitante.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
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
            // colSolicitado
            // 
            this.colSolicitado.HeaderText = "Solicitado";
            this.colSolicitado.Name = "colSolicitado";
            this.colSolicitado.ReadOnly = true;
            // 
            // colStock
            // 
            this.colStock.HeaderText = "Stock disponible";
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            // 
            // colEntregada
            // 
            this.colEntregada.HeaderText = "Cantidad entregada *";
            this.colEntregada.Name = "colEntregada";
            // 
            // colEstadoStock
            // 
            this.colEstadoStock.HeaderText = "Estado de stock";
            this.colEstadoStock.Name = "colEstadoStock";
            this.colEstadoStock.ReadOnly = true;
            // 
            // FrmSalidaInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 640);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grpPendientes);
            this.Controls.Add(this.grpDetalle);
            this.Controls.Add(this.lblObligatorio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmSalidaInsumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar salida de insumos";
            this.grpPendientes.Controls.Add(this.dgvPendientes);
            this.grpDetalle.Controls.Add(this.lblFecha);
            this.grpDetalle.Controls.Add(this.txtFecha);
            this.grpDetalle.Controls.Add(this.lblHora);
            this.grpDetalle.Controls.Add(this.txtHora);
            this.grpDetalle.Controls.Add(this.lblPedido);
            this.grpDetalle.Controls.Add(this.txtPedido);
            this.grpDetalle.Controls.Add(this.lblResponsable);
            this.grpDetalle.Controls.Add(this.txtResponsable);
            this.grpDetalle.Controls.Add(this.dgvDetalle);
            this.grpDetalle.Controls.Add(this.lblAlerta);
            this.grpDetalle.Controls.Add(this.lblNota);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.grpPendientes.ResumeLayout(false);
            this.grpDetalle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpPendientes;
        private System.Windows.Forms.DataGridView dgvPendientes;
        private System.Windows.Forms.GroupBox grpDetalle;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.TextBox txtResponsable;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Label lblAlerta;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Label lblObligatorio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSolicitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSolicitado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntregada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoStock;
    }
}