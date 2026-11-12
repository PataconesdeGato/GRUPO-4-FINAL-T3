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
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void btnAbastecimiento_Click(object sender, EventArgs e)
        {
            frmAbastecimiento formulario = new frmAbastecimiento();
            formulario.ShowDialog();
        }

        private void btnSalidadeInsumo_Click(object sender, EventArgs e)
        {
            frmModuloSalidaInsumos formulario = new frmModuloSalidaInsumos();
            formulario.ShowDialog();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            frmMantenedorProveedor formulario = new frmMantenedorProveedor();
            formulario.ShowDialog();
        }
    }
}
