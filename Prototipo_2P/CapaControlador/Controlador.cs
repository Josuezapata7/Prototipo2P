using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModelo;

namespace CapaControlador
{
    public class Controlador
    {
        puesto p = new puesto();
        departamento d = new departamento();

        public DataTable llenarTbl(string tablaDB)
        {
            OdbcDataAdapter dt = p.llenarTbl(tablaDB);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public void funInsertar(string idPuesto, string NombrePuesto, string estatusPuesto)
        {
            p.funInsertar(idPuesto, NombrePuesto, estatusPuesto);
        }

        public void funSeleccionarDT(DataGridView data, TextBox id, TextBox nombre, TextBox estatus)
        {
            p.funSeleccionarDT(data, id, nombre, estatus);
        }

        public void funDarBajaPuesto(string id)
        {
            p.funDarBajaPuesto(id);
        }

        public void funModificar(string idModificar, string nombre,string estatus)
        {
            p.funModificar(idModificar,nombre,estatus);
        }

        /*------ Funciones Depto -------*/
        public DataTable llenarTblD(string tablaDB)
        {
            OdbcDataAdapter dt = p.llenarTbl(tablaDB);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public void funSeleccionarDTD(DataGridView data, TextBox id, TextBox nombre, TextBox estatus)
        {
            p.funSeleccionarDT(data, id, nombre, estatus);
        }

        public void funInsertarD(string idD, string NombreD, string estatusD)
        {
            d.funInsertar(idD, NombreD, estatusD);
        }

        public void funModificarD(string idModificar, string nombre, string estatus)
        {
            d.funModificar(idModificar, nombre, estatus);
        }

        public void funDarBajaDep(string id)
        {
            d.funDarBajaDep(id);
        }
    }
}
