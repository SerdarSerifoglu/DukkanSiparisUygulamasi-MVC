using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    [Table("DigerSiparisler")]
    public class DigerSiparis : Siparis
    {
        [Required]
        [MaxLength(50, ErrorMessage = "50 karakterden fazla giriş yapılamaz")]
        [Display(Name = "Ürün Adı")]
        public string UrunAdi { get; set; }
        [MaxLength(250, ErrorMessage = "250 karakterden fazla giriş yapılamaz")]
        public string Not { get; set; }
    }
}
