using challenger.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace challenger.Controllers
{
    public class HomeController : Controller
    {

        UserAdmin admin = new UserAdmin();
      


        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult ValidUser(string name, string password)
        {
            try
            {
                var user = admin.GetData(name, password);
                if (user == null)
                {
                    return Json(new { success = false, message = "Usuario o contraseña incorrectos." });
                }

                return Json(new { success = true, user });
            }
            catch (Exception ex)
            {
                // Aquí puedes registrar el error para depuración si es necesario
                return Json(new { success = false, message = "Ocurrió un error al procesar la solicitud." });
            }
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
       
    }
}