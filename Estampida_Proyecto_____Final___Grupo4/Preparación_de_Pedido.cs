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
    public partial class Preparación_de_Pedido : Form
    {
        public Preparación_de_Pedido()
        {
            InitializeComponent();
        }

        private void btnRecetas_Click(object sender, EventArgs e)
        {
            Receta ventana = new Receta();
         ventana.Show();
        }
    }
}
