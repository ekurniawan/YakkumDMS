using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DokumenWebApps.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DokumenWebApps.Controllers
{
    public class ClassificationController : Controller
    {
        private ApplicationDbContext _context;
        public ClassificationController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Classification
        public ActionResult Index()
        {
            var model = from c in _context.Classifications
                        orderby c.Keterangan descending
                        select c;

            return View(model);
        }

        // GET: Classification/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Classification/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Classification/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Classification/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Classification/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Classification/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Classification/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}