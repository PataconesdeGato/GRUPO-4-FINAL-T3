using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estampida_Proyecto_____Final___Grupo4
{
    public partial class frmModuloSalidaInsumos : Form
    {
        public frmModuloSalidaInsumos()
        {
            InitializeComponent();
        }

        private void btnCorePedido_Click(object sender, EventArgs e)
        {
            // Abre el formulario del Core de Pedido
            frmSolicitudInsumos frm = new frmSolicitudInsumos();
            frm.ShowDialog();
        }

        private void btnCoreSalida_Click(object sender, EventArgs e)
        {
            // Abre el formulario del Core de Salida
            frmSalidaInsumos frm = new frmSalidaInsumos();
            frm.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}