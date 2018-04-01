using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class Repository
    {
        public class BebekSekeriSiparisRepository : BaseRepository<BebekSekeriSiparis>
        {
            public override void Update(BebekSekeriSiparis obj)
            {
                BebekSekeriSiparis degisenSiparis = GetById(obj.SiparisId);
                degisenSiparis.SiparisTuru = obj.SiparisTuru;
                degisenSiparis.SiparisVerenAdi = obj.SiparisVerenAdi;
                degisenSiparis.SiparisVerenTel = obj.SiparisVerenTel;
                degisenSiparis.SiparisVerenEmail = obj.SiparisVerenEmail;
                degisenSiparis.SiparisAdet = obj.SiparisAdet;
                degisenSiparis.SiparisTarihi = obj.SiparisTarihi;
                degisenSiparis.TeslimTarihi = obj.TeslimTarihi;
                degisenSiparis.TeslimEdildiMi = obj.TeslimEdildiMi;
                degisenSiparis.SiparisToplamTutari = obj.SiparisToplamTutari;
                degisenSiparis.SiparisAlan = obj.SiparisAlan;
                degisenSiparis.SekerKodu = obj.SekerKodu;
                degisenSiparis.CocukAdi = obj.CocukAdi;
                degisenSiparis.EtiketeYazilacakYazi = obj.EtiketeYazilacakYazi;
                degisenSiparis.Not = obj.Not;
                SiparisContext.db.Entry(degisenSiparis).State = System.Data.Entity.EntityState.Modified;
                SiparisContext.db.SaveChanges();
            }
        }

        public class DavetiyeKatalogRepository : BaseRepository<DavetiyeKatalog>
        {

        }

        public class DavetiyeSiparisRepository : BaseRepository<DavetiyeSiparis>
        {

        }

        public class DigerSiparisRepository : BaseRepository<DigerSiparis>
        {

        }

        public class NikahSekeriSiparisRepository : BaseRepository<NikahSekeriSiparis>
        {

        }

        public class SunnetDavetiyeSiparisRepository : BaseRepository<SunnetDavetiyeSiparis>
        {

        }

        public class SunnetSekeriSiparisRepository : BaseRepository<SunnetSekeriSiparis>
        {

        }

        public class SiparisRepository : BaseRepository<Siparis>
        {

        }
    }
}
