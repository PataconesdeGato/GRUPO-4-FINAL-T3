using System;
using System.Windows.Forms;
using CAPA_ENTDIDAD_;
using CAPA_LOGICA_;

namespace Estampida_Proyecto_____Final___Grupo4
{
    public partial class Insumos1 : Form
    {
        public Insumos1()
        {
            InitializeComponent();
            btnAgregarInsumos.Enabled = false;
            txtIdInsumo.Enabled = false;
        }

        private void Insumos_Shown(object sender, EventArgs e)
        {
            listarInsumos();
            llenarComboBoxCategorias(); // Llenamos la lista desplegable al abrir
        }

        private void llenarComboBoxCategorias()
        {
            try
            {
                cboCategoria.DataSource = log_Categori_Insumos.Instancia.ListarCategoriaInsumos();
                cboCategoria.DisplayMember = "descripcion"; // Lo que el usuario lee
                cboCategoria.ValueMember = "idCategoriaInsumo"; // El ID oculto que va a la BD
                cboCategoria.SelectedIndex = -1; // Lo dejamos en blanco al principio
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aviso: No se pudieron cargar las categorías.\n" + ex.Message);
            }
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
            btnAgregarInsumos.Enabled = true;
            btnAgregar.Visible = true;
            btnModificar.Visible = false;
            LimpiarVariables();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboCategoria.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, seleccione una Categoría de Insumo de la lista.");
                    return;
                }

                entInsumos c = new entInsumos();
                c.idCategoriaInsumo = Convert.ToInt32(cboCategoria.SelectedValue);
                c.descripcion = txtDescripcion.Text.Trim();
                c.stock = decimal.Parse(txtStock.Text.Trim());
                c.unidadMedida = txtUnidadMedida.Text.Trim();

                logInsumos.Instancia.InsertaInsumos(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Asegúrese de ingresar números válidos en el Stock.\nError: " + ex.Message);
            }
            LimpiarVariables();
            btnAgregarInsumos.Enabled = false;
            listarInsumos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LimpiarVariables()
        {
            txtIdInsumo.Text = "";
            cboCategoria.SelectedIndex = -1;
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

                // Asignamos el ID a la lista para que se auto-seleccione el nombre correcto
                cboCategoria.SelectedValue = Convert.ToInt32(filaActual.Cells[1].Value);

                // Cells[2] es el nombre de la categoría en texto, no lo ponemos en ningún input
                txtDescripcion.Text = filaActual.Cells[3].Value.ToString();
                txtStock.Text = filaActual.Cells[4].Value.ToString();
                txtUnidadMedida.Text = filaActual.Cells[5].Value.ToString();
                cbkEstado.Checked = Convert.ToBoolean(filaActual.Cells[6].Value);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnAgregarInsumos.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboCategoria.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, seleccione una Categoría de Insumo de la lista.");
                    return;
                }

                entInsumos c = new entInsumos();
                c.idInsumo = int.Parse(txtIdInsumo.Text.Trim());
                c.idCategoriaInsumo = Convert.ToInt32(cboCategoria.SelectedValue);
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
            btnAgregarInsumos.Enabled = false;
            listarInsumos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnAgregarInsumos.Enabled = false;
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
            btnAgregarInsumos.Enabled = false;
            listarInsumos();
        }

        private void btn_agregar_Categoria_Click(object sender, EventArgs e)
        {
            CategoriaInsumos1 ventana = new CategoriaInsumos1();
            ventana.Show();
        }
    }
}