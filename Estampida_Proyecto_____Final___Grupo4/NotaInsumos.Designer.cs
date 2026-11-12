namespace Estampida_Proyecto_____Final___Grupo4
{
    partial class NotaInsumos
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
            this.grpPedido = new System.Windows.Forms.GroupBox();
            this.lblEstadoPedidoValor = new System.Windows.Forms.Label();
            this.lblEstadoPedido = new System.Windows.Forms.Label();
            this.lblFechaPedidoValor = new System.Windows.Forms.Label();
            this.lblFechaPedido = new System.Windows.Forms.Label();
            this.btnBuscarPedido = new System.Windows.Forms.Button();
            this.txtNumeroPedido = new System.Windows.Forms.TextBox();
            this.lblNumeroPedido = new System.Windows.Forms.Label();
            this.grpDetalle = new System.Windows.Forms.GroupBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.colInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantSolicitada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantRecibida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnNuevoPedido = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpPedido.SuspendLayout();
            this.grpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPedido
            // 
            this.grpPedido.Controls.Add(this.lblEstadoPedidoValor);
            this.grpPedido.Controls.Add(this.lblEstadoPedido);
            this.grpPedido.Controls.Add(this.lblFechaPedidoValor);
            this.grpPedido.Controls.Add(this.lblFechaPedido);
            this.grpPedido.Controls.Add(this.btnBuscarPedido);
            this.grpPedido.Controls.Add(this.txtNumeroPedido);
            this.grpPedido.Controls.Add(this.lblNumeroPedido);
            this.grpPedido.Location = new System.Drawing.Point(12, 12);
            this.grpPedido.Name = "grpPedido";
            this.grpPedido.Size = new System.Drawing.Size(776, 95);
            this.grpPedido.TabIndex = 0;
            this.grpPedido.TabStop = false;
            this.grpPedido.Text = "1. Pedido de insumos a vincular";
            // 
            // lblNumeroPedido
            // 
            this.lblNumeroPedido.AutoSize = true;
            this.lblNumeroPedido.Location = new System.Drawing.Point(15, 30);
            this.lblNumeroPedido.Name = "lblNumeroPedido";
            this.lblNumeroPedido.Size = new System.Drawing.Size(97, 13);
            this.lblNumeroPedido.TabIndex = 0;
            this.lblNumeroPedido.Text = "Número de pedido *";
            // 
            // txtNumeroPedido
            // 
            this.txtNumeroPedido.Location = new System.Drawing.Point(125, 27);
            this.txtNumeroPedido.Name = "txtNumeroPedido";
            this.txtNumeroPedido.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroPedido.TabIndex = 1;
            // 
            // btnBuscarPedido
            // 
            this.btnBuscarPedido.Location = new System.Drawing.Point(235, 25);
            this.btnBuscarPedido.Name = "btnBuscarPedido";
            this.btnBuscarPedido.Size = new System.Drawing.Size(80, 24);
            this.btnBuscarPedido.TabIndex = 2;
            this.btnBuscarPedido.Text = "Buscar";
            this.btnBuscarPedido.UseVisualStyleBackColor = true;
            // 
            // lblFechaPedido
            // 
            this.lblFechaPedido.AutoSize = true;
            this.lblFechaPedido.Location = new System.Drawing.Point(15, 64);
            this.lblFechaPedido.Name = "lblFechaPedido";
            this.lblFechaPedido.Size = new System.Drawing.Size(98, 13);
            this.lblFechaPedido.TabIndex = 3;
            this.lblFechaPedido.Text = "Fecha del pedido:";
            // 
            // lblFechaPedidoValor
            // 
            this.lblFechaPedidoValor.AutoSize = true;
            this.lblFechaPedidoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFechaPedidoValor.Location = new System.Drawing.Point(125, 64);
            this.lblFechaPedidoValor.Name = "lblFechaPedidoValor";
            this.lblFechaPedidoValor.Size = new System.Drawing.Size(65, 13);
            this.lblFechaPedidoValor.TabIndex = 4;
            this.lblFechaPedidoValor.Text = "dd/mm/aaaa";
            // 
            // lblEstadoPedido
            // 
            this.lblEstadoPedido.AutoSize = true;
            this.lblEstadoPedido.Location = new System.Drawing.Point(260, 64);
            this.lblEstadoPedido.Name = "lblEstadoPedido";
            this.lblEstadoPedido.Size = new System.Drawing.Size(43, 13);
            this.lblEstadoPedido.TabIndex = 5;
            this.lblEstadoPedido.Text = "Estado:";
            // 
            // lblEstadoPedidoValor
            // 
            this.lblEstadoPedidoValor.AutoSize = true;
            this.lblEstadoPedidoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblEstadoPedidoValor.Location = new System.Drawing.Point(310, 64);
            this.lblEstadoPedidoValor.Name = "lblEstadoPedidoValor";
            this.lblEstadoPedidoValor.Size = new System.Drawing.Size(58, 13);
            this.lblEstadoPedidoValor.TabIndex = 6;
            this.lblEstadoPedidoValor.Text = "Pendiente";
            // 
            // grpDetalle
            // 
            this.grpDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDetalle.Controls.Add(this.dgvDetalle);
            this.grpDetalle.Location = new System.Drawing.Point(12, 115);
            this.grpDetalle.Name = "grpDetalle";
            this.grpDetalle.Size = new System.Drawing.Size(776, 305);
            this.grpDetalle.TabIndex = 1;
            this.grpDetalle.TabStop = false;
            this.grpDetalle.Text = "2. Detalle del pedido (ingrese las cantidades recibidas)";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInsumo,
            this.colUnidad,
            this.colCantSolicitada,
            this.colCantRecibida,
            this.colDiferencia});
            this.dgvDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalle.Location = new System.Drawing.Point(3, 16);
            this.dgvDetalle.MultiSelect = false;
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(770, 286);
            this.dgvDetalle.TabIndex = 0;
            // 
            // colInsumo
            // 
            this.colInsumo.FillWeight = 150F;
            this.colInsumo.HeaderText = "Insumo";
            this.colInsumo.Name = "colInsumo";
            this.colInsumo.ReadOnly = true;
            // 
            // colUnidad
            // 
            this.colUnidad.FillWeight = 60F;
            this.colUnidad.HeaderText = "Unidad";
            this.colUnidad.Name = "colUnidad";
            this.colUnidad.ReadOnly = true;
            // 
            // colCantSolicitada
            // 
            this.colCantSolicitada.FillWeight = 90F;
            this.colCantSolicitada.HeaderText = "Cant. solicitada";
            this.colCantSolicitada.Name = "colCantSolicitada";
            this.colCantSolicitada.ReadOnly = true;
            // 
            // colCantRecibida
            // 
            this.colCantRecibida.FillWeight = 90F;
            this.colCantRecibida.HeaderText = "Cant. recibida *";
            this.colCantRecibida.Name = "colCantRecibida";
            // 
            // colDiferencia
            // 
            this.colDiferencia.FillWeight = 70F;
            this.colDiferencia.HeaderText = "Diferencia";
            this.colDiferencia.Name = "colDiferencia";
            this.colDiferencia.ReadOnly = true;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(12, 428);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(776, 22);
            this.lblMensaje.TabIndex = 2;
            this.lblMensaje.Text = "Mensaje de advertencia (rojo)";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNuevoPedido
            // 
            this.btnNuevoPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoPedido.Location = new System.Drawing.Point(12, 460);
            this.btnNuevoPedido.Name = "btnNuevoPedido";
            this.btnNuevoPedido.Size = new System.Drawing.Size(190, 34);
            this.btnNuevoPedido.TabIndex = 3;
            this.btnNuevoPedido.Text = "Registrar nuevo pedido";
            this.btnNuevoPedido.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmar.Location = new System.Drawing.Point(548, 460);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(140, 34);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Confirmar registro";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(698, 460);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 34);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmNotaInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnNuevoPedido);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.grpDetalle);
            this.Controls.Add(this.grpPedido);
            this.MinimumSize = new System.Drawing.Size(816, 544);
            this.Name = "FrmNotaInsumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Nota de Insumos";
            this.grpPedido.ResumeLayout(false);
            this.grpPedido.PerformLayout();
            this.grpDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPedido;
        private System.Windows.Forms.Label lblEstadoPedidoValor;
        private System.Windows.Forms.Label lblEstadoPedido;
        private System.Windows.Forms.Label lblFechaPedidoValor;
        private System.Windows.Forms.Label lblFechaPedido;
        private System.Windows.Forms.Button btnBuscarPedido;
        private System.Windows.Forms.TextBox txtNumeroPedido;
        private System.Windows.Forms.Label lblNumeroPedido;
        private System.Windows.Forms.GroupBox grpDetalle;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantSolicitada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantRecibida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiferencia;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnNuevoPedido;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
    }
}