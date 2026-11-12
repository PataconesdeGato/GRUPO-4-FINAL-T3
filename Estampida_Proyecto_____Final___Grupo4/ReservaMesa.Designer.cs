namespace Estampida_Proyecto_____Final___Grupo4
{
    partial class ReservaMesa
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
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.btnRegistrarCliente = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.grpReserva = new System.Windows.Forms.GroupBox();
            this.btnVerMesas = new System.Windows.Forms.Button();
            this.nudComensales = new System.Windows.Forms.NumericUpDown();
            this.lblComensales = new System.Windows.Forms.Label();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.lblHora = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.grpMesas = new System.Windows.Forms.GroupBox();
            this.flpMesas = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMesa1 = new System.Windows.Forms.Panel();
            this.lblMesa1 = new System.Windows.Forms.Label();
            this.pnlMesa2 = new System.Windows.Forms.Panel();
            this.lblMesa2 = new System.Windows.Forms.Label();
            this.pnlMesa3 = new System.Windows.Forms.Panel();
            this.lblMesa3 = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpCliente.SuspendLayout();
            this.grpReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudComensales)).BeginInit();
            this.grpMesas.SuspendLayout();
            this.flpMesas.SuspendLayout();
            this.pnlMesa1.SuspendLayout();
            this.pnlMesa2.SuspendLayout();
            this.pnlMesa3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCliente
            // 
            this.grpCliente.Controls.Add(this.btnRegistrarCliente);
            this.grpCliente.Controls.Add(this.lblCliente);
            this.grpCliente.Controls.Add(this.btnBuscarCliente);
            this.grpCliente.Controls.Add(this.txtDocumento);
            this.grpCliente.Controls.Add(this.lblDocumento);
            this.grpCliente.Location = new System.Drawing.Point(12, 12);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Size = new System.Drawing.Size(776, 70);
            this.grpCliente.TabIndex = 0;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "1. Cliente";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(15, 32);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(140, 13);
            this.lblDocumento.TabIndex = 0;
            this.lblDocumento.Text = "Documento de identidad *";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(165, 29);
            this.txtDocumento.MaxLength = 20;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(120, 20);
            this.txtDocumento.TabIndex = 1;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(295, 27);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(80, 24);
            this.btnBuscarCliente.TabIndex = 2;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCliente.Location = new System.Drawing.Point(395, 31);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(116, 16);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Nombre del cliente";
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.Location = new System.Drawing.Point(640, 27);
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Size = new System.Drawing.Size(120, 24);
            this.btnRegistrarCliente.TabIndex = 4;
            this.btnRegistrarCliente.Text = "Registrar cliente";
            this.btnRegistrarCliente.UseVisualStyleBackColor = true;
            // 
            // grpReserva
            // 
            this.grpReserva.Controls.Add(this.btnVerMesas);
            this.grpReserva.Controls.Add(this.nudComensales);
            this.grpReserva.Controls.Add(this.lblComensales);
            this.grpReserva.Controls.Add(this.dtpHora);
            this.grpReserva.Controls.Add(this.lblHora);
            this.grpReserva.Controls.Add(this.dtpFecha);
            this.grpReserva.Controls.Add(this.lblFecha);
            this.grpReserva.Location = new System.Drawing.Point(12, 90);
            this.grpReserva.Name = "grpReserva";
            this.grpReserva.Size = new System.Drawing.Size(776, 70);
            this.grpReserva.TabIndex = 1;
            this.grpReserva.TabStop = false;
            this.grpReserva.Text = "2. Datos de la reserva";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(15, 32);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 13);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha *";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(65, 28);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(100, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(190, 32);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(41, 13);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "Hora *";
            // 
            // dtpHora
            // 
            this.dtpHora.CustomFormat = "HH:mm";
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora.Location = new System.Drawing.Point(235, 28);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(70, 20);
            this.dtpHora.TabIndex = 3;
            // 
            // lblComensales
            // 
            this.lblComensales.AutoSize = true;
            this.lblComensales.Location = new System.Drawing.Point(330, 32);
            this.lblComensales.Name = "lblComensales";
            this.lblComensales.Size = new System.Drawing.Size(73, 13);
            this.lblComensales.TabIndex = 4;
            this.lblComensales.Text = "Comensales *";
            // 
            // nudComensales
            // 
            this.nudComensales.Location = new System.Drawing.Point(410, 28);
            this.nudComensales.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            this.nudComensales.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudComensales.Name = "nudComensales";
            this.nudComensales.Size = new System.Drawing.Size(55, 20);
            this.nudComensales.TabIndex = 5;
            this.nudComensales.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // btnVerMesas
            // 
            this.btnVerMesas.Location = new System.Drawing.Point(500, 24);
            this.btnVerMesas.Name = "btnVerMesas";
            this.btnVerMesas.Size = new System.Drawing.Size(170, 28);
            this.btnVerMesas.TabIndex = 6;
            this.btnVerMesas.Text = "Ver mesas disponibles";
            this.btnVerMesas.UseVisualStyleBackColor = true;
            // 
            // grpMesas
            // 
            this.grpMesas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMesas.Controls.Add(this.flpMesas);
            this.grpMesas.Location = new System.Drawing.Point(12, 168);
            this.grpMesas.Name = "grpMesas";
            this.grpMesas.Size = new System.Drawing.Size(776, 265);
            this.grpMesas.TabIndex = 2;
            this.grpMesas.TabStop = false;
            this.grpMesas.Text = "3. Mesas disponibles (seleccione una)";
            // 
            // flpMesas
            // 
            this.flpMesas.AutoScroll = true;
            this.flpMesas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flpMesas.Controls.Add(this.pnlMesa1);
            this.flpMesas.Controls.Add(this.pnlMesa2);
            this.flpMesas.Controls.Add(this.pnlMesa3);
            this.flpMesas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMesas.Location = new System.Drawing.Point(3, 16);
            this.flpMesas.Name = "flpMesas";
            this.flpMesas.Padding = new System.Windows.Forms.Padding(5);
            this.flpMesas.Size = new System.Drawing.Size(770, 246);
            this.flpMesas.TabIndex = 0;
            // 
            // pnlMesa1 (bloque de ejemplo)
            // 
            this.pnlMesa1.BackColor = System.Drawing.Color.FromArgb(46, 160, 67);
            this.pnlMesa1.Controls.Add(this.lblMesa1);
            this.pnlMesa1.Location = new System.Drawing.Point(13, 13);
            this.pnlMesa1.Margin = new System.Windows.Forms.Padding(8);
            this.pnlMesa1.Name = "pnlMesa1";
            this.pnlMesa1.Size = new System.Drawing.Size(110, 80);
            this.pnlMesa1.TabIndex = 0;
            // 
            // lblMesa1
            // 
            this.lblMesa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMesa1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMesa1.ForeColor = System.Drawing.Color.White;
            this.lblMesa1.Location = new System.Drawing.Point(0, 0);
            this.lblMesa1.Name = "lblMesa1";
            this.lblMesa1.Size = new System.Drawing.Size(110, 80);
            this.lblMesa1.TabIndex = 0;
            this.lblMesa1.Text = "Mesa 1\nCap: 4";
            this.lblMesa1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMesa2 (bloque de ejemplo)
            // 
            this.pnlMesa2.BackColor = System.Drawing.Color.FromArgb(46, 160, 67);
            this.pnlMesa2.Controls.Add(this.lblMesa2);
            this.pnlMesa2.Location = new System.Drawing.Point(139, 13);
            this.pnlMesa2.Margin = new System.Windows.Forms.Padding(8);
            this.pnlMesa2.Name = "pnlMesa2";
            this.pnlMesa2.Size = new System.Drawing.Size(110, 80);
            this.pnlMesa2.TabIndex = 1;
            // 
            // lblMesa2
            // 
            this.lblMesa2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMesa2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMesa2.ForeColor = System.Drawing.Color.White;
            this.lblMesa2.Location = new System.Drawing.Point(0, 0);
            this.lblMesa2.Name = "lblMesa2";
            this.lblMesa2.Size = new System.Drawing.Size(110, 80);
            this.lblMesa2.TabIndex = 0;
            this.lblMesa2.Text = "Mesa 2\nCap: 2";
            this.lblMesa2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMesa3 (bloque de ejemplo, seleccionado)
            // 
            this.pnlMesa3.BackColor = System.Drawing.Color.FromArgb(22, 101, 52);
            this.pnlMesa3.Controls.Add(this.lblMesa3);
            this.pnlMesa3.Location = new System.Drawing.Point(265, 13);
            this.pnlMesa3.Margin = new System.Windows.Forms.Padding(8);
            this.pnlMesa3.Name = "pnlMesa3";
            this.pnlMesa3.Size = new System.Drawing.Size(110, 80);
            this.pnlMesa3.TabIndex = 2;
            // 
            // lblMesa3
            // 
            this.lblMesa3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMesa3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMesa3.ForeColor = System.Drawing.Color.White;
            this.lblMesa3.Location = new System.Drawing.Point(0, 0);
            this.lblMesa3.Name = "lblMesa3";
            this.lblMesa3.Size = new System.Drawing.Size(110, 80);
            this.lblMesa3.TabIndex = 0;
            this.lblMesa3.Text = "Mesa 3\nCap: 6";
            this.lblMesa3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(12, 442);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(776, 22);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.Text = "Mensaje de advertencia (rojo)";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmar.Location = new System.Drawing.Point(548, 476);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(140, 34);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Confirmar reserva";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(698, 476);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 34);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.grpMesas);
            this.Controls.Add(this.grpReserva);
            this.Controls.Add(this.grpCliente);
            this.MinimumSize = new System.Drawing.Size(816, 564);
            this.Name = "FrmReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva de Mesa";
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            this.grpReserva.ResumeLayout(false);
            this.grpReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudComensales)).EndInit();
            this.grpMesas.ResumeLayout(false);
            this.flpMesas.ResumeLayout(false);
            this.pnlMesa1.ResumeLayout(false);
            this.pnlMesa2.ResumeLayout(false);
            this.pnlMesa3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.Button btnRegistrarCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.GroupBox grpReserva;
        private System.Windows.Forms.Button btnVerMesas;
        private System.Windows.Forms.NumericUpDown nudComensales;
        private System.Windows.Forms.Label lblComensales;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox grpMesas;
        private System.Windows.Forms.FlowLayoutPanel flpMesas;
        private System.Windows.Forms.Panel pnlMesa1;
        private System.Windows.Forms.Label lblMesa1;
        private System.Windows.Forms.Panel pnlMesa2;
        private System.Windows.Forms.Label lblMesa2;
        private System.Windows.Forms.Panel pnlMesa3;
        private System.Windows.Forms.Label lblMesa3;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
    }
}