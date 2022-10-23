using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DAL.models
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<KoronaTable> KoronaTables { get; set; }
        public virtual DbSet<Member> Members { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\Desktop\\8200 shiraChadad\\DB8200.mdf;Integrated Security=True;Connect Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<KoronaTable>(entity =>
            {
                entity.HasKey(e => e.MemberId)
                    .HasName("PK__tmp_ms_x__7FD7CFF61EC1C292");

                entity.ToTable("KoronaTable");

                entity.Property(e => e.MemberId)
                    .HasMaxLength(10)
                    .HasColumnName("memberID")
                    .IsFixedLength(true);

                entity.Property(e => e.MemberRecoveryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("memberRecoveryDate");

                entity.Property(e => e.MemberSickDate)
                    .HasColumnType("datetime")
                    .HasColumnName("memberSickDate");

                entity.Property(e => e.Vaccination1Date).HasColumnType("datetime");

                entity.Property(e => e.Vaccination1manufacturer).HasMaxLength(50);

                entity.Property(e => e.Vaccination2Date).HasColumnType("datetime");

                entity.Property(e => e.Vaccination2manufacturer).HasMaxLength(50);

                entity.Property(e => e.Vaccination3Date).HasColumnType("datetime");

                entity.Property(e => e.Vaccination3manufacturer).HasMaxLength(50);

                entity.Property(e => e.Vaccination4Date).HasColumnType("datetime");

                entity.Property(e => e.Vaccination4manufacturer).HasMaxLength(50);
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.ToTable("members");

                entity.Property(e => e.MemberId)
                    .HasMaxLength(10)
                    .HasColumnName("memberID")
                    .IsFixedLength(true);

                entity.Property(e => e.MemberAdress)
                    .HasMaxLength(50)
                    .HasColumnName("memberAdress")
                    .IsFixedLength(true);

                entity.Property(e => e.MemberBirthDate)
                    .HasColumnType("date")
                    .HasColumnName("memberBirthDate");

                entity.Property(e => e.MemberCity)
                    .HasMaxLength(50)
                    .HasColumnName("memberCity")
                    .IsFixedLength(true);

                entity.Property(e => e.MemberLastName)
                    .HasMaxLength(20)
                    .HasColumnName("memberLastName")
                    .IsFixedLength(true);

                entity.Property(e => e.MemberName)
                    .HasMaxLength(20)
                    .HasColumnName("memberName")
                    .IsFixedLength(true);

                entity.Property(e => e.MemberPhone)
                    .HasMaxLength(20)
                    .HasColumnName("memberPhone")
                    .IsFixedLength(true);

                entity.Property(e => e.MemberTel)
                    .HasMaxLength(20)
                    .HasColumnName("memberTel")
                    .IsFixedLength(true);

                entity.HasOne(d => d.MemberNavigation)
                    .WithOne(p => p.Member)
                    .HasForeignKey<Member>(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_members_ToTable");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
