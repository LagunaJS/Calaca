using Calaca.Nucleo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calaca.Presentacion.Controllers
{
    public class HomeController : Controller
    {
        
            
        //
        // GET: /Home/

        public ActionResult Index()
        {
            IList<Usuario> users = Usuario.ObtenerTodos();
            ViewBag.Usuarios = users;
            return View();
        }   


        public ActionResult Registro()
        {
            return View();
        }

        public ActionResult Guardar(Usuario u)
        {
            u.Save();
            IList<Usuario> users = Usuario.ObtenerTodos();
            ViewBag.Usuarios = users;
            return View("Index");
        }

    }
}
