using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace Controller
{
    public class Controller_Insertar
    {
        Functions f;
        public Controller_Insertar() 
        {
            f = new Functions();
        }
        public void Insertar(TextBox producto, TextBox descripcion, TextBox precio)
        {
            MessageBox.Show(f.Guardar($"CALL p_InsertarProducto('{producto.Text}', '{descripcion.Text}', {precio.Text})"),
                "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
