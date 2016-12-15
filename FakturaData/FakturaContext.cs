namespace FakturaData
{
    using Faktura.Models;
    using Migrations;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class FakturaContext : DbContext
    {
        public FakturaContext()
            : base("FakturaContext")
        {
           
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<FakturaContext,Configuration>());
        }

         public virtual DbSet<Firm> Firms { get; set; }

         public virtual DbSet<Product> Products { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}