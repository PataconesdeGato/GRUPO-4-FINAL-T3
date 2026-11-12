<<<<<<< HEAD
﻿using System;
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
        //preparacion de Pedido
        private void button7_Click(object sender, EventArgs e)
        {
     
            Preparación_de_Pedido ventana = new Preparación_de_Pedido();

          
            ventana.Show();
        }

   
        //Mantenedor Empleado
        private void button11_Click_1(object sender, EventArgs e)
        {
            Empleado ventana = new Empleado();

       
            ventana.Show();
        }

        private void btn_Venta_a_Pedido_Click(object sender, EventArgs e)
        {

            Venta_a_Pedido ventana = new Venta_a_Pedido();


            ventana.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btn_Inventario_fisico_Click(object sender, EventArgs e)
        {
            Inventario_Fisico ventana = new Inventario_Fisico();


            ventana.Show();

        }

        private void Ajuste_Inventario_Click(object sender, EventArgs e)
        {
            frmAjusteInventario ventana = new frmAjusteInventario();


            ventana.Show();
        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            Insumos ventana = new Insumos();


            ventana.Show();
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            Cliente ventana = new Cliente();


            ventana.Show();

        }
    }
}
=======
﻿using System;
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
>>>>>>> main
