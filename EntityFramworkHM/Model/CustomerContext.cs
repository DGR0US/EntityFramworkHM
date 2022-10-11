using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EntityFramworkHM.Model
{
    public class CustomerContext : DbContext
    {
        public CustomerContext() : base()
        {
        }

        public DbSet<customer> Customer { get; set; }
        public DbSet<orderh> Orderh { get; set; }
        public DbSet<orderid> Orderid { get; set; }
        public DbSet<product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile(Path.Combine(Environment.CurrentDirectory, "appSettings.json"))
                .Build();
            optionsBuilder.UseNpgsql(config["ConnectionStrings:ConnectDB"])
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        public CustomerContext(DbContextOptions<CustomerContext> option)
            : base(option)
        {
            //AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }

}
