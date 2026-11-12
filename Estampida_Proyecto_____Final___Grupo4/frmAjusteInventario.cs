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
    public partial class frmAjusteInventario : Form
    {
        public frmAjusteInventario()
        {
            InitializeComponent();
        }

        private void frmAjusteInventario_Load(object sender, EventArgs e) { }

        private void cboReporte_SelectedIndexChanged(object sender, EventArgs e) { }

        private void cboInsumo_SelectedIndexChanged(object sender, EventArgs e) { }

        private void nudCantidad_ValueChanged(object sender, EventArgs e) { }

        private void btnRegistrarAjuste_Click(object sender, EventArgs e) { }

        private void btnNuevoAjuste_Click(object sender, EventArgs e) { }

        private void btnConsultar_Click(object sender, EventArgs e) { }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e) { }

        private void btnAnularAjuste_Click(object sender, EventArgs e) { }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
