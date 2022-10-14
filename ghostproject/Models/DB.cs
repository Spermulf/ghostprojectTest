using Microsoft.EntityFrameworkCore;
using System.Text;


namespace ghostproject.Models
{
    public class DB:DbContext 
    {
        public DB(DbContextOptions<DB> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public virtual DbSet<Bruker> Bruker { get; set; }
        public virtual DbSet<Aksje> Aksje { get; set; }
        public virtual DbSet<Poststeder> Poststeder { get; set; }
        public virtual DbSet<Transaksjoner> Transaksjoner { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // må importere pakken Microsoft.EntityFrameworkCore.Proxies
            // og legge til"viritual" på de attriuttene som ønskes å lastes automatisk (LazyLoading)
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
