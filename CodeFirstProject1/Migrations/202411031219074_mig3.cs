namespace CodeFirstProject1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "MovieCategory");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "MovieCategory", c => c.String());
        }
    }
}
