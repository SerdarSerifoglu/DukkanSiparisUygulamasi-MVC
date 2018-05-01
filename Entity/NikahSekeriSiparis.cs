using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    [Table("NikahSekeriSiparisleri")]
    public class NikahSekeriSiparis : Siparis
    {
        [Required]
        [MaxLength(10, ErrorMessage = "10 karakterden fazla giriş yapılamaz")]
        [Display(Name = "Şeker Kodu:")]
        public string SekerKodu { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "20 karakterden fazla giriş yapılamaz")]
        [Display(Name = "Gelinin Adı:")]
        public string GelinAdi { get; set; }
        [MaxLength(20, ErrorMessage = "20 karakterden fazla giriş yapılamaz")]
        [Display(Name = "Damadin Adı:")]
        public string DamatAdi { get; set; }
        [MaxLength(50, ErrorMessage = "50 karakterden fazla giriş yapılamaz")]
        [Display(Name = "Şeker Yazısı:")]
        public string SekerYazisi { get; set; }
        [MaxLength(250, ErrorMessage = "250 karakterden fazla giriş yapılamaz")]
        [Display(Name = "Not:")]
        public string Not { get; set; }
    }
}
