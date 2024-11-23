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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TIENDA
{
    public partial class FrmActualizarProducto : Form
    {
        dataProducto datos = new dataProducto();
        Int32 _idproducto;
        public FrmActualizarProducto(Int32 id)
        {
            InitializeComponent();
            _idproducto= id;
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                Entidades.Producto prod = new Entidades.Producto();
                prod=datos.lista_Producto(_idproducto);

                txtIdProdcuto.Text = prod.IdProducto.ToString();
                txtnombre.Text = prod.Nombre;
                txtStock.Text=prod.stock.ToString();
                txtprecio.Text = prod.Precio.ToString();


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

                producto.IdProducto=Convert.ToInt32(txtIdProdcuto.Text);
                producto.Nombre = txtnombre.Text;
                producto.Precio = Convert.ToDecimal(txtprecio.Text);
                producto.stock = Convert.ToInt32(txtStock.Text);

                datos.Actualizar_Producto(producto);

                MessageBox.Show("Dato actualizado de forma exitosa.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
