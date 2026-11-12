namespace Estampida_Proyecto_____Final___Grupo4
{
    partial class Venta_a_Pedido
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
            this.grpReserva = new System.Windows.Forms.GroupBox();
            this.lblCodigoVale = new System.Windows.Forms.Label();
            this.txtCodigoVale = new System.Windows.Forms.TextBox();
            this.btnValidarReserva = new System.Windows.Forms.Button();
            this.lblClienteTitulo = new System.Windows.Forms.Label();
            this.lblClienteValor = new System.Windows.Forms.Label();
            this.lblMesaTitulo = new System.Windows.Forms.Label();
            this.lblMesaValor = new System.Windows.Forms.Label();
            this.lblComensalesTitulo = new System.Windows.Forms.Label();
            this.lblComensalesValor = new System.Windows.Forms.Label();
            this.lblFechaTitulo = new System.Windows.Forms.Label();
            this.lblFechaValor = new System.Windows.Forms.Label();
            this.lblReservaTitulo = new System.Windows.Forms.Label();
            this.lblReservaValor = new System.Windows.Forms.Label();
            this.lblSinReserva = new System.Windows.Forms.Label();
            this.dgvMesasLibres = new System.Windows.Forms.DataGridView();
            this.colMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCapacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUbicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUsarMesa = new System.Windows.Forms.Button();
            this.grpPedido = new System.Windows.Forms.GroupBox();
            this.lblPedidoTitulo = new System.Windows.Forms.Label();
            this.lblPedidoValor = new System.Windows.Forms.Label();
            this.lblMeseroTitulo = new System.Windows.Forms.Label();
            this.lblMeseroValor = new System.Windows.Forms.Label();
            this.lblMesaPedidoTitulo = new System.Windows.Forms.Label();
            this.lblMesaPedidoValor = new System.Windows.Forms.Label();
            this.lblHoraTitulo = new System.Windows.Forms.Label();
            this.lblHoraValor = new System.Windows.Forms.Label();
            this.dgvDetallePedido = new System.Windows.Forms.DataGridView();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnQuitarItem = new System.Windows.Forms.Button();
            this.btnModificarItem = new System.Windows.Forms.Button();
            this.grpCarta = new System.Windows.Forms.GroupBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvCarta = new System.Windows.Forms.DataGridView();
            this.colCartaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCartaCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCartaPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblModificacion = new System.Windows.Forms.Label();
            this.txtModificacion = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblEstadoTitulo = new System.Windows.Forms.Label();
            this.lblEstadoValor = new System.Windows.Forms.Label();
            this.btnAnularPedido = new System.Windows.Forms.Button();
            this.btnEnviarCocina = new System.Windows.Forms.Button();
            this.btnNuevoPedido = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.ssEstado = new System.Windows.Forms.StatusStrip();
            this.tsslListo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpReserva.SuspendLayout();
            this.grpPedido.SuspendLayout();
            this.grpCarta.SuspendLayout();
            this.SuspendLayout();

            // grpReserva
            this.grpReserva.Controls.Add(this.lblCodigoVale);
            this.grpReserva.Controls.Add(this.txtCodigoVale);
            this.grpReserva.Controls.Add(this.btnValidarReserva);
            this.grpReserva.Controls.Add(this.lblClienteTitulo);
            this.grpReserva.Controls.Add(this.lblClienteValor);
            this.grpReserva.Controls.Add(this.lblMesaTitulo);
            this.grpReserva.Controls.Add(this.lblMesaValor);
            this.grpReserva.Controls.Add(this.lblComensalesTitulo);
            this.grpReserva.Controls.Add(this.lblComensalesValor);
            this.grpReserva.Controls.Add(this.lblFechaTitulo);
            this.grpReserva.Controls.Add(this.lblFechaValor);
            this.grpReserva.Controls.Add(this.lblReservaTitulo);
            this.grpReserva.Controls.Add(this.lblReservaValor);
            this.grpReserva.Controls.Add(this.lblSinReserva);
            this.grpReserva.Controls.Add(this.dgvMesasLibres);
            this.grpReserva.Controls.Add(this.btnUsarMesa);
            this.grpReserva.Location = new System.Drawing.Point(12, 12);
            this.grpReserva.Name = "grpReserva";
            this.grpReserva.Size = new System.Drawing.Size(520, 340);
            this.grpReserva.TabStop = false;
            this.grpReserva.Text = "Mesa y reserva";

            // lblCodigoVale
            this.lblCodigoVale.AutoSize = true;
            this.lblCodigoVale.Location = new System.Drawing.Point(14, 30);
            this.lblCodigoVale.Name = "lblCodigoVale";
            this.lblCodigoVale.Text = "Código de vale:";

            // txtCodigoVale
            this.txtCodigoVale.Location = new System.Drawing.Point(108, 27);
            this.txtCodigoVale.MaxLength = 10;
            this.txtCodigoVale.Name = "txtCodigoVale";
            this.txtCodigoVale.Size = new System.Drawing.Size(150, 23);
            this.txtCodigoVale.Text = "VAL-0047";

            // btnValidarReserva
            this.btnValidarReserva.Location = new System.Drawing.Point(270, 26);
            this.btnValidarReserva.Name = "btnValidarReserva";
            this.btnValidarReserva.Size = new System.Drawing.Size(130, 26);
            this.btnValidarReserva.Text = "Validar reserva";
            this.btnValidarReserva.UseVisualStyleBackColor = true;
            this.btnValidarReserva.Click += new System.EventHandler(this.btnValidarReserva_Click);

            // lblClienteTitulo
            this.lblClienteTitulo.AutoSize = true;
            this.lblClienteTitulo.Location = new System.Drawing.Point(14, 70);
            this.lblClienteTitulo.Name = "lblClienteTitulo";
            this.lblClienteTitulo.Text = "Cliente:";

            // lblClienteValor
            this.lblClienteValor.AutoSize = true;
            this.lblClienteValor.Location = new System.Drawing.Point(130, 70);
            this.lblClienteValor.Name = "lblClienteValor";
            this.lblClienteValor.Text = "Ana Torres Vargas";

            // lblMesaTitulo
            this.lblMesaTitulo.AutoSize = true;
            this.lblMesaTitulo.Location = new System.Drawing.Point(14, 92);
            this.lblMesaTitulo.Name = "lblMesaTitulo";
            this.lblMesaTitulo.Text = "Mesa:";

            // lblMesaValor
            this.lblMesaValor.AutoSize = true;
            this.lblMesaValor.Location = new System.Drawing.Point(130, 92);
            this.lblMesaValor.Name = "lblMesaValor";
            this.lblMesaValor.Text = "5";

            // lblComensalesTitulo
            this.lblComensalesTitulo.AutoSize = true;
            this.lblComensalesTitulo.Location = new System.Drawing.Point(14, 114);
            this.lblComensalesTitulo.Name = "lblComensalesTitulo";
            this.lblComensalesTitulo.Text = "Comensales:";

            // lblComensalesValor
            this.lblComensalesValor.AutoSize = true;
            this.lblComensalesValor.Location = new System.Drawing.Point(130, 114);
            this.lblComensalesValor.Name = "lblComensalesValor";
            this.lblComensalesValor.Text = "4";

            // lblFechaTitulo
            this.lblFechaTitulo.AutoSize = true;
            this.lblFechaTitulo.Location = new System.Drawing.Point(14, 136);
            this.lblFechaTitulo.Name = "lblFechaTitulo";
            this.lblFechaTitulo.Text = "Fecha y hora:";

            // lblFechaValor
            this.lblFechaValor.AutoSize = true;
            this.lblFechaValor.Location = new System.Drawing.Point(130, 136);
            this.lblFechaValor.Name = "lblFechaValor";
            this.lblFechaValor.Text = "12/11/2026 19:30";

            // lblReservaTitulo
            this.lblReservaTitulo.AutoSize = true;
            this.lblReservaTitulo.Location = new System.Drawing.Point(14, 158);
            this.lblReservaTitulo.Name = "lblReservaTitulo";
            this.lblReservaTitulo.Text = "Reserva:";

            // lblReservaValor
            this.lblReservaValor.AutoSize = true;
            this.lblReservaValor.ForeColor = System.Drawing.Color.FromArgb(16, 124, 16);
            this.lblReservaValor.Location = new System.Drawing.Point(130, 158);
            this.lblReservaValor.Name = "lblReservaValor";
            this.lblReservaValor.Text = "Vigente";

            // lblSinReserva
            this.lblSinReserva.AutoSize = true;
            this.lblSinReserva.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblSinReserva.Location = new System.Drawing.Point(14, 196);
            this.lblSinReserva.Name = "lblSinReserva";
            this.lblSinReserva.Text = "Sin reserva: seleccione una mesa libre.";

            // dgvMesasLibres
            this.dgvMesasLibres.AllowUserToAddRows = false;
            this.dgvMesasLibres.AllowUserToDeleteRows = false;
            this.dgvMesasLibres.AllowUserToResizeRows = false;
            this.dgvMesasLibres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMesasLibres.BackgroundColor = System.Drawing.Color.White;
            this.dgvMesasLibres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvMesasLibres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesasLibres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMesa,
            this.colCapacidad,
            this.colUbicacion});
            this.dgvMesasLibres.Location = new System.Drawing.Point(14, 218);
            this.dgvMesasLibres.MultiSelect = false;
            this.dgvMesasLibres.Name = "dgvMesasLibres";
            this.dgvMesasLibres.ReadOnly = true;
            this.dgvMesasLibres.RowHeadersVisible = false;
            this.dgvMesasLibres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMesasLibres.Size = new System.Drawing.Size(492, 88);

            // colMesa
            this.colMesa.HeaderText = "Mesa";
            this.colMesa.Name = "colMesa";
            this.colMesa.ReadOnly = true;

            // colCapacidad
            this.colCapacidad.HeaderText = "Capacidad";
            this.colCapacidad.Name = "colCapacidad";
            this.colCapacidad.ReadOnly = true;

            // colUbicacion
            this.colUbicacion.HeaderText = "Ubicación";
            this.colUbicacion.Name = "colUbicacion";
            this.colUbicacion.ReadOnly = true;

            // btnUsarMesa
            this.btnUsarMesa.Location = new System.Drawing.Point(352, 310);
            this.btnUsarMesa.Name = "btnUsarMesa";
            this.btnUsarMesa.Size = new System.Drawing.Size(154, 26);
            this.btnUsarMesa.Text = "Usar mesa seleccionada";
            this.btnUsarMesa.UseVisualStyleBackColor = true;
            this.btnUsarMesa.Click += new System.EventHandler(this.btnUsarMesa_Click);

            // grpPedido
            this.grpPedido.Controls.Add(this.lblPedidoTitulo);
            this.grpPedido.Controls.Add(this.lblPedidoValor);
            this.grpPedido.Controls.Add(this.lblMeseroTitulo);
            this.grpPedido.Controls.Add(this.lblMeseroValor);
            this.grpPedido.Controls.Add(this.lblMesaPedidoTitulo);
            this.grpPedido.Controls.Add(this.lblMesaPedidoValor);
            this.grpPedido.Controls.Add(this.lblHoraTitulo);
            this.grpPedido.Controls.Add(this.lblHoraValor);
            this.grpPedido.Controls.Add(this.dgvDetallePedido);
            this.grpPedido.Controls.Add(this.lblTotal);
            this.grpPedido.Controls.Add(this.btnQuitarItem);
            this.grpPedido.Controls.Add(this.btnModificarItem);
            this.grpPedido.Location = new System.Drawing.Point(544, 12);
            this.grpPedido.Name = "grpPedido";
            this.grpPedido.Size = new System.Drawing.Size(534, 340);
            this.grpPedido.TabStop = false;
            this.grpPedido.Text = "Pedido";

            // lblPedidoTitulo
            this.lblPedidoTitulo.AutoSize = true;
            this.lblPedidoTitulo.Location = new System.Drawing.Point(14, 28);
            this.lblPedidoTitulo.Name = "lblPedidoTitulo";
            this.lblPedidoTitulo.Text = "Pedido:";

            // lblPedidoValor
            this.lblPedidoValor.AutoSize = true;
            this.lblPedidoValor.Location = new System.Drawing.Point(70, 28);
            this.lblPedidoValor.Name = "lblPedidoValor";
            this.lblPedidoValor.Text = "0023";

            // lblMeseroTitulo
            this.lblMeseroTitulo.AutoSize = true;
            this.lblMeseroTitulo.Location = new System.Drawing.Point(150, 28);
            this.lblMeseroTitulo.Name = "lblMeseroTitulo";
            this.lblMeseroTitulo.Text = "Mesero:";

            // lblMeseroValor
            this.lblMeseroValor.AutoSize = true;
            this.lblMeseroValor.Location = new System.Drawing.Point(212, 28);
            this.lblMeseroValor.Name = "lblMeseroValor";
            this.lblMeseroValor.Text = "Lucía Huamán";

            // lblMesaPedidoTitulo
            this.lblMesaPedidoTitulo.AutoSize = true;
            this.lblMesaPedidoTitulo.Location = new System.Drawing.Point(14, 50);
            this.lblMesaPedidoTitulo.Name = "lblMesaPedidoTitulo";
            this.lblMesaPedidoTitulo.Text = "Mesa:";

            // lblMesaPedidoValor
            this.lblMesaPedidoValor.AutoSize = true;
            this.lblMesaPedidoValor.Location = new System.Drawing.Point(70, 50);
            this.lblMesaPedidoValor.Name = "lblMesaPedidoValor";
            this.lblMesaPedidoValor.Text = "5";

            // lblHoraTitulo
            this.lblHoraTitulo.AutoSize = true;
            this.lblHoraTitulo.Location = new System.Drawing.Point(150, 50);
            this.lblHoraTitulo.Name = "lblHoraTitulo";
            this.lblHoraTitulo.Text = "Hora:";

            // lblHoraValor
            this.lblHoraValor.AutoSize = true;
            this.lblHoraValor.Location = new System.Drawing.Point(212, 50);
            this.lblHoraValor.Name = "lblHoraValor";
            this.lblHoraValor.Text = "19:41";

            // dgvDetallePedido
            this.dgvDetallePedido.AllowUserToAddRows = false;
            this.dgvDetallePedido.AllowUserToDeleteRows = false;
            this.dgvDetallePedido.AllowUserToResizeRows = false;
            this.dgvDetallePedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetallePedido.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetallePedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvDetallePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallePedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProducto,
            this.colCantidad,
            this.colPrecio,
            this.colSubtotal,
            this.colModificacion});
            this.dgvDetallePedido.Location = new System.Drawing.Point(14, 80);
            this.dgvDetallePedido.MultiSelect = false;
            this.dgvDetallePedido.Name = "dgvDetallePedido";
            this.dgvDetallePedido.ReadOnly = true;
            this.dgvDetallePedido.RowHeadersVisible = false;
            this.dgvDetallePedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetallePedido.Size = new System.Drawing.Size(506, 200);

            // colProducto
            this.colProducto.HeaderText = "Producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;

            // colCantidad
            this.colCantidad.HeaderText = "Cant.";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;

            // colPrecio
            this.colPrecio.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;

            // colSubtotal
            this.colSubtotal.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.ReadOnly = true;

            // colModificacion
            this.colModificacion.HeaderText = "Modificación";
            this.colModificacion.Name = "colModificacion";
            this.colModificacion.ReadOnly = true;

            // lblTotal
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(300, 290);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(220, 20);
            this.lblTotal.Text = "Total: S/ 115.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // btnQuitarItem
            this.btnQuitarItem.Location = new System.Drawing.Point(14, 302);
            this.btnQuitarItem.Name = "btnQuitarItem";
            this.btnQuitarItem.Size = new System.Drawing.Size(110, 26);
            this.btnQuitarItem.Text = "Quitar ítem";
            this.btnQuitarItem.UseVisualStyleBackColor = true;
            this.btnQuitarItem.Click += new System.EventHandler(this.btnQuitarItem_Click);

            // btnModificarItem
            this.btnModificarItem.Location = new System.Drawing.Point(132, 302);
            this.btnModificarItem.Name = "btnModificarItem";
            this.btnModificarItem.Size = new System.Drawing.Size(130, 26);
            this.btnModificarItem.Text = "Modificar ítem";
            this.btnModificarItem.UseVisualStyleBackColor = true;
            this.btnModificarItem.Click += new System.EventHandler(this.btnModificarItem_Click);

            // grpCarta
            this.grpCarta.Controls.Add(this.lblCategoria);
            this.grpCarta.Controls.Add(this.cboCategoria);
            this.grpCarta.Controls.Add(this.lblBuscar);
            this.grpCarta.Controls.Add(this.txtBuscar);
            this.grpCarta.Controls.Add(this.dgvCarta);
            this.grpCarta.Controls.Add(this.lblCantidad);
            this.grpCarta.Controls.Add(this.nudCantidad);
            this.grpCarta.Controls.Add(this.lblModificacion);
            this.grpCarta.Controls.Add(this.txtModificacion);
            this.grpCarta.Controls.Add(this.btnAgregar);
            this.grpCarta.Location = new System.Drawing.Point(12, 364);
            this.grpCarta.Name = "grpCarta";
            this.grpCarta.Size = new System.Drawing.Size(1066, 270);
            this.grpCarta.TabStop = false;
            this.grpCarta.Text = "Carta de productos";

            // lblCategoria
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(14, 30);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Text = "Categoría:";

            // cboCategoria
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(84, 27);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(170, 23);
            this.cboCategoria.SelectedIndexChanged += new System.EventHandler(this.cboCategoria_SelectedIndexChanged);

            // lblBuscar
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(276, 30);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Text = "Buscar:";

            // txtBuscar
            this.txtBuscar.Location = new System.Drawing.Point(328, 27);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(220, 23);
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);

            // dgvCarta
            this.dgvCarta.AllowUserToAddRows = false;
            this.dgvCarta.AllowUserToDeleteRows = false;
            this.dgvCarta.AllowUserToResizeRows = false;
            this.dgvCarta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarta.BackgroundColor = System.Drawing.Color.White;
            this.dgvCarta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvCarta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCartaProducto,
            this.colCartaCategoria,
            this.colCartaPrecio});
            this.dgvCarta.Location = new System.Drawing.Point(14, 62);
            this.dgvCarta.MultiSelect = false;
            this.dgvCarta.Name = "dgvCarta";
            this.dgvCarta.ReadOnly = true;
            this.dgvCarta.RowHeadersVisible = false;
            this.dgvCarta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarta.Size = new System.Drawing.Size(1038, 150);

            // colCartaProducto
            this.colCartaProducto.HeaderText = "Producto";
            this.colCartaProducto.Name = "colCartaProducto";
            this.colCartaProducto.ReadOnly = true;

            // colCartaCategoria
            this.colCartaCategoria.HeaderText = "Categoría";
            this.colCartaCategoria.Name = "colCartaCategoria";
            this.colCartaCategoria.ReadOnly = true;

            // colCartaPrecio
            this.colCartaPrecio.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colCartaPrecio.HeaderText = "Precio";
            this.colCartaPrecio.Name = "colCartaPrecio";
            this.colCartaPrecio.ReadOnly = true;

            // lblCantidad
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(560, 229);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Text = "Cantidad:";

            // nudCantidad
            this.nudCantidad.Location = new System.Drawing.Point(626, 226);
            this.nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(60, 23);
            this.nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });

            // lblModificacion
            this.lblModificacion.AutoSize = true;
            this.lblModificacion.Location = new System.Drawing.Point(700, 229);
            this.lblModificacion.Name = "lblModificacion";
            this.lblModificacion.Text = "Modificación:";

            // txtModificacion
            this.txtModificacion.Location = new System.Drawing.Point(784, 226);
            this.txtModificacion.Name = "txtModificacion";
            this.txtModificacion.Size = new System.Drawing.Size(150, 23);

            // btnAgregar
            this.btnAgregar.Location = new System.Drawing.Point(944, 225);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(108, 26);
            this.btnAgregar.Text = "Agregar al pedido";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            // lblEstadoTitulo
            this.lblEstadoTitulo.AutoSize = true;
            this.lblEstadoTitulo.Location = new System.Drawing.Point(14, 656);
            this.lblEstadoTitulo.Name = "lblEstadoTitulo";
            this.lblEstadoTitulo.Text = "Estado:";

            // lblEstadoValor
            this.lblEstadoValor.AutoSize = true;
            this.lblEstadoValor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstadoValor.Location = new System.Drawing.Point(62, 656);
            this.lblEstadoValor.Name = "lblEstadoValor";
            this.lblEstadoValor.Text = "Registrado";

            // btnAnularPedido
            this.btnAnularPedido.Location = new System.Drawing.Point(580, 650);
            this.btnAnularPedido.Name = "btnAnularPedido";
            this.btnAnularPedido.Size = new System.Drawing.Size(120, 28);
            this.btnAnularPedido.Text = "Anular pedido";
            this.btnAnularPedido.UseVisualStyleBackColor = true;
            this.btnAnularPedido.Click += new System.EventHandler(this.btnAnularPedido_Click);

            // btnEnviarCocina
            this.btnEnviarCocina.Location = new System.Drawing.Point(708, 650);
            this.btnEnviarCocina.Name = "btnEnviarCocina";
            this.btnEnviarCocina.Size = new System.Drawing.Size(140, 28);
            this.btnEnviarCocina.Text = "Enviar a cocina";
            this.btnEnviarCocina.UseVisualStyleBackColor = true;
            this.btnEnviarCocina.Click += new System.EventHandler(this.btnEnviarCocina_Click);

            // btnNuevoPedido
            this.btnNuevoPedido.Location = new System.Drawing.Point(856, 650);
            this.btnNuevoPedido.Name = "btnNuevoPedido";
            this.btnNuevoPedido.Size = new System.Drawing.Size(110, 28);
            this.btnNuevoPedido.Text = "Nuevo pedido";
            this.btnNuevoPedido.UseVisualStyleBackColor = true;
            this.btnNuevoPedido.Click += new System.EventHandler(this.btnNuevoPedido_Click);

            // btnCerrar
            this.btnCerrar.Location = new System.Drawing.Point(974, 650);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(96, 28);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);

            // ssEstado
            this.ssEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslListo,
            this.tsslUsuario});
            this.ssEstado.Location = new System.Drawing.Point(0, 698);
            this.ssEstado.Name = "ssEstado";
            this.ssEstado.Size = new System.Drawing.Size(1090, 22);

            // tsslListo
            this.tsslListo.Name = "tsslListo";
            this.tsslListo.Spring = true;
            this.tsslListo.Text = "Listo";
            this.tsslListo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // tsslUsuario
            this.tsslUsuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsslUsuario.Name = "tsslUsuario";
            this.tsslUsuario.Text = "Usuario: Mesero – Lucía Huamán · 12/11/2026 19:41";

            // frmVentaPedido
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.ClientSize = new System.Drawing.Size(1090, 720);
            this.Controls.Add(this.ssEstado);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnNuevoPedido);
            this.Controls.Add(this.btnEnviarCocina);
            this.Controls.Add(this.btnAnularPedido);
            this.Controls.Add(this.lblEstadoValor);
            this.Controls.Add(this.lblEstadoTitulo);
            this.Controls.Add(this.grpCarta);
            this.Controls.Add(this.grpPedido);
            this.Controls.Add(this.grpReserva);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmVentaPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta a pedido – La Estampida";
            this.Load += new System.EventHandler(this.frmVentaPedido_Load);
            this.grpReserva.ResumeLayout(false);
            this.grpReserva.PerformLayout();
            this.grpPedido.ResumeLayout(false);
            this.grpPedido.PerformLayout();
            this.grpCarta.ResumeLayout(false);
            this.grpCarta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesasLibres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpReserva;
        private System.Windows.Forms.Label lblCodigoVale;
        private System.Windows.Forms.TextBox txtCodigoVale;
        private System.Windows.Forms.Button btnValidarReserva;
        private System.Windows.Forms.Label lblClienteTitulo;
        private System.Windows.Forms.Label lblClienteValor;
        private System.Windows.Forms.Label lblMesaTitulo;
        private System.Windows.Forms.Label lblMesaValor;
        private System.Windows.Forms.Label lblComensalesTitulo;
        private System.Windows.Forms.Label lblComensalesValor;
        private System.Windows.Forms.Label lblFechaTitulo;
        private System.Windows.Forms.Label lblFechaValor;
        private System.Windows.Forms.Label lblReservaTitulo;
        private System.Windows.Forms.Label lblReservaValor;
        private System.Windows.Forms.Label lblSinReserva;
        private System.Windows.Forms.DataGridView dgvMesasLibres;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCapacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUbicacion;
        private System.Windows.Forms.Button btnUsarMesa;
        private System.Windows.Forms.GroupBox grpPedido;
        private System.Windows.Forms.Label lblPedidoTitulo;
        private System.Windows.Forms.Label lblPedidoValor;
        private System.Windows.Forms.Label lblMeseroTitulo;
        private System.Windows.Forms.Label lblMeseroValor;
        private System.Windows.Forms.Label lblMesaPedidoTitulo;
        private System.Windows.Forms.Label lblMesaPedidoValor;
        private System.Windows.Forms.Label lblHoraTitulo;
        private System.Windows.Forms.Label lblHoraValor;
        private System.Windows.Forms.DataGridView dgvDetallePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModificacion;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnQuitarItem;
        private System.Windows.Forms.Button btnModificarItem;
        private System.Windows.Forms.GroupBox grpCarta;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvCarta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartaCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartaPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblModificacion;
        private System.Windows.Forms.TextBox txtModificacion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblEstadoTitulo;
        private System.Windows.Forms.Label lblEstadoValor;
        private System.Windows.Forms.Button btnAnularPedido;
        private System.Windows.Forms.Button btnEnviarCocina;
        private System.Windows.Forms.Button btnNuevoPedido;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.StatusStrip ssEstado;
        private System.Windows.Forms.ToolStripStatusLabel tsslListo;
        private System.Windows.Forms.ToolStripStatusLabel tsslUsuario;
    }
}