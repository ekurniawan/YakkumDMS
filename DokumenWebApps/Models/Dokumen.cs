using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DokumenWebApps.Models
{
    public class Dokumen
    {
        [Key,MaxLength(20)]
        public string DokumenID { get; set; }
        public string KodeKlasifikasi { get; set; }
        public string NamaDokumen { get; set; }
        public DateTime TanggalDibuat { get; set; }
        public DateTime TanggalDiterima { get; set; }
        public string Sumber { get; set; }
        public string Keterangan { get; set; }
        public Klasifikasi Klasifikasi { get; set; }
    }
}
