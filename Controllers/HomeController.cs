using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;
using Model.EF;

namespace YonobPerfume.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Slides = new SlideDao().ListAll();
            ViewBag.newProduct = new ProductDao().NewProduct(9);
            ViewBag.bestProduct = new ProductDao().HotProduct(6);
            ViewBag.feedback = new ProductDao().feedback(6);
            return View();
        }

        [ChildActionOnly]
        public ActionResult MainMenu()
        {
            var model = new menuDao().ListByGroupId(1);
            return PartialView(model);
        }

        [ChildActionOnly]
        public ActionResult Footer()
        {
            var model = new FooterDao().GetFooter();
            return PartialView(model);
        }
    }
}