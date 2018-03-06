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
    [Migration("20180226090410_InitialDcs")]
    partial class InitialDcs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
#pragma warning restore 612, 618
        }
    }
}