using challenger.Data;
using challenger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace challenger.Controllers
{

    public class ProductController : Controller
    {

        public bool RolUserBool { get; set; }
        UserAdmin adminUser = new UserAdmin();

        ProductAdmin admin = new ProductAdmin();


        // GET: Product
      
        public ActionResult Index()
        {

            IEnumerable<Product> lista = admin.GetData();
            return View(lista);
        }
        public ActionResult SaveData()
        {
            ViewBag.message = "";

            return View();

        }
        public ActionResult EditProduct(int id = 0)
        {

            Product modelo = admin.GetData(id);


            return View(modelo);

        }
        public ActionResult UpdateProduct(Product modelo)
        { admin.UpdateProduct(modelo);
        
            return View("EditProduct", modelo);

        }
    
        public ActionResult Delete(int id = 0)
        {

            Product modelo = new Product()
            {
                ProductID = id

            };

            admin.Delete(modelo);
            IEnumerable<Product> lista = admin.GetData();


            return View("Index", lista);

        }
        public ActionResult NewData(Product modelo)
        {
            admin.SaveData(modelo);
            ViewBag.message = "Saved Product";
            return View("SaveData", modelo);

        }

      
    }

  
}