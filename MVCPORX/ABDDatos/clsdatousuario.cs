using CapaModeloEntidad;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ABDDatos
{
    public class clsdatousuario
    {
        public DataTable dato_login(clsentusuario objusuario)
        {
            return SqlHelper.ExecuteDataTable(clsdatoconexion.dato_conexion(), "accesar_login", objusuario.NomUsuario, objusuario.PassUsuario);
        }
        public List<clsentempleado> listar_empleado()
        {
            List<clsentempleado> listaEmpleado = new List<clsentempleado>();
            SqlDataReader reader = SqlHelper.ExecuteReader(clsdatoconexion.dato_conexion(), "listar_empleado");
            
            try
            {
                while (reader.Read())
                {
                    clsentempleado objempleado = new clsentempleado();
                    objempleado.CodEmpleado = reader[0].ToString();
                    objempleado.NomEmpleado = reader[1].ToString();
                    objempleado.ApeEmpleado = reader[2].ToString();
                    objempleado.DirEmpleado = reader[3].ToString();
                    objempleado.CelEmpleado = reader[4].ToString();
                    objempleado.EmailEmpleado = reader[5].ToString();
                    objempleado.FecIngEmpleado = Convert.ToDateTime(reader[6].ToString());
                    objempleado.FecNacEmpleado = Convert.ToDateTime(reader[7].ToString());
                    objempleado.CargoEmpleado = reader[9].ToString();
                    listaEmpleado.Add(objempleado);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return listaEmpleado;
        }
    }
}
