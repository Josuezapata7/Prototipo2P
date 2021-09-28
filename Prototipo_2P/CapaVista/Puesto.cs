using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class Puesto : Form
    {
        Controlador control = new Controlador();

        public Puesto()
        {
            InitializeComponent();

            pnlBorde.Visible = false;
            pnlBodeM.Visible = false;
            pnlBordeE.Visible = false;

            pnlIngresar.Visible = false;
            pnlModificar.Visible = false;
            pnlDB.Visible = false;

            llenaTabla();

        }

        private void Puesto_Load(object sender, EventArgs e)
        {

        }

        public void llenaTabla()
        {
            DataTable dt = control.llenarTbl("puesto");
            dvgPuesto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgPuesto.DataSource = dt;
        }

        private void pnlCerrar_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }

        private void lblIngresarP_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBorde.Visible = true;
            pnlBodeM.Visible = false;
            pnlBordeE.Visible = false;

            pnlIngresar.Visible = true;
            pnlModificar.Visible = false;
            pnlDB.Visible = false;

            txtEP.Text = "";
            txtIDP.Text = "";
            txtNP.Text = "";
        }

        private void lblModificar_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBorde.Visible = false;
            pnlBodeM.Visible = true;
            pnlBordeE.Visible = false;

            pnlIngresar.Visible = false;
            pnlModificar.Visible = true;
            pnlDB.Visible = false;

            txtEP.Text = "";
            txtIDP.Text = "";
            txtNP.Text = "";
        }

        private void lblDB_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBorde.Visible = false;
            pnlBodeM.Visible = false;
            pnlBordeE.Visible = true;

            pnlIngresar.Visible = false;
            pnlModificar.Visible = false;
            pnlDB.Visible = true;
        }

        private void pnlIngresar_MouseClick(object sender, MouseEventArgs e)
        {
            string id = txtIDP.Text;
            string nombre = txtNP.Text;
            string estatus = txtEP.Text;

            control.funInsertar(id, nombre, estatus);
            llenaTabla();
        }

        private void dvgPuesto_SelectionChanged(object sender, EventArgs e)
        {
            control.funSeleccionarDT(dvgPuesto, txtIDP, txtNP, txtEP);
        }

        private void pnlDB_MouseClick(object sender, MouseEventArgs e)
        {
            string id = txtIDP.Text;
            control.funDarBajaPuesto(id);
            llenaTabla();
        }

        private void pnlModificar_MouseClick(object sender, MouseEventArgs e)
        {
            string id = txtIDP.Text;
            string nombre = txtNP.Text;
            string estatus = txtEP.Text;

            control.funModificar(id, nombre,estatus);
            llenaTabla();
        }
    }
}
