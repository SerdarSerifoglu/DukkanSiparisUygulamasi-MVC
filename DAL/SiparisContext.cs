using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class SiparisContext : DbContext
    {
        public SiparisContext(): base("Name=SiparisUygulamaCS")
        {

        }
        public virtual DbSet<BebekSekeriSiparis> BebekSekeriSiparisler { get; set; }
        public virtual DbSet<DavetiyeKatalog> DavetiyeKataloglar { get; set; }
        public virtual DbSet<DavetiyeSiparis> DavetiyeSiparisler { get; set; }
        public virtual DbSet<DigerSiparis> DigerSiparisler { get; set; }
        public virtual DbSet<NikahSekeriSiparis> NikahSekeriSiparisler { get; set; }
        public virtual DbSet<Siparis> Siparisler { get; set; }
        public virtual DbSet<SunnetDavetiyeSiparis> SunnetDavetiyeSiparisler { get; set; }
        public virtual DbSet<SunnetSekeriSiparis> SunnetSekeriSiparisler { get; set; }
    }
}
