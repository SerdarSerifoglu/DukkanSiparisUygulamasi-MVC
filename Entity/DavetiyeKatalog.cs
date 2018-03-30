using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    [Table("DavetiyeKataloglari")]
   public class DavetiyeKatalog
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(25,ErrorMessage ="25 karakterden fazla giriş yapılamaz")]
        [Display(Name = "Davetiye Katalog Adı")]
        public string KatalogAdi { get; set; }
        public virtual List<DavetiyeSiparis> DavetiyeSiparisleri { get; set; }
        public virtual List<SunnetDavetiyeSiparis> SunnetDavetiyeSiparisleri { get; set; }

    }
}
