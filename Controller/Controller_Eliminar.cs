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
    public class Controller_Eliminar
    {
        Functions f = new Functions();
        public void Eliminar(int idProducto, string dato)
        {
            DialogResult rs = MessageBox.Show($"Estas seguro de eliminar {dato}?", "!ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                f.Borrar($"CALL p_EliminarProducto({idProducto})");
                MessageBox.Show("Registro eliminado", "!ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
        public void EliminarProducto(DataGridView tabla, string filtro)
        {
            tabla.Columns.Add(Boton("Eliminar", Color.Red));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }
    }
}
