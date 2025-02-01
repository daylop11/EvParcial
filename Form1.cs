using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EvParcial.Vistas;

namespace EvParcial
{
    public partial class Frm_MenuPrincipal : Form
    {
        public Frm_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Frm_MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            Frm_Pagos frmPagos = new Frm_Pagos(); 
            frmPagos.Show(); 
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            Frm_Estudiantes frmEstudiantes = new Frm_Estudiantes();
            frmEstudiantes.Show();
        }

        private void btnCarreras_Click(object sender, EventArgs e)
        {
            Frm_Carreras frmCarreras = new Frm_Carreras();
            frmCarreras.Show();
        }
    }
}
