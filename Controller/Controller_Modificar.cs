using DataAccess;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    public class Controller_Modificar
    {
        Functions f = new Functions();
        public void Modificar(int idProducto, TextBox Producto, TextBox Descripcion, TextBox Precio)
        {
            MessageBox.Show(f.Modificar($"CALL p_ModiificarProducto({idProducto}, '{Producto.Text}', '{Descripcion.Text}', {Precio.Text})"),
                "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        DataGridViewButtonColumn Boton(string texto, Color fondo)
        {
            DataGridViewButtonColumn b = new DataGridViewButtonColumn();
            b.Text = texto;
            b.UseColumnTextForButtonValue = true;
            b.FlatStyle = FlatStyle.Popup;
            b.DefaultCellStyle.BackColor = fondo;
            b.DefaultCellStyle.ForeColor = Color.White;
            return b;
        }
        public void MostrarProducto(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.DataSource = f.Mostrar($"select * from Productos where nombre like '%{filtro}%'", "Productos").Tables[0];
            tabla.Columns.Add(Boton("Modificar", Color.Green));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }
    }
}
