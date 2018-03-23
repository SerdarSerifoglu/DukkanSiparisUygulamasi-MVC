﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    [Table("BebekSekeriSiparisleri")]
    public class BebekSekeriSiparis : Siparis
    {
        [Required]
        [MaxLength(10, ErrorMessage = "10 karakterden fazla giriş yapılamaz")]
        public string SekerKodu { get; set; }
        [MaxLength(25, ErrorMessage = "25 karakterden fazla giriş yapılamaz")]
        public string CocukAdi { get; set; }
        [MaxLength(25, ErrorMessage = "25 karakterden fazla giriş yapılamaz")]
        public string EtiketeYazilacakYazi { get; set; }
        [MaxLength(100, ErrorMessage = "100 karakterden fazla giriş yapılamaz")]
        public string Not { get; set; }
    }
}