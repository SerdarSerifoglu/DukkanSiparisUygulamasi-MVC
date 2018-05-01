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
            public override void Update(DavetiyeKatalog obj)
            {
                DavetiyeKatalog degisenkatalog = GetById(obj.KatalogId);
                degisenkatalog.KatalogAdi = obj.KatalogAdi;
                SiparisContext.db.Entry(degisenkatalog).State = System.Data.Entity.EntityState.Modified;
                SiparisContext.db.SaveChanges();

            }
        }

        public class DavetiyeSiparisRepository : BaseRepository<DavetiyeSiparis>
        {
            public override void Update(DavetiyeSiparis obj)
            {
                DavetiyeSiparis degisenSiparis = GetById(obj.SiparisId);
                degisenSiparis.KatalogId = obj.KatalogId;
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
                degisenSiparis.DavetiyeKodu = obj.DavetiyeKodu;
                degisenSiparis.GelinAdi = obj.GelinAdi;
                degisenSiparis.DamatAdi = obj.DamatAdi;
                degisenSiparis.GelininAnneAdi = obj.GelininAnneAdi;
                degisenSiparis.GelininAnneSoyadi = obj.GelininAnneSoyadi;
                degisenSiparis.GelininBabaAdi = obj.GelininBabaAdi;
                degisenSiparis.GelininBabaSoyadi = obj.GelininBabaSoyadi;
                degisenSiparis.DamadinAnneAdi = obj.DamadinAnneAdi;
                degisenSiparis.DamadinAnneSoyadi = obj.DamadinAnneSoyadi;
                degisenSiparis.DamadinBabaAdi = obj.DamadinBabaAdi;
                degisenSiparis.DamadinBabaSoyadi = obj.DamadinBabaSoyadi;
                degisenSiparis.DavetiyeYazisi = obj.DavetiyeYazisi;
                degisenSiparis.TorenTarihi = obj.TorenTarihi;
                degisenSiparis.TorenSaati = obj.TorenSaati;
                degisenSiparis.AdresBilgileri = obj.AdresBilgileri;
                degisenSiparis.Not = obj.Not;
                SiparisContext.db.Entry(degisenSiparis).State = System.Data.Entity.EntityState.Modified;
                SiparisContext.db.SaveChanges();
            }
        }

        public class DigerSiparisRepository : BaseRepository<DigerSiparis>
        {
            public override void Update(DigerSiparis obj)
            {
                DigerSiparis degisenSiparis = GetById(obj.SiparisId);
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
                degisenSiparis.UrunAdi = obj.UrunAdi;
                degisenSiparis.Not = obj.Not;
                SiparisContext.db.Entry(degisenSiparis).State = System.Data.Entity.EntityState.Modified;
                SiparisContext.db.SaveChanges();
            }
        }

        public class NikahSekeriSiparisRepository : BaseRepository<NikahSekeriSiparis>
        {
            public override void Update(NikahSekeriSiparis obj)
            {
                NikahSekeriSiparis degisenSiparis = GetById(obj.SiparisId);
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
                degisenSiparis.GelinAdi = obj.GelinAdi;
                degisenSiparis.DamatAdi = obj.DamatAdi;
                degisenSiparis.SekerYazisi = obj.SekerYazisi;
                degisenSiparis.Not = obj.Not;
                SiparisContext.db.Entry(degisenSiparis).State = System.Data.Entity.EntityState.Modified;
                SiparisContext.db.SaveChanges();
            }
        }

        public class SunnetDavetiyeSiparisRepository : BaseRepository<SunnetDavetiyeSiparis>
        {
            public override void Update(SunnetDavetiyeSiparis obj)
            {
                SunnetDavetiyeSiparis degisenSiparis = GetById(obj.SiparisId);
                degisenSiparis.KatalogId = obj.KatalogId;
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
                degisenSiparis.DavetiyeKodu = obj.DavetiyeKodu;
                degisenSiparis.CocugunAdi = obj.CocugunAdi;
                degisenSiparis.CocugunAnneAdi = obj.CocugunAnneAdi;
                degisenSiparis.CocugunAnneSoyadi = obj.CocugunAnneSoyadi;
                degisenSiparis.CocugunBabaAdi = obj.CocugunBabaAdi;
                degisenSiparis.CocugunBabaSoyadi = obj.CocugunBabaSoyadi;
                degisenSiparis.DavetiyeYazisi = obj.DavetiyeYazisi;
                degisenSiparis.TorenTarihi = obj.TorenTarihi;
                degisenSiparis.TorenSaati = obj.TorenSaati;
                degisenSiparis.AdresBilgileri = obj.AdresBilgileri;
                degisenSiparis.Not = obj.Not;
                SiparisContext.db.Entry(degisenSiparis).State = System.Data.Entity.EntityState.Modified;
                SiparisContext.db.SaveChanges();
            }
        }

        public class SunnetSekeriSiparisRepository : BaseRepository<SunnetSekeriSiparis>
        {
            public override void Update(SunnetSekeriSiparis obj)
            {
                SunnetSekeriSiparis degisensiparis = GetById(obj.SiparisId);
                degisensiparis.SiparisId = obj.SiparisId;
                degisensiparis.SiparisTuru = obj.SiparisTuru;
                degisensiparis.SiparisVerenAdi = obj.SiparisVerenAdi;
                degisensiparis.SiparisVerenTel = obj.SiparisVerenTel;
                degisensiparis.SiparisVerenEmail = obj.SiparisVerenEmail;
                degisensiparis.SiparisAdet = obj.SiparisAdet;
                degisensiparis.SiparisTarihi = obj.SiparisTarihi;
                degisensiparis.TeslimTarihi = obj.TeslimTarihi;
                degisensiparis.TeslimEdildiMi = obj.TeslimEdildiMi;
                degisensiparis.SiparisToplamTutari = obj.SiparisToplamTutari;
                degisensiparis.SiparisAlan = obj.SiparisAlan;
                degisensiparis.SekerKodu = obj.SekerKodu;
                degisensiparis.CocukAdi = obj.CocukAdi;
                degisensiparis.EtiketeYazilacakYazi = obj.EtiketeYazilacakYazi;
                degisensiparis.Not = obj.Not;
                SiparisContext.db.Entry(degisensiparis).State = System.Data.Entity.EntityState.Modified;
                SiparisContext.db.SaveChanges();

            }
        }

        public class SiparisRepository : BaseRepository<Siparis>
        {

        }
    }
}
