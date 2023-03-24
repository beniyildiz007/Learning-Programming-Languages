namespace _02_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMusterisTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Musteris",
                c => new
                    {
                        MUSTERIID = c.Int(nullable: false, identity: true),
                        MUSTERIAD = c.String(),
                        MUSTERISOYAD = c.String(),
                    })
                .PrimaryKey(t => t.MUSTERIID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Musteris");
        }
    }
}
