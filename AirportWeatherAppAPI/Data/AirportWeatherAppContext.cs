using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AirportWeatherAppAPI.Data;

public partial class AirportWeatherAppContext : DbContext
{


    public AirportWeatherAppContext(DbContextOptions<AirportWeatherAppContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Alert> Alerts { get; set; }

    public virtual DbSet<Feedback> Feedbacks { get; set; }

    public virtual DbSet<Observation> Observations { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<WeatherDataOrg> WeatherDataOrgs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Alert>(entity =>
        {
            entity.HasKey(e => e.AlertId).HasName("PK__Alerts__EBB16AED37EB1ED3");

            entity.Property(e => e.AlertId).HasColumnName("AlertID");
            entity.Property(e => e.CommunicationText).HasMaxLength(255);
            entity.Property(e => e.ObservationId).HasColumnName("ObservationID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Observation).WithMany(p => p.Alerts)
                .HasForeignKey(d => d.ObservationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Alerts__Observat__412EB0B6");

            entity.HasOne(d => d.User).WithMany(p => p.Alerts)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Alerts__UserID__403A8C7D");
        });

        modelBuilder.Entity<Feedback>(entity =>
        {
            entity.HasKey(e => e.FeedbackId).HasName("PK__Feedback__6A4BEDF604FA67AE");

            entity.ToTable("Feedback");

            entity.Property(e => e.FeedbackId).HasColumnName("FeedbackID");
            entity.Property(e => e.Timestamp).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.Feedbacks)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Feedback__UserID__440B1D61");
        });

        modelBuilder.Entity<Observation>(entity =>
        {
            entity.HasKey(e => e.ObservationId).HasName("PK__Observat__420EA5C7EEE19CAB");

            entity.Property(e => e.ObservationId).HasColumnName("ObservationID");
            entity.Property(e => e.Descriptor).HasMaxLength(100);
            entity.Property(e => e.OrgId).HasColumnName("OrgID");
            entity.Property(e => e.Temperature).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Timestamp).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Visibility).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.WindDirection).HasMaxLength(50);
            entity.Property(e => e.WindSpeed).HasColumnType("decimal(5, 2)");

            entity.HasOne(d => d.Org).WithMany(p => p.Observations)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Observati__OrgID__3D5E1FD2");

            entity.HasOne(d => d.User).WithMany(p => p.Observations)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Observati__UserI__3C69FB99");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CCAC3D155842");

            entity.HasIndex(e => e.Email, "UQ__Users__A9D1053457AD2EA5").IsUnique();

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<WeatherDataOrg>(entity =>
        {
            entity.HasKey(e => e.OrgId).HasName("PK__WeatherD__420C9E0C4E72B995");

            entity.ToTable("WeatherDataOrg");

            entity.Property(e => e.OrgId).HasColumnName("OrgID");
            entity.Property(e => e.OrgName).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
