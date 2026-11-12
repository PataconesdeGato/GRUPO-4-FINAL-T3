using System;
using System.Windows.Forms;
using CAPA_ENTDIDAD_;
using CAPA_LOGICA_;

namespace Estampida_Proyecto_____Final___Grupo4
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
            grupBoxDatos.Enabled = false;
            txtIdCliente.Enabled = false;
        }

        private void Cliente_Shown(object sender, EventArgs e)
        {
            listarCliente();
        }

        public void listarCliente()
        {
            try
            {
                dgvCliente.DataSource = logCliente.Instancia.ListarCliente();
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
                entCliente c = new entCliente();
                c.dni = txtDni.Text.Trim();
                c.nombres = txtNombres.Text.Trim();
                c.telefono = txtTelefono.Text.Trim();
                c.correo = txtCorreo.Text.Trim();

                logCliente.Instancia.InsertaCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Asegúrese de ingresar un DNI válido (que no se repita).\nError: " + ex.Message, "Aviso");
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarCliente();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LimpiarVariables()
        {
            txtIdCliente.Text = "";
            txtDni.Text = "";
            txtNombres.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            cbkEstado.Checked = false;
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaActual = dgvCliente.Rows[e.RowIndex];
                txtIdCliente.Text = filaActual.Cells[0].Value.ToString();
                txtDni.Text = filaActual.Cells[1].Value.ToString();
                txtNombres.Text = filaActual.Cells[2].Value.ToString();
                txtTelefono.Text = filaActual.Cells[3].Value.ToString();
                txtCorreo.Text = filaActual.Cells[4].Value.ToString();
                cbkEstado.Checked = Convert.ToBoolean(filaActual.Cells[5].Value);
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
                entCliente c = new entCliente();
                c.idCliente = int.Parse(txtIdCliente.Text.Trim());
                c.dni = txtDni.Text.Trim();
                c.nombres = txtNombres.Text.Trim();
                c.telefono = txtTelefono.Text.Trim();
                c.correo = txtCorreo.Text.Trim();
                c.estado = cbkEstado.Checked;

                logCliente.Instancia.EditaCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarCliente();
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
                entCliente c = new entCliente();
                c.idCliente = int.Parse(txtIdCliente.Text.Trim());
                cbkEstado.Checked = false;

                logCliente.Instancia.DeshabilitarCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarCliente();
        }
    }
}