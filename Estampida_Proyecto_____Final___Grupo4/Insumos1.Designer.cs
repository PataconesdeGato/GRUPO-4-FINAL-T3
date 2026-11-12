namespace Estampida_Proyecto_____Final___Grupo4
{
    partial class Insumos1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnAgregarInsumos = new System.Windows.Forms.GroupBox();
            this.cbkEstado = new System.Windows.Forms.CheckBox();
            this.txtUnidadMedida = new System.Windows.Forms.TextBox();
            this.lblU = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblS = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdInsumo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInsumos = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btn_agregar_Categoria = new System.Windows.Forms.Button();
            this.btnAgregarInsumos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarInsumos
            // 
            this.btnAgregarInsumos.Controls.Add(this.btn_agregar_Categoria);
            this.btnAgregarInsumos.Controls.Add(this.cbkEstado);
            this.btnAgregarInsumos.Controls.Add(this.txtUnidadMedida);
            this.btnAgregarInsumos.Controls.Add(this.lblU);
            this.btnAgregarInsumos.Controls.Add(this.txtStock);
            this.btnAgregarInsumos.Controls.Add(this.lblS);
            this.btnAgregarInsumos.Controls.Add(this.txtDescripcion);
            this.btnAgregarInsumos.Controls.Add(this.label3);
            this.btnAgregarInsumos.Controls.Add(this.cboCategoria);
            this.btnAgregarInsumos.Controls.Add(this.label2);
            this.btnAgregarInsumos.Controls.Add(this.txtIdInsumo);
            this.btnAgregarInsumos.Controls.Add(this.label1);
            this.btnAgregarInsumos.Location = new System.Drawing.Point(31, 250);
            this.btnAgregarInsumos.Name = "btnAgregarInsumos";
            this.btnAgregarInsumos.Size = new System.Drawing.Size(867, 197);
            this.btnAgregarInsumos.TabIndex = 1;
            this.btnAgregarInsumos.TabStop = false;
            this.btnAgregarInsumos.Text = "Agregar Categorria";
            // 
            // cbkEstado
            // 
            this.cbkEstado.AutoSize = true;
            this.cbkEstado.Location = new System.Drawing.Point(550, 77);
            this.cbkEstado.Name = "cbkEstado";
            this.cbkEstado.Size = new System.Drawing.Size(112, 20);
            this.cbkEstado.TabIndex = 14;
            this.cbkEstado.Text = "Estado Activo";
            this.cbkEstado.UseVisualStyleBackColor = true;
            // 
            // txtUnidadMedida
            // 
            this.txtUnidadMedida.Location = new System.Drawing.Point(340, 120);
            this.txtUnidadMedida.Name = "txtUnidadMedida";
            this.txtUnidadMedida.Size = new System.Drawing.Size(180, 22);
            this.txtUnidadMedida.TabIndex = 9;
            // 
            // lblU
            // 
            this.lblU.AutoSize = true;
            this.lblU.Location = new System.Drawing.Point(230, 123);
            this.lblU.Name = "lblU";
            this.lblU.Size = new System.Drawing.Size(103, 16);
            this.lblU.TabIndex = 8;
            this.lblU.Text = "Unidad Medida:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(120, 120);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(92, 22);
            this.txtStock.TabIndex = 7;
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Location = new System.Drawing.Point(27, 123);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(44, 16);
            this.lblS.TabIndex = 6;
            this.lblS.Text = "Stock:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(120, 75);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(400, 22);
            this.txtDescripcion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripción:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.Location = new System.Drawing.Point(340, 30);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(180, 24);
            this.cboCategoria.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoría:";
            // 
            // txtIdInsumo
            // 
            this.txtIdInsumo.Location = new System.Drawing.Point(120, 30);
            this.txtIdInsumo.Name = "txtIdInsumo";
            this.txtIdInsumo.Size = new System.Drawing.Size(92, 22);
            this.txtIdInsumo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Insumo:";
            // 
            // dgvInsumos
            // 
            this.dgvInsumos.AllowUserToAddRows = false;
            this.dgvInsumos.AllowUserToDeleteRows = false;
            this.dgvInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsumos.Location = new System.Drawing.Point(31, 15);
            this.dgvInsumos.Name = "dgvInsumos";
            this.dgvInsumos.ReadOnly = true;
            this.dgvInsumos.RowHeadersWidth = 51;
            this.dgvInsumos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInsumos.Size = new System.Drawing.Size(867, 215);
            this.dgvInsumos.TabIndex = 0;
            this.dgvInsumos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInsumos_CellClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(927, 15);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(127, 37);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(927, 74);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(127, 37);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(927, 133);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(127, 37);
            this.btnDeshabilitar.TabIndex = 4;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(927, 193);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(127, 37);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(927, 265);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(127, 37);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Visible = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(927, 327);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(127, 37);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Visible = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(927, 390);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(127, 37);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btn_agregar_Categoria
            // 
            this.btn_agregar_Categoria.Location = new System.Drawing.Point(604, 15);
            this.btn_agregar_Categoria.Name = "btn_agregar_Categoria";
            this.btn_agregar_Categoria.Size = new System.Drawing.Size(218, 33);
            this.btn_agregar_Categoria.TabIndex = 15;
            this.btn_agregar_Categoria.Text = "Agregar Categoria";
            this.btn_agregar_Categoria.UseVisualStyleBackColor = true;
            this.btn_agregar_Categoria.Click += new System.EventHandler(this.btn_agregar_Categoria_Click);
            // 
            // Insumos1
            // 
            this.ClientSize = new System.Drawing.Size(1085, 469);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvInsumos);
            this.Controls.Add(this.btnAgregarInsumos);
            this.Name = "Insumos1";
            this.Text = "Mantenedor de Insumos";
            this.btnAgregarInsumos.ResumeLayout(false);
            this.btnAgregarInsumos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox btnAgregarInsumos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdInsumo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblU;
        private System.Windows.Forms.TextBox txtUnidadMedida;
        private System.Windows.Forms.CheckBox cbkEstado;
        private System.Windows.Forms.DataGridView dgvInsumos;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btn_agregar_Categoria;
    }
}