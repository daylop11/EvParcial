using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvParcial.Config;
using EvParcial.Models;

namespace EvParcial.Controllers
{
    internal class Controller_Pago
    {
        public readonly Conexion cn = new Conexion();

        public List<Pagos_model> ObtenerPagosPorCarrera(int carreraId)
        {
            var listaPagos = new List<Pagos_model>();
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = "SELECT * FROM Pagos WHERE Estudiante_Id IN (SELECT Estudiante_Id FROM Estudiantes WHERE Carrera_Id = @Carrera_Id)";
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    comando.Parameters.AddWithValue("@Carrera_Id", carreraId);
                    conexion.Open();
                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            var pago = new Pagos_model
                            {
                                Pago_Id = (int)lector["Pago_Id"],
                                Estudiante_Id = (int)lector["Estudiante_Id"],
                                Monto = (decimal)lector["Monto"],
                                Fecha = (DateTime)lector["Fecha"]
                            };
                            listaPagos.Add(pago);
                        }
                    }
                }
            }
            return listaPagos;
        }
    }

}