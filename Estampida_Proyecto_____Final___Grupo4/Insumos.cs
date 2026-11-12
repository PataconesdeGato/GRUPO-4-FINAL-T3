using System;
using System.Windows.Forms;
using CAPA_ENTDIDAD_;
using CAPA_LOGICA_;

namespace Estampida_Proyecto_____Final___Grupo4
{
    public partial class Insumos : Form
    {
        public Insumos()
        {
            InitializeComponent();
            grupBoxDatos.Enabled = false;
            txtIdInsumo.Enabled = false;
        }

        private void Insumos_Shown(object sender, EventArgs e)
        {
            listarInsumos();
        }

        public void listarInsumos()
        {
            try
            {
                dgvInsumos.DataSource = logInsumos.Instancia.ListarInsumos();
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
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entInsumos c = new entInsumos();
                c.idCategoriaInsumo = int.Parse(txtIdCategoria.Text.Trim());
                c.descripcion = txtDescripcion.Text.Trim();
                c.stock = decimal.Parse(txtStock.Text.Trim());
                c.unidadMedida = txtUnidadMedida.Text.Trim();

                logInsumos.Instancia.InsertaInsumos(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Asegúrese de ingresar números válidos en ID Categoría y Stock.\nError: " + ex.Message);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarInsumos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LimpiarVariables()
        {
            txtIdInsumo.Text = "";
            txtIdCategoria.Text = "";
            txtDescripcion.Text = "";
            txtStock.Text = "";
            txtUnidadMedida.Text = "";
            cbkEstado.Checked = false;
        }

        private void dgvInsumos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaActual = dgvInsumos.Rows[e.RowIndex];
                txtIdInsumo.Text = filaActual.Cells[0].Value.ToString();
                txtIdCategoria.Text = filaActual.Cells[1].Value.ToString();
                // Cells[2] es el nombre de la categoría (no lo guardamos en un input)
                txtDescripcion.Text = filaActual.Cells[3].Value.ToString();
                txtStock.Text = filaActual.Cells[4].Value.ToString();
                txtUnidadMedida.Text = filaActual.Cells[5].Value.ToString();
                cbkEstado.Checked = Convert.ToBoolean(filaActual.Cells[6].Value);
            }
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
                entInsumos c = new entInsumos();
                c.idInsumo = int.Parse(txtIdInsumo.Text.Trim());
                c.idCategoriaInsumo = int.Parse(txtIdCategoria.Text.Trim());
                c.descripcion = txtDescripcion.Text.Trim();
                c.stock = decimal.Parse(txtStock.Text.Trim());
                c.unidadMedida = txtUnidadMedida.Text.Trim();
                c.estado = cbkEstado.Checked;

                logInsumos.Instancia.EditaInsumos(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarInsumos();
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
                entInsumos c = new entInsumos();
                c.idInsumo = int.Parse(txtIdInsumo.Text.Trim());
                cbkEstado.Checked = false;

                logInsumos.Instancia.DeshabilitarInsumos(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarInsumos();
        }

        private void btnCategoria_Insumos_Click(object sender, EventArgs e)
        {
            CategoriaInsumos ventana = new CategoriaInsumos();


            ventana.Show();
        }
    }
}