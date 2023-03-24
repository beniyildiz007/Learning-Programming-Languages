namespace _02_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renameMUSTERISOYADtoMUSTERIUNVANinMusteristable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musteris", "MUSTERIUNVAN", c => c.String());
            DropColumn("dbo.Musteris", "MUSTERISOYAD");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Musteris", "MUSTERISOYAD", c => c.String());
            DropColumn("dbo.Musteris", "MUSTERIUNVAN");
        }
    }
}
