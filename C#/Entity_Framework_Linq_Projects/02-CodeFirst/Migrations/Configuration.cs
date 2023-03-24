namespace _02_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<_02_CodeFirst.Entity.context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "_02_CodeFirst.Entity.context";
        }

        protected override void Seed(_02_CodeFirst.Entity.context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
