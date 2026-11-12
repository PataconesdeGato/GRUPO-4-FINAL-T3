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
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
            grupBoxDatos.Enabled = false;
            txtidEmpleado.Enabled = false;
        }

        private void Empleado_Shown(object sender, EventArgs e)
        {
            listarEmpleado();
        }

        public void listarEmpleado()
        {
            try
            {
                dgvEmpleado.DataSource = logEmpleado.Instancia.ListarEmpleado();
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
            LimpiarVariables();
            btnModificar.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entEmpleado c = new entEmpleado();
                c.dni = txtDni.Text.Trim();
                c.nombres = txtNombres.Text.Trim();
                c.cargo = txtCargo.Text.Trim();
                c.turno = txtTurno.Text.Trim();
                c.telefono = txtTelefono.Text.Trim();
                c.correo = txtCorreo.Text.Trim();

                logEmpleado.Instancia.InsertaEmpleado(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarEmpleado();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LimpiarVariables()
        {
            txtidEmpleado.Text = "";
            txtDni.Text = "";
            txtNombres.Text = "";
            txtCargo.Text = "";
            txtTurno.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
        }

        private void dgvEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaActual = dgvEmpleado.Rows[e.RowIndex];
                txtidEmpleado.Text = filaActual.Cells[0].Value.ToString();
                txtDni.Text = filaActual.Cells[1].Value.ToString();
                txtNombres.Text = filaActual.Cells[2].Value.ToString();
                txtCargo.Text = filaActual.Cells[3].Value.ToString();
                txtTurno.Text = filaActual.Cells[4].Value.ToString();
                txtTelefono.Text = filaActual.Cells[5].Value.ToString();
                txtCorreo.Text = filaActual.Cells[6].Value.ToString();
                cbkEstadoEmpleado.Checked = Convert.ToBoolean(filaActual.Cells[7].Value);
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
                entEmpleado c = new entEmpleado();
                c.idEmpleado = int.Parse(txtidEmpleado.Text.Trim());
                c.dni = txtDni.Text.Trim();
                c.nombres = txtNombres.Text.Trim();
                c.cargo = txtCargo.Text.Trim();
                c.turno = txtTurno.Text.Trim();
                c.telefono = txtTelefono.Text.Trim();
                c.correo = txtCorreo.Text.Trim();
                c.estado = cbkEstadoEmpleado.Checked;

                logEmpleado.Instancia.EditaEmpleado(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarEmpleado();
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
                entEmpleado c = new entEmpleado();
                c.idEmpleado = int.Parse(txtidEmpleado.Text.Trim());
                cbkEstadoEmpleado.Checked = false;

                logEmpleado.Instancia.DeshabilitarEmpleado(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarEmpleado();
        }
    }
}