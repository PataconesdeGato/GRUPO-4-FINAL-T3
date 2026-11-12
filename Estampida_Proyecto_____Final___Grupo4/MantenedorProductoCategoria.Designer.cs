namespace Estampida_Proyecto_____Final___Grupo4
{
    partial class MantenedorProductoCategoria
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
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.grupBoxDatos = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cbkEstadoCategoria = new System.Windows.Forms.CheckBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtidCategoriaProducto = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.grupBoxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Location = new System.Drawing.Point(16, 15);
            this.dgvCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.RowHeadersWidth = 51;
            this.dgvCategoria.Size = new System.Drawing.Size(839, 266);
            this.dgvCategoria.TabIndex = 0;
            this.dgvCategoria.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoria_CellDoubleClick);
            // 
            // grupBoxDatos
            // 
            this.grupBoxDatos.Controls.Add(this.btnCancelar);
            this.grupBoxDatos.Controls.Add(this.btnModificar);
            this.grupBoxDatos.Controls.Add(this.btnAgregar);
            this.grupBoxDatos.Controls.Add(this.cbkEstadoCategoria);
            this.grupBoxDatos.Controls.Add(this.txtNombre);
            this.grupBoxDatos.Controls.Add(this.txtidCategoriaProducto);
            this.grupBoxDatos.Controls.Add(this.label);
            this.grupBoxDatos.Controls.Add(this.label1);
            this.grupBoxDatos.Location = new System.Drawing.Point(16, 300);
            this.grupBoxDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grupBoxDatos.Name = "grupBoxDatos";
            this.grupBoxDatos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grupBoxDatos.Size = new System.Drawing.Size(839, 170);
            this.grupBoxDatos.TabIndex = 1;
            this.grupBoxDatos.TabStop = false;
            this.grupBoxDatos.Text = "Datos Categoria";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(712, 95);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 41);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(577, 123);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 39);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(577, 70);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 46);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cbkEstadoCategoria
            // 
            this.cbkEstadoCategoria.AutoSize = true;
            this.cbkEstadoCategoria.Location = new System.Drawing.Point(615, 42);
            this.cbkEstadoCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbkEstadoCategoria.Name = "cbkEstadoCategoria";
            this.cbkEstadoCategoria.Size = new System.Drawing.Size(66, 20);
            this.cbkEstadoCategoria.TabIndex = 4;
            this.cbkEstadoCategoria.Text = "Activo";
            this.cbkEstadoCategoria.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(123, 91);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(341, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // txtidCategoriaProducto
            // 
            this.txtidCategoriaProducto.Location = new System.Drawing.Point(123, 46);
            this.txtidCategoriaProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtidCategoriaProducto.Name = "txtidCategoriaProducto";
            this.txtidCategoriaProducto.Size = new System.Drawing.Size(212, 22);
            this.txtidCategoriaProducto.TabIndex = 2;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(28, 95);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(56, 16);
            this.label.TabIndex = 1;
            this.label.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(29, 501);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(120, 50);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(201, 501);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(128, 50);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(381, 501);
            this.btnDeshabilitar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(131, 50);
            this.btnDeshabilitar.TabIndex = 4;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(728, 501);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(111, 50);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // MantenedorProductoCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 583);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.grupBoxDatos);
            this.Controls.Add(this.dgvCategoria);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MantenedorProductoCategoria";
            this.Text = "MantenedorProductoCategoria";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.grupBoxDatos.ResumeLayout(false);
            this.grupBoxDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.GroupBox grupBoxDatos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.CheckBox cbkEstadoCategoria;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtidCategoriaProducto;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnSalir;
    }
}