using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BTAPI.Migrations
{
    /// <inheritdoc />
    public partial class completemigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AreaNegocio",
                columns: table => new
                {
                    codigo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ano = table.Column<short>(type: "smallint", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataUltimaActualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaNegocio", x => x.codigo);
                });

            migrationBuilder.CreateTable(
                name: "DocumentToCreate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArmazemOrigem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalizacaoOrigem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaNegocio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Projecto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipodoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NumDoc = table.Column<long>(type: "bigint", nullable: true),
                    NrDocExterno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Serie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoEntidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Entidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resumo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Anexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataUltimaActualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Utilizador = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentToCreate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entity",
                columns: table => new
                {
                    Codigo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(1)", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataUltimaActualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entity", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Filial",
                columns: table => new
                {
                    Codigo = table.Column<string>(type: "nvarchar(38)", maxLength: 38, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PorDefeito = table.Column<bool>(type: "bit", nullable: false),
                    Morada1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Morada2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Provincia = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Utilizador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataUltimaActualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filial", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Barcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Warehouse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projeto",
                columns: table => new
                {
                    Codigo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    TipoEntidade = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Entidade = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TipoEntidadeResponsavel = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    EntidadeResponsavel = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    DataConclusaoPrevista = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PrevisaoInicio = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocalExec = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TipoProjecto = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Referencia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Prioridade = table.Column<int>(type: "int", nullable: false),
                    Utilizador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataUltimaActualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projeto", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniqueIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataUltimaActualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Gender = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Student__3214EC077FC5CA9B", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoArtigo",
                columns: table => new
                {
                    Codigo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataUltimaActualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoArtigo", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "TipoDocumentos",
                columns: table => new
                {
                    Documento = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    ordem = table.Column<int>(type: "int", nullable: false),
                    visivelPaginaInicial = table.Column<bool>(type: "bit", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NomeAmigavelUtilizador = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AccaoGerada = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Classificacao = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    TipoArtigo = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Modulo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TemFiltroTipoArtigo = table.Column<bool>(type: "bit", nullable: false),
                    TemSelecaoArtigo = table.Column<bool>(type: "bit", nullable: false),
                    PermiteAdicaoArtigosNovos = table.Column<bool>(type: "bit", nullable: false),
                    DaArtigosEntidade = table.Column<bool>(type: "bit", nullable: false),
                    MovimentaStock = table.Column<bool>(type: "bit", nullable: false),
                    MovimentaStockEntidade = table.Column<bool>(type: "bit", nullable: false),
                    FiltraArtigoStock = table.Column<bool>(type: "bit", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataUltimaActualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDocumentos", x => x.Documento);
                });

            migrationBuilder.CreateTable(
                name: "Unidades",
                columns: table => new
                {
                    Codigo = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Arredondamento = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataUltimaActualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unidades", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "UnidadesConversao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnidadeOrigem = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    UnidadeDestino = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Formula = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    FactorConversao = table.Column<float>(type: "real", nullable: false),
                    UtilzaFormula = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadesConversao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Base = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Purchase = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserForLogin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserForLogin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserToCreate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserToCreate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarehouseItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Wharehouse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stock = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FuncionarioAreaNegocio",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Funcionario = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    AreaNegocio = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Supervisor = table.Column<bool>(type: "bit", nullable: false),
                    Director = table.Column<bool>(type: "bit", nullable: false),
                    Principal = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuncionarioAreaNegocio", x => x.id);
                    table.ForeignKey(
                        name: "FK_FuncionarioAreaNegocio_AreaNegocio_AreaNegocio",
                        column: x => x.AreaNegocio,
                        principalTable: "AreaNegocio",
                        principalColumn: "codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FuncionarioAreaNegocio_Entity_Funcionario",
                        column: x => x.Funcionario,
                        principalTable: "Entity",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Armazem",
                columns: table => new
                {
                    Codigo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Filial = table.Column<string>(type: "nvarchar(38)", maxLength: 38, nullable: false),
                    Morada1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Morada2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Provincia = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Utilizador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataUltimaActualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armazem", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_Armazem_Filial_Filial",
                        column: x => x.Filial,
                        principalTable: "Filial",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Utilizadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(48)", maxLength: 48, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(48)", maxLength: 48, nullable: false),
                    FilialId = table.Column<string>(type: "nvarchar(38)", maxLength: 38, nullable: false),
                    PhoneNumber1 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    PhoneNumber2 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    IsSuperAdmin = table.Column<bool>(type: "bit", nullable: true),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataUltimaActualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilizadores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Utilizadores_Filial_FilialId",
                        column: x => x.FilialId,
                        principalTable: "Filial",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EstadosArtigo",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TipoArtigo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    _TipoArtigoCodigo = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataUltimaActualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosArtigo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EstadosArtigo_TipoArtigo__TipoArtigoCodigo",
                        column: x => x._TipoArtigoCodigo,
                        principalTable: "TipoArtigo",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CabecInterno",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMigracao = table.Column<long>(type: "bigint", nullable: false),
                    ArmazemOrigem = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    IdDocumentoOrigem = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LocalizacaoOrigem = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    AreaNegocio = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Projecto = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Tipodoc = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumDoc = table.Column<long>(type: "bigint", nullable: false),
                    NrDocExterno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Serie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoEntidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Entidade = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdFornecedor = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Resumo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Anexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PathAnexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Utilizador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataUltimaActualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CabecInterno", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CabecInterno_AreaNegocio_AreaNegocio",
                        column: x => x.AreaNegocio,
                        principalTable: "AreaNegocio",
                        principalColumn: "codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CabecInterno_Entity_Entidade",
                        column: x => x.Entidade,
                        principalTable: "Entity",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CabecInterno_Entity_IdFornecedor",
                        column: x => x.IdFornecedor,
                        principalTable: "Entity",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CabecInterno_TipoDocumentos_Tipodoc",
                        column: x => x.Tipodoc,
                        principalTable: "TipoDocumentos",
                        principalColumn: "Documento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Documento_WorkFlow",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkFlow = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TipoDocumentoOrigem = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    TipoDocumentoDestino = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    EstadoDocumentoDestino = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CriacaoAutomatica = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documento_WorkFlow", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documento_WorkFlow_TipoDocumentos_TipoDocumentoOrigem",
                        column: x => x.TipoDocumentoOrigem,
                        principalTable: "TipoDocumentos",
                        principalColumn: "Documento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UnitItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitId = table.Column<int>(type: "int", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Conversion = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnitItem_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Warehouse",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Default = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalStock = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ItemsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Warehouse_WarehouseItem_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "WarehouseItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArmazemLocalizacoes",
                columns: table => new
                {
                    localizacao = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    armazem = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    activa = table.Column<bool>(type: "bit", nullable: true),
                    manual = table.Column<bool>(type: "bit", nullable: true),
                    nomeNivel = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataUltimaActualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Utilizador = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmazemLocalizacoes", x => x.localizacao);
                    table.ForeignKey(
                        name: "FK_ArmazemLocalizacoes_Armazem_armazem",
                        column: x => x.armazem,
                        principalTable: "Armazem",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Utilizadores_UserId",
                        column: x => x.UserId,
                        principalTable: "Utilizadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Artigo",
                columns: table => new
                {
                    Codigo = table.Column<string>(type: "nvarchar(48)", maxLength: 48, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CodBarras = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StkActual = table.Column<double>(type: "float", nullable: false),
                    TipoArtigo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    IdEstado = table.Column<short>(type: "smallint", nullable: true),
                    IdFornecedor = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataUltimaActualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artigo", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_Artigo_Entity_IdFornecedor",
                        column: x => x.IdFornecedor,
                        principalTable: "Entity",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Artigo_EstadosArtigo_IdEstado",
                        column: x => x.IdEstado,
                        principalTable: "EstadosArtigo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Artigo_TipoArtigo_TipoArtigo",
                        column: x => x.TipoArtigo,
                        principalTable: "TipoArtigo",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArtigoArmazem",
                columns: table => new
                {
                    Artigo = table.Column<string>(type: "nvarchar(48)", maxLength: 48, nullable: false),
                    Armazem_Defeito = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    StkActual = table.Column<float>(type: "real", nullable: false),
                    StkMinimo = table.Column<double>(type: "float", nullable: false),
                    StkMaximo = table.Column<double>(type: "float", nullable: false),
                    StkReposicao = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtigoArmazem", x => x.Artigo);
                    table.ForeignKey(
                        name: "FK_ArtigoArmazem_Armazem_Armazem_Defeito",
                        column: x => x.Armazem_Defeito,
                        principalTable: "Armazem",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtigoArmazem_Artigo_Artigo",
                        column: x => x.Artigo,
                        principalTable: "Artigo",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArtigoEntidade",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Artigo = table.Column<string>(type: "nvarchar(48)", maxLength: 48, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TipoEntidade = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Entidade = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Quantidade = table.Column<double>(type: "float", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    EstadoArtigo = table.Column<short>(type: "smallint", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataUltimaActualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: true),
                    Filial = table.Column<string>(type: "nvarchar(38)", maxLength: 38, nullable: false),
                    Armazem = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Localizacao = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtigoEntidade", x => x.id);
                    table.ForeignKey(
                        name: "FK_ArtigoEntidade_Armazem_Armazem",
                        column: x => x.Armazem,
                        principalTable: "Armazem",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtigoEntidade_Artigo_Artigo",
                        column: x => x.Artigo,
                        principalTable: "Artigo",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtigoEntidade_Entity_Entidade",
                        column: x => x.Entidade,
                        principalTable: "Entity",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtigoEntidade_EstadosArtigo_EstadoArtigo",
                        column: x => x.EstadoArtigo,
                        principalTable: "EstadosArtigo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ArtigoEntidade_Filial_Filial",
                        column: x => x.Filial,
                        principalTable: "Filial",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArtigoFornecedor",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Artigo = table.Column<string>(type: "nvarchar(48)", maxLength: 48, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TipoEntidade = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Entidade = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Estado = table.Column<short>(type: "smallint", nullable: true),
                    Armazem = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Localizacao = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ComFornecedor = table.Column<bool>(type: "bit", maxLength: 30, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataUltimaActualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtigoFornecedor", x => x.id);
                    table.ForeignKey(
                        name: "FK_ArtigoFornecedor_Armazem_Armazem",
                        column: x => x.Armazem,
                        principalTable: "Armazem",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtigoFornecedor_Artigo_Artigo",
                        column: x => x.Artigo,
                        principalTable: "Artigo",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtigoFornecedor_Entity_Entidade",
                        column: x => x.Entidade,
                        principalTable: "Entity",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArtigoProjecto",
                columns: table => new
                {
                    Artigo = table.Column<string>(type: "nvarchar(48)", maxLength: 48, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Projeto = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    EstadoArtigo = table.Column<short>(type: "smallint", nullable: false),
                    Armazem = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Localizacao = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataUltimaActualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtigoProjecto", x => x.Artigo);
                    table.ForeignKey(
                        name: "FK_ArtigoProjecto_Armazem_Armazem",
                        column: x => x.Armazem,
                        principalTable: "Armazem",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtigoProjecto_Artigo_Artigo",
                        column: x => x.Artigo,
                        principalTable: "Artigo",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtigoProjecto_EstadosArtigo_EstadoArtigo",
                        column: x => x.EstadoArtigo,
                        principalTable: "EstadosArtigo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtigoProjecto_Projeto_Projeto",
                        column: x => x.Projeto,
                        principalTable: "Projeto",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArtigoUnidades",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Artigo = table.Column<string>(type: "nvarchar(48)", maxLength: 48, nullable: false),
                    Base = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Venda = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Compra = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtigoUnidades", x => x.id);
                    table.ForeignKey(
                        name: "FK_ArtigoUnidades_Artigo_Artigo",
                        column: x => x.Artigo,
                        principalTable: "Artigo",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LinhasInterno",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMigracao = table.Column<long>(type: "bigint", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Notas = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    TipoReparacao = table.Column<short>(type: "smallint", nullable: true),
                    QuantidadeReparacao = table.Column<short>(type: "smallint", nullable: true),
                    Artigo = table.Column<string>(type: "nvarchar(48)", maxLength: 48, nullable: false),
                    Unidade = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    FactorConversao = table.Column<double>(type: "float", nullable: false),
                    EntradaSaida = table.Column<string>(type: "nvarchar(1)", nullable: true),
                    Armazem = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Filial = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Localizacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AreaNegocio = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Projecto = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    IdEstado = table.Column<short>(type: "smallint", nullable: true),
                    Quantidade = table.Column<double>(type: "float", nullable: false),
                    CabecInternoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Utilizador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataUltimaActualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinhasInterno", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LinhasInterno_AreaNegocio_AreaNegocio",
                        column: x => x.AreaNegocio,
                        principalTable: "AreaNegocio",
                        principalColumn: "codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LinhasInterno_Armazem_Armazem",
                        column: x => x.Armazem,
                        principalTable: "Armazem",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LinhasInterno_Armazem_Filial",
                        column: x => x.Filial,
                        principalTable: "Armazem",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LinhasInterno_Artigo_Artigo",
                        column: x => x.Artigo,
                        principalTable: "Artigo",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LinhasInterno_CabecInterno_CabecInternoId",
                        column: x => x.CabecInternoId,
                        principalTable: "CabecInterno",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LinhasInterno_EstadosArtigo_IdEstado",
                        column: x => x.IdEstado,
                        principalTable: "EstadosArtigo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinhasInterno_Projeto_Projecto",
                        column: x => x.Projecto,
                        principalTable: "Projeto",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LinhasInterno_Unidades_Unidade",
                        column: x => x.Unidade,
                        principalTable: "Unidades",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Linhas_ArtigoArmazem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Artigo = table.Column<string>(type: "nvarchar(48)", maxLength: 48, nullable: false),
                    Armazem = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    StkActual = table.Column<double>(type: "float", nullable: false),
                    ArtigoArmazemArtigo = table.Column<string>(type: "nvarchar(48)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Linhas_ArtigoArmazem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Linhas_ArtigoArmazem_Armazem_Armazem",
                        column: x => x.Armazem,
                        principalTable: "Armazem",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Linhas_ArtigoArmazem_ArtigoArmazem_ArtigoArmazemArtigo",
                        column: x => x.ArtigoArmazemArtigo,
                        principalTable: "ArtigoArmazem",
                        principalColumn: "Artigo");
                    table.ForeignKey(
                        name: "FK_Linhas_ArtigoArmazem_Artigo_Artigo",
                        column: x => x.Artigo,
                        principalTable: "Artigo",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Linhas_ArtigoUnidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_ArtigoUnidade = table.Column<int>(type: "int", nullable: false),
                    Artigo = table.Column<string>(type: "nvarchar(48)", maxLength: 48, nullable: false),
                    UnidadeOrigem = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    UnidadeDestino = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    UtilizaFormula = table.Column<bool>(type: "bit", nullable: false),
                    Formula = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    FactorConversao = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Linhas_ArtigoUnidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Linhas_ArtigoUnidades_ArtigoUnidades_Id_ArtigoUnidade",
                        column: x => x.Id_ArtigoUnidade,
                        principalTable: "ArtigoUnidades",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Linhas_ArtigoUnidades_Artigo_Artigo",
                        column: x => x.Artigo,
                        principalTable: "Artigo",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Linhas_ArtigoUnidades_Unidades_UnidadeDestino",
                        column: x => x.UnidadeDestino,
                        principalTable: "Unidades",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Linhas_ArtigoUnidades_Unidades_UnidadeOrigem",
                        column: x => x.UnidadeOrigem,
                        principalTable: "Unidades",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LinhasInternoStatus",
                columns: table => new
                {
                    IdLinhaInterno = table.Column<long>(type: "bigint", nullable: false),
                    Quantidade = table.Column<double>(type: "float", nullable: false),
                    QuantidadeTransformada = table.Column<double>(type: "float", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    QuantidadePendente = table.Column<double>(type: "float", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataUltimaActualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinhasInternoStatus", x => x.IdLinhaInterno);
                    table.ForeignKey(
                        name: "FK_LinhasInternoStatus_LinhasInterno_IdLinhaInterno",
                        column: x => x.IdLinhaInterno,
                        principalTable: "LinhasInterno",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Armazem_Filial",
                table: "Armazem",
                column: "Filial");

            migrationBuilder.CreateIndex(
                name: "IX_ArmazemLocalizacoes_armazem",
                table: "ArmazemLocalizacoes",
                column: "armazem");

            migrationBuilder.CreateIndex(
                name: "IX_Artigo_IdEstado",
                table: "Artigo",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_Artigo_IdFornecedor",
                table: "Artigo",
                column: "IdFornecedor");

            migrationBuilder.CreateIndex(
                name: "IX_Artigo_TipoArtigo",
                table: "Artigo",
                column: "TipoArtigo");

            migrationBuilder.CreateIndex(
                name: "IX_ArtigoArmazem_Armazem_Defeito",
                table: "ArtigoArmazem",
                column: "Armazem_Defeito");

            migrationBuilder.CreateIndex(
                name: "IX_ArtigoEntidade_Armazem",
                table: "ArtigoEntidade",
                column: "Armazem");

            migrationBuilder.CreateIndex(
                name: "IX_ArtigoEntidade_Artigo",
                table: "ArtigoEntidade",
                column: "Artigo");

            migrationBuilder.CreateIndex(
                name: "IX_ArtigoEntidade_Entidade",
                table: "ArtigoEntidade",
                column: "Entidade");

            migrationBuilder.CreateIndex(
                name: "IX_ArtigoEntidade_EstadoArtigo",
                table: "ArtigoEntidade",
                column: "EstadoArtigo");

            migrationBuilder.CreateIndex(
                name: "IX_ArtigoEntidade_Filial",
                table: "ArtigoEntidade",
                column: "Filial");

            migrationBuilder.CreateIndex(
                name: "IX_ArtigoFornecedor_Armazem",
                table: "ArtigoFornecedor",
                column: "Armazem");

            migrationBuilder.CreateIndex(
                name: "IX_ArtigoFornecedor_Artigo",
                table: "ArtigoFornecedor",
                column: "Artigo");

            migrationBuilder.CreateIndex(
                name: "IX_ArtigoFornecedor_Entidade",
                table: "ArtigoFornecedor",
                column: "Entidade");

            migrationBuilder.CreateIndex(
                name: "IX_ArtigoProjecto_Armazem",
                table: "ArtigoProjecto",
                column: "Armazem");

            migrationBuilder.CreateIndex(
                name: "IX_ArtigoProjecto_EstadoArtigo",
                table: "ArtigoProjecto",
                column: "EstadoArtigo");

            migrationBuilder.CreateIndex(
                name: "IX_ArtigoProjecto_Projeto",
                table: "ArtigoProjecto",
                column: "Projeto");

            migrationBuilder.CreateIndex(
                name: "IX_ArtigoUnidades_Artigo",
                table: "ArtigoUnidades",
                column: "Artigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CabecInterno_AreaNegocio",
                table: "CabecInterno",
                column: "AreaNegocio");

            migrationBuilder.CreateIndex(
                name: "IX_CabecInterno_Entidade",
                table: "CabecInterno",
                column: "Entidade");

            migrationBuilder.CreateIndex(
                name: "IX_CabecInterno_IdFornecedor",
                table: "CabecInterno",
                column: "IdFornecedor");

            migrationBuilder.CreateIndex(
                name: "IX_CabecInterno_Tipodoc",
                table: "CabecInterno",
                column: "Tipodoc");

            migrationBuilder.CreateIndex(
                name: "IX_Documento_WorkFlow_TipoDocumentoOrigem",
                table: "Documento_WorkFlow",
                column: "TipoDocumentoOrigem");

            migrationBuilder.CreateIndex(
                name: "IX_EstadosArtigo__TipoArtigoCodigo",
                table: "EstadosArtigo",
                column: "_TipoArtigoCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_FuncionarioAreaNegocio_AreaNegocio",
                table: "FuncionarioAreaNegocio",
                column: "AreaNegocio");

            migrationBuilder.CreateIndex(
                name: "IX_FuncionarioAreaNegocio_Funcionario",
                table: "FuncionarioAreaNegocio",
                column: "Funcionario");

            migrationBuilder.CreateIndex(
                name: "IX_Linhas_ArtigoArmazem_Armazem",
                table: "Linhas_ArtigoArmazem",
                column: "Armazem");

            migrationBuilder.CreateIndex(
                name: "IX_Linhas_ArtigoArmazem_Artigo",
                table: "Linhas_ArtigoArmazem",
                column: "Artigo");

            migrationBuilder.CreateIndex(
                name: "IX_Linhas_ArtigoArmazem_ArtigoArmazemArtigo",
                table: "Linhas_ArtigoArmazem",
                column: "ArtigoArmazemArtigo");

            migrationBuilder.CreateIndex(
                name: "IX_Linhas_ArtigoUnidades_Artigo",
                table: "Linhas_ArtigoUnidades",
                column: "Artigo");

            migrationBuilder.CreateIndex(
                name: "IX_Linhas_ArtigoUnidades_Id_ArtigoUnidade",
                table: "Linhas_ArtigoUnidades",
                column: "Id_ArtigoUnidade",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Linhas_ArtigoUnidades_UnidadeDestino",
                table: "Linhas_ArtigoUnidades",
                column: "UnidadeDestino");

            migrationBuilder.CreateIndex(
                name: "IX_Linhas_ArtigoUnidades_UnidadeOrigem",
                table: "Linhas_ArtigoUnidades",
                column: "UnidadeOrigem");

            migrationBuilder.CreateIndex(
                name: "IX_LinhasInterno_AreaNegocio",
                table: "LinhasInterno",
                column: "AreaNegocio");

            migrationBuilder.CreateIndex(
                name: "IX_LinhasInterno_Armazem",
                table: "LinhasInterno",
                column: "Armazem");

            migrationBuilder.CreateIndex(
                name: "IX_LinhasInterno_Artigo",
                table: "LinhasInterno",
                column: "Artigo");

            migrationBuilder.CreateIndex(
                name: "IX_LinhasInterno_CabecInternoId",
                table: "LinhasInterno",
                column: "CabecInternoId");

            migrationBuilder.CreateIndex(
                name: "IX_LinhasInterno_Filial",
                table: "LinhasInterno",
                column: "Filial");

            migrationBuilder.CreateIndex(
                name: "IX_LinhasInterno_IdEstado",
                table: "LinhasInterno",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_LinhasInterno_Projecto",
                table: "LinhasInterno",
                column: "Projecto");

            migrationBuilder.CreateIndex(
                name: "IX_LinhasInterno_Unidade",
                table: "LinhasInterno",
                column: "Unidade");

            migrationBuilder.CreateIndex(
                name: "IX_UnitItem_UnitId",
                table: "UnitItem",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Utilizadores_FilialId",
                table: "Utilizadores",
                column: "FilialId");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouse_ItemsId",
                table: "Warehouse",
                column: "ItemsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArmazemLocalizacoes");

            migrationBuilder.DropTable(
                name: "ArtigoEntidade");

            migrationBuilder.DropTable(
                name: "ArtigoFornecedor");

            migrationBuilder.DropTable(
                name: "ArtigoProjecto");

            migrationBuilder.DropTable(
                name: "Documento_WorkFlow");

            migrationBuilder.DropTable(
                name: "DocumentToCreate");

            migrationBuilder.DropTable(
                name: "FuncionarioAreaNegocio");

            migrationBuilder.DropTable(
                name: "Linhas_ArtigoArmazem");

            migrationBuilder.DropTable(
                name: "Linhas_ArtigoUnidades");

            migrationBuilder.DropTable(
                name: "LinhasInternoStatus");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "UnidadesConversao");

            migrationBuilder.DropTable(
                name: "UnitItem");

            migrationBuilder.DropTable(
                name: "UserForLogin");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserToCreate");

            migrationBuilder.DropTable(
                name: "Warehouse");

            migrationBuilder.DropTable(
                name: "ArtigoArmazem");

            migrationBuilder.DropTable(
                name: "ArtigoUnidades");

            migrationBuilder.DropTable(
                name: "LinhasInterno");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Utilizadores");

            migrationBuilder.DropTable(
                name: "WarehouseItem");

            migrationBuilder.DropTable(
                name: "Armazem");

            migrationBuilder.DropTable(
                name: "Artigo");

            migrationBuilder.DropTable(
                name: "CabecInterno");

            migrationBuilder.DropTable(
                name: "Projeto");

            migrationBuilder.DropTable(
                name: "Unidades");

            migrationBuilder.DropTable(
                name: "Filial");

            migrationBuilder.DropTable(
                name: "EstadosArtigo");

            migrationBuilder.DropTable(
                name: "AreaNegocio");

            migrationBuilder.DropTable(
                name: "Entity");

            migrationBuilder.DropTable(
                name: "TipoDocumentos");

            migrationBuilder.DropTable(
                name: "TipoArtigo");
        }
    }
}
