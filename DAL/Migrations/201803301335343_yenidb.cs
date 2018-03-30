namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class yenidb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Siparisler",
                c => new
                    {
                        SiparisId = c.Int(nullable: false, identity: true),
                        SiparisTuru = c.String(nullable: false, maxLength: 25),
                        SiparisVerenAdi = c.String(nullable: false, maxLength: 25),
                        SiparisVerenTel = c.String(nullable: false, maxLength: 15),
                        SiparisVerenEmail = c.String(maxLength: 40),
                        SiparisAdet = c.Int(nullable: false),
                        SiparisTarihi = c.DateTime(nullable: false),
                        TeslimTarihi = c.DateTime(nullable: false),
                        TeslimEdildiMi = c.Boolean(nullable: false),
                        SiparisToplamTutari = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SiparisAlan = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SiparisId);
            
            CreateTable(
                "dbo.DavetiyeKataloglari",
                c => new
                    {
                        KatalogId = c.Int(nullable: false, identity: true),
                        KatalogAdi = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.KatalogId);
            
            CreateTable(
                "dbo.BebekSekeriSiparisleri",
                c => new
                    {
                        SiparisId = c.Int(nullable: false),
                        SekerKodu = c.String(nullable: false, maxLength: 10),
                        CocukAdi = c.String(maxLength: 25),
                        EtiketeYazilacakYazi = c.String(maxLength: 40),
                        Not = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.SiparisId)
                .ForeignKey("dbo.Siparisler", t => t.SiparisId)
                .Index(t => t.SiparisId);
            
            CreateTable(
                "dbo.DavetiyeSiparisleri",
                c => new
                    {
                        SiparisId = c.Int(nullable: false),
                        KatalogId = c.Int(nullable: false),
                        DavetiyeKodu = c.String(nullable: false, maxLength: 10),
                        GelinAdi = c.String(nullable: false, maxLength: 20),
                        DamatAdi = c.String(maxLength: 20),
                        GelininAnneAdi = c.String(maxLength: 20),
                        GelininAnneSoyadi = c.String(maxLength: 20),
                        GelininBabaAdi = c.String(maxLength: 20),
                        GelininBabaSoyadi = c.String(maxLength: 20),
                        DamadinAnneAdi = c.String(maxLength: 20),
                        DamadinAnneSoyadi = c.String(maxLength: 20),
                        DamadinBabaAdi = c.String(maxLength: 20),
                        DamadinBabaSoyadi = c.String(maxLength: 20),
                        DavetiyeYazisi = c.String(maxLength: 500),
                        TorenTarihi = c.DateTime(nullable: false),
                        TorenSaati = c.String(nullable: false, maxLength: 20),
                        AdresBilgileri = c.String(nullable: false, maxLength: 500),
                        Not = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.SiparisId)
                .ForeignKey("dbo.Siparisler", t => t.SiparisId)
                .ForeignKey("dbo.DavetiyeKataloglari", t => t.KatalogId, cascadeDelete: true)
                .Index(t => t.SiparisId)
                .Index(t => t.KatalogId);
            
            CreateTable(
                "dbo.DigerSiparisler",
                c => new
                    {
                        SiparisId = c.Int(nullable: false),
                        UrunAdi = c.String(nullable: false, maxLength: 50),
                        Not = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.SiparisId)
                .ForeignKey("dbo.Siparisler", t => t.SiparisId)
                .Index(t => t.SiparisId);
            
            CreateTable(
                "dbo.NikahSekeriSiparisleri",
                c => new
                    {
                        SiparisId = c.Int(nullable: false),
                        SekerKodu = c.String(nullable: false, maxLength: 10),
                        GelinAdi = c.String(nullable: false, maxLength: 20),
                        DamatAdi = c.String(maxLength: 20),
                        SekerYazisi = c.String(maxLength: 50),
                        Not = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.SiparisId)
                .ForeignKey("dbo.Siparisler", t => t.SiparisId)
                .Index(t => t.SiparisId);
            
            CreateTable(
                "dbo.SunnetDavetiyeSiparisleri",
                c => new
                    {
                        SiparisId = c.Int(nullable: false),
                        DavetiyeKatalogu_KatalogId = c.Int(),
                        DavetiyeKodu = c.String(nullable: false, maxLength: 10),
                        CocugunAdi = c.String(nullable: false, maxLength: 25),
                        CocugunAnneAdi = c.String(maxLength: 25),
                        CocugunAnneSoyadi = c.String(maxLength: 25),
                        CocugunBabaAdi = c.String(maxLength: 25),
                        CocugunBabaSoyadi = c.String(maxLength: 25),
                        DavetiyeYazisi = c.String(maxLength: 250),
                        TorenTarihi = c.DateTime(nullable: false),
                        TorenSaati = c.String(nullable: false, maxLength: 15),
                        AdresBilgileri = c.String(maxLength: 250),
                        Not = c.String(maxLength: 400),
                    })
                .PrimaryKey(t => t.SiparisId)
                .ForeignKey("dbo.Siparisler", t => t.SiparisId)
                .ForeignKey("dbo.DavetiyeKataloglari", t => t.DavetiyeKatalogu_KatalogId)
                .Index(t => t.SiparisId)
                .Index(t => t.DavetiyeKatalogu_KatalogId);
            
            CreateTable(
                "dbo.SunnetSekeriSiparisleri",
                c => new
                    {
                        SiparisId = c.Int(nullable: false),
                        SekerKodu = c.String(nullable: false, maxLength: 250),
                        CocukAdi = c.String(nullable: false, maxLength: 25),
                        EtiketeYazilacakYazi = c.String(maxLength: 50),
                        Not = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.SiparisId)
                .ForeignKey("dbo.Siparisler", t => t.SiparisId)
                .Index(t => t.SiparisId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SunnetSekeriSiparisleri", "SiparisId", "dbo.Siparisler");
            DropForeignKey("dbo.SunnetDavetiyeSiparisleri", "DavetiyeKatalogu_KatalogId", "dbo.DavetiyeKataloglari");
            DropForeignKey("dbo.SunnetDavetiyeSiparisleri", "SiparisId", "dbo.Siparisler");
            DropForeignKey("dbo.NikahSekeriSiparisleri", "SiparisId", "dbo.Siparisler");
            DropForeignKey("dbo.DigerSiparisler", "SiparisId", "dbo.Siparisler");
            DropForeignKey("dbo.DavetiyeSiparisleri", "KatalogId", "dbo.DavetiyeKataloglari");
            DropForeignKey("dbo.DavetiyeSiparisleri", "SiparisId", "dbo.Siparisler");
            DropForeignKey("dbo.BebekSekeriSiparisleri", "SiparisId", "dbo.Siparisler");
            DropIndex("dbo.SunnetSekeriSiparisleri", new[] { "SiparisId" });
            DropIndex("dbo.SunnetDavetiyeSiparisleri", new[] { "DavetiyeKatalogu_KatalogId" });
            DropIndex("dbo.SunnetDavetiyeSiparisleri", new[] { "SiparisId" });
            DropIndex("dbo.NikahSekeriSiparisleri", new[] { "SiparisId" });
            DropIndex("dbo.DigerSiparisler", new[] { "SiparisId" });
            DropIndex("dbo.DavetiyeSiparisleri", new[] { "KatalogId" });
            DropIndex("dbo.DavetiyeSiparisleri", new[] { "SiparisId" });
            DropIndex("dbo.BebekSekeriSiparisleri", new[] { "SiparisId" });
            DropTable("dbo.SunnetSekeriSiparisleri");
            DropTable("dbo.SunnetDavetiyeSiparisleri");
            DropTable("dbo.NikahSekeriSiparisleri");
            DropTable("dbo.DigerSiparisler");
            DropTable("dbo.DavetiyeSiparisleri");
            DropTable("dbo.BebekSekeriSiparisleri");
            DropTable("dbo.DavetiyeKataloglari");
            DropTable("dbo.Siparisler");
        }
    }
}
