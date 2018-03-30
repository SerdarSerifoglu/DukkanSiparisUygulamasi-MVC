namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class s : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BebekSekeriSiparisleri", "EtiketeYazilacakYazi", c => c.String(maxLength: 40));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BebekSekeriSiparisleri", "EtiketeYazilacakYazi", c => c.String(maxLength: 25));
        }
    }
}
