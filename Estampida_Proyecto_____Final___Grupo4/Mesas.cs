using CAPA_ENTDIDAD_;
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
    public partial class Mesas : Form
    {
        private const int AnchoBloque = 120;
        private const int AltoBloque = 90;

        private readonly Color VerdeNormal = Color.FromArgb(46, 160, 67);
        private readonly Color VerdeSeleccion = Color.FromArgb(22, 101, 52);

        private Panel bloqueSeleccionado;

        public Mesas()
        {
            InitializeComponent();
        }

        private void FrmMesa_Load(object sender, EventArgs e)
        {
            CargarBloques();
        }

        #region Bloques de mesas
        // Dibuja un bloque verde por cada mesa activa (ordenadas por número).
        private void CargarBloques()
        {
            try
            {
                List<entMesas> lista = logMesas.Instancia.ListarMesa()
                                             .OrderBy(m => m.Numero)
                                             .ToList();

                bloqueSeleccionado = null;

                flpMesas.SuspendLayout();

                foreach (Control c in flpMesas.Controls.Cast<Control>().ToList())
                {
                    flpMesas.Controls.Remove(c);
                    c.Dispose();
                }

                foreach (entMesas mes in lista)
                    flpMesas.Controls.Add(CrearBloque(mes));

                flpMesas.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Panel CrearBloque(entMesas mes)
        {
            Panel bloque = new Panel
            {
                Tag = mes,
                BackColor = VerdeNormal,
                Margin = new Padding(8),
                Cursor = Cursors.Hand,
                Size = new Size(AnchoBloque, AltoBloque)
            };

            string texto = "Mesa " + mes.Numero + "\nCap: " + mes.Capacidad;
            if (!string.IsNullOrWhiteSpace(mes.Ubicacion))
                texto += "\n" + mes.Ubicacion;

            Label lbl = new Label
            {
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Cursor = Cursors.Hand,
                Text = texto
            };

            bloque.Controls.Add(lbl);
            bloque.Click += Bloque_Click;
            lbl.Click += (s, e) => Bloque_Click(bloque, e);

            return bloque;
        }

        private void Bloque_Click(object sender, EventArgs e)
        {
            Panel bloque = sender as Panel;
            if (bloque == null) return;

            if (bloqueSeleccionado != null)
                bloqueSeleccionado.BackColor = VerdeNormal;

            bloqueSeleccionado = bloque;
            bloque.BackColor = VerdeSeleccion;

            entMesas mes = (entMesas)bloque.Tag;
            txtId.Text = mes.IdMesa.ToString();
            txtNumero.Text = mes.Numero.ToString();
            txtCapacidad.Text = mes.Capacidad.ToString();
            txtUbicacion.Text = mes.Ubicacion;
        }
        #endregion

        #region Métodos auxiliares
        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNumero.Clear();
            txtCapacidad.Clear();
            txtUbicacion.Clear();

            if (bloqueSeleccionado != null)
            {
                bloqueSeleccionado.BackColor = VerdeNormal;
                bloqueSeleccionado = null;
            }

            txtNumero.Focus();
        }

        // Valida los campos y devuelve la entidad lista para enviar a la capa lógica
        private entMesas ObtenerMesaDelFormulario()
        {
            int numero;
            if (!int.TryParse(txtNumero.Text.Trim(), out numero) || numero <= 0)
            {
                MessageBox.Show("Ingrese un número de mesa válido (entero mayor a 0).", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumero.Focus();
                return null;
            }

            int capacidad;
            if (!int.TryParse(txtCapacidad.Text.Trim(), out capacidad) || capacidad <= 0)
            {
                MessageBox.Show("Ingrese una capacidad válida (entero mayor a 0).", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCapacidad.Focus();
                return null;
            }

            entMesas mes = new entMesas
            {
                Numero = numero,
                Capacidad = capacidad,
                Ubicacion = txtUbicacion.Text.Trim(),
                Estado = true
            };

            if (!string.IsNullOrWhiteSpace(txtId.Text))
                mes.IdMesa = Convert.ToInt32(txtId.Text);

            return mes;
        }
        #endregion

        #region Eventos de botones
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entMesas mes = ObtenerMesaDelFormulario();
                if (mes == null) return;

                logMesas.Instancia.InsertaMesa(mes);
                LimpiarCampos();
                CargarBloques();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Seleccione una mesa para editar.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                entMesas mes = ObtenerMesaDelFormulario();
                if (mes == null) return;

                logMesas.Instancia.EditaMesa(mes);
                LimpiarCampos();
                CargarBloques();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Seleccione una mesa para deshabilitar.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult r = MessageBox.Show("¿Seguro que desea deshabilitar esta mesa?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r != DialogResult.Yes) return;

                entMesas mes = new entMesas { IdMesa = Convert.ToInt32(txtId.Text) };
                logMesas.Instancia.DeshabilitarMesa(mes);

                LimpiarCampos();
                CargarBloques();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deshabilitar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        #endregion
    }
}
