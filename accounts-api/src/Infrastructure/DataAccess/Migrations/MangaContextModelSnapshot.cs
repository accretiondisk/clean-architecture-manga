﻿// <auto-generated />

namespace Infrastructure.DataAccess.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Infrastructure;
    using Microsoft.EntityFrameworkCore.Metadata;

    [DbContext(typeof(MangaContext))]
    internal class MangaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Accounts.Account", b =>
            {
                b.Property<Guid>("AccountId")
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("Currency")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("ExternalUserId")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("AccountId");

                b.ToTable("Account");

                b.HasData(
                    new
                    {
                        AccountId = new Guid("4c510cfe-5d61-4a46-a3d9-c4313426655f"),
                        Currency = "USD",
                        ExternalUserId = "197d0438-e04b-453d-b5de-eca05960c6ae"
                    });
            });

            modelBuilder.Entity("Domain.Accounts.Credits.Credit", b =>
            {
                b.Property<Guid>("CreditId")
                    .HasColumnType("uniqueidentifier");

                b.Property<Guid>("AccountId")
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("Currency")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("TransactionDate")
                    .HasColumnType("datetime2");

                b.Property<decimal>("Value")
                    .HasColumnType("decimal(18,2)");

                b.HasKey("CreditId");

                b.HasIndex("AccountId");

                b.ToTable("Credit");

                b.HasData(
                    new
                    {
                        CreditId = new Guid("7bf066ba-379a-4e72-a59b-9755fda432ce"),
                        AccountId = new Guid("4c510cfe-5d61-4a46-a3d9-c4313426655f"),
                        Currency = "USD",
                        TransactionDate = new DateTime(2020, 8, 21, 6, 43, 4, 92, DateTimeKind.Utc).AddTicks(7795),
                        Value = 400m
                    });
            });

            modelBuilder.Entity("Domain.Accounts.Debits.Debit", b =>
            {
                b.Property<Guid>("DebitId")
                    .HasColumnType("uniqueidentifier");

                b.Property<Guid>("AccountId")
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("Currency")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("TransactionDate")
                    .HasColumnType("datetime2");

                b.Property<decimal>("Value")
                    .HasColumnType("decimal(18,2)");

                b.HasKey("DebitId");

                b.HasIndex("AccountId");

                b.ToTable("Debit");

                b.HasData(
                    new
                    {
                        DebitId = new Guid("31ade963-bd69-4afb-9df7-611ae2cfa651"),
                        AccountId = new Guid("4c510cfe-5d61-4a46-a3d9-c4313426655f"),
                        Currency = "USD",
                        TransactionDate = new DateTime(2020, 8, 21, 6, 43, 4, 93, DateTimeKind.Utc).AddTicks(301),
                        Value = 400m
                    });
            });

            modelBuilder.Entity("Domain.Accounts.Credits.Credit", b =>
            {
                b.HasOne("Domain.Accounts.Account", "Account")
                    .WithMany("CreditsCollection")
                    .HasForeignKey("AccountId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("Domain.Accounts.Debits.Debit", b =>
            {
                b.HasOne("Domain.Accounts.Account", "Account")
                    .WithMany("DebitsCollection")
                    .HasForeignKey("AccountId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });
#pragma warning restore 612, 618
        }
    }
}