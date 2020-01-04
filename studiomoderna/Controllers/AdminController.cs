
using studiomoderna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace studiomoderna.Controllers
{
    public class AdminController : Controller
    {


        StudioDB db = new StudioDB();
        // GET: Admin
        public ActionResult Index()
        {
            var sorgu = db.Kateqoris.ToList();
            return View(sorgu);
        }
    }
}