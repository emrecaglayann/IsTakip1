using IsTakip.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Reflection;

namespace IsTakip.Data.Context
{
    public class DataContext : DbContext
    {
      

        public DataContext()
        {
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=IsTakip; Trusted_Connection=True");
        }


      

        public DbSet<Depo> Depo { get; set; }
		public DbSet<Is> Is { get; set; }
		public DbSet<Musteri> Musteri { get; set; }
        public DbSet<MusteriTemsilcisi> MusteriTemsilcisi { get; set; }
		public DbSet<UretimDurus> UretimDurus { get; set; }
		public DbSet<UretimEmri> UretimEmri { get; set; }
		public DbSet<DurusTip> DurusTip { get; set; }
        public DbSet<DepoEnvanter> DepoEnvanter { get; set; }
        public DbSet<Kullanici> Kullanici { get; set;}
        public DbSet<MailParametreleri> MailParametreleri { get; set; }
        public DbSet<Tedarikci> Tedarikci { get;set; }
        public DbSet<MusteriSinif> MusteriSinif { get; set; }
        public DbSet<MusteriKisitlama> MusteriKisitlama { get; set; }
        public DbSet<Ajanda> Ajanda { get; set; }
        public DbSet<DepoRaf> DepoRaf { get; set; }
        public DbSet<MalzemeTip> MalzemeTip { get;set; }
        public DbSet<IsDosya> IsDosya { get; set; }
        public DbSet<KalinlikId> KalinlikId { get;set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);




        }

        public object GetById(int ıd)
        {
            throw new NotImplementedException();
        }
    }
}
