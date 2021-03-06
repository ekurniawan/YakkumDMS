﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DokumenWebApps.DAL;
using DokumenWebApps.Models;
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
            var models = _tblKlasifikasi.GetAllAktifStatus();
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
        public ActionResult Create(Klasifikasi klasifikasi)
        {
            try
            {
                _tblKlasifikasi.Create(klasifikasi);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ViewBag.Error = 
                    $"<span class='alert alert-danger'>Kesalahan {ex.Message}</span>";
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
        public ActionResult Delete(string id)
        {
            var model = _tblKlasifikasi.GetById(id);
            return View(model);
        }

        // POST: Klasifikasi/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(string id)
        {
            try
            {
                _tblKlasifikasi.UbahStatusAktif(id);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ViewBag.Error = "Error : " + ex.Message;
                return View();
            }
        }
    }
}