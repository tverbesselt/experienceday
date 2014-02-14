using System.Data.Entity;

namespace BLL
{
    public class SessieContext : DbContext
    {
        public SessieContext() : base(BLL.Properties.Settings.Default.connString)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SessieContext>());
        }


        public DbSet<Sessie> Sessies { get; set; }
        public DbSet<Spreker> Sprekers { get; set; }
    }
}