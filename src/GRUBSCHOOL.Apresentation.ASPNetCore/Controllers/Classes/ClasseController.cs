﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GRUBSCHOOL.Apresentation.ASPNetCore.Controllers.Classes
{
    public class ClasseController : Controller
    {
        // GET: ClasseController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ClasseController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClasseController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClasseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClasseController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClasseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClasseController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClasseController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
