using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EvParcial.Controllers;
using EvParcial.Models;

namespace EvParcial.Vistas
{
    public partial class AgregarEstudiante : Form
    {
        public AgregarEstudiante()
        {
            InitializeComponent();
        }

        private void AgregarEstudiante_Load(object sender, EventArgs e)
        {

        }
        public partial class FrmAgregarEstudiante : Form
        {
            public Controllers_Estudiantes controller = new Controllers_Estudiantes();
            public object txtNombre;

            public FrmAgregarEstudiante()
            {
            }

            public object Nombre { get; private set; }
            public object Apellido { get; private set; }
            public int Carrera_Id { get; private set; }
            public object txtApellido { get; private set; }
            public object txtCarreraId { get; private set; }

            public void btnGuardar_Click(object sender, EventArgs e)
            {
            }
            public void btnAggStudent_Click(object sender, EventArgs e)
            {
                var estudiante = new Estudiantes_model();
                {
                    Nombre = txtNombre.GetType().Name;
                }
                Apellido = txtApellido.GetType().Name;
            }
            bool resultado = Controllers_AgregarEstudiante("Estudiante");
             if {
            }
            
private static bool Controllers_AgregarEstudiante(object estudiante)
            {
                throw new NotImplementedException();
            }
            if (resultado.AgregarEstudiante)
            }

        private void AgregarEstudiante_Load_1(object sender, EventArgs e)
        {

        }
    }

    internal class resultado
        {
            internal class AgregarEstudiante
            {
            }
        }
    }
        }