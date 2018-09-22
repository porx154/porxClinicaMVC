using CapaModeloNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaModeloEntidad;
using System.Data;

namespace MVCPORX.Controllers
{
    public class LoginController : Controller
    {
        clsnegousuario objnegousuario = new clsnegousuario();
        // GET: Login
        public ActionResult Acceso()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Acceso(clsentusuario objentusuario)
        {
            DataTable dtlogin = new DataTable();
            
            try
            {
                dtlogin = objnegousuario.nego_login(objentusuario.NomUsuario, objentusuario.PassUsuario);
                if (!ModelState.IsValid) return View();
                if (dtlogin.Rows.Count > 0)
                {
                    return RedirectToAction("Index", "Inicio");
                }
                return View();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al iniciar session", ex);
                return View();
            }
           
            
        }
    }
}