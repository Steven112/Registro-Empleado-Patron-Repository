using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patron_Repository.UI.Registros;

namespace Patron_Repository
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        

        private void RegistroEmpleadoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form registre = new RegistroEmpleado();
            registre.Show();
        }
    }
}
