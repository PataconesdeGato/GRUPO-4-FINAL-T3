namespace Estampida_Proyecto_____Final___Grupo4
{
    partial class CategoriaInsumos1
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
            this.grupBoxDatos = new System.Windows.Forms.GroupBox();
            this.cbkEstado = new System.Windows.Forms.CheckBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdCategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // grupBoxDatos
            // 
            this.grupBoxDatos.Controls.Add(this.cbkEstado);
            this.grupBoxDatos.Controls.Add(this.txtDescripcion);
            this.grupBoxDatos.Controls.Add(this.label3);
            this.grupBoxDatos.Controls.Add(this.txtIdCategoria);
            this.grupBoxDatos.Controls.Add(this.label1);
            this.grupBoxDatos.Location = new System.Drawing.Point(31, 250);
            this.grupBoxDatos.Size = new System.Drawing.Size(867, 130);
            this.grupBoxDatos.TabIndex = 1;
            this.grupBoxDatos.TabStop = false;
            this.grupBoxDatos.Text = "Datos de Categoría";
            // 
            // cbkEstado
            // 
            this.cbkEstado.AutoSize = true;
            this.cbkEstado.Location = new System.Drawing.Point(340, 45);
            this.cbkEstado.Size = new System.Drawing.Size(130, 20);
            this.cbkEstado.TabIndex = 14;
            this.cbkEstado.Text = "Estado Activo";
            this.cbkEstado.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(120, 80);
            this.txtDescripcion.Size = new System.Drawing.Size(400, 22);
            this.txtDescripcion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 83);
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripción:";
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.Location = new System.Drawing.Point(120, 43);
            this.txtIdCategoria.Size = new System.Drawing.Size(92, 22);
            this.txtIdCategoria.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 46);
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Categoría:";
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.AllowUserToAddRows = false;
            this.dgvCategoria.AllowUserToDeleteRows = false;
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Location = new System.Drawing.Point(31, 15);
            this.dgvCategoria.ReadOnly = true;
            this.dgvCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategoria.Size = new System.Drawing.Size(867, 215);
            this.dgvCategoria.TabIndex = 0;
            this.dgvCategoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoria_CellClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(927, 15);
            this.btnNuevo.Size = new System.Drawing.Size(127, 37);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(927, 74);
            this.btnEditar.Size = new System.Drawing.Size(127, 37);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(927, 133);
            this.btnDeshabilitar.Size = new System.Drawing.Size(127, 37);
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(927, 193);
            this.btnSalir.Size = new System.Drawing.Size(127, 37);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(927, 265);
            this.btnAgregar.Size = new System.Drawing.Size(127, 37);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Visible = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(927, 327);
            this.btnModificar.Size = new System.Drawing.Size(127, 37);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Visible = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(927, 390);
            this.btnCancelar.Size = new System.Drawing.Size(127, 37);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // CategoriaInsumos1
            // 
            this.ClientSize = new System.Drawing.Size(1085, 469);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvCategoria);
            this.Controls.Add(this.grupBoxDatos);
            this.Name = "CategoriaInsumos1";
            this.Text = "Categoría de Insumos";
            this.Shown += new System.EventHandler(this.CategoriaInsumos1_Shown);
            this.grupBoxDatos.ResumeLayout(false);
            this.grupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grupBoxDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.CheckBox cbkEstado;
        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
    }
}