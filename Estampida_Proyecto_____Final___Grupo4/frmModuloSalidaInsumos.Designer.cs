namespace Estampida_Proyecto_____Final___Grupo4
{
    partial class frmModuloSalidaInsumos
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCorePedido = new System.Windows.Forms.Button();
            this.btnCoreSalida = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(40, 30);
            this.lblTitulo.Text = "Gestión de Salida de Insumos";

            // btnCorePedido (Core 1)
            this.btnCorePedido.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCorePedido.Location = new System.Drawing.Point(45, 90);
            this.btnCorePedido.Size = new System.Drawing.Size(300, 60);
            this.btnCorePedido.Text = "1. Registrar Pedido de Insumos (Cocina)";
            this.btnCorePedido.UseVisualStyleBackColor = true;
            this.btnCorePedido.Click += new System.EventHandler(this.btnCorePedido_Click);

            // btnCoreSalida (Core 2)
            this.btnCoreSalida.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCoreSalida.Location = new System.Drawing.Point(45, 170);
            this.btnCoreSalida.Size = new System.Drawing.Size(300, 60);
            this.btnCoreSalida.Text = "2. Registrar Salida de Insumos (Almacén)";
            this.btnCoreSalida.UseVisualStyleBackColor = true;
            this.btnCoreSalida.Click += new System.EventHandler(this.btnCoreSalida_Click);

            // btnVolver
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVolver.Location = new System.Drawing.Point(45, 260);
            this.btnVolver.Size = new System.Drawing.Size(100, 30);
            this.btnVolver.Text = "Volver al Menú";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);

            // frmModuloSalidaInsumos
            this.ClientSize = new System.Drawing.Size(400, 320);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCoreSalida);
            this.Controls.Add(this.btnCorePedido);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmModuloSalidaInsumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módulo Salida de Insumos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCorePedido;
        private System.Windows.Forms.Button btnCoreSalida;
        private System.Windows.Forms.Button btnVolver;
    }
}