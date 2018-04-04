using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace MyMaster.Controllers
{
    public class IndexController : Controller
    {

        private Models.AppContext db = new Models.AppContext();
        // GET: Index
        public ActionResult Index()
        {
            Database.SetInitializer(
                new DropCreateDatabaseAlways<Models.AppContext>());

            db.Database.Initialize(false);

            return View();
        }
    }
}