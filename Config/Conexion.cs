using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvParcial.Config
{
    internal class Conexion
    {
        private readonly string cadenaConexion =
           "Servidor=(local);base de datos ";

        public SqlConnection obtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
