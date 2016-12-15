namespace FakturaData.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FakturaData.FakturaContext>
    {
        public Configuration()
        {
            AutomaticMigrationDataLossAllowed = true;
            AutomaticMigrationsEnabled = true;
            ContextKey = "FakturaData.FakturaContext";
        }

        protected override void Seed(FakturaData.FakturaContext context)
        { 
        }
    }
}
