namespace _02_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renameKATEGORIADtoKATEGORIADIinKategoristable : DbMigration
    {
        public override void Up()
        {
            //Verileri kaybetmeden sütun adını değiştirmek
            AddColumn("dbo.Kategoris", "KATEGORIADI", c => c.String());
            Sql("update Kategoris set KATEGORIADI=KATEGORIAD");
            DropColumn("dbo.Kategoris", "KATEGORIAD");
        }
        
        public override void Down()
        {
            //Verileri kaybetmeden sütun adını değiştirmek
            AddColumn("dbo.Kategoris", "KATEGORIAD", c => c.String());
            Sql("update Kategoris set KATEGORIAD=KATEGORIADI");
            DropColumn("dbo.Kategoris", "KATEGORIADI");
        }
    }
}
