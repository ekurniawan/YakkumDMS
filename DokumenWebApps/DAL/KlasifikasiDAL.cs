﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DokumenWebApps.Data;
using DokumenWebApps.Models;

namespace DokumenWebApps.DAL
{
    public class KlasifikasiDAL : IKlasifikasi
    {
        private ApplicationDbContext _db;
        public KlasifikasiDAL(ApplicationDbContext db)
        {
            _db = db;
        }

        public void Create(Klasifikasi obj)
        {
            try
            {
                _db.Add(obj);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(string id)
        {
            try
            {
                var result = GetById(id);
                _db.Remove(result);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Klasifikasi> GetAll()
        {
            var results = _db.Klasifikasi.OrderBy(k => k.NamaKlasifikasi);
            //var results = from k in _db.Klasifikasi
            //              orderby k.NamaKlasifikasi ascending
            //              select k;
            return results;
        }

        public IEnumerable<Klasifikasi> GetAllByNama(string nama)
        {
            //var results = from k in _db.Klasifikasi
            //              where k.NamaKlasifikasi.Contains(nama)
            //              orderby k.NamaKlasifikasi ascending
            //              select k;

            var results = _db.Klasifikasi
                .Where(k => k.NamaKlasifikasi.Contains(nama))
                .OrderBy(k => k.NamaKlasifikasi);

            return results;
        }

        public Klasifikasi GetById(string id)
        {
            var results = (from k in _db.Klasifikasi
                           where k.KodeKlasifikasi == id
                           select k).SingleOrDefault();

            if (results != null)
                return results;
            else
                throw new Exception("Data tidak ditemukan !");
        }

        public void Update(string id, Klasifikasi obj)
        {
            try
            {
                var result = GetById(id);
                result.Induk = obj.Induk;
                result.Level = obj.Level;
                result.NamaKlasifikasi = obj.NamaKlasifikasi;
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}