using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Repository.Entidades
{
    public class Empleado
    {
        public int EmpleadoID { get; set; }
        public DateTime Fecha{ get; set; }
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Cedula { get; set; }
        public decimal Sueldo { get; set; }
        public decimal Incetivo { get; set; }

        public Empleado()
        {
            EmpleadoID = 0;
            Fecha = DateTime.Now;
            Nombres = string.Empty;
            Direccion = string.Empty;
            Telefono = string.Empty;
            Celular = string.Empty;
            Cedula = string.Empty;
            Sueldo = 0;
            Incetivo = 0;

        }
    }
}
