namespace Estampida_Proyecto_____Final___Grupo4
{
    partial class Inventario_Fisico
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
            this.grpInventario = new System.Windows.Forms.GroupBox();
            this.lblNumeroTitulo = new System.Windows.Forms.Label();
            this.lblNumeroValor = new System.Windows.Forms.Label();
            this.lblFechaTitulo = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblResponsableTitulo = new System.Windows.Forms.Label();
            this.lblResponsableValor = new System.Windows.Forms.Label();
            this.lblEstadoTitulo = new System.Windows.Forms.Label();
            this.lblEstadoValor = new System.Windows.Forms.Label();
            this.btnProgramar = new System.Windows.Forms.Button();
            this.grpConteo = new System.Windows.Forms.GroupBox();
            this.lblBuscarTitulo = new System.Windows.Forms.Label();
            this.txtBuscarInsumo = new System.Windows.Forms.TextBox();
            this.lblCategoriaTitulo = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.dgvConteo = new System.Windows.Forms.DataGridView();
            this.colInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockRegistrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockContado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCausa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpResultado = new System.Windows.Forms.GroupBox();
            this.lblResumenValor = new System.Windows.Forms.Label();
            this.btnGuardarConteo = new System.Windows.Forms.Button();
            this.btnComparar = new System.Windows.Forms.Button();
            this.btnRegistrarConforme = new System.Windows.Forms.Button();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.btnAnularInventario = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.ssEstado = new System.Windows.Forms.StatusStrip();
            this.tsslListo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpInventario.SuspendLayout();
            this.grpConteo.SuspendLayout();
            this.grpResultado.SuspendLayout();
            this.SuspendLayout();
 
            // grpInventario
            this.grpInventario.Controls.Add(this.lblNumeroTitulo);
            this.grpInventario.Controls.Add(this.lblNumeroValor);
            this.grpInventario.Controls.Add(this.lblFechaTitulo);
            this.grpInventario.Controls.Add(this.dtpFecha);
            this.grpInventario.Controls.Add(this.lblResponsableTitulo);
            this.grpInventario.Controls.Add(this.lblResponsableValor);
            this.grpInventario.Controls.Add(this.lblEstadoTitulo);
            this.grpInventario.Controls.Add(this.lblEstadoValor);
            this.grpInventario.Controls.Add(this.btnProgramar);
            this.grpInventario.Location = new System.Drawing.Point(12, 12);
            this.grpInventario.Name = "grpInventario";
            this.grpInventario.Size = new System.Drawing.Size(976, 110);
            this.grpInventario.TabStop = false;
            this.grpInventario.Text = "Inventario físico";
 
            // lblNumeroTitulo
            this.lblNumeroTitulo.AutoSize = true;
            this.lblNumeroTitulo.Location = new System.Drawing.Point(14, 30);
            this.lblNumeroTitulo.Name = "lblNumeroTitulo";
            this.lblNumeroTitulo.Text = "Nº inventario:";
 
            // lblNumeroValor
            this.lblNumeroValor.AutoSize = true;
            this.lblNumeroValor.Location = new System.Drawing.Point(110, 30);
            this.lblNumeroValor.Name = "lblNumeroValor";
            this.lblNumeroValor.Text = "0004";
 
            // lblFechaTitulo
            this.lblFechaTitulo.AutoSize = true;
            this.lblFechaTitulo.Location = new System.Drawing.Point(14, 62);
            this.lblFechaTitulo.Name = "lblFechaTitulo";
            this.lblFechaTitulo.Text = "Fecha programada:";
 
            // dtpFecha
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(120, 58);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(160, 23);
 
            // lblResponsableTitulo
            this.lblResponsableTitulo.AutoSize = true;
            this.lblResponsableTitulo.Location = new System.Drawing.Point(300, 30);
            this.lblResponsableTitulo.Name = "lblResponsableTitulo";
            this.lblResponsableTitulo.Text = "Responsable:";
 
            // lblResponsableValor
            this.lblResponsableValor.AutoSize = true;
            this.lblResponsableValor.Location = new System.Drawing.Point(390, 30);
            this.lblResponsableValor.Name = "lblResponsableValor";
            this.lblResponsableValor.Text = "Jorge Medina Flores";
 
            // lblEstadoTitulo
            this.lblEstadoTitulo.AutoSize = true;
            this.lblEstadoTitulo.Location = new System.Drawing.Point(300, 62);
            this.lblEstadoTitulo.Name = "lblEstadoTitulo";
            this.lblEstadoTitulo.Text = "Estado:";
 
