using Controller;
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
    public partial class ModificarProductos : Form
    {
        Controller_Modificar cm;
        Controller_Eliminar ce;
        int fila, columna;
        public static int idProducto;
        public static string producto, descripcion;
        public static double precio;

        private void txtBModificar_TextChanged(object sender, EventArgs e)
        {
            dtgvModProductos.Visible = true;
            cm.MostrarProducto(dtgvModProductos, txtBModificar.Text);
            ce.EliminarProducto(dtgvModProductos, txtBModificar.Text);
        }

        public ModificarProductos()
        {
            InitializeComponent();
            cm = new Controller_Modificar();
            ce = new Controller_Eliminar();
        }

        private void dtgvModProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
            switch (columna)
            {
                case 4:
                    {
                        idProducto = int.Parse(dtgvModProductos.Rows[fila].Cells[0].Value.ToString());
                        producto = dtgvModProductos.Rows[fila].Cells[1].Value.ToString();
                        descripcion = dtgvModProductos.Rows[fila].Cells[2].Value.ToString();
                        precio = double.Parse(dtgvModProductos.Rows[fila].Cells[3].Value.ToString());
                        InsertarProductos ip = new InsertarProductos();
                        ip.ShowDialog();
                        dtgvModProductos.Visible = false;
                    }
                    break;
                case 5:
                    {
                        idProducto = int.Parse(dtgvModProductos.Rows[fila].Cells[0].Value.ToString());
                        ce.Eliminar(idProducto, dtgvModProductos.Rows[fila].Cells[1].Value.ToString());
                        dtgvModProductos.Visible = false;
                    }
                    break;
            }
        }
    }
}
