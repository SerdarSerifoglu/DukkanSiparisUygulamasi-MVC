using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    [Table("Siparisler")]
    public class Siparis
    {
        public Siparis()
        {
            //Daha sonra ekliycem
            //SiparisTarihi = DateTime.Now;
            TeslimEdildiMi = false;
        }
        [Key]
        public int SiparisId { get; set; }
        [Required]
        [MaxLength(25, ErrorMessage = "25 karakterden fazla giriş yapılamaz")]
        [Display(Name = "Sipariş Türü")]
        public string SiparisTuru { get; set; }
        [Required]
        [MaxLength(25, ErrorMessage = "25 karakterden fazla giriş yapılamaz")]
        [Display(Name = "Sipariş Verenin Adı Soyadı")]
        public string SiparisVerenAdi { get; set; }
        [Required]
        [MaxLength(15, ErrorMessage = "25 karakterden fazla giriş yapılamaz")]
        [Display(Name = "Siparis Verenin Telefonu")]
        public string SiparisVerenTel { get; set; }
        [MaxLength(40, ErrorMessage = "40 karakterden fazla giriş yapılamaz")]
        [Display(Name = "Siparis Verenin E-mail Adresi")]
        public string SiparisVerenEmail { get; set; }
        [Required]
        [Display(Name = "Sipariş Adedi")]
        public int SiparisAdet { get; set; }
        [Display(Name = "Siparis Tarihi")]
        public DateTime SiparisTarihi { get; set; }
        [Required]
        [Display(Name = "Teslim Tarihi")]
        public DateTime TeslimTarihi { get; set; }
        public bool TeslimEdildiMi { get; set; }
        [Required]
        [Display(Name = "Toplam Siparis Tutarı")]
        public decimal SiparisToplamTutari { get; set; }
        [Required]
        public Kisi SiparisAlan { get; set; } 

        public enum Kisi
        {
            Ali,
            Selim
        }


    }
}
