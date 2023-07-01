using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace GonpaPasaportOtomasyonu.Models
{
    public partial class PassportDBContext : DbContext
    {
        public PassportDBContext()
        {
        }

        public PassportDBContext(DbContextOptions<PassportDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Batches> Batches { get; set; }
        public virtual DbSet<PassportDetails> PassportDetails { get; set; }
        public virtual DbSet<Temporary> Temporary { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conString= GonpaPasaportOtomasyonu.Properties.Settings.Default.DBConnectionString;
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseSqlServer(@"Server=DESKTOP-HSU933P\SQLEXPRESS; Uid=sa; Password=Sb123456; Database=PassportDB; TrustServerCertificate=True");
                optionsBuilder.UseSqlServer(conString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PassportDetails>(entity =>
            {
                entity.Property(e => e.State).HasDefaultValueSql("((0))");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
