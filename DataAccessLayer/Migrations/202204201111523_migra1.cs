namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migra1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategoris",
                c => new
                    {
                        KategoriID = c.Int(nullable: false, identity: true),
                        KategoriAdi = c.String(maxLength: 40),
                    })
                .PrimaryKey(t => t.KategoriID);
            
            CreateTable(
                "dbo.Urunlers",
                c => new
                    {
                        UrunID = c.Int(nullable: false, identity: true),
                        UrunAdi = c.String(maxLength: 40),
                        Stok = c.Int(nullable: false),
                        KategoriID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UrunID)
                .ForeignKey("dbo.Kategoris", t => t.KategoriID, cascadeDelete: true)
                .Index(t => t.KategoriID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Urunlers", "KategoriID", "dbo.Kategoris");
            DropIndex("dbo.Urunlers", new[] { "KategoriID" });
            DropTable("dbo.Urunlers");
            DropTable("dbo.Kategoris");
        }
    }
}
