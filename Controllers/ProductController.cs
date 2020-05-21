using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;

namespace YonobPerfume.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            var productDao = new ProductDao();
            ViewBag.getProduct = productDao.getProduct(9);
            return View();
        }

        [ChildActionOnly]
        public PartialViewResult ProductCategory()
        {
            var model = new ProductCategryDao().ListAll();
            var productDao = new ProductDao();
            ViewBag.newProduct = productDao.NewProduct(3);
            ViewBag.hotProduct = productDao.HotProduct(3);
            return PartialView(model);
        }


        public ActionResult Category(long id)
        {
            var category = new ProductCategryDao().ListAll();
            ViewBag.sameProduct = new ProductDao().sameProduct(9, id);
            return View(category);
        }

        public ActionResult Detail(long id)
        {
            var product = new ProductDao().ViewDetail(id);
            ViewBag.Category = new ProductCategryDao().ViewDetail(product.CategoryID.Value);
            return View(product);
        }
    }
}