using Patron_Repository.BLL;
using Patron_Repository.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patron_Repository.UI.Consultas
{
    public partial class ConsultaEmpleado : Form
    {
        public ConsultaEmpleado()
        {
            InitializeComponent();
        }

        private void EstBuscarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Empleado> Repository = new RepositorioBase<Empleado>(); ;

            var Listado = new List<Empleado>();
            
            Expression<Func<Empleado, bool>> filtro = a => true;
            int id;

            if (EstCriteriotextBox.Text.Trim().Length > 0)
            {
                switch (ESTfiltro.SelectedIndex)
                {
                    case 0:        // Todos
                        break;
                    case 1:        // Por ID

                        id = Convert.ToInt32(EstCriteriotextBox.Text);
                        filtro = a => a.EmpleadoID == id;
                        break;
                    case 2:        // Por Nombre

                        filtro = a => a.Nombres.Contains(EstCriteriotextBox.Text);
                        break;


                    case 3:       // Por Cedula
                        filtro = a => a.Cedula.Contains(EstCriteriotextBox.Text);
                        break;


                }

                Listado = Listado.Where(c => c.Fecha.Date >= DesdeTimePicker1.Value.Date && c.Fecha.Date <= HastadataTimer.Value.Date).ToList();

            }
            else
            {
                Listado = Repository.GetList(a => true);
            }

            MydataGridView.DataSource = Listado;
            MydataGridView.DataSource = Repository.GetList(filtro);

        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {

        }

    }
    
}
