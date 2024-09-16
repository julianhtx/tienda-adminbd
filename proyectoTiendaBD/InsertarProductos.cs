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
        public static string producto, descripcion;
        public static double precio;
        public InsertarProductos()
        {
            InitializeComponent();
            ci = new Controller_Insertar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ci.Insertar(txtProducto, txtDescripcion, txtPrecio);
            Close();
        }
    }
}
