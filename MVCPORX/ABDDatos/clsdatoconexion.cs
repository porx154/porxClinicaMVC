using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ApplicationBlocks.Data;
using System.Data;
using System.Configuration;
namespace ABDDatos
{
    public class clsdatoconexion
    {
        public static string conexion = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

        public static string dato_conexion()
        {
            return conexion;
        }
    }
}
