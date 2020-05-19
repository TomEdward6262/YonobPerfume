﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;
using Model.EF;
using YonobPerfume.Common;

namespace YonobPerfume.Areas.Admin.Controllers
{
    public class UserController : BaseController
    {
        // GET: Admin/User
        public ActionResult Index(string searchString, int page = 1, int pageSize = 10)
        {
            var dao = new UserDao();
            var model = dao.ListAllPaging(searchString, page,pageSize);
            ViewBag.SearchString = searchString;
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        public  ActionResult Edit(int id)
        {
            var user = new UserDao().ViewDetail(id);
            return View(user);
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var enCryptedMd5Pass = Encryptor.MD5Hash(user.Password);
                user.Password = enCryptedMd5Pass;
                long id = dao.Insert(user);
                if (id > 0)
                {
                    SetAlert("Thêm thành công người dùng", "success");
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm người dùng KHÔNG thành công !!!");
                }
            }
            return View("Index");
        }

        [HttpPost]
        public ActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();

                if (!string.IsNullOrEmpty(user.Password))
                {
                    var enCryptedMd5Pass = Encryptor.MD5Hash(user.Password);
                    user.Password = enCryptedMd5Pass;
                }

                var result = dao.Update(user);
                if (result)
                {
                    SetAlert("Sửa thành công người dùng", "success");
                    return RedirectToAction("Index", "User");

                }
                else
                {
                    ModelState.AddModelError("", "Cập nhật người dùng KHÔNG thành công !!!");
                }
            }
            return View("Index");
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            new UserDao().Delete(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public JsonResult ChangeStatus(long id)
        {
            var result = new UserDao().ChangeStatus(id);
            return Json(new
            {
                status = result
            });
        }
    }
}