using ITShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITShop.Data
{
    public class OOADContext : DbContext
    {
        public OOADContext(DbContextOptions<OOADContext> options): base(options)
        {
        }
        public DbSet<Administrator> Administrator { get; set; }
        public DbSet<Proizvod> Proizvod { get; set; }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<Uposlenik> Uposlenik { get; set; }
        public DbSet<Kupac> Kupac { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Kupovina> Kupovina { get; set; }
        public DbSet<Slusalice> Slusalice { get; set; }
        public DbSet<Disk> Disk { get; set; }
        public DbSet<HardDisk> HDisk { get; set; }
        public DbSet<SSD> SDisk { get; set; }
        public DbSet<Tastatura> Tastatura { get; set; }
        public DbSet<Kuciste> Kuciste { get; set; }
        public DbSet<GrafickaKartica> GrafickaKartica { get; set; }
        public DbSet<ZvucnaKartica> ZvucnaKartica { get; set; }
        public DbSet<Memorija> Memorija { get; set; }
        public DbSet<Monitor> Monitor { get; set; }
        public DbSet<Mis> Mis { get; set; }
        public DbSet<Procesor> Procesor { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Student>().ToTable("Student");
            builder.Entity<Administrator>().ToTable("Administrator");
            builder.Entity<Uposlenik>().ToTable("Uposlenik");
            builder.Entity<Kupac>().ToTable("Kupac");
            builder.Entity<Korisnik>().ToTable("Korisnik");
            builder.Entity<MaticnaPloca>().ToTable("Maticna_Ploca");
            builder.Entity<GrafickaKartica>().ToTable("Graficka_Kartica");
            builder.Entity<Proizvod>().ToTable("Proizvod");
            builder.Entity<Monitor>().ToTable("Monitor");
            builder.Entity<Kuciste>().ToTable("Kuciste");
            builder.Entity<Kupovina>().ToTable("Kupovina");
            builder.Entity<Disk>().ToTable("Disk");
            builder.Entity<SSD>().ToTable("SSD");
            builder.Entity<HardDisk>().ToTable("HardDisk");
            builder.Entity<ZvucnaKartica>().ToTable("Zvucna_Kartica");
            builder.Entity<Slusalice>().ToTable("Slusalice");
            builder.Entity<Tastatura>().ToTable("Tastatura");
            builder.Entity<Mis>().ToTable("Mis");
            builder.Entity<Memorija>().ToTable("Memorija");
            builder.Entity<Procesor>().ToTable("Procesor");

        }
    }
}
