using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BASEDEDATOSPC2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnAlmacenes_Click(object sender, EventArgs e)
        {
            ALMACENES form = new ALMACENES();
            form.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            PRODUCTOS form = new PRODUCTOS();
            form.ShowDialog();
        }

        private void btnUnidad_Click(object sender, EventArgs e)
        {
            UNIDAD form = new UNIDAD();
            form.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            CLIENTES form = new CLIENTES();
            form.ShowDialog();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            PROVEEDORES form = new PROVEEDORES();
            form.ShowDialog();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            COMPRAS form = new COMPRAS();
            form.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            VENTAS2 form = new VENTAS2();
            form.ShowDialog();
        }
    }
}
