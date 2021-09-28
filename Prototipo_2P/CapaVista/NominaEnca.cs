using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class NominaEnca : Form
    {
        Controlador control = new Controlador();
        public NominaEnca()
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

        private void pnlCerrar_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }

        private void NominaEnca_Load(object sender, EventArgs e)
        {

        }

        public void llenaTabla()
        {
            DataTable dt = control.llenarTbl("nominaE");
            dvgNE.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgNE.DataSource = dt;
        }

        private void pnlIngresar_MouseClick(object sender, MouseEventArgs e)
        {
            string id = txtIDP.Text;
            string fechaI = dateI.Value.ToString("yyyy-MM-dd");
            string fechaF = dateF.Value.ToString("yyyy-MM-dd");
            string estatus = txtED.Text;

            control.funInsertarN(id, fechaI, fechaF,estatus);
            llenaTabla();
        }

        private void dvgNE_SelectionChanged(object sender, EventArgs e)
        {
            control.funSeleccionarDTN(dvgNE, txtIDP, dateI, dateF,txtED);
        }

        private void pnlModificar_MouseClick(object sender, MouseEventArgs e)
        {
            string id = txtIDP.Text;
            string fechaI = dateI.Value.ToString("yyyy-MM-dd");
            string fechaF = dateF.Value.ToString("yyyy-MM-dd");
            string estatus = txtED.Text;

            control.funModificarN(id, fechaI, fechaF,estatus);
            llenaTabla();
        }

        private void pnlDB_MouseClick(object sender, MouseEventArgs e)
        {
            string id = txtIDP.Text;
            control.funDarBajaN(id);
            llenaTabla();
        }

        private void lblIngresarP_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBorde.Visible = true;
            pnlBodeM.Visible = false;
            pnlBordeE.Visible = false;

            pnlIngresar.Visible = true;
            pnlModificar.Visible = false;
            pnlDB.Visible = false;

            txtIDP.Text = "";
            txtED.Text = "";
        }

        private void lblModificar_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBorde.Visible = false;
            pnlBodeM.Visible = true;
            pnlBordeE.Visible = false;

            pnlIngresar.Visible = false;
            pnlModificar.Visible = true;
            pnlDB.Visible = false;

            txtIDP.Text = "";
            txtED.Text = "";
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
    }
}
