using CapaModeloNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaModeloEntidad;
namespace MVCPORX.Controllers
{
    public class UsuarioController : Controller
    {
        clsnegousuario objusuario = new clsnegousuario();
        // GET: Usuario
        public ActionResult ConsultaUsuario()
        {
            List<clsentempleado> listaempleado = objusuario.nego_listar_empleado();
            return View(listaempleado);
        }
    }
}