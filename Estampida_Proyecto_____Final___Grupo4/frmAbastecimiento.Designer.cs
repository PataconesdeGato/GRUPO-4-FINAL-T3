namespace Estampida_Proyecto_____Final___Grupo4
{
    partial class frmAbastecimiento
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
            this.btnCoreOrden = new System.Windows.Forms.Button();
            this.btnCoreIngreso = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(40, 30);
            this.lblTitulo.Text = "Gestión de Abastecimiento";

            // btnCoreOrden (Core 1)
            this.btnCoreOrden.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCoreOrden.Location = new System.Drawing.Point(45, 90);
            this.btnCoreOrden.Size = new System.Drawing.Size(300, 60);
            this.btnCoreOrden.Text = "1. Registrar Orden de Compra";
            this.btnCoreOrden.UseVisualStyleBackColor = true;
            this.btnCoreOrden.Click += new System.EventHandler(this.btnCoreOrden_Click);

            // btnCoreIngreso (Core 2)
            this.btnCoreIngreso.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCoreIngreso.Location = new System.Drawing.Point(45, 170);
            this.btnCoreIngreso.Size = new System.Drawing.Size(300, 60);
            this.btnCoreIngreso.Text = "2. Registrar Ingreso de Insumos";
            this.btnCoreIngreso.UseVisualStyleBackColor = true;
            this.btnCoreIngreso.Click += new System.EventHandler(this.btnCoreIngreso_Click);

            // btnVolver
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVolver.Location = new System.Drawing.Point(45, 260);
            this.btnVolver.Size = new System.Drawing.Size(100, 30);
            this.btnVolver.Text = "Volver al Menú";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);

            // frmAbastecimiento
            this.ClientSize = new System.Drawing.Size(400, 320);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCoreIngreso);
            this.Controls.Add(this.btnCoreOrden);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmAbastecimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módulo Almacén";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCoreOrden;
        private System.Windows.Forms.Button btnCoreIngreso;
        private System.Windows.Forms.Button btnVolver;
    }
}