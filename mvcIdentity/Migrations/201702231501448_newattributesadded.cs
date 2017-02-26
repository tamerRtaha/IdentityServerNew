namespace mvcIdentity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newattributesadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "fname", c => c.String());
            AddColumn("dbo.AspNetUsers", "age", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "age");
            DropColumn("dbo.AspNetUsers", "fname");
        }
    }
}
