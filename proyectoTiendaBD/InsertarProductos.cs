using Controller;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoTiendaBD
{
    public partial class InsertarProductos : Form
    {
        Controller_Insertar ci;
        Controller_Modificar cm;
        public InsertarProductos()
        {
            InitializeComponent();
            ci = new Controller_Insertar();
            cm = new Controller_Modificar();
            if (ModificarProductos.idProducto > 0)
            {
                txtProducto.Text = ModificarProductos.producto;
                txtDescripcion.Text = ModificarProductos.descripcion;
                txtPrecio.Text = ModificarProductos.precio.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ModificarProductos.idProducto > 0)
            {
                cm.Modificar(ModificarProductos.idProducto, txtProducto, txtDescripcion, txtPrecio);
            }
            else
            {
                ci.Insertar(txtProducto, txtDescripcion, txtPrecio);
            }
            Close();
        }
    }
}
