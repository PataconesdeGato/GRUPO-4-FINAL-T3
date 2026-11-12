using System;
using System.Windows.Forms;
using CAPA_ENTDIDAD_;
using CAPA_LOGICA_;

namespace Estampida_Proyecto_____Final___Grupo4
{
    public partial class Receta : Form
    {
        public Receta()
        {
            InitializeComponent();
            grupBoxDatos.Enabled = false;
            txtIdReceta.Enabled = false;
        }

        private void Receta_Shown(object sender, EventArgs e)
        {
            listarReceta();
        }

        public void listarReceta()
        {
            try
            {
                dgvReceta.DataSource = logRecetas.Instancia.ListarRecetas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de base de datos:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = true;
            btnAgregar.Visible = true;
            btnModificar.Visible = false;
            LimpiarVariables();
            txtIdProducto.Enabled = true; // Al crear, SÍ podemos elegir el producto
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entRecetas c = new entRecetas();
                c.idProducto = int.Parse(txtIdProducto.Text.Trim());
                c.descripcion = txtDescripcion.Text.Trim();

                logRecetas.Instancia.InsertaRecetas(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Asegúrese de ingresar un ID de Producto válido que no tenga receta.\n\nError interno: " + ex.Message, "Aviso");
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarReceta();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LimpiarVariables()
        {
            txtIdReceta.Text = "";
            txtIdProducto.Text = "";
            txtDescripcion.Text = "";
            cbkEstadoReceta.Checked = false;
        }

        private void dgvReceta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaActual = dgvReceta.Rows[e.RowIndex];
                txtIdReceta.Text = filaActual.Cells[0].Value.ToString();
                txtIdProducto.Text = filaActual.Cells[1].Value.ToString();
                // Cells[2] es el Nombre del producto, no lo guardamos en TextBox porque es de lectura
                txtDescripcion.Text = filaActual.Cells[3].Value.ToString();
                cbkEstadoReceta.Checked = Convert.ToBoolean(filaActual.Cells[4].Value);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;

            // Bloqueamos el ID Producto porque el SP no permite cambiar de producto una vez creada la receta
            txtIdProducto.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entRecetas c = new entRecetas();
                c.idReceta = int.Parse(txtIdReceta.Text.Trim());
                c.descripcion = txtDescripcion.Text.Trim();
                c.estado = cbkEstadoReceta.Checked;

                logRecetas.Instancia.EditaRecetas(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarReceta();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = false;
            LimpiarVariables();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entRecetas c = new entRecetas();
                c.idReceta = int.Parse(txtIdReceta.Text.Trim());

                logRecetas.Instancia.DeshabilitarRecetas(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarReceta();
        }
    }
}