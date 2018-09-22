using ABDDatos;
using CapaModeloEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModeloNegocio
{
    public class clsnegousuario
    {
        public  DataTable nego_login(string nomb_usuario, string pass_usuario)
        {
            clsentusuario objentusuario = new clsentusuario();
            objentusuario.NomUsuario = nomb_usuario;
            objentusuario.PassUsuario = pass_usuario;
            return new clsdatousuario().dato_login(objentusuario);
        }
        public List<clsentempleado> nego_listar_empleado()
        {
            clsdatousuario objusuario = new clsdatousuario();
            return objusuario.listar_empleado();
        }
    }
}
