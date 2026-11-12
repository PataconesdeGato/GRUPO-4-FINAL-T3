namespace Estampida_Proyecto_____Final___Grupo4
{
    partial class MantenedorProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.chkMostrarInactivos = new System.Windows.Forms.CheckBox();
            this.grupBoxDatos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtidProducto = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.cbkEstadoProducto = new System.Windows.Forms.CheckBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.grupBoxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(12, 12);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(855, 239);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellDoubleClick);
            // 
            // chkMostrarInactivos
            // 
            this.chkMostrarInactivos.AutoSize = true;
            this.chkMostrarInactivos.Location = new System.Drawing.Point(12, 257);
            this.chkMostrarInactivos.Name = "chkMostrarInactivos";
            this.chkMostrarInactivos.Size = new System.Drawing.Size(133, 17);
            this.chkMostrarInactivos.TabIndex = 1;
            this.chkMostrarInactivos.Text = "Mostrar Deshabilitados";
            this.chkMostrarInactivos.UseVisualStyleBackColor = true;
            this.chkMostrarInactivos.CheckedChanged += new System.EventHandler(this.chkMostrarInactivos_CheckedChanged);
            // 
            // grupBoxDatos
            // 
            this.grupBoxDatos.Controls.Add(this.btnCancelar);
            this.grupBoxDatos.Controls.Add(this.btnModificar);
            this.grupBoxDatos.Controls.Add(this.btnAgregar);
            this.grupBoxDatos.Controls.Add(this.cbkEstadoProducto);
            this.grupBoxDatos.Controls.Add(this.cboCategoria);
            this.grupBoxDatos.Controls.Add(this.txtCodigo);
            this.grupBoxDatos.Controls.Add(this.txtPrecio);
            this.grupBoxDatos.Controls.Add(this.txtNombres);
            this.grupBoxDatos.Controls.Add(this.txtidProducto);
            this.grupBoxDatos.Controls.Add(this.label5);
            this.grupBoxDatos.Controls.Add(this.label4);
            this.grupBoxDatos.Controls.Add(this.label3);
            this.grupBoxDatos.Controls.Add(this.txtNombre);
            this.grupBoxDatos.Controls.Add(this.label1);
            this.grupBoxDatos.Location = new System.Drawing.Point(12, 290);
            this.grupBoxDatos.Name = "grupBoxDatos";
            this.grupBoxDatos.Size = new System.Drawing.Size(855, 195);
            this.grupBoxDatos.TabIndex = 2;
            this.grupBoxDatos.TabStop = false;
            this.grupBoxDatos.Text = "Datos del Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(29, 84);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(44, 13);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio (S/)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Codigo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categoria";
            // 
            // txtidProducto
            // 
            this.txtidProducto.Location = new System.Drawing.Point(112, 39);
            this.txtidProducto.Name = "txtidProducto";
            this.txtidProducto.Size = new System.Drawing.Size(166, 20);
            this.txtidProducto.TabIndex = 5;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(112, 81);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(470, 20);
            this.txtNombres.TabIndex = 6;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(112, 121);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(166, 20);
            this.txtPrecio.TabIndex = 7;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(460, 42);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(122, 20);
            this.txtCodigo.TabIndex = 8;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(461, 128);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 9;
            // 
            // cbkEstadoProducto
            // 
            this.cbkEstadoProducto.AutoSize = true;
            this.cbkEstadoProducto.Location = new System.Drawing.Point(624, 30);
            this.cbkEstadoProducto.Name = "cbkEstadoProducto";
            this.cbkEstadoProducto.Size = new System.Drawing.Size(56, 17);
            this.cbkEstadoProducto.TabIndex = 10;
            this.cbkEstadoProducto.Text = "Activo";
            this.cbkEstadoProducto.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(24, 502);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(109, 44);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(165, 502);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(107, 44);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(312, 502);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(103, 44);
            this.btnDeshabilitar.TabIndex = 5;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(624, 62);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(101, 39);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(624, 128);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(101, 42);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(750, 96);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 41);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(774, 505);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(93, 41);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // MantenedorProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 558);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.grupBoxDatos);
            this.Controls.Add(this.chkMostrarInactivos);
            this.Controls.Add(this.dgvProductos);
            this.Name = "MantenedorProducto";
            this.Text = "MantenedorProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.grupBoxDatos.ResumeLayout(false);
            this.grupBoxDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.CheckBox chkMostrarInactivos;
        private System.Windows.Forms.GroupBox grupBoxDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtidProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.CheckBox cbkEstadoProducto;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnSalir;
    }
}