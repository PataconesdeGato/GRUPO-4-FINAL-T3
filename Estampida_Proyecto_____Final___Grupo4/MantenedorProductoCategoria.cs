using CAPA_ENTDIDAD_;
using CAPA_LOGICA_;
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
    public partial class MantenedorProductoCategoria : Form
    {
        public MantenedorProductoCategoria()
        {
            InitializeComponent();
            listarCategoria();
            grupBoxDatos.Enabled = false;
            txtidCategoriaProducto.Enabled = false;
        }

        public void listarCategoria()
        {
            dgvCategoria.DataSource = Log_Categoria_Productos.Instancia.ListarCategoriaProducto();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = true;
            btnAgregar.Visible = true;
            LimpiarVariables();
            cbkEstadoCategoria.Checked = true;
            btnModificar.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                ent_Categoria_Productos c = new ent_Categoria_Productos();
                c.nombre = txtNombre.Text.Trim();
                c.estado = cbkEstadoCategoria.Checked;
                Log_Categoria_Productos.Instancia.InsertaCategoriaProducto(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarCategoria();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            Menu_Principal Menu_Principal = new Menu_Principal();
            Menu_Principal.Show();

            Close();

        }
        private void LimpiarVariables()
        {
            txtidCategoriaProducto.Text = "";
            txtNombre.Text = "";
        }

        private void dgvCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvCategoria.Rows[e.RowIndex]; //
            txtidCategoriaProducto.Text = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
            cbkEstadoCategoria.Checked = Convert.ToBoolean(filaActual.Cells[2].Value);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            grupBoxDatos.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                ent_Categoria_Productos c = new ent_Categoria_Productos();
                c.idCategoriaProducto = int.Parse(txtidCategoriaProducto.Text.Trim());
                c.nombre = txtNombre.Text.Trim();
                c.estado = cbkEstadoCategoria.Checked;
                Log_Categoria_Productos.Instancia.EditaCategoriaProducto(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarCategoria();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = false;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                ent_Categoria_Productos c = new ent_Categoria_Productos();
                c.idCategoriaProducto = int.Parse(txtidCategoriaProducto.Text.Trim());
                cbkEstadoCategoria.Checked = false;
                Log_Categoria_Productos.Instancia.DeshabilitarCategoriaProducto(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarCategoria();
        }

        private void btn_Agregar_Categoria_Click(object sender, EventArgs e)
        {

        }
    }
}
