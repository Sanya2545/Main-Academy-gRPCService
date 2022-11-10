using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace gRPCService.Models
{
    public partial class UnivercityDBContext : DbContext
    {
        public UnivercityDBContext()
        {
        }

        public UnivercityDBContext(DbContextOptions<UnivercityDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Faculty> Faculties { get; set; } = null!;
        public virtual DbSet<Lecture> Lectures { get; set; } = null!;
        public virtual DbSet<Room> Rooms { get; set; } = null!;
        public virtual DbSet<Sgroup> Sgroups { get; set; } = null!;
        public virtual DbSet<Subject> Subjects { get; set; } = null!;
        public virtual DbSet<Teacher> Teachers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server = ASUS-VIVOBOOK-P\\SASHASQLSERVER;Database=UnivercityDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DepPk)
                    .HasName("PK__DEPARTME__DB9D91F6F42F6C6B");

                entity.ToTable("DEPARTMENT");

                entity.Property(e => e.DepPk)
                    .ValueGeneratedNever()
                    .HasColumnName("DepPK");

                entity.Property(e => e.Building)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FacFk).HasColumnName("FacFK");

                entity.Property(e => e.HeadFk).HasColumnName("HeadFK");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.HeadFkNavigation)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.HeadFk)
                    .HasConstraintName("FK__DEPARTMEN__HeadF__4316F928");
            });

            modelBuilder.Entity<Faculty>(entity =>
            {
                entity.HasKey(e => e.FacPk)
                    .HasName("PK__FACULTY__81503CEC14A459F4");

                entity.ToTable("FACULTY");

                entity.Property(e => e.FacPk)
                    .ValueGeneratedNever()
                    .HasColumnName("FacPK");

                entity.Property(e => e.Building)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeanFk).HasColumnName("DeanFK");

                entity.Property(e => e.Fund).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.DeanFkNavigation)
                    .WithMany(p => p.Faculties)
                    .HasForeignKey(d => d.DeanFk)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__FACULTY__DeanFK__4222D4EF");
            });

            modelBuilder.Entity<Lecture>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LECTURE");

                entity.Property(e => e.Day)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GrpFk).HasColumnName("GrpFK");

                entity.Property(e => e.RomFk).HasColumnName("RomFK");

                entity.Property(e => e.SbjFk).HasColumnName("SbjFK");

                entity.Property(e => e.TchFk).HasColumnName("TchFK");

                entity.Property(e => e.Type)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Week).HasColumnName("week");

                entity.HasOne(d => d.GrpFkNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.GrpFk)
                    .HasConstraintName("FK__LECTURE__GrpFK__3E52440B");

                entity.HasOne(d => d.RomFkNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.RomFk)
                    .HasConstraintName("FK__LECTURE__RomFK__403A8C7D");

                entity.HasOne(d => d.SbjFkNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.SbjFk)
                    .HasConstraintName("FK__LECTURE__SbjFK__3F466844");

                entity.HasOne(d => d.TchFkNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.TchFk)
                    .HasConstraintName("FK__LECTURE__TchFK__3D5E1FD2");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.HasKey(e => e.RomPk)
                    .HasName("PK__ROOM__F9623FB2B8A37123");

                entity.ToTable("ROOM");

                entity.Property(e => e.RomPk)
                    .ValueGeneratedNever()
                    .HasColumnName("RomPK");

                entity.Property(e => e.Building)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Sgroup>(entity =>
            {
                entity.HasKey(e => e.GrpPk)
                    .HasName("PK__SGROUP__DE3C1454B6D2DF6F");

                entity.ToTable("SGROUP");

                entity.Property(e => e.GrpPk)
                    .ValueGeneratedNever()
                    .HasColumnName("GrpPK");

                entity.Property(e => e.DepFk).HasColumnName("DepFK");

                entity.HasOne(d => d.DepFkNavigation)
                    .WithMany(p => p.Sgroups)
                    .HasForeignKey(d => d.DepFk)
                    .HasConstraintName("FK__SGROUP__DepFK__2F10007B");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.HasKey(e => e.SbjPk)
                    .HasName("PK__SUBJECT__934B0E76D765EB4F");

                entity.ToTable("SUBJECT");

                entity.Property(e => e.SbjPk)
                    .ValueGeneratedNever()
                    .HasColumnName("SbjPK");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.HasKey(e => e.TchPk)
                    .HasName("PK__Teacher__5FD549BDF6455571");

                entity.ToTable("Teacher");

                entity.Property(e => e.TchPk)
                    .ValueGeneratedNever()
                    .HasColumnName("TchPK");

                entity.Property(e => e.DepFk).HasColumnName("DepFK");

                entity.Property(e => e.Hiredate).HasColumnType("date");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Post)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.DepFkNavigation)
                    .WithMany(p => p.Teachers)
                    .HasForeignKey(d => d.DepFk)
                    .HasConstraintName("FK__Teacher__DepFK__31EC6D26");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
