﻿// <auto-generated />
using System;
using Bank.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bank.Infrastructure.Migrations
{
    [DbContext(typeof(BankContext))]
    [Migration("20200125003713_SoftremiiTestBentsa.Bank.Infrastructure.EntityFrameworkDataAccess.ContextFactory")]
    partial class SoftremiiTestBentsaBankInfrastructureEntityFrameworkDataAccessContextFactory
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Bank.Infrastructure.Entities.Client", b =>
                {
                    b.Property<Guid>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CompId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientId");

                    b.HasIndex("CompId");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("Bank.Infrastructure.Entities.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("Bank.Infrastructure.Entities.Client", b =>
                {
                    b.HasOne("Bank.Infrastructure.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompId");
                });
#pragma warning restore 612, 618
        }
    }
}