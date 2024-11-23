using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TIENDA
{
    public class Conexion
    {
        public SqlConnection ConexionTienda()
        {
            return new SqlConnection("Data Source=localhost;Initial Catalog=TIENDA;User id=SOPORTE;Password=SOPORTE");
        }
    }
}
