using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaModelo
{
    public class puesto
    {

        Conexion conexion = new Conexion();
        public OdbcDataAdapter llenarTbl(string tabla)
        {
            
            string sql = "select * from " + " " + tabla;
            OdbcConnection conexionBD = conexion.conexion();
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conexionBD);
            conexion.desconexion(conexionBD);

            return dataTable;
        }

        public void funInsertar(string idPuesto, string NombrePuesto, string estatusPuesto)
        {
            String psql = "INSERT INTO puesto(codigo_puesto,nombre_puesto,estatus_puesto)" +
             " VALUES('" + idPuesto + "' , '" + NombrePuesto + "' , '" + estatusPuesto + "')";

            OdbcConnection conexionBD = conexion.conexion();

            try
            {
                OdbcCommand insertarCliente = new OdbcCommand(psql, conexionBD);
                insertarCliente.ExecuteNonQuery();
                MessageBox.Show("Datos Ingresados Correctamente");
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al guardar los datos " + ex.Message);
            }
            finally
            {
                conexion.desconexion(conexionBD);
            }
        }

        public void funSeleccionarDT(DataGridView data, TextBox id, TextBox nombre, TextBox estatus)
        {
            var filaSeleccionada = data.CurrentRow;
            if (filaSeleccionada != null)
            {
                id.Text = data.CurrentRow.Cells[0].Value.ToString();
                nombre.Text = data.CurrentRow.Cells[1].Value.ToString();
                estatus.Text = data.CurrentRow.Cells[2].Value.ToString();
            }
        }

        public void funDarBajaPuesto(string id)
        {
            String pSqlModificar = "UPDATE puesto SET estatus_puesto='I' WHERE codigo_puesto='" + id + "'";

            OdbcConnection conexionBD = conexion.conexion();

            try
            {
                OdbcCommand modificarPuesto = new OdbcCommand(pSqlModificar, conexionBD);
                modificarPuesto.ExecuteNonQuery();
                MessageBox.Show("Estatus modificado Correctamente");
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al modificar los datos " + ex.Message);
            }
            finally
            {
                conexion.desconexion(conexionBD);
            }
        }

        public void funModificar(string idModificar,string nombre,string estatus)
        {
            string pSqlModificar = "UPDATE puesto SET nombre_puesto='" + nombre + "', estatus_puesto='" +
            estatus + "' WHERE codigo_puesto='" + idModificar + "'";

            //Console.WriteLine(psql);
            OdbcConnection conexionBD = conexion.conexion();

            try
            {
                OdbcCommand modificarPuesto = new OdbcCommand(pSqlModificar, conexionBD);
                modificarPuesto.ExecuteNonQuery();
                MessageBox.Show("Datos Modificados Correctamente");
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al modificar los datos " + ex.Message);
            }
            finally
            {
                conexion.desconexion(conexionBD);
            }
        }

    }
}
