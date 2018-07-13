using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DokumenWebApps.Models
{
    public class Klasifikasi
    {
        public Klasifikasi()
        {
            StatusAktif = true;
        }

        [Key, MaxLength(20)]
        public string KodeKlasifikasi { get; set; }
        [MaxLength(20)]
        public string Induk { get; set; }
        public int Level { get; set; }
        public string NamaKlasifikasi { get; set; }
        public string Uraian { get; set; }
        public int RetensiAktif { get; set; }
        public int RetensiInaktif { get; set; }
        public bool StatusAktif { get; set; }
    }
}
