﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DokumenWebApps.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DokumenWebApps.Controllers
{
    public class KlasifikasiController : Controller
    {
        private IKlasifikasi _tblKlasifikasi;
        public KlasifikasiController(IKlasifikasi tblKlasifikasi)
        {
            _tblKlasifikasi = tblKlasifikasi;
        }

        // GET: Klasifikasi
        public ActionResult Index()
        {
            var models = _tblKlasifikasi.GetAll();
            return View(models);
        }

        // GET: Klasifikasi/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Klasifikasi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Klasifikasi/Create
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

        // GET: Klasifikasi/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Klasifikasi/Edit/5
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

        // GET: Klasifikasi/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Klasifikasi/Delete/5
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