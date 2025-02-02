using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvParcial.Config;
using EvParcial.Models;
using EvParcial.Vistas;
using Microsoft.AspNetCore.Mvc;

namespace EvParcial.Controllers
{
    public class Controllers_Estudiantes
    {
        
        public List<Estudiantes_model> ObtenerTodos
        {
            get
            {
                var listaEstudiantes = new List<Estudiantes_model>();
                using (var conexion = cn.obtenerConexion())
                {
                    string cadena = "SELECT * FROM Estudiantes";
                    using (var comando = new SqlCommand(cadena, conexion))
                    {
                        conexion.Open();
                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                var estudiante = new Estudiantes_model
                                {
                                    Estudiante_Id = (int)lector["Estudiante_Id"],
                                    Nombre = lector["Nombre"].ToString(),
                                    Apellido = lector["Apellido"].ToString(),
                                    Carrera_Id = (int)lector["Carrera_Id"]
                                };
                                listaEstudiantes.Add(estudiante);
                            }
                        }
                    }
                }
                return listaEstudiantes;
            }
        }
        private readonly Conexion cn = new Conexion();

        public bool AgregarEstudiante(Estudiantes_model estudiante)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string query = "INSERT INTO Estudiantes (Nombre, Apellido, Carrera_Id) VALUES (@Nombre, @Apellido, @CarreraId)";
                using (var comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Nombre", estudiante.Nombre);
                    comando.Parameters.AddWithValue("@Apellido", estudiante.Apellido);
                    comando.Parameters.AddWithValue("@CarreraId", estudiante.Carrera_Id);

                    conexion.Open();
                    int filasAfectadas = comando.ExecuteNonQuery(); // Ejecuta la consulta
                    return filasAfectadas > 0; // Retorna true si se insertó correctamente
                }
            }
        }
    }

}