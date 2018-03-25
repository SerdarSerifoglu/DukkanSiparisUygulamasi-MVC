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
        [Display(Name ="Davetiye Kodu")]
        public string DavetiyeKodu { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "20 karakterden fazla giriş yapılamaz")]
        [Display(Name = "Gelinin Adı")]
        public string GelinAdi { get; set; }
        [MaxLength(20, ErrorMessage = "20 karakterden fazla giriş yapılamaz")]
        [Display(Name = "Damadın Adı")]
        public string DamatAdi { get; set; }
        [MaxLength(20, ErrorMessage = "20 karakterden fazla giriş yapılamaz")]
        [Display(Name = "Gelinin Annesinin Adı")]
        public string GelininAnneAdi { get; set; }
        [MaxLength(20, ErrorMessage = "20 karakterden fazla giriş yapılamaz")]
        [Display(Name = "Gelinin Annesinin Soyadı")]
        public string GelininAnneSoyadi { get; set; }
        [MaxLength(20, ErrorMessage = "20 karakterden fazla giriş yapılamaz")]
        [Display(Name = "Gelinin Babasının Adı")]
        public string GelininBabaAdi { get; set; }
        [MaxLength(20, ErrorMessage = "20 karakterden fazla giriş yapılamaz")]
        [Display(Name = "Gelinin Babasının Soyadı")]
        public string GelininBabaSoyadi { get; set; }
        [MaxLength(20, ErrorMessage = "20 karakterden fazla giriş yapılamaz")]
        [Display(Name = "Damadin Annesinin Adı")]
        public string DamadinAnneAdi { get; set; }
        [MaxLength(20, ErrorMessage = "20 karakterden fazla giriş yapılamaz")]
        [Display(Name = "Damadin Annesinin Soyadı")]
        public string DamadinAnneSoyadi { get; set; }
        [MaxLength(20, ErrorMessage = "20 karakterden fazla giriş yapılamaz")]
        [Display(Name = "Damadin Babasının Adı")]
        public string DamadinBabaAdi { get; set; }
        [MaxLength(20, ErrorMessage = "20 karakterden fazla giriş yapılamaz")]
        [Display(Name = "Damadin Babasının Soyadı")]
        public string DamadinBabaSoyadi { get; set; }
        [MaxLength(500, ErrorMessage = "500 karakterden fazla giriş yapılamaz")]
        [Display(Name = "DavetiyeYazısı")]
        public string DavetiyeYazisi { get; set; }
        [Required]
        [Display(Name = "Tören Tarihi")]
        public DateTime TorenTarihi { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "20 karakterden fazla giriş yapılamaz")]
        [Display(Name = "Tören Saati")]
        public string TorenSaati { get; set; }
        [Required]
        [MaxLength(500, ErrorMessage = "500 karakterden fazla giriş yapılamaz")]
        [Display(Name = "Adres Bilgileri")]
        public string AdresBilgileri { get; set; }
        [MaxLength(500, ErrorMessage = "500 karakterden fazla giriş yapılamaz")]
        public string Not { get; set; }
    }
}
