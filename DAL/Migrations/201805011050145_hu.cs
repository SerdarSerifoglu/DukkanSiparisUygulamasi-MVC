namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hu : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SunnetDavetiyeSiparisleri", "DavetiyeKatalogu_KatalogId", "dbo.DavetiyeKataloglari");
            DropIndex("dbo.SunnetDavetiyeSiparisleri", new[] { "DavetiyeKatalogu_KatalogId" });
            RenameColumn(table: "dbo.SunnetDavetiyeSiparisleri", name: "DavetiyeKatalogu_KatalogId", newName: "KatalogId");
            AlterColumn("dbo.SunnetDavetiyeSiparisleri", "KatalogId", c => c.Int(nullable: false));
            CreateIndex("dbo.SunnetDavetiyeSiparisleri", "KatalogId");
            AddForeignKey("dbo.SunnetDavetiyeSiparisleri", "KatalogId", "dbo.DavetiyeKataloglari", "KatalogId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SunnetDavetiyeSiparisleri", "KatalogId", "dbo.DavetiyeKataloglari");
            DropIndex("dbo.SunnetDavetiyeSiparisleri", new[] { "KatalogId" });
            AlterColumn("dbo.SunnetDavetiyeSiparisleri", "KatalogId", c => c.Int());
            RenameColumn(table: "dbo.SunnetDavetiyeSiparisleri", name: "KatalogId", newName: "DavetiyeKatalogu_KatalogId");
            CreateIndex("dbo.SunnetDavetiyeSiparisleri", "DavetiyeKatalogu_KatalogId");
            AddForeignKey("dbo.SunnetDavetiyeSiparisleri", "DavetiyeKatalogu_KatalogId", "dbo.DavetiyeKataloglari", "KatalogId");
        }
    }
}
