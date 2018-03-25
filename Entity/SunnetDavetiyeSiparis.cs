using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    [Table("SunnetDavetiyeSiparisleri")]
    public class SunnetDavetiyeSiparis : Siparis
    {
        //[ForeignKey("DavetiyeKatalog")]
        //public int KatalogId { get; set; }
        public virtual DavetiyeKatalog DavetiyeKatalogu { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "10 karakterden fazla giriş yapılamaz")]
        [Display(Name = "Davetiye Kodu")]
        public string DavetiyeKodu { get; set; }
        [Required]
        [MaxLength(25, ErrorMessage = "25 karakterden fazla giriş yapılamaz")]
        [Display(Name = "Çocuğun Adı")]
        public string CocugunAdi { get; set; }
        [MaxLength(25, ErrorMessage = "25 karakterden fazla giriş yapılamaz")]
        [Display(Name = "Çocuğun Annesinin Adı")]
        public string CocugunAnneAdi { get; set; }
        [MaxLength(25, ErrorMessage = "25 karakterden fazla giriş yapılamaz")]
        [Display(Name = "Çocuğun Annesinin Soyadı")]
        public string CocugunAnneSoyadi { get; set; }
        [MaxLength(25, ErrorMessage = "25 karakterden fazla giriş yapılamaz")]
        [Display(Name = "Çocuğun Babasının Adı")]
        public string CocugunBabaAdi { get; set; }
        [MaxLength(25, ErrorMessage = "25 karakterden fazla giriş yapılamaz")]
        [Display(Name = "Çocuğun Babasının Soyadı")]
        public string CocugunBabaSoyadi { get; set; }
        [MaxLength(250, ErrorMessage = "250 karakterden fazla giriş yapılamaz")]
        [Display(Name = "Davetiye Yazısı")]
        public string DavetiyeYazisi { get; set; }
        [Required]
        [Display(Name = "Tören Tarihi")]
        public DateTime TorenTarihi { get; set; }
        [Required]
        [MaxLength(15, ErrorMessage = "15 karakterden fazla giriş yapılamaz")]
        [Display(Name = "Tören Saati")]
        public string TorenSaati { get; set; }
        [MaxLength(250, ErrorMessage = "250 karakterden fazla giriş yapılamaz")]
        [Display(Name = "Adres Bilgileri")]
        public string AdresBilgileri { get; set; }
        [MaxLength(400, ErrorMessage = "400 karakterden fazla giriş yapılamaz")]
        public string Not { get; set; }
    }
}
