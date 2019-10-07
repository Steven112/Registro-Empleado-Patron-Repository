using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patron_Repository.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patron_Repository.Entidades;


namespace Patron_Repository.BLL.Tests
{
    [TestClass()]
    public class RepositorioBaseTests
    {
       

        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Empleado> Repository = new RepositorioBase<Empleado>();
            bool paso;
            Empleado empleado = new Empleado();
            empleado.EmpleadoID = 0;
            empleado.Fecha = DateTime.Now;
            empleado.Nombres = "Starlyn";
            empleado.Direccion = "27 de Febrero";
            empleado.Telefono = "829-478-2659";
            empleado.Celular = "756-366-8964";
            empleado.Cedula = "789-9657254-8";
            empleado.Sueldo = 25000;
            empleado.Incetivo = 500;
            paso = Repository.Guardar(empleado);
            Assert.AreEqual(paso,true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Empleado> Repository = new RepositorioBase<Empleado>();
            bool paso=false;
            Empleado empleado = new Empleado();
            empleado.EmpleadoID = 1;
            empleado.Fecha = DateTime.Now;
            empleado.Nombres = "Starlyn";
            empleado.Direccion = "27 de Febrero";
            empleado.Telefono = "829-478-2659";
            empleado.Celular = "756-366-8964";
            empleado.Cedula = "789-9657254-8";
            empleado.Sueldo = 35000;
            empleado.Incetivo = 500;
            paso = Repository.Modificar(empleado);
            Assert.AreEqual(paso, true);
        }

       

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Empleado> Repository = new RepositorioBase<Empleado>();
            bool paso=false;
            Empleado empleado = new Empleado();
            empleado.EmpleadoID = 1;

            paso = Repository.Eliminar(empleado.EmpleadoID);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Empleado> Repository = new RepositorioBase<Empleado>();
            bool paso=false;
            Empleado empleado = new Empleado();
            empleado = Repository.Buscar(1);
            if (empleado != null)
                paso = true;
           
        }

        
    }
}