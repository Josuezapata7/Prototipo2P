using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaModelo
{
    public class departamento
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

        public void funInsertar(string idDep, string NombreDep, string estatusDep)
        {
            String psql = "INSERT INTO departamento(codigo_departamento,nombre_departamento,estatus_departamento)" +
             " VALUES('" + idDep + "' , '" + NombreDep + "' , '" + estatusDep + "')";

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

        public void funModificar(string idModificar, string nombre, string estatus)
        {
            string pSqlModificar = "UPDATE departamento SET nombre_departamento='" + nombre + "', estatus_departamento='" +
            estatus + "' WHERE codigo_departamento='" + idModificar + "'";

            //Console.WriteLine(psql);
            OdbcConnection conexionBD = conexion.conexion();

            try
            {
                OdbcCommand modificarDep = new OdbcCommand(pSqlModificar, conexionBD);
                modificarDep.ExecuteNonQuery();
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

        public void funDarBajaDep(string id)
        {
            String pSqlModificar = "UPDATE departamento SET estatus_departamento='I' WHERE codigo_departamento='" + id + "'";

            OdbcConnection conexionBD = conexion.conexion();

            try
            {
                OdbcCommand modificarDep = new OdbcCommand(pSqlModificar, conexionBD);
                modificarDep.ExecuteNonQuery();
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
    }
}
