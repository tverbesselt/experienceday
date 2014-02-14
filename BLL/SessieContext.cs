using System.Data.Entity;

namespace BLL
{
    public class SessieContext : DbContext
    {
        public SessieContext() : base(BLL.Properties.Settings.Default.connString)
        {
        }


        public DbSet<Sessie> Sessies { get; set; }
        public DbSet<Spreker> Sprekers { get; set; }
    }
}