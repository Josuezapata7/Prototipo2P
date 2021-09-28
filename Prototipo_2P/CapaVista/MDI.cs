using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void puestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Puesto puesto = new Puesto();
            puesto.MdiParent = this;

            puesto.Show();

        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Departamento departamento = new Departamento();
            departamento.MdiParent = this;

            departamento.Show();
        }

        private void nominaEncabezadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NominaEnca nomina = new NominaEnca();
            nomina.MdiParent = this;

            nomina.Show();
        }
    }
}
