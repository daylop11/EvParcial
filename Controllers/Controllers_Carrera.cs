using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvParcial.Config;
using EvParcial.Models;
using Microsoft.AspNetCore.Mvc;

namespace EvParcial.Controllers
{
    public class carreras_controller
    {
        private readonly Conexion cn = new Conexion();

        internal static Conexion Conexion => Conexion1;

        internal static Conexion Conexion1 => Conexion;

        public List<Carreras_model> ObtenerTodas()
        {
            var listaCarreras = new List<Carreras_model>();
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = "SELECT * FROM Carreras";
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();
                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            var carrera = new Carreras_model
                            {
                                Carrera_Id = (int)lector["Carrera_Id"],
                                Nombre = lector["Nombre"].ToString()
                            };
                            listaCarreras.Add(carrera);
                        }
                    }
                }
            }
            return listaCarreras;
        }
    }

    public class Carreras_model
    {
        public int Carrera_Id { get; internal set; }
        public string Nombre { get; internal set; }
    }
}
