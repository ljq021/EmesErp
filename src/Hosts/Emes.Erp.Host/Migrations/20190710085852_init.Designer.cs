﻿// <auto-generated />
using System;
using Emes.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Emes.Erp.Host.Migrations
{
    [DbContext(typeof(EmesDbContext))]
    [Migration("20190710085852_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0-preview6.19304.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Emes.Erp.System.Models.Organization", b =>
                {
                    b.Property<long>("Id");

                    b.Property<long>("CreatedById");

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<bool>("IsFiliale");

                    b.Property<bool>("IsSubbranch");

                    b.Property<string>("Message");

                    b.Property<string>("MnemonicCode");

                    b.Property<string>("Name");

                    b.Property<string>("No");

                    b.Property<long>("OrgId");

                    b.Property<long>("ParentId");

                    b.Property<long>("UpdatedById");

                    b.Property<DateTimeOffset>("UpdatedOn");

                    b.Property<int>("Version");

                    b.HasKey("Id");

                    b.ToTable("System_Organization");
                });
#pragma warning restore 612, 618
        }
    }
}
