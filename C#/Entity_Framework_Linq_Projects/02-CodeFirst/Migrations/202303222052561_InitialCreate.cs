namespace _02_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Urunlers",
                c => new
                    {
                        URUNID = c.Int(nullable: false, identity: true),
                        URUNAD = c.String(),
                        URUNMARKA = c.String(),
                        URUNKATEGORI = c.String(),
                        URUNSTOK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.URUNID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Urunlers");
        }
    }
}