            // lblEstadoValor
            this.lblEstadoValor.AutoSize = true;
            this.lblEstadoValor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstadoValor.Location = new System.Drawing.Point(352, 62);
            this.lblEstadoValor.Name = "lblEstadoValor";
            this.lblEstadoValor.Text = "En conteo";
 
            // btnProgramar
            this.btnProgramar.Location = new System.Drawing.Point(700, 26);
            this.btnProgramar.Name = "btnProgramar";
            this.btnProgramar.Size = new System.Drawing.Size(150, 28);
            this.btnProgramar.Text = "Programar inventario";
            this.btnProgramar.UseVisualStyleBackColor = true;
            this.btnProgramar.Click += new System.EventHandler(this.btnProgramar_Click);
 
            // grpConteo
            this.grpConteo.Controls.Add(this.lblBuscarTitulo);
            this.grpConteo.Controls.Add(this.txtBuscarInsumo);
            this.grpConteo.Controls.Add(this.lblCategoriaTitulo);
            this.grpConteo.Controls.Add(this.cboCategoria);
            this.grpConteo.Controls.Add(this.dgvConteo);
            this.grpConteo.Location = new System.Drawing.Point(12, 130);
            this.grpConteo.Name = "grpConteo";
            this.grpConteo.Size = new System.Drawing.Size(976, 400);
            this.grpConteo.TabStop = false;
            this.grpConteo.Text = "Conteo de insumos";
 
            // lblBuscarTitulo
            this.lblBuscarTitulo.AutoSize = true;
            this.lblBuscarTitulo.Location = new System.Drawing.Point(14, 30);
            this.lblBuscarTitulo.Name = "lblBuscarTitulo";
            this.lblBuscarTitulo.Text = "Buscar insumo:";
 
            // txtBuscarInsumo
            this.txtBuscarInsumo.Location = new System.Drawing.Point(100, 27);
            this.txtBuscarInsumo.Name = "txtBuscarInsumo";
            this.txtBuscarInsumo.Size = new System.Drawing.Size(240, 23);
            this.txtBuscarInsumo.TextChanged += new System.EventHandler(this.txtBuscarInsumo_TextChanged);
 
            // lblCategoriaTitulo
            this.lblCategoriaTitulo.AutoSize = true;
            this.lblCategoriaTitulo.Location = new System.Drawing.Point(360, 30);
            this.lblCategoriaTitulo.Name = "lblCategoriaTitulo";
            this.lblCategoriaTitulo.Text = "Categoría:";
 
            // cboCategoria
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(430, 27);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(180, 23);
            this.cboCategoria.SelectedIndexChanged += new System.EventHandler(this.cboCategoria_SelectedIndexChanged);
 
