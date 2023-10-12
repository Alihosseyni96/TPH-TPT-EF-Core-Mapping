﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TPH_TPT_EF_Core_Mapping.Model;

#nullable disable

namespace TPH_TPT_EF_Core_Mapping.Migrations
{
    [DbContext(typeof(EFCoreMappingContext))]
    [Migration("20231001191443_efTest")]
    partial class efTest
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TPH_TPT_EF_Core_Mapping.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("TPH_TPT_EF_Core_Mapping.Model.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("Models");
                });

            modelBuilder.Entity("TPH_TPT_EF_Core_Mapping.Model.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("TPH_TPT_EF_Core_Mapping.Model.TPH_MappingModels.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("People");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("TPH_TPT_EF_Core_Mapping.Model.TPT_MappingModels.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Animals", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("TPH_TPT_EF_Core_Mapping.Model.TPH_MappingModels.Client", b =>
                {
                    b.HasBaseType("TPH_TPT_EF_Core_Mapping.Model.TPH_MappingModels.Person");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Client");
                });

            modelBuilder.Entity("TPH_TPT_EF_Core_Mapping.Model.TPH_MappingModels.User", b =>
                {
                    b.HasBaseType("TPH_TPT_EF_Core_Mapping.Model.TPH_MappingModels.Person");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("User");
                });

            modelBuilder.Entity("TPH_TPT_EF_Core_Mapping.Model.TPT_MappingModels.Cat", b =>
                {
                    b.HasBaseType("TPH_TPT_EF_Core_Mapping.Model.TPT_MappingModels.Animal");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Cats", (string)null);
                });

            modelBuilder.Entity("TPH_TPT_EF_Core_Mapping.Model.TPT_MappingModels.Dog", b =>
                {
                    b.HasBaseType("TPH_TPT_EF_Core_Mapping.Model.TPT_MappingModels.Animal");

                    b.Property<int>("Speed")
                        .HasColumnType("int");

                    b.ToTable("Dogs", (string)null);
                });

            modelBuilder.Entity("TPH_TPT_EF_Core_Mapping.Model.Model", b =>
                {
                    b.HasOne("TPH_TPT_EF_Core_Mapping.Model.Product", "Product")
                        .WithOne("Model")
                        .HasForeignKey("TPH_TPT_EF_Core_Mapping.Model.Model", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("TPH_TPT_EF_Core_Mapping.Model.Product", b =>
                {
                    b.HasOne("TPH_TPT_EF_Core_Mapping.Model.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("TPH_TPT_EF_Core_Mapping.Model.TPT_MappingModels.Cat", b =>
                {
                    b.HasOne("TPH_TPT_EF_Core_Mapping.Model.TPT_MappingModels.Animal", null)
                        .WithOne()
                        .HasForeignKey("TPH_TPT_EF_Core_Mapping.Model.TPT_MappingModels.Cat", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TPH_TPT_EF_Core_Mapping.Model.TPT_MappingModels.Dog", b =>
                {
                    b.HasOne("TPH_TPT_EF_Core_Mapping.Model.TPT_MappingModels.Animal", null)
                        .WithOne()
                        .HasForeignKey("TPH_TPT_EF_Core_Mapping.Model.TPT_MappingModels.Dog", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TPH_TPT_EF_Core_Mapping.Model.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("TPH_TPT_EF_Core_Mapping.Model.Product", b =>
                {
                    b.Navigation("Model");
                });
#pragma warning restore 612, 618
        }
    }
}
