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
    public partial class Inventario_Fisico : Form
    {
        public Inventario_Fisico()
        {
            InitializeComponent();
        }

        private void frmInventarioFisico_Load(object sender, EventArgs e) { }

        private void btnProgramar_Click(object sender, EventArgs e) { }

        private void txtBuscarInsumo_TextChanged(object sender, EventArgs e) { }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e) { }

        private void dgvConteo_CellEndEdit(object sender, DataGridViewCellEventArgs e) { }

        private void btnGuardarConteo_Click(object sender, EventArgs e) { }

        private void btnComparar_Click(object sender, EventArgs e) { }

        private void btnRegistrarConforme_Click(object sender, EventArgs e) { }

        private void btnGenerarReporte_Click(object sender, EventArgs e) { }

        private void btnAnularInventario_Click(object sender, EventArgs e) { }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}