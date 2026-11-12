namespace Estampida_Proyecto_____Final___Grupo4
{
    partial class InformeInsumos
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.btnPedidoInsumos = new System.Windows.Forms.Button();
            this.btnNotaInsumos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(0, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(400, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Informe de Insumos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubtitulo.Location = new System.Drawing.Point(0, 52);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(400, 20);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Seleccione la operación a realizar";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPedidoInsumos
            // 
            this.btnPedidoInsumos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnPedidoInsumos.Location = new System.Drawing.Point(60, 95);
            this.btnPedidoInsumos.Name = "btnPedidoInsumos";
            this.btnPedidoInsumos.Size = new System.Drawing.Size(280, 60);
            this.btnPedidoInsumos.TabIndex = 2;
            this.btnPedidoInsumos.Text = "Registrar Pedido de Insumos";
            this.btnPedidoInsumos.UseVisualStyleBackColor = true;
            this.btnPedidoInsumos.Click += new System.EventHandler(this.btnPedidoInsumos_Click);
            // 
            // btnNotaInsumos
            // 
            this.btnNotaInsumos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnNotaInsumos.Location = new System.Drawing.Point(60, 170);
            this.btnNotaInsumos.Name = "btnNotaInsumos";
            this.btnNotaInsumos.Size = new System.Drawing.Size(280, 60);
            this.btnNotaInsumos.TabIndex = 3;
            this.btnNotaInsumos.Text = "Registrar Nota de Insumos";
            this.btnNotaInsumos.UseVisualStyleBackColor = true;
            this.btnNotaInsumos.Click += new System.EventHandler(this.btnNotaInsumos_Click);
            // 
            // InformeInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 255);
            this.Controls.Add(this.btnNotaInsumos);
            this.Controls.Add(this.btnPedidoInsumos);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InformeInsumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insumos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InformeInsumos_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnPedidoInsumos;
        private System.Windows.Forms.Button btnNotaInsumos;
    }
}