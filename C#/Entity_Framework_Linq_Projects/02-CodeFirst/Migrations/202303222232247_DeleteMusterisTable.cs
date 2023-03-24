namespace _02_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteMusterisTable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Musteris");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Musteris",
                c => new
                    {
                        MUSTERIID = c.Int(nullable: false, identity: true),
                        MUSTERIAD = c.String(),
                        MUSTERIUNVAN = c.String(),
                        MUSTERISEHIR = c.String(),
                    })
                .PrimaryKey(t => t.MUSTERIID);
            
        }
    }
}
