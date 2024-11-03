﻿namespace CodeFirstProject1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "CategoryID", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "CategoryID");
            AddForeignKey("dbo.Movies", "CategoryID", "dbo.Categories", "CategoryID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Movies", new[] { "CategoryID" });
            DropColumn("dbo.Movies", "CategoryID");
        }
    }
}