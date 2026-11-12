namespace Estampida_Proyecto_____Final___Grupo4
{
    partial class Clientes
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
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // grupBoxDatos
            // 
            this.grupBoxDatos.Controls.Add(this.cbkEstado);
            this.grupBoxDatos.Controls.Add(this.txtCorreo);
            this.grupBoxDatos.Controls.Add(this.label5);
            this.grupBoxDatos.Controls.Add(this.txtTelefono);
            this.grupBoxDatos.Controls.Add(this.label4);
            this.grupBoxDatos.Controls.Add(this.txtNombres);
            this.grupBoxDatos.Controls.Add(this.label3);
            this.grupBoxDatos.Controls.Add(this.txtDni);
            this.grupBoxDatos.Controls.Add(this.label2);
            this.grupBoxDatos.Controls.Add(this.txtIdCliente);
            this.grupBoxDatos.Controls.Add(this.label1);
            this.grupBoxDatos.Location = new System.Drawing.Point(31, 250);
            this.grupBoxDatos.Size = new System.Drawing.Size(867, 160);
            this.grupBoxDatos.TabIndex = 1;
            this.grupBoxDatos.TabStop = false;
            this.grupBoxDatos.Text = "Datos de Cliente";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(120, 30);
            this.txtIdCliente.Size = new System.Drawing.Size(92, 22);
            this.txtIdCliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Cliente:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(340, 30);
            this.txtDni.Size = new System.Drawing.Size(120, 22);
            this.txtDni.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 33);
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "DNI:";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(120, 70);
            this.txtNombres.Size = new System.Drawing.Size(340, 22);
            this.txtNombres.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 73);
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombres:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(120, 110);
            this.txtTelefono.Size = new System.Drawing.Size(150, 22);
            this.txtTelefono.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 113);
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Teléfono:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(360, 110);
            this.txtCorreo.Size = new System.Drawing.Size(250, 22);
            this.txtCorreo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 113);
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Correo:";
            // 
            // cbkEstado
            // 
            this.cbkEstado.AutoSize = true;
            this.cbkEstado.Location = new System.Drawing.Point(550, 32);
            this.cbkEstado.Size = new System.Drawing.Size(130, 20);
            this.cbkEstado.TabIndex = 14;
            this.cbkEstado.Text = "Estado Activo";
            this.cbkEstado.UseVisualStyleBackColor = true;
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(31, 15);
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(867, 215);
            this.dgvCliente.TabIndex = 0;
            this.dgvCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellClick);
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
            // Clientes
            // 
            this.ClientSize = new System.Drawing.Size(1085, 469);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.grupBoxDatos);
            this.Name = "Clientes";
            this.Text = "Mantenedor de Clientes";
            this.Shown += new System.EventHandler(this.Clientes_Shown);
            this.grupBoxDatos.ResumeLayout(false);
            this.grupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grupBoxDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.CheckBox cbkEstado;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
    }
}