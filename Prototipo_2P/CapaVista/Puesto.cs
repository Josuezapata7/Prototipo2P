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
    public partial class Puesto : Form
    {
        public Puesto()
        {
            InitializeComponent();
        }

        private void Puesto_Load(object sender, EventArgs e)
        {

        }

        private void pnlCerrar_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }
    }
}
