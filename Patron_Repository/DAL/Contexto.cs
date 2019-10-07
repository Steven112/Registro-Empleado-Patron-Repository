using Patron_Repository.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Repository.DAL
{
    public class Contexto: DbContext
    {
        public DbSet<Empleado> Estudiante { get; set; }
        

        public Contexto() : base("ConStr")
        {

        }
    }
}
