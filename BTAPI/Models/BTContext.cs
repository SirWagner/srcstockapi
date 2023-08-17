using Microsoft.EntityFrameworkCore;
using Stocks.Core.DTOs;
using Stocks.Domain.BSEntities;
using Stocks.Domain.BSEntities.Base;
using Stocks.Domain.BSEntities.HR;
using Stocks.Domain.BSEntities.Internal;
using Stocks.Domain.BSEntities.Inventory;

namespace BTAPI.Models;

public partial class BTContext : DbContext
{
    public BTContext()
    {
    }

    public BTContext(DbContextOptions<BTContext> options)
        : base(options)
    {
    }


    public virtual DbSet<Warehouse> Warehouse { get; set; }
    public virtual DbSet<Unit> Units { get; set; }
    public virtual DbSet<CabecInterno> CabecInterno { get; set; }
    //public virtual DbSet<Projeto> Projeto { get; set; }
    public  DbSet<Artigo> Product { get; set; }
    //public virtual DbSet<ArmazemLocalizacoes> ArmazemLocalizacoes { get; set; }
    //public virtual DbSet<Entity> Entity { get; set; }
    public virtual DbSet<Funcionario> Funcionario { get; set; }
    //public virtual DbSet<AreaNegocio> AreaNegocio { get; set; }
    //public virtual DbSet<Funcionario> Funcionario { get; set; }
    //public virtual DbSet<Filial> Filial { get; set; }
    public virtual DbSet<UserToCreate> UserToCreate { get; set; }
    public virtual DbSet<UserForLogin> UserForLogin { get; set; }
    public virtual DbSet<DocumentToCreate> DocumentToCreate { get; set; }
    public virtual DbSet<ArmazemLocalizacoes> ArmazemLocalizacoes { get; set; }
    public virtual DbSet<Entity> Entity { get; set; }

    public DbSet<Funcionario> Funcionarios { get; set; }
    public DbSet<Projeto> Projeto { get; set; }
    public DbSet<Filial> Filial { get; set; }
    public DbSet<AreaNegocio> AreaNegocio { get; set; }
    public DbSet<TipoDocumento> TipoDocumentos { get; set; }
    //public DbSet<Formulario> Formularios { get; set; }


    #region RH
    public DbSet<FuncionarioAreaNegocio> FuncionarioAreaNegocio { get; set; }
    #endregion
    public DbSet<Utilizador> Utilizadores { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }
    public DbSet<UnidadesConversao> UnidadesConversao { get; set; }
    //public DbSet<ArtigoFuncionario> ArtigoFuncionario { get; set; }

    #region Documentos
    public DbSet<Documento_WorkFlow> Documento_WorkFlow { get; set; }
    #endregion

    #region Gestão de Stock
    public DbSet<Artigo> Artigo { get; set; }
    public DbSet<ArtigoEntidade> ArtigoEntidade { get; set; }
    public DbSet<ArtigoFornecedor> ArtigoFornecedor { get; set; }
    public DbSet<ArtigoProjecto> ArtigoProjecto { get; set; }
    public DbSet<Unidades> Unidades { get; set; }
    public DbSet<ArtigoUnidades> ArtigoUnidades { get; set; }
    public DbSet<Linhas_ArtigoUnidades> Linhas_ArtigoUnidades { get; set; }
    public DbSet<ArtigoArmazem> ArtigoArmazem { get; set; }
    public DbSet<Linhas_ArtigoArmazem> Linhas_ArtigoArmazem { get; set; }
    
    public DbSet<LinhaInterno> LinhasInterno { get; set; }
    public DbSet<LinhaInternoStatus> LinhasInternoStatus { get; set; }
    public DbSet<Armazem> Armazem { get; set; }

    public DbSet<EstadoArtigo> EstadosArtigo { get; set; }
    public DbSet<Fornecedor> Fornecedores { get; set; }
    public DbSet<TipoArtigo> TipoArtigo { get; set; }
    //public DbSet<INV_ValoresActuaisStock> INV_ValoresActuaisStock { get; set; }
    //public DbSet<INV_Movimentos> INV_Movimentos { get; set; }
    //public DbSet<ArtigoProjeto> ArtigoProjeto { get; set; }
    #endregion








    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:BTConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserToCreate>(entity =>
        {
            entity.Ignore(e => e.PasswordHash); // Ignore the PasswordHash property
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

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
