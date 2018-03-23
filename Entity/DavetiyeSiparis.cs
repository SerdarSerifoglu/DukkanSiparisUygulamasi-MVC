using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    [Table("DavetiyeSiparisleri")]
    public class DavetiyeSiparis : Siparis
    {
        //[ForeignKey("DavetiyeKatalog")]
        //public int KatalogId { get; set; }
        public virtual DavetiyeKatalog DavetiyeKatalogu { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "10 karakterden fazla giriş yapılamaz")]
        public string DavetiyeKodu { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "20 karakterden fazla giriş yapılamaz")]
        public string GelinAdi { get; set; }
        [MaxLength(20, ErrorMessage = "20 karakterden fazla giriş yapılamaz")]
        public string DamatAdi { get; set; }
        [MaxLength(20, ErrorMessage = "20 karakterden fazla giriş yapılamaz")]
        public string GelininAnneAdi { get; set; }
        [MaxLength(20, ErrorMessage = "20 karakterden fazla giriş yapılamaz")]
        public string GelininAnneSoyadi { get; set; }
        [MaxLength(20, ErrorMessage = "20 karakterden fazla giriş yapılamaz")]
        public string GelininBabaAdi { get; set; }
        [MaxLength(20, ErrorMessage = "20 karakterden fazla giriş yapılamaz")]
        public string GelininBabaSoyadi { get; set; }
        [MaxLength(20, ErrorMessage = "20 karakterden fazla giriş yapılamaz")]
        public string DamadinAnneAdi { get; set; }
        [MaxLength(20, ErrorMessage = "20 karakterden fazla giriş yapılamaz")]
        public string DamadinAnneSoyadi { get; set; }
        [MaxLength(20, ErrorMessage = "20 karakterden fazla giriş yapılamaz")]
        public string DamadinBabaAdi { get; set; }
        [MaxLength(20, ErrorMessage = "20 karakterden fazla giriş yapılamaz")]
        public string DamadinBabaSoyadi { get; set; }
        [MaxLength(500, ErrorMessage = "500 karakterden fazla giriş yapılamaz")]
        public string DavetiyeYazisi { get; set; }
        [Required]
        public DateTime TorenTarihi { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "20 karakterden fazla giriş yapılamaz")]
        public string TorenSaati { get; set; }
        [Required]
        [MaxLength(500, ErrorMessage = "500 karakterden fazla giriş yapılamaz")]
        public string AdresBilgileri { get; set; }
        [MaxLength(500, ErrorMessage = "500 karakterden fazla giriş yapılamaz")]
        public string Not { get; set; }
    }
}
