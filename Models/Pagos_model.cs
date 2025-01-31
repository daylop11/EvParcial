using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvParcial.Models
{
    internal class Pagos_model
    {
        public int Identificacion { get; set; }
        public int IdEstudiante { get; set; }
        public int IdCarrera { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public int Pago_Id { get; internal set; }
        public int Estudiante_Id { get; internal set; }
    }
}
