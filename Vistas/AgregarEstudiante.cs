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
    public partial class Frm_AgregarEstudiante : Form
    {
        public Frm_AgregarEstudiante()
        {
            InitializeComponent();
        }

        private void AgregarEstudiante_Load(object sender, EventArgs e)
        {

        }
        //public object txtNombre;


        public void btnGuardar_Click(object sender, EventArgs e)
        {
        }

        private static bool Controllers_AgregarEstudiante(Estudiantes_model estudiante)
        {
            try
            {
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        private void AgregarEstudiante_Load_1(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            var estudiante = new Estudiantes_model()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
            };

            var controller = new Controllers_Estudiantes();


            bool resultado = Controllers_AgregarEstudiante(estudiante);
            if (resultado)
            {
                MessageBox.Show("Estudiante agregado exitosamente.");
            }
            else
            {
                MessageBox.Show("Hubo un error al agregar el estudiante.");
            }
        }
    }
}