using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_ENTDIDAD_;
using CAPA_LOGICA_;

namespace Estampida_Proyecto_____Final___Grupo4
{
    public partial class frmMantenedorProveedor : Form
    {
        public frmMantenedorProveedor()
        {
            InitializeComponent();
            ListarProveedores();
            BloquearControles();
        }

        private void ListarProveedores()
        {
            try
            {
                dgvProveedores.DataSource = logProvedor.Instancia.ListarProveedor();
                FormatearGrilla();
                dgvProveedores.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar: " + ex.Message);
            }
        }

        // Solo cambia los títulos y anchos; no depende del orden de las columnas.
        private void FormatearGrilla()
        {
            var c = dgvProveedores.Columns;
            if (c.Contains("idProveedor")) { c["idProveedor"].HeaderText = "ID"; c["idProveedor"].FillWeight = 35; }
            if (c.Contains("ruc")) { c["ruc"].HeaderText = "RUC"; c["ruc"].FillWeight = 70; }
            if (c.Contains("razonSocial")) { c["razonSocial"].HeaderText = "Razón Social"; c["razonSocial"].FillWeight = 140; }
            if (c.Contains("telefono")) { c["telefono"].HeaderText = "Teléfono"; c["telefono"].FillWeight = 65; }
            if (c.Contains("correo")) { c["correo"].HeaderText = "Correo"; c["correo"].FillWeight = 100; }
            if (c.Contains("direccion")) { c["direccion"].HeaderText = "Dirección"; c["direccion"].FillWeight = 110; }
            if (c.Contains("estado")) { c["estado"].HeaderText = "Activo"; c["estado"].FillWeight = 40; }
        }

        private void BloquearControles()
        {
            txtRuc.Enabled = false; txtRazonSocial.Enabled = false; txtTelefono.Enabled = false;
            txtCorreo.Enabled = false; txtDireccion.Enabled = false; chkEstado.Enabled = false;
            btnAgregar.Visible = false; btnModificar.Visible = false; btnNuevo.Visible = true;
            btnCancelar.Visible = false;
        }

        private void HabilitarControles()
        {
            txtRuc.Enabled = true; txtRazonSocial.Enabled = true; txtTelefono.Enabled = true;
            txtCorreo.Enabled = true; txtDireccion.Enabled = true; chkEstado.Enabled = true;
            btnCancelar.Visible = true;
        }

        private void LimpiarVariables()
        {
            txtId.Text = ""; txtRuc.Text = ""; txtRazonSocial.Text = "";
            txtTelefono.Text = ""; txtCorreo.Text = ""; txtDireccion.Text = "";
            chkEstado.Checked = true;
        }

        // Mismas reglas que la base de datos (RUC de 11 dígitos, razón social obligatoria)
        private bool ValidarCampos()
        {
            string ruc = txtRuc.Text.Trim();

            if (ruc.Length != 11 || !ruc.All(char.IsDigit))
            {
                MessageBox.Show("El RUC debe tener exactamente 11 dígitos numéricos.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRuc.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtRazonSocial.Text))
            {
                MessageBox.Show("La Razón Social es obligatoria.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRazonSocial.Focus();
                return false;
            }
            if (!string.IsNullOrWhiteSpace(txtCorreo.Text) && !txtCorreo.Text.Contains("@"))
            {
                MessageBox.Show("El correo no tiene un formato válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return false;
            }
            return true;
        }

        private void txtRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo números en el RUC
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarControles();
            btnAgregar.Visible = true; btnNuevo.Visible = false;
            LimpiarVariables();
            txtRuc.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            BloquearControles();
            dgvProveedores.ClearSelection();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos()) return;

                entProveedor p = new entProveedor();
                p.ruc = txtRuc.Text.Trim();
                p.razonSocial = txtRazonSocial.Text.Trim();
                p.telefono = txtTelefono.Text.Trim();
                p.correo = txtCorreo.Text.Trim();
                p.direccion = txtDireccion.Text.Trim();
                p.estado = chkEstado.Checked;

                logProvedor.Instancia.InsertaProveedor(p);
                MessageBox.Show("Proveedor registrado correctamente.");

                LimpiarVariables();
                BloquearControles();
                ListarProveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar: " + ex.Message);
            }
        }

        private void dgvProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // doble clic en el encabezado

            // Seleccionar fila para editar (por nombre de columna, no por posición)
            DataGridViewRow fila = dgvProveedores.Rows[e.RowIndex];
            txtId.Text = Convert.ToString(fila.Cells["idProveedor"].Value);
            txtRuc.Text = Convert.ToString(fila.Cells["ruc"].Value);
            txtRazonSocial.Text = Convert.ToString(fila.Cells["razonSocial"].Value);
            txtTelefono.Text = Convert.ToString(fila.Cells["telefono"].Value);
            txtCorreo.Text = Convert.ToString(fila.Cells["correo"].Value);
            txtDireccion.Text = Convert.ToString(fila.Cells["direccion"].Value);
            chkEstado.Checked = Convert.ToBoolean(fila.Cells["estado"].Value);

            HabilitarControles();
            btnModificar.Visible = true; btnAgregar.Visible = false; btnNuevo.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text)) return;
                if (!ValidarCampos()) return;

                entProveedor p = new entProveedor();
                p.idProveedor = Convert.ToInt32(txtId.Text);
                p.ruc = txtRuc.Text.Trim();
                p.razonSocial = txtRazonSocial.Text.Trim();
                p.telefono = txtTelefono.Text.Trim();
                p.correo = txtCorreo.Text.Trim();
                p.direccion = txtDireccion.Text.Trim();
                p.estado = chkEstado.Checked;

                logProvedor.Instancia.EditaProveedor(p);
                MessageBox.Show("Proveedor actualizado.");

                LimpiarVariables();
                BloquearControles();
                ListarProveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar: " + ex.Message);
            }
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Seleccione un proveedor de la lista haciendo doble clic.");
                    return;
                }

                if (MessageBox.Show("¿Seguro de deshabilitar este proveedor?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    logProvedor.Instancia.DeshabilitarProveedor(Convert.ToInt32(txtId.Text));
                    MessageBox.Show("Proveedor deshabilitado.");
                    LimpiarVariables();
                    BloquearControles();
                    ListarProveedores();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deshabilitar: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}