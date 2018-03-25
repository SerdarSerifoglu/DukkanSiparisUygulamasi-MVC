using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    [Table("SunnetSekeriSiparisleri")]
    public class SunnetSekeriSiparis : Siparis
    {
        [Required]
        [MaxLength(250, ErrorMessage = "250 karakterden fazla giriş yapılamaz")]
        [Display(Name = "Şeker Kodu")]
        public string SekerKodu { get; set; }
        [Required]
        [MaxLength(25, ErrorMessage = "25 karakterden fazla giriş yapılamaz")]
        [Display(Name = "Çocuğun Adı")]
        public string CocukAdi { get; set; }
        [MaxLength(50, ErrorMessage = "50 karakterden fazla giriş yapılamaz")]
        [Display(Name = "Etiket Yazısı")]
        public string EtiketeYazilacakYazi { get; set; }
        [MaxLength(250, ErrorMessage = "250 karakterden fazla giriş yapılamaz")]
        public string Not { get; set; }
    }
}
