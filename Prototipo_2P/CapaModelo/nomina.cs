using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaModelo
{
    public class nomina
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

        public void funInsertar(string idNo, string fechaI, string fechaF, string estatus)
        {
            String psql = "INSERT INTO nominaE(codigo_nomina,fecha_inicial_nomina,fecha_final_nomina,estatus_nomina)" +
             " VALUES('" + idNo + "' , '" + fechaI + "' , '" + fechaF + "', '" + estatus + "')";

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

        public void funSeleccionarDT(DataGridView data, TextBox id, DateTimePicker fechaI, DateTimePicker fechaF,TextBox estatus)
        {
            var filaSeleccionada = data.CurrentRow;
            if (filaSeleccionada != null)
            {
                id.Text = data.CurrentRow.Cells[0].Value.ToString();
                fechaI.Value = Convert.ToDateTime(data.CurrentRow.Cells[1].Value.ToString());
                fechaF.Value = Convert.ToDateTime(data.CurrentRow.Cells[2].Value.ToString());
                estatus.Text = data.CurrentRow.Cells[3].Value.ToString();

            }
        }

        public void funModificar(string idModificar, string fechaI, string fechaF, string estatus)
        {
            string pSqlModificar = "UPDATE nominaE SET fecha_inicial_nomina='" + fechaI + "', fecha_final_nomina='" + fechaF + "', estatus_nomina='" + estatus + "' WHERE codigo_nomina='" + idModificar + "'";

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

        public void funDarBajaN(string id)
        {
            String pSqlModificar = "UPDATE nominaE SET estatus_nomina='I' WHERE codigo_nomina='" + id + "'";

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
