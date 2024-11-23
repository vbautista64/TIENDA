using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIENDA.Entidades;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TIENDA.Datos
{
    public class dataProducto
    {
        public List<Entidades.Producto> lista_Producto()
        {
            string m_ssql = "ObtenerProductos";

            using (SqlConnection cn = new Conexion().ConexionTienda())
            {
                SqlCommand cmd = new SqlCommand(m_ssql, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                List<Entidades.Producto> lprod = new List<Entidades.Producto>();

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Entidades.Producto producto = new Entidades.Producto()
                    {
                        IdProducto= Convert.ToInt32(dr["IdProducto"]),
                        Nombre= dr["Nombre"].ToString(),
                        Precio= Convert.ToDecimal(dr["Precio"]),
                        stock= Convert.ToInt32(dr["stock"]),
                        FechaCreacion= Convert.ToDateTime(dr["FechaCreacion"])
                    };

                    lprod.Add(producto);

                }

                cn.Close();

                return lprod;
            }
        }

        public List<Entidades.Producto> BuscarProducto(string buscar)
        {
            string m_ssql = "BuscarProductos";

            using (SqlConnection cn = new Conexion().ConexionTienda())
            {
                SqlCommand cmd = new SqlCommand(m_ssql, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", buscar);
                List<Entidades.Producto> lprod = new List<Entidades.Producto>();

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Entidades.Producto producto = new Entidades.Producto()
                    {
                        IdProducto = Convert.ToInt32(dr["IdProducto"]),
                        Nombre = dr["Nombre"].ToString(),
                        Precio = Convert.ToDecimal(dr["Precio"]),
                        stock = Convert.ToInt32(dr["stock"]),
                        FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"])
                    };

                    lprod.Add(producto);

                }

                cn.Close();

                return lprod;
            }
        }

        public Entidades.Producto lista_Producto(Int32 id)
        {
            string m_ssql = "ObtenerProductoDetalle";

            using (SqlConnection cn = new Conexion().ConexionTienda())
            {
                SqlCommand cmd = new SqlCommand(m_ssql, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                Entidades.Producto prod = new Entidades.Producto();

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    prod = new Entidades.Producto()
                    {
                        IdProducto = Convert.ToInt32(dr["IdProducto"]),
                        Nombre = dr["Nombre"].ToString(),
                        Precio = Convert.ToDecimal(dr["Precio"]),
                        stock = Convert.ToInt32(dr["stock"]),
                        FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"])
                    };
                }

                cn.Close();
                
                return prod;
            }
        }

        public void Insertar_Producto(Entidades.Producto producto)
        {
            using (SqlConnection cn = new Conexion().ConexionTienda())
            {
                string m_ssql = "InsertarProducto";
                

                SqlCommand cmd = new SqlCommand(m_ssql, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                cmd.Parameters.AddWithValue("@Stock", producto.stock);                


                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

            }
        }

        public void Actualizar_Producto(Entidades.Producto producto)
        {
            using (SqlConnection cn = new Conexion().ConexionTienda())
            {
                string m_ssql = "ActualizarProducto  ";

                SqlCommand cmd = new SqlCommand(m_ssql, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", producto.IdProducto);
                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                cmd.Parameters.AddWithValue("@Stock", producto.stock);


                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

            }
        }

        public void Elimina_Producto(Int32 idProducto)
        {
            using (SqlConnection cn = new Conexion().ConexionTienda())
            {
                string m_ssql = "EliminarProducto  ";

                SqlCommand cmd = new SqlCommand(m_ssql, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", idProducto);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

            }
        }
    }
}
