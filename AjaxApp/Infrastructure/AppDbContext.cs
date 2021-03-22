using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AjaxApp.Models;

namespace AjaxApp.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public AppDbContext() : base("Data Source=.; Initial Catalog=Student; Integrated Security=true;")
                {
                    Database.SetInitializer<AppDbContext>(null);
                }

}
}
