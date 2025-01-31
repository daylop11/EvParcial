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
    internal class Controllers_Semestre
        {
            public readonly Conexion cn = new Conexion();

            public List<Semestres_model> ObtenerTodos()
            {
                var listaSemestres = new List<Semestres_model>();
                using (var conexion = cn.obtenerConexion())
                {
                    string cadena = "SELECT * FROM Semestres";
                    using (var comando = new SqlCommand(cadena, conexion))
                    {
                        conexion.Open();
                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                var semestre = new Semestres_model
                                {
                                    Semestre_Id = (int)lector["Semestre_Id"],
                                    Nombre = lector["Nombre"].ToString()
                                };
                                listaSemestres.Add(semestre);
                            }
                        }
                    }
                }
                return listaSemestres;
            }
        }
    }
