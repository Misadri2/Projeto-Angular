﻿// <auto-generated />
using System;
using Desafio_API_GFT.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Desafio_API_GFT.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210602223917_AlterarEntities")]
    partial class AlterarEntities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Desafio_API_GFT.Models.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("IdCliente");

                    b.ToTable("Cliente");

                    b.HasData(
                        new
                        {
                            IdCliente = 1,
                            CPF = "174.133.260-51",
                            Email = "joao@cliente.com",
                            Endereco = "Avenida Brasil 160, Centro, Águas de Lindóia, SP, cep 13940-970",
                            Nome = "Joao",
                            Telefone = "11 99887766"
                        },
                        new
                        {
                            IdCliente = 2,
                            CPF = "168.635.238-76",
                            Email = "maria@cliente.com",
                            Endereco = "Avenida Independência 160, Centro, Jacarei, SP, cep 15660-970",
                            Nome = "Maria",
                            Telefone = "11 99557766"
                        });
                });

            modelBuilder.Entity("Desafio_API_GFT.Models.Compra", b =>
                {
                    b.Property<int>("IdCompra")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("FornecedorId")
                        .HasColumnType("int");

                    b.HasKey("IdCompra");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Compra");

                    b.HasData(
                        new
                        {
                            IdCompra = 1,
                            FornecedorId = 1
                        },
                        new
                        {
                            IdCompra = 2,
                            FornecedorId = 2
                        });
                });

            modelBuilder.Entity("Desafio_API_GFT.Models.Estoque", b =>
                {
                    b.Property<int>("IdEstoque")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ProdutoEstoque")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("QuantidadeEstoque")
                        .HasColumnType("int");

                    b.HasKey("IdEstoque");

                    b.ToTable("Estoque");

                    b.HasData(
                        new
                        {
                            IdEstoque = 1,
                            ProdutoEstoque = "Dolly Guaraná",
                            QuantidadeEstoque = 100
                        },
                        new
                        {
                            IdEstoque = 2,
                            ProdutoEstoque = "Fantas",
                            QuantidadeEstoque = 150
                        });
                });

            modelBuilder.Entity("Desafio_API_GFT.Models.Fornecedor", b =>
                {
                    b.Property<int>("IdFornecedor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CNPJ")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("IdFornecedor");

                    b.ToTable("Fornecedor");

                    b.HasData(
                        new
                        {
                            IdFornecedor = 1,
                            CNPJ = "11.815.158/0001-36",
                            Email = "fornecedor@dolly.com",
                            Endereco = "Avenida Paulista, 2000, Centro, São Paulo, SP, cep 02764-010",
                            Nome = "Dolly",
                            Telefone = "11-9988-7766"
                        },
                        new
                        {
                            IdFornecedor = 2,
                            CNPJ = "14.878.074/0001-30",
                            Email = "fornecedor@ambev.com",
                            Endereco = "Beco do Miro, 2000, Mangueira, Rio de Janeiro, RJ, cep 20911-138",
                            Nome = "Ambev",
                            Telefone = "11-9668-7766"
                        });
                });

            modelBuilder.Entity("Desafio_API_GFT.Models.ItemCompra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CompraId")
                        .HasColumnType("int");

                    b.Property<string>("Produto")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<float>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CompraId");

                    b.ToTable("ItemCompra");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompraId = 1,
                            Produto = "Fanta",
                            Quantidade = 75,
                            Valor = 6.5f
                        },
                        new
                        {
                            Id = 2,
                            CompraId = 1,
                            Produto = "FantaUva",
                            Quantidade = 75,
                            Valor = 6f
                        },
                        new
                        {
                            Id = 3,
                            CompraId = 2,
                            Produto = "DollyGuaraná",
                            Quantidade = 100,
                            Valor = 5.5f
                        });
                });

            modelBuilder.Entity("Desafio_API_GFT.Models.ItemVenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Produto")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<float>("Valor")
                        .HasColumnType("float");

                    b.Property<int>("VendaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VendaId");

                    b.ToTable("ItemVenda");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Produto = "Fanta",
                            Quantidade = 10,
                            Valor = 10f,
                            VendaId = 1
                        },
                        new
                        {
                            Id = 2,
                            Produto = "FantaUva",
                            Quantidade = 10,
                            Valor = 10f,
                            VendaId = 1
                        },
                        new
                        {
                            Id = 3,
                            Produto = "DollyGuaraná",
                            Quantidade = 10,
                            Valor = 8f,
                            VendaId = 2
                        });
                });

            modelBuilder.Entity("Desafio_API_GFT.Models.Produto", b =>
                {
                    b.Property<int>("IdProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("EstoqueId")
                        .HasColumnType("int");

                    b.Property<string>("Unidade")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("IdProduto");

                    b.HasIndex("EstoqueId");

                    b.ToTable("Produto");

                    b.HasData(
                        new
                        {
                            IdProduto = 1,
                            Descricao = "DollyGuaraná",
                            EstoqueId = 1,
                            Unidade = "UN"
                        },
                        new
                        {
                            IdProduto = 2,
                            Descricao = "FantaLaranja",
                            EstoqueId = 2,
                            Unidade = "UN"
                        },
                        new
                        {
                            IdProduto = 3,
                            Descricao = "FantaUva",
                            EstoqueId = 2,
                            Unidade = "UN"
                        });
                });

            modelBuilder.Entity("Desafio_API_GFT.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Senha")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("TypeUser")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Usuario");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "adm@admin.com",
                            Senha = "GFT2021",
                            TypeUser = 0
                        },
                        new
                        {
                            Id = 2,
                            Email = "Cliente@cliente.com",
                            Senha = "GFT2021",
                            TypeUser = 1
                        });
                });

            modelBuilder.Entity("Desafio_API_GFT.Models.Venda", b =>
                {
                    b.Property<int>("IdVenda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("IdVenda");

                    b.HasIndex("ClienteId");

                    b.ToTable("Venda");

                    b.HasData(
                        new
                        {
                            IdVenda = 1,
                            ClienteId = 1,
                            Status = 0
                        },
                        new
                        {
                            IdVenda = 2,
                            ClienteId = 2,
                            Status = 0
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Value")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Desafio_API_GFT.Models.Compra", b =>
                {
                    b.HasOne("Desafio_API_GFT.Models.Fornecedor", "Fornecedor")
                        .WithMany("Compras")
                        .HasForeignKey("FornecedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Desafio_API_GFT.Models.ItemCompra", b =>
                {
                    b.HasOne("Desafio_API_GFT.Models.Compra", "Compra")
                        .WithMany("ItensCompras")
                        .HasForeignKey("CompraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Desafio_API_GFT.Models.ItemVenda", b =>
                {
                    b.HasOne("Desafio_API_GFT.Models.Venda", "Venda")
                        .WithMany("ItensVendas")
                        .HasForeignKey("VendaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Desafio_API_GFT.Models.Produto", b =>
                {
                    b.HasOne("Desafio_API_GFT.Models.Estoque", "Estoque")
                        .WithMany("Produtos")
                        .HasForeignKey("EstoqueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Desafio_API_GFT.Models.Venda", b =>
                {
                    b.HasOne("Desafio_API_GFT.Models.Cliente", "Cliente")
                        .WithMany("Vendas")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
