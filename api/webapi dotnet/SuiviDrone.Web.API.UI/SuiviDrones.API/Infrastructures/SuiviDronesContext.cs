using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SuiviDrones.API.Models;

namespace SuiviDrones.API.Infrastructures
{
    public partial class SuiviDronesContext : DbContext
    {
        public SuiviDronesContext()
        {
        }

        public SuiviDronesContext(DbContextOptions<SuiviDronesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; } = null!;

        public virtual DbSet<Drone> Drones { get; set; } = null!;
        public virtual DbSet<DroneHealthStatus> DroneHealthStatuses { get; set; } = null!;
        public virtual DbSet<DroneHistory> DroneHistories { get; set; } = null!;
        public virtual DbSet<DroneType> DroneTypes { get; set; } = null!;
        public virtual DbSet<HealthReason> HealthReasons { get; set; } = null!;
        public virtual DbSet<HealthStatus> HealthStatuses { get; set; } = null!;
        public virtual DbSet<Status> Statuses { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Drone>(entity =>
            {
                entity.ToTable("Drone");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DroneTypeId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HealthStatusId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Matricule)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.DroneType)
                    .WithMany(p => p.Drones)
                    .HasForeignKey(d => d.DroneTypeId)
                    .HasConstraintName("FK_Drone_DroneType");
            });

            modelBuilder.Entity<DroneHealthStatus>(entity =>
            {
                entity.HasKey(e => new { e.DroneId, e.HealthStatusId, e.Date });

                entity.ToTable("DroneHealthStatus");

                entity.Property(e => e.DroneId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HealthStatusId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.HealthReasonId).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Drone)
                    .WithMany(p => p.DroneHealthStatuses)
                    .HasForeignKey(d => d.DroneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DroneHealthStatus_Drone");

                entity.HasOne(d => d.HealthReason)
                    .WithMany(p => p.DroneHealthStatuses)
                    .HasForeignKey(d => d.HealthReasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DroneHealthStatus_HealthReason");

                entity.HasOne(d => d.HealthStatus)
                    .WithMany(p => p.DroneHealthStatuses)
                    .HasForeignKey(d => d.HealthStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DroneHealthStatus_HealthStatus");
            });

            modelBuilder.Entity<DroneHistory>(entity =>
            {
                entity.ToTable("DroneHistory");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DroneId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.StatusId).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Drone)
                    .WithMany(p => p.DroneHistories)
                    .HasForeignKey(d => d.DroneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DroneHistory_Drone");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.DroneHistories)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DroneHistory_State");
            });

            modelBuilder.Entity<DroneType>(entity =>
            {
                entity.ToTable("DroneType");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HealthReason>(entity =>
            {
                entity.ToTable("HealthReason");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HealthStatus>(entity =>
            {
                entity.ToTable("HealthStatus");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("Status");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("AspNetUsers");
                entity.Ignore(item => item.Token);
                entity.Ignore(item => item.Password);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
