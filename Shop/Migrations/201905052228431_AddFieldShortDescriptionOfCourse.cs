namespace Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFieldShortDescriptionOfCourse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Course", "ShortDescriptionOfCourse", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Course", "ShortDescriptionOfCourse");
        }
    }
}
