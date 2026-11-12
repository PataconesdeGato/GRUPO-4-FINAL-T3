using CAPA_ENTDIDAD_;
using CAPA_LOGICA_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estampida_Proyecto_____Final___Grupo4
{
    public partial class MantenedorProducto : Form
    {
        public MantenedorProducto()
        {
            InitializeComponent();
            CargarCategorias();
            listarProducto();
            grupBoxDatos.Enabled = false;
            txtidProducto.Enabled = false;
            btnAgregar.Visible = false;
            btnModificar.Visible = false;
        }

        public void listarProducto()
        {
            dgvProductos.DataSource = logProductos.Instancia.ListarProducto(!chkMostrarInactivos.Checked);
            if (dgvProductos.Columns["idCategoriaProducto"] != null)
                dgvProductos.Columns["idCategoriaProducto"].Visible = false;
        }
        private void CargarCategorias()
        {
            cboCategoria.DataSource = logProductos.Instancia.ListarCategoriaProducto();
            cboCategoria.DisplayMember = "nombre";
            cboCategoria.ValueMember = "idCategoriaProducto";
        }

        private void chkMostrarInactivos_CheckedChanged(object sender, EventArgs e)
        {
            listarProducto();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = true;
            LimpiarVariables();
            cbkEstadoProducto.Checked = true;
            btnAgregar.Visible = true;
            btnModificar.Visible = false;
        }
        private entProductos LeerFormulario()
        {
            entProductos p = new entProductos();
            decimal precio;
            if (!decimal.TryParse(txtPrecio.Text.Trim(), out precio))
                throw new ApplicationException("El precio debe ser un número válido.");
            p.codigo = txtCodigo.Text.Trim();
            p.nombre = txtNombres.Text.Trim();
            p.precio = precio;
            p.idCategoriaProducto = cboCategoria.SelectedValue == null ? 0 : Convert.ToInt32(cboCategoria.SelectedValue);
            p.estado = cbkEstadoProducto.Checked;
            return p;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entProductos p = LeerFormulario();
                logProductos.Instancia.InsertaProducto(p);
                MessageBox.Show("Producto registrado.");
                LimpiarVariables();
                grupBoxDatos.Enabled = false;
                btnAgregar.Visible = false;
                listarProducto();
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                MessageBox.Show("Ya existe un producto con ese código.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.. " + ex.Message);
            }
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            entProductos p = (entProductos)dgvProductos.Rows[e.RowIndex].DataBoundItem;
            txtidProducto.Text = p.idProducto.ToString();
            txtCodigo.Text = p.codigo;
            txtNombres.Text = p.nombre;
            txtPrecio.Text = p.precio.ToString("0.00");
            cboCategoria.SelectedValue = p.idCategoriaProducto;
            cbkEstadoProducto.Checked = p.estado;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtidProducto.Text))
            {
                MessageBox.Show("Haga doble clic en un producto de la lista para editarlo.");
                return;
            }
            grupBoxDatos.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entProductos p = LeerFormulario();
                p.idProducto = int.Parse(txtidProducto.Text.Trim());
                logProductos.Instancia.EditaProducto(p);
                MessageBox.Show("Producto actualizado.");
                LimpiarVariables();
                grupBoxDatos.Enabled = false;
                btnModificar.Visible = false;
                listarProducto();
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                MessageBox.Show("Ya existe un producto con ese código.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.. " + ex.Message);
            }
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtidProducto.Text))
            {
                MessageBox.Show("Seleccione un producto (doble clic en la lista).");
                return;
            }
            if (MessageBox.Show("¿Deshabilitar este producto? Dejará de aparecer en la carta.",
                "Confirmar", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            try
            {
                entProductos p = new entProductos();
                p.idProducto = int.Parse(txtidProducto.Text.Trim());
                logProductos.Instancia.DeshabilitarProducto(p);
                cbkEstadoProducto.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.. " + ex.Message);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarProducto();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            btnAgregar.Visible = false;
            btnModificar.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu_Principal Menu_Principal = new Menu_Principal();
            Menu_Principal.Show();

            Close();
        }
        private void LimpiarVariables()
        {
            txtidProducto.Text = "";
            txtCodigo.Text = "";
            txtNombres.Text = "";
            txtPrecio.Text = "";
            if (cboCategoria.Items.Count > 0) cboCategoria.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MantenedorProductoCategoria mantenedorProductoCategoria = new MantenedorProductoCategoria();
            mantenedorProductoCategoria.Show();
            this.Hide();
        }
    }
}
