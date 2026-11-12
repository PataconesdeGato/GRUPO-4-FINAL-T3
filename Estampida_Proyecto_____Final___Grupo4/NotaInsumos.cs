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
    public partial class NotaInsumos : Form
    {
        public NotaInsumos()
        {
            InitializeComponent();
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            Menu_Principal Menu_Principal = new Menu_Principal();
            Menu_Principal.Show();
            Close();
        }
    }
}
