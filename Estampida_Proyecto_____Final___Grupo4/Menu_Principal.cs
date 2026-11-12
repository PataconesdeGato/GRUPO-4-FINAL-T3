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

        private void button7_Click(object sender, EventArgs e)
        {
            // 1. Crear la instancia de la nueva ventana
            Preparación_de_Pedido ventana = new Preparación_de_Pedido();

            // 2. Mostrar la ventana
            ventana.Show();
        }
    }
}
