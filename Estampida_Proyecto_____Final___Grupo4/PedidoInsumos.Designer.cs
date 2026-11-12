namespace Estampida_Proyecto_____Final___Grupo4
{
    partial class PedidoInsumos
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.grpInsumos = new System.Windows.Forms.GroupBox();
            this.dgvInsumos = new System.Windows.Forms.DataGridView();
            this.colInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpAgregar = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.cboUnidad = new System.Windows.Forms.ComboBox();
            this.lblInsumoSelValor = new System.Windows.Forms.Label();
            this.lblInsumoSel = new System.Windows.Forms.Label();
            this.grpDetalle = new System.Windows.Forms.GroupBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.colDetInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpPedido.SuspendLayout();
            this.grpInsumos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).BeginInit();
            this.grpAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.grpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPedido
            // 
            this.grpPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPedido.Controls.Add(this.dtpFecha);
            this.grpPedido.Controls.Add(this.lblFecha);
            this.grpPedido.Location = new System.Drawing.Point(12, 12);
            this.grpPedido.Name = "grpPedido";
            this.grpPedido.Size = new System.Drawing.Size(776, 56);
            this.grpPedido.TabIndex = 0;
            this.grpPedido.TabStop = false;
            this.grpPedido.Text = "1. Datos del pedido";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(15, 26);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(98, 13);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha del pedido *";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(125, 22);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(110, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // grpInsumos
            // 
            this.grpInsumos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInsumos.Controls.Add(this.dgvInsumos);
            this.grpInsumos.Location = new System.Drawing.Point(12, 74);
            this.grpInsumos.Name = "grpInsumos";
            this.grpInsumos.Size = new System.Drawing.Size(776, 160);
            this.grpInsumos.TabIndex = 1;
            this.grpInsumos.TabStop = false;
            this.grpInsumos.Text = "2. Insumos faltantes o con stock bajo el mínimo (seleccione uno)";
            // 
            // dgvInsumos
            // 
            this.dgvInsumos.AllowUserToAddRows = false;
            this.dgvInsumos.AllowUserToDeleteRows = false;
            this.dgvInsumos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInsumos.BackgroundColor = System.Drawing.Color.White;
            this.dgvInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsumos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInsumo,
            this.colUnidad,
            this.colStockActual,
            this.colStockMinimo});
            this.dgvInsumos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInsumos.Location = new System.Drawing.Point(3, 16);
            this.dgvInsumos.MultiSelect = false;
            this.dgvInsumos.Name = "dgvInsumos";
            this.dgvInsumos.ReadOnly = true;
            this.dgvInsumos.RowHeadersVisible = false;
            this.dgvInsumos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInsumos.Size = new System.Drawing.Size(770, 141);
            this.dgvInsumos.TabIndex = 0;
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
            // colStockActual
            // 
            this.colStockActual.FillWeight = 80F;
            this.colStockActual.HeaderText = "Stock actual";
            this.colStockActual.Name = "colStockActual";
            this.colStockActual.ReadOnly = true;
            // 
            // colStockMinimo
            // 
            this.colStockMinimo.FillWeight = 80F;
            this.colStockMinimo.HeaderText = "Stock mínimo";
            this.colStockMinimo.Name = "colStockMinimo";
            this.colStockMinimo.ReadOnly = true;
            // 
            // grpAgregar
            // 
            this.grpAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAgregar.Controls.Add(this.btnAgregar);
            this.grpAgregar.Controls.Add(this.cboUnidad);
            this.grpAgregar.Controls.Add(this.lblUnidad);
            this.grpAgregar.Controls.Add(this.nudCantidad);
            this.grpAgregar.Controls.Add(this.lblCantidad);
            this.grpAgregar.Controls.Add(this.lblInsumoSelValor);
            this.grpAgregar.Controls.Add(this.lblInsumoSel);
            this.grpAgregar.Location = new System.Drawing.Point(12, 240);
            this.grpAgregar.Name = "grpAgregar";
            this.grpAgregar.Size = new System.Drawing.Size(776, 60);
            this.grpAgregar.TabIndex = 2;
            this.grpAgregar.TabStop = false;
            this.grpAgregar.Text = "3. Cantidad y unidad de medida a agregar";
            // 
            // lblInsumoSel
            // 
            this.lblInsumoSel.AutoSize = true;
            this.lblInsumoSel.Location = new System.Drawing.Point(15, 28);
            this.lblInsumoSel.Name = "lblInsumoSel";
            this.lblInsumoSel.Size = new System.Drawing.Size(42, 13);
            this.lblInsumoSel.TabIndex = 0;
            this.lblInsumoSel.Text = "Insumo:";
            // 
            // lblInsumoSelValor
            // 
            this.lblInsumoSelValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblInsumoSelValor.Location = new System.Drawing.Point(62, 28);
            this.lblInsumoSelValor.Name = "lblInsumoSelValor";
            this.lblInsumoSelValor.Size = new System.Drawing.Size(220, 15);
            this.lblInsumoSelValor.TabIndex = 1;
            this.lblInsumoSelValor.Text = "(seleccione un insumo de la lista)";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(295, 28);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(58, 13);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad *";
            // 
            // nudCantidad
            // 
            this.nudCantidad.DecimalPlaces = 2;
            this.nudCantidad.Location = new System.Drawing.Point(360, 24);
            this.nudCantidad.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(80, 20);
            this.nudCantidad.TabIndex = 3;
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(455, 28);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(47, 13);
            this.lblUnidad.TabIndex = 4;
            this.lblUnidad.Text = "Unidad *";
            // 
            // cboUnidad
            // 
            this.cboUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidad.FormattingEnabled = true;
            this.cboUnidad.Items.AddRange(new object[] {
            "Kilos",
            "Gramos",
            "Litros"});
            this.cboUnidad.Location = new System.Drawing.Point(508, 24);
            this.cboUnidad.Name = "cboUnidad";
            this.cboUnidad.Size = new System.Drawing.Size(90, 21);
            this.cboUnidad.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(640, 20);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 28);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // grpDetalle
            // 
            this.grpDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDetalle.Controls.Add(this.btnQuitar);
            this.grpDetalle.Controls.Add(this.dgvDetalle);
            this.grpDetalle.Location = new System.Drawing.Point(12, 306);
            this.grpDetalle.Name = "grpDetalle";
            this.grpDetalle.Size = new System.Drawing.Size(776, 196);
            this.grpDetalle.TabIndex = 3;
            this.grpDetalle.TabStop = false;
            this.grpDetalle.Text = "4. Detalle del pedido";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDetInsumo,
            this.colDetUnidad,
            this.colDetCantidad});
            this.dgvDetalle.Location = new System.Drawing.Point(6, 19);
            this.dgvDetalle.MultiSelect = false;
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(764, 133);
            this.dgvDetalle.TabIndex = 0;
            // 
            // colDetInsumo
            // 
            this.colDetInsumo.FillWeight = 150F;
            this.colDetInsumo.HeaderText = "Insumo";
            this.colDetInsumo.Name = "colDetInsumo";
            this.colDetInsumo.ReadOnly = true;
            // 
            // colDetUnidad
            // 
            this.colDetUnidad.FillWeight = 60F;
            this.colDetUnidad.HeaderText = "Unidad";
            this.colDetUnidad.Name = "colDetUnidad";
            this.colDetUnidad.ReadOnly = true;
            // 
            // colDetCantidad
            // 
            this.colDetCantidad.FillWeight = 80F;
            this.colDetCantidad.HeaderText = "Cantidad";
            this.colDetCantidad.Name = "colDetCantidad";
            this.colDetCantidad.ReadOnly = true;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitar.Location = new System.Drawing.Point(640, 159);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(130, 28);
            this.btnQuitar.TabIndex = 1;
            this.btnQuitar.Text = "Quitar seleccionado";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(12, 508);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(776, 22);
            this.lblMensaje.TabIndex = 4;
            this.lblMensaje.Text = "Mensaje de advertencia (rojo)";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrar.Location = new System.Drawing.Point(548, 540);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(140, 34);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar pedido";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(698, 540);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 34);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmPedidoInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 590);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.grpDetalle);
            this.Controls.Add(this.grpAgregar);
            this.Controls.Add(this.grpInsumos);
            this.Controls.Add(this.grpPedido);
            this.MinimumSize = new System.Drawing.Size(816, 629);
            this.Name = "FrmPedidoInsumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Pedido de Insumos";
            this.grpPedido.ResumeLayout(false);
            this.grpPedido.PerformLayout();
            this.grpInsumos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).EndInit();
            this.grpAgregar.ResumeLayout(false);
            this.grpAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.grpDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPedido;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox grpInsumos;
        private System.Windows.Forms.DataGridView dgvInsumos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockMinimo;
        private System.Windows.Forms.GroupBox grpAgregar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.ComboBox cboUnidad;
        private System.Windows.Forms.Label lblInsumoSelValor;
        private System.Windows.Forms.Label lblInsumoSel;
        private System.Windows.Forms.GroupBox grpDetalle;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetCantidad;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
    }
}