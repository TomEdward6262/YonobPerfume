using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;
using Model.EF;

namespace YonobPerfume.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content
        public ActionResult Index()
        {
            var contentDao = new ContentDao();
            ViewBag.getContent = contentDao.getContent(9);
            ViewBag.newContent = contentDao.newContent(3);
            ViewBag.hotContent = contentDao.hotContent(3);
            return View();
        }

        public ActionResult Content_detail(int id)
        {
            var content = new ContentDao().ViewDetail(id);

            return View(content);
        }

    }
}