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
    public partial class frmAbastecimiento : Form
    {
        public frmAbastecimiento()
        {
            InitializeComponent();
        }

        private void btnCoreOrden_Click(object sender, EventArgs e)
        {
            // Abre el Formulario del Core 1
            frmOrdenCompra frm = new frmOrdenCompra();
            frm.ShowDialog();
        }

        private void btnCoreIngreso_Click(object sender, EventArgs e)
        {
            // Abre el Formulario del Core 2
            frmIngresoInsumos frm = new frmIngresoInsumos();
            frm.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra este menú y vuelve al Menu_Principal
        }
    }
}
