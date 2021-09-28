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
    public partial class Departamento : Form
    {
        Controlador control = new Controlador();

        public Departamento()
        {
            InitializeComponent();

            pnlBordeD.Visible = false;
            pnlBodeD.Visible = false;
            pnlBordeE.Visible = false;

            pnlIngresar.Visible = false;
            pnlModificar.Visible = false;
            pnlDB.Visible = false;

            llenaTabla();
        }

        private void pnlCerrar_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }

        private void lblIngresar_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBordeD.Visible = true;
            pnlBodeD.Visible = false;
            pnlBordeE.Visible = false;

            pnlIngresar.Visible = true;
            pnlModificar.Visible = false;
            pnlDB.Visible = false;

            txtED.Text = "";
            txtIDD.Text = "";
            txtND.Text = "";
        }

        private void lblModificar_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBordeD.Visible = false;
            pnlBodeD.Visible = true;
            pnlBordeE.Visible = false;

            pnlIngresar.Visible = false;
            pnlModificar.Visible = true;
            pnlDB.Visible = false;

            txtED.Text = "";
            txtIDD.Text = "";
            txtND.Text = "";
        }

        private void lblDB_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBordeD.Visible = false;
            pnlBodeD.Visible = false;
            pnlBordeE.Visible = true;

            pnlIngresar.Visible = false;
            pnlModificar.Visible = false;
            pnlDB.Visible = true;
        }

        public void llenaTabla()
        {
            DataTable dt = control.llenarTbl("departamento");
            dvgDepartamento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgDepartamento.DataSource = dt;
        }

        private void dvgDepartamento_SelectionChanged(object sender, EventArgs e)
        {
            control.funSeleccionarDT(dvgDepartamento, txtIDD, txtND, txtED);
        }

        private void pnlIngresar_MouseClick(object sender, MouseEventArgs e)
        {
            string id = txtIDD.Text;
            string nombre = txtND.Text;
            string estatus = txtED.Text;

            control.funInsertarD(id, nombre, estatus);
            llenaTabla();
        }

        private void pnlModificar_MouseClick(object sender, MouseEventArgs e)
        {
            string id = txtIDD.Text;
            string nombre = txtND.Text;
            string estatus = txtED.Text;

            control.funModificarD(id, nombre, estatus);
            llenaTabla();
        }

        private void pnlDB_MouseClick(object sender, MouseEventArgs e)
        {
            string id = txtIDD.Text;
            control.funDarBajaDep(id);
            llenaTabla();
        }

        private void Departamento_Load(object sender, EventArgs e)
        {

        }
    }
}
