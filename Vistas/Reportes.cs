﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvParcial.Vistas
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            this.sistemaDeControlTableAdapter1.Fill(sistemaDeControlDePagosDeUniversidadDataSet.SistemaDeControl);
            
            this.reportViewer1.RefreshReport();
            
        }
    }
}
