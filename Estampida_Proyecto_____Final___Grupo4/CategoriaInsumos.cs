using System;
using System.Windows.Forms;
using CAPA_ENTDIDAD_;
using CAPA_LOGICA_;

namespace Estampida_Proyecto_____Final___Grupo4
{
    public partial class CategoriaInsumos : Form
    {
        public CategoriaInsumos()
        {
            InitializeComponent();
            grupBoxDatos.Enabled = false;
            txtIdCategoria.Enabled = false;
        }

        private void CategoriaInsumos_Shown(object sender, EventArgs e)
        {
            listarCategoriaInsumos();
        }

        public void listarCategoriaInsumos()
        {
            try
            {
                dgvCategoria.DataSource = log_Categori_Insumos.Instancia.ListarCategoriaInsumos();
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
                ent_Categori_Insumos c = new ent_Categori_Insumos();
                c.descripcion = txtDescripcion.Text.Trim();

                log_Categori_Insumos.Instancia.InsertaCategoriaInsumos(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarCategoriaInsumos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LimpiarVariables()
        {
            txtIdCategoria.Text = "";
            txtDescripcion.Text = "";
            cbkEstado.Checked = false;
        }

        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaActual = dgvCategoria.Rows[e.RowIndex];
                txtIdCategoria.Text = filaActual.Cells[0].Value.ToString();
                txtDescripcion.Text = filaActual.Cells[1].Value.ToString();
                cbkEstado.Checked = Convert.ToBoolean(filaActual.Cells[2].Value);
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
                ent_Categori_Insumos c = new ent_Categori_Insumos();
                c.idCategoriaInsumo = int.Parse(txtIdCategoria.Text.Trim());
                c.descripcion = txtDescripcion.Text.Trim();
                c.estado = cbkEstado.Checked;

                log_Categori_Insumos.Instancia.EditaCategoriaInsumos(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarCategoriaInsumos();
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
                ent_Categori_Insumos c = new ent_Categori_Insumos();
                c.idCategoriaInsumo = int.Parse(txtIdCategoria.Text.Trim());
                cbkEstado.Checked = false;

                log_Categori_Insumos.Instancia.DeshabilitarCategoriaInsumos(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarCategoriaInsumos();
        }
    }
}