namespace Shop.Migrations
{
    using Shop.DataAccessLayer;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<Shop.DataAccessLayer.CoursesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Shop.DataAccessLayer.CoursesContext";
        }

        protected override void Seed(Shop.DataAccessLayer.CoursesContext context)
        {
            CoursesInitializer.SeedCoursesData(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