            // dgvConteo
            this.dgvConteo.AllowUserToAddRows = false;
            this.dgvConteo.AllowUserToDeleteRows = false;
            this.dgvConteo.AllowUserToResizeRows = false;
            this.dgvConteo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConteo.BackgroundColor = System.Drawing.Color.White;
            this.dgvConteo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvConteo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConteo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInsumo,
            this.colStockRegistrado,
            this.colStockContado,
            this.colDiferencia,
            this.colCausa});
            this.dgvConteo.Location = new System.Drawing.Point(14, 60);
            this.dgvConteo.MultiSelect = false;
            this.dgvConteo.Name = "dgvConteo";
            this.dgvConteo.RowHeadersVisible = false;
            this.dgvConteo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConteo.Size = new System.Drawing.Size(946, 326);
            this.dgvConteo.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConteo_CellEndEdit);
 
            // colInsumo
            this.colInsumo.HeaderText = "Insumo";
            this.colInsumo.Name = "colInsumo";
            this.colInsumo.ReadOnly = true;
 
            // colStockRegistrado
            this.colStockRegistrado.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colStockRegistrado.HeaderText = "Stock registrado";
            this.colStockRegistrado.Name = "colStockRegistrado";
            this.colStockRegistrado.ReadOnly = true;
 
            // colStockContado (editable: aquí se digita el conteo)
            this.colStockContado.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colStockContado.HeaderText = "Stock contado";
            this.colStockContado.Name = "colStockContado";
 
            // colDiferencia (se calcula: contado - registrado)
            this.colDiferencia.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colDiferencia.HeaderText = "Diferencia";
            this.colDiferencia.Name = "colDiferencia";
            this.colDiferencia.ReadOnly = true;
 
            // colCausa (editable: solo si hay diferencia)
            this.colCausa.HeaderText = "Causa de la diferencia";
            this.colCausa.Name = "colCausa";
 
            // grpResultado
            this.grpResultado.Controls.Add(this.lblResumenValor);
            this.grpResultado.Location = new System.Drawing.Point(12, 540);
            this.grpResultado.Name = "grpResultado";
            this.grpResultado.Size = new System.Drawing.Size(976, 70);
            this.grpResultado.TabStop = false;
            this.grpResultado.Text = "Resultado";
 
            // lblResumenValor
            this.lblResumenValor.AutoSize = true;
            this.lblResumenValor.Location = new System.Drawing.Point(14, 30);
            this.lblResumenValor.Name = "lblResumenValor";
            this.lblResumenValor.Text = "0 insumos contados · 0 con diferencia";
 
            // btnGuardarConteo
            this.btnGuardarConteo.Location = new System.Drawing.Point(14, 630);
            this.btnGuardarConteo.Name = "btnGuardarConteo";
            this.btnGuardarConteo.Size = new System.Drawing.Size(130, 28);
            this.btnGuardarConteo.Text = "Guardar conteo";
            this.btnGuardarConteo.UseVisualStyleBackColor = true;
            this.btnGuardarConteo.Click += new System.EventHandler(this.btnGuardarConteo_Click);
 
            // btnComparar
            this.btnComparar.Location = new System.Drawing.Point(152, 630);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(150, 28);
            this.btnComparar.Text = "Comparar con stock";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
 
            // btnRegistrarConforme
            this.btnRegistrarConforme.Location = new System.Drawing.Point(310, 630);
            this.btnRegistrarConforme.Name = "btnRegistrarConforme";
            this.btnRegistrarConforme.Size = new System.Drawing.Size(150, 28);
            this.btnRegistrarConforme.Text = "Registrar conforme";
            this.btnRegistrarConforme.UseVisualStyleBackColor = true;
            this.btnRegistrarConforme.Click += new System.EventHandler(this.btnRegistrarConforme_Click);
 
            // btnGenerarReporte
            this.btnGenerarReporte.Location = new System.Drawing.Point(468, 630);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(190, 28);
            this.btnGenerarReporte.Text = "Generar reporte de diferencias";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
 
            // btnAnularInventario
            this.btnAnularInventario.Location = new System.Drawing.Point(666, 630);
            this.btnAnularInventario.Name = "btnAnularInventario";
            this.btnAnularInventario.Size = new System.Drawing.Size(130, 28);
            this.btnAnularInventario.Text = "Anular inventario";
            this.btnAnularInventario.UseVisualStyleBackColor = true;
            this.btnAnularInventario.Click += new System.EventHandler(this.btnAnularInventario_Click);
 
            // btnCerrar
            this.btnCerrar.Location = new System.Drawing.Point(876, 630);
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
 
            // frmInventarioFisico
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.ssEstado);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAnularInventario);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.btnRegistrarConforme);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.btnGuardarConteo);
            this.Controls.Add(this.grpResultado);
            this.Controls.Add(this.grpConteo);
            this.Controls.Add(this.grpInventario);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmInventarioFisico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario físico – La Estampida";
            this.Load += new System.EventHandler(this.frmInventarioFisico_Load);
            this.grpInventario.ResumeLayout(false);
            this.grpInventario.PerformLayout();
            this.grpConteo.ResumeLayout(false);
            this.grpConteo.PerformLayout();
            this.grpResultado.ResumeLayout(false);
            this.grpResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConteo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
 
        #endregion
 
        private System.Windows.Forms.GroupBox grpInventario;
        private System.Windows.Forms.Label lblNumeroTitulo;
        private System.Windows.Forms.Label lblNumeroValor;
        private System.Windows.Forms.Label lblFechaTitulo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblResponsableTitulo;
        private System.Windows.Forms.Label lblResponsableValor;
        private System.Windows.Forms.Label lblEstadoTitulo;
        private System.Windows.Forms.Label lblEstadoValor;
        private System.Windows.Forms.Button btnProgramar;
        private System.Windows.Forms.GroupBox grpConteo;
        private System.Windows.Forms.Label lblBuscarTitulo;
        private System.Windows.Forms.TextBox txtBuscarInsumo;
        private System.Windows.Forms.Label lblCategoriaTitulo;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.DataGridView dgvConteo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockRegistrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockContado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCausa;
        private System.Windows.Forms.GroupBox grpResultado;
        private System.Windows.Forms.Label lblResumenValor;
        private System.Windows.Forms.Button btnGuardarConteo;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.Button btnRegistrarConforme;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Button btnAnularInventario;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.StatusStrip ssEstado;
        private System.Windows.Forms.ToolStripStatusLabel tsslListo;
        private System.Windows.Forms.ToolStripStatusLabel tsslUsuario;
    }
}