﻿// <auto-generated />
using System;
using DuzceUniversitesi_DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DuzceUniversitesi_DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220102175320_EkleAkademikPersonelMail")]
    partial class EkleAkademikPersonelMail
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DuzceUniversitesi_Model.Models.AkademikPersonel", b =>
                {
                    b.Property<int>("AkademikPersonelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AkademikPersonelAdSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AkademikPersonelDersler")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("AkademikPersonelDogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("AkademikPersonelGorsel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AkademikPersonelMail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AkademikPersonelId");

                    b.ToTable("AkademikPersoneller");
                });

            modelBuilder.Entity("DuzceUniversitesi_Model.Models.Duyuru", b =>
                {
                    b.Property<int>("DuyuruId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DuyuruAçıklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DuyuruKonu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DuyuruOlusturulmaTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("DuyuruId");

                    b.ToTable("Duyurular");
                });

            modelBuilder.Entity("DuzceUniversitesi_Model.Models.Fakulte", b =>
                {
                    b.Property<int>("FakulteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FakulteAd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FakulteId");

                    b.ToTable("Fakulteler");
                });
#pragma warning restore 612, 618
        }
    }
}
