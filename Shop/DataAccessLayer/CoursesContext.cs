using Shop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Shop.DataAccessLayer
{
    public class CoursesContext: DbContext
    {
        public CoursesContext() : base("CoursesContext")
        {

        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ItemOrder> ItemsOrders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // this function turn off convention which automatically create plural for name of table in our DB
            // does not add "ES" in the end name of table
            // I created plular properties, I dont want something like Courses -> Courseses
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}