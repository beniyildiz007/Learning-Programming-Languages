namespace _02_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMUSTERISEHIRColumnInMusterisTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musteris", "MUSTERISEHIR", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Musteris", "MUSTERISEHIR");
        }
    }
}
