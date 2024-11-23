using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TIENDA.Datos;

namespace TIENDA
{
    public partial class FrmNuevoProducto : Form
    {
        dataProducto datos = new dataProducto();
        public FrmNuevoProducto()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnombre.Text == string.Empty)
                {
                    MessageBox.Show("nombre del producto no puede estar en blanco.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtprecio.Text == string.Empty)
                {
                    MessageBox.Show("Precio no puede estar en blanco.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtStock.Text == string.Empty)
                {
                    MessageBox.Show("Stock del producto no puede estar en blanco.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Entidades.Producto producto = new Entidades.Producto();

                producto.Nombre = txtnombre.Text;
                producto.Precio = Convert.ToDecimal(txtprecio.Text);
                producto.stock = Convert.ToInt32(txtStock.Text);

                datos.Insertar_Producto(producto);

                MessageBox.Show("Dato almacenado de forma exitosa.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FrmNuevoProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
