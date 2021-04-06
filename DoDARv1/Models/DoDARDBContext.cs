using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DoDARv1.Models
{
    public partial class DoDARDBContext : DbContext
    {
        public DoDARDBContext()
        {
        }

        public DoDARDBContext(DbContextOptions<DoDARDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectsV13;Initial Catalog=DoDARDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Request>(entity =>
            {
                entity.HasKey(e => e.Uic)
                    .HasName("PK__Request__C5B19603098517F4");

                entity.ToTable("Request");

                entity.Property(e => e.Uic)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UIC");

                entity.Property(e => e.DateIn)
                    .HasColumnType("date")
                    .HasColumnName("DATE IN");

                entity.Property(e => e.RegularType).HasColumnName("Regular Type");

                entity.Property(e => e.Serial)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialType).HasColumnName("Special Type");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Dodid)
                    .HasName("PK__User__CFE0CA844FE9C6DE");

                entity.ToTable("User");

                entity.Property(e => e.Dodid)
                    .ValueGeneratedNever()
                    .HasColumnName("DODID");

                entity.Property(e => e.Ao).HasColumnName("AO");

                entity.Property(e => e.CommandName)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("Command Name");

                entity.Property(e => e.Email)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("First Name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("Last Name");

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Middle Name");

                entity.Property(e => e.Phone)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Rank)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Uic)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UIC");

                entity.HasOne(d => d.UicNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.Uic)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_USER_REQUEST_UIC");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
