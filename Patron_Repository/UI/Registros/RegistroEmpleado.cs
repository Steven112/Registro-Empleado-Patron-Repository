using Patron_Repository.BLL;
using Patron_Repository.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patron_Repository.UI.Registros
{
    public partial class RegistroEmpleado : Form
    {
        public RegistroEmpleado()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            EmpleadoIDnumericUpDown1.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            NombretextBox.Text = string.Empty;
            DirecciontextBox.Text = string.Empty;
            TelefonomaskedTextBox.Text = string.Empty;
            CelularmaskedTextBox.Text = string.Empty;
            CedulamaskedTextBox.Text = string.Empty;
            SueldotextBox.Text = string.Empty;
            IncentivotextBox.Text = string.Empty;
            MyerrorProvider.Clear();

        }
        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Empleado> Repository = new RepositorioBase<Empleado>();
            Empleado empleado = Repository.Buscar((int)EmpleadoIDnumericUpDown1.Value);
            return (empleado != null);
        }


        private Empleado LlenaClase()
        {
            Empleado empleado = new Empleado();
            empleado.EmpleadoID = Convert.ToInt32(EmpleadoIDnumericUpDown1.Value);
            empleado.Fecha = FechadateTimePicker.Value;
            empleado.Nombres = NombretextBox.Text;
            empleado.Direccion = DirecciontextBox.Text;
            empleado.Cedula = CedulamaskedTextBox.Text;
            empleado.Telefono = TelefonomaskedTextBox.Text;
            empleado.Celular = CelularmaskedTextBox.Text;
            empleado.Cedula = CedulamaskedTextBox.Text;
            empleado.Sueldo = Convert.ToInt32(SueldotextBox.Text);
            empleado.Incetivo = Convert.ToInt32(IncentivotextBox.Text);

            return empleado;
        }

        public void LlenaCampo(Empleado empleado)
        {
            EmpleadoIDnumericUpDown1.Value = empleado.EmpleadoID;
            FechadateTimePicker.Value = empleado.Fecha;
            NombretextBox.Text = empleado.Nombres;
            DirecciontextBox.Text = empleado.Direccion;
            TelefonomaskedTextBox.Text = empleado.Telefono;
            CelularmaskedTextBox.Text = empleado.Celular;
            CedulamaskedTextBox.Text = empleado.Cedula;
            SueldotextBox.Text = Convert.ToString(empleado.Sueldo);
            IncentivotextBox.Text = Convert.ToString(empleado.Incetivo);
            
        }
        private bool Validar()
        {
            bool paso = true;
            MyerrorProvider.Clear();

            if (NombretextBox.Text == string.Empty)
            {
                MyerrorProvider.SetError(NombretextBox, "El campo Nombre no puede estar vacio");
                NombretextBox.Focus();
                paso = false;
            }


            if (string.IsNullOrEmpty(CedulamaskedTextBox.Text.Replace("-", "")))
            {
                MyerrorProvider.SetError(CedulamaskedTextBox, "El campo Cedula no puede estar vacio");
                CedulamaskedTextBox.Focus();
                paso = false;
            }

            if (Convert.ToInt32(SueldotextBox.Text) < 0)
            {
                MyerrorProvider.SetError(SueldotextBox, "Campo llenado incorrectamente");
               SueldotextBox.Focus();
                paso = false;
            }

            if (Convert.ToInt32(IncentivotextBox.Text) < 0)
            {
                MyerrorProvider.SetError(IncentivotextBox, "Campo llenado incorrectamente");
                IncentivotextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MyerrorProvider.Clear();
            RepositorioBase<Empleado> Repository = new RepositorioBase<Empleado>();

            int id;
            id = Convert.ToInt32(EmpleadoIDnumericUpDown1.Value);

            Limpiar();

            if (Repository.Eliminar(id))
            {
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MyerrorProvider.SetError(EmpleadoIDnumericUpDown1, "No se puede eliminar una persona que no existe");
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Empleado> Repository = new RepositorioBase<Empleado>();
           Empleado empleado;
            bool paso = false;

            if (!Validar())
                return;

           empleado = LlenaClase();

            if (EmpleadoIDnumericUpDown1.Value == 0)
                paso = Repository.Guardar(empleado);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede Modificar a una persona que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = Repository.Modificar(empleado);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("No fue posible guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            RepositorioBase<Empleado> Repository = new RepositorioBase<Empleado>();
           Empleado empleado= new Empleado();
            id = Convert.ToInt32(EmpleadoIDnumericUpDown1.Value);

            Limpiar();
            empleado = Repository.Buscar(id);

            if (empleado != null)
            {
                LlenaCampo(empleado);
            }
            else
            {
                MessageBox.Show("Persona no Encontrada");
            }
        }
    }
}
