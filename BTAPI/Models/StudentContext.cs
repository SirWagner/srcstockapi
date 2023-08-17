using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Stocks.Domain.BSEntities.Base;

namespace BTAPI.Models;

public partial class StudentContext : DbContext
{
    public StudentContext()
    {
    }

    public StudentContext(DbContextOptions<StudentContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DocumentToCreate> DocumentToCreates { get; set; }

    public virtual DbSet<GenericHeaderProperty> GenericHeaderProperties { get; set; }

    public virtual DbSet<Artigo> Products { get; set; }

    public virtual DbSet<ProductType> ProductTypes { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Unit> Units { get; set; }

    public virtual DbSet<UnitItem> UnitItems { get; set; }

    public virtual DbSet<UserForLogin> UserForLogins { get; set; }

    public virtual DbSet<UserToCreate> UserToCreates { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:BTConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DocumentToCreate>(entity =>
        {
            entity.ToTable("DocumentToCreate");

            entity.Property(e => e.Data).HasColumnType("datetime");
            entity.Property(e => e.DataCriacao)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataUltimaActualizacao)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Serie).HasDefaultValueSql("(CONVERT([nvarchar](4),datepart(year,getdate())))");
            entity.Property(e => e.TipoEntidade)
                .HasMaxLength(1)
                .HasDefaultValueSql("('F')");
        });

        modelBuilder.Entity<GenericHeaderProperty>(entity =>
        {
            entity.Property(e => e.Data).HasColumnType("datetime");
            entity.Property(e => e.TipoEntidade).HasMaxLength(1);
        });

        modelBuilder.Entity<Artigo>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PK__Products__3214EC07E2DA638E");
        });

        modelBuilder.Entity<ProductType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ProductT__3214EC07F551E1C3");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Student__3214EC077FC5CA9B");

            entity.ToTable("Student");

            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Unit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Units__3214EC076B766D0F");
        });

        modelBuilder.Entity<UnitItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UnitItem__3214EC07B245AC15");

            entity.HasOne(d => d.Unit).WithMany(p => p.UnitItems)
                .HasForeignKey(d => d.UnitId)
                .HasConstraintName("FK__UnitItems__UnitI__5CD6CB2B");
        });

        modelBuilder.Entity<UserForLogin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserForL__3214EC07826B96B1");

            entity.ToTable("UserForLogin");
        });

        modelBuilder.Entity<UserToCreate>(entity =>
        {
            entity.ToTable("UserToCreate");

            entity.Property(e => e.Password).HasMaxLength(14);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
