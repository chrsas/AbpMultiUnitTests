﻿// <auto-generated />

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Sdt.Dcs.EntityFrameworkCore;

namespace Sdt.Dcs.Migrations
{
    [DbContext(typeof(DcsDbContext))]
    [Migration("20180227054206_AddDealerMarketDptRelation")]
    partial class AddDealerMarketDptRelation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sdt.Companies.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BusinessAddress")
                        .HasMaxLength(200);

                    b.Property<string>("BusinessScope")
                        .HasMaxLength(200);

                    b.Property<string>("CityCategory")
                        .HasMaxLength(50);

                    b.Property<string>("CityName")
                        .HasMaxLength(50);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("ContactAddress")
                        .HasMaxLength(200);

                    b.Property<string>("ContactMail")
                        .HasMaxLength(100);

                    b.Property<string>("ContactPerson")
                        .HasMaxLength(100);

                    b.Property<string>("ContactPhone")
                        .HasMaxLength(100);

                    b.Property<string>("ContactPostCode")
                        .HasMaxLength(100);

                    b.Property<int?>("CorporateNature");

                    b.Property<string>("CountyName")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("CreatorName")
                        .HasMaxLength(100);

                    b.Property<long?>("CreatorUserId");

                    b.Property<int?>("DealerId");

                    b.Property<string>("Fax")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("FoundDate");

                    b.Property<string>("IdDocumentNumber")
                        .HasMaxLength(50);

                    b.Property<int?>("IdDocumentType");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("LegalRepresentative")
                        .HasMaxLength(100);

                    b.Property<string>("ModifierName")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("ProvinceName")
                        .HasMaxLength(50);

                    b.Property<int?>("RegionId");

                    b.Property<decimal?>("RegisterCapital")
                        .HasColumnType("decimal(19, 4)");

                    b.Property<string>("RegisterCode")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("RegisterDate");

                    b.Property<string>("RegisterName")
                        .HasMaxLength(100);

                    b.Property<string>("Remark")
                        .HasMaxLength(200);

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("ShortName")
                        .HasMaxLength(50);

                    b.Property<int?>("Status");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("DealerId")
                        .IsUnique()
                        .HasFilter("[DealerId] IS NOT NULL");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("Sdt.DealerCorrelation.Dealer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("CreatorName")
                        .HasMaxLength(100);

                    b.Property<long?>("CreatorUserId");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("ModifierName")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("ShortName")
                        .HasMaxLength(100);

                    b.Property<int>("Status");

                    b.Property<string>("SubNetworkCode")
                        .HasMaxLength(50);

                    b.Property<int?>("SubNetworkType");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.ToTable("Dealer");
                });

            modelBuilder.Entity("Sdt.DealerCorrelation.DealerMarketDptRelation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BranchId");

                    b.Property<int>("DealerId");

                    b.Property<int>("MarketId");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("DealerMarketDptRelation");
                });

            modelBuilder.Entity("Sdt.DealerCorrelation.DealerSaleInfoes.DealerSalesInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasMaxLength(200);

                    b.Property<int>("BranchId");

                    b.Property<DateTime?>("CancellationTime");

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("CreatorName")
                        .HasMaxLength(100);

                    b.Property<long?>("CreatorUserId");

                    b.Property<int>("DealerId");

                    b.Property<DateTime?>("DegradeTime");

                    b.Property<string>("Email")
                        .HasMaxLength(50);

                    b.Property<string>("ErpServiceCode")
                        .HasMaxLength(50);

                    b.Property<string>("Fax")
                        .HasMaxLength(50);

                    b.Property<string>("GroupName")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("ModifierName")
                        .HasMaxLength(100);

                    b.Property<string>("Remark")
                        .HasMaxLength(500);

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("SalesHotline")
                        .HasMaxLength(100);

                    b.Property<string>("ShopLevel")
                        .HasMaxLength(100);

                    b.Property<string>("ShopProperty")
                        .HasMaxLength(100);

                    b.Property<int>("Status");

                    b.Property<DateTime?>("SubscriptionTime");

                    b.Property<string>("ZipCode")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("DealerId");

                    b.ToTable("DealerSalesInfo");
                });

            modelBuilder.Entity("Sdt.DealerCorrelation.DealerSaleInfoes.DealerSalesInfoHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasMaxLength(200);

                    b.Property<int>("BranchId");

                    b.Property<DateTime?>("CancellationTime");

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("CreatorName")
                        .HasMaxLength(100);

                    b.Property<long?>("CreatorUserId");

                    b.Property<int>("DealerId");

                    b.Property<int?>("DealerSalesInfoId");

                    b.Property<DateTime?>("DegradeTime");

                    b.Property<string>("Email")
                        .HasMaxLength(50);

                    b.Property<string>("Fax")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("FileTime");

                    b.Property<int?>("FilerId");

                    b.Property<string>("FilerName")
                        .HasMaxLength(100);

                    b.Property<string>("GroupName")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("ModifierName")
                        .HasMaxLength(100);

                    b.Property<int>("RecordId");

                    b.Property<string>("Remark")
                        .HasMaxLength(500);

                    b.Property<string>("SalesHotline")
                        .HasMaxLength(100);

                    b.Property<string>("ShopLevel")
                        .HasMaxLength(100);

                    b.Property<string>("ShopProperty")
                        .HasMaxLength(100);

                    b.Property<int>("Status");

                    b.Property<DateTime?>("SubscriptionTime");

                    b.Property<string>("ZipCode")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("DealerSalesInfoId");

                    b.ToTable("DealerSalesInfoHistory");
                });

            modelBuilder.Entity("Sdt.Companies.Company", b =>
                {
                    b.HasOne("Sdt.DealerCorrelation.Dealer", "Dealer")
                        .WithOne("Company")
                        .HasForeignKey("Sdt.Companies.Company", "DealerId");
                });

            modelBuilder.Entity("Sdt.DealerCorrelation.DealerSaleInfoes.DealerSalesInfo", b =>
                {
                    b.HasOne("Sdt.DealerCorrelation.Dealer", "Dealer")
                        .WithMany()
                        .HasForeignKey("DealerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sdt.DealerCorrelation.DealerSaleInfoes.DealerSalesInfoHistory", b =>
                {
                    b.HasOne("Sdt.DealerCorrelation.DealerSaleInfoes.DealerSalesInfo", "DealerSalesInfo")
                        .WithMany()
                        .HasForeignKey("DealerSalesInfoId");
                });
#pragma warning restore 612, 618
        }
    }
}
