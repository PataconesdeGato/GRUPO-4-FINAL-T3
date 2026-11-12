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

        private void btnMantenedorProducto_Click(object sender, EventArgs e)
        {
            MantenedorProducto mantenedorProducto = new MantenedorProducto();
            mantenedorProducto.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MantenedorProductoCategoria mantenedorProductoCategoria = new MantenedorProductoCategoria();
            mantenedorProductoCategoria.Show();
            this.Hide();
        }

        private void btnMantenedorMesas_Click(object sender, EventArgs e)
        {
            Mesas mesas = new Mesas();
            mesas.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            InformeInsumos informeInsumos = new InformeInsumos();
            informeInsumos.Show();
            this.Hide();
        }
    }
}
