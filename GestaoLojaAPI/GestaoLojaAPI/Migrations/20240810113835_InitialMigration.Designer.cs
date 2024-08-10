﻿// <auto-generated />
using System;
using GestaoLojaAPI.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestaoLojaAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240810113835_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.7");

            modelBuilder.Entity("GestaoLojaAPI.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apelido")
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<string>("Bairro")
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<int>("Cep")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cidade")
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EstaDevendo")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Nascimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<string>("NumeroResidencia")
                        .HasMaxLength(80)
                        .HasColumnType("TEXT");

                    b.Property<string>("Rua")
                        .HasMaxLength(80)
                        .HasColumnType("TEXT");

                    b.Property<int>("Telefone")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("ValorDivida")
                        .HasColumnType("TEXT");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("GestaoLojaAPI.Models.Pedido", b =>
                {
                    b.Property<int>("PedidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataPedido")
                        .HasColumnType("TEXT");

                    b.HasKey("PedidoId");

                    b.HasIndex("ClienteId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("GestaoLojaAPI.Models.Produto", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Genero")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<int>("Idade")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<int?>("PedidoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Status")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ValorAtacado")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ValorFinal")
                        .HasColumnType("TEXT");

                    b.HasKey("ProdutoId");

                    b.HasIndex("PedidoId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("GestaoLojaAPI.Models.Pedido", b =>
                {
                    b.HasOne("GestaoLojaAPI.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("GestaoLojaAPI.Models.Produto", b =>
                {
                    b.HasOne("GestaoLojaAPI.Models.Pedido", null)
                        .WithMany("Produtos")
                        .HasForeignKey("PedidoId");
                });

            modelBuilder.Entity("GestaoLojaAPI.Models.Pedido", b =>
                {
                    b.Navigation("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
