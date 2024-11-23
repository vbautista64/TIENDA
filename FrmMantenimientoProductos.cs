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
    public partial class FrmMantenimientoProductos : Form
    {
        dataProducto datos = new dataProducto();
        List<Entidades.Producto> listaproductos = new List<Entidades.Producto>();

        public FrmMantenimientoProductos()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {

                listaproductos = datos.lista_Producto();
                dgdatos.AutoGenerateColumns = false;
                dgdatos.DataSource = listaproductos;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FrmNuevoProducto frm = new FrmNuevoProducto();
                frm.ShowDialog();
                CargarDatos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgdatos.RowCount == 0) { return; }
                int index = dgdatos.CurrentCell.RowIndex;
                Int32 codigo = Convert.ToInt32(dgdatos.Rows[index].Cells[0].Value.ToString());

                FrmActualizarProducto frm = new FrmActualizarProducto(codigo);
                frm.ShowDialog();


                CargarDatos();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgdatos.RowCount == 0) { return; }
                int index = dgdatos.CurrentCell.RowIndex;
                Int32 codigo = Convert.ToInt32(dgdatos.Rows[index].Cells[0].Value.ToString());

                if (MessageBox.Show("¿Está seguro de eliminar el código " + codigo + "?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    datos.Elimina_Producto(codigo);
                    CargarDatos();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtbuscar.Text == string.Empty)
            {
                listaproductos = datos.lista_Producto();
            }
            else
            {
                listaproductos = datos.BuscarProducto(txtbuscar.Text);                
            }
            dgdatos.AutoGenerateColumns = false;
            dgdatos.DataSource = listaproductos;
        }
    }
}
