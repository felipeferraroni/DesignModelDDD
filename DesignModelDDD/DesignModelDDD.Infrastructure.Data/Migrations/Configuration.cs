namespace DesignModelDDD.Infrastructure.Data.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Contexto.DesignModelContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Contexto.DesignModelContext context)
        {
        }
    }
}
